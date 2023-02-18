using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Windows.Forms;

namespace SeriLink
{
    public partial class Form1 : Form
    {
        private SerialPort _mySerial;
        private bool _connectedSerial;
        
        // HashSet of string to store the sent commands
        private HashSet<string> _sentCommands = new HashSet<string>();
        private int _sentCommandsIndex;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lineEndingComboBox.SelectedIndex = 3; // set default to NL & CR
            baudComboBox.SelectedItem = "9600";
            RefreshPorts();
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            SendMessage();
        }

        private void input_textbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (!_connectedSerial) return;
            
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // prevent 'Ding' sound when press enter
                SendMessage();

                // reset the last command index
                _sentCommandsIndex = _sentCommands.Count;
            }

            // if the key is down arrow, get the next command from the sent commands list
            if (e.KeyCode == Keys.Up)
            {
                GoUpHistory();
            }
            
            // same as arrow up key, but go through the history opposite direction
            if (e.KeyCode == Keys.Down)
            {
                GoDownHistory();
            }
            
            // clear the textbox
            if (e.KeyCode == Keys.Escape)
            {
                e.SuppressKeyPress = true; 
                input_textbox.Clear();
            } 
        }

        private void clearConsoleButton_Click(object sender, EventArgs e)
        {
            monitorTextbox.Clear();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            RefreshPorts();
        }

        private void RefreshPorts()
        {
            // Get a list of serial port names.
            string[] ports = SerialPort.GetPortNames();

            // set the ports to the portsComboBox
            portsComboBox.Items.Clear();
            portsComboBox.Items.AddRange(ports);

            // if there are ports, select the first one
            if (ports.Length > 0)
                portsComboBox.SelectedIndex = 0;
            else
                connectButton.Enabled = false;
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            if (!_connectedSerial)
            {
                // Connect the selected port
                var targetPort = portsComboBox.SelectedItem;
                if (targetPort != null)
                {
                    OpenSerialPort(port: targetPort.ToString());
                }

                return;
            }

            // Disconnect the port
            CloseSerialPort();
        }

        private void OpenSerialPort(String port)
        {
            _mySerial = new SerialPort(port);
            // baud rate supported on Windows? 
            // https://learn.microsoft.com/en-us/windows/win32/api/winbase/ns-winbase-commprop
            _mySerial.BaudRate = int.Parse(baudComboBox.SelectedItem.ToString());

            try
            {
                _mySerial.Open();
            }
            catch (UnauthorizedAccessException e)
            {
                // show error MessageBox with error icon
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            _mySerial.DataReceived += MySerial_DataReceived;

            // enable input button and disable refresh button
            input_textbox.ReadOnly = false;
            sendButton.Enabled = true;
            refreshButton.Enabled = false;
            monitorTextbox.Enabled = true;
            monitorTextbox.BackColor = SystemColors.Window;

            connectButton.Text = "Disconnect";
            _connectedSerial = true;
        }

        private void SendMessage()
        {
            // by default, the text includes newline at the start
            // so we trim it
            var myMessage = input_textbox.Text.Trim();

            // add line termination accordingly
            // https://arduino.stackexchange.com/questions/22852/what-does-serial-monitor-send-with-both-nl-cr/22853#22853
            Dictionary<int, string> lineEndings = new Dictionary<int, string>
            {
                { 1, Environment.NewLine }, // NewLine
                { 2, "\r" }, // Carriage Return
                { 3, "\r\n" } // // NL & CR
            };
            // if the option is not None, do the things
            if (lineEndingComboBox.SelectedIndex > 0)
            {
                myMessage += lineEndings[lineEndingComboBox.SelectedIndex];
            }

            Console.WriteLine(myMessage);

            // send the message
            _mySerial.Write(myMessage);

            // add send message to the console in green colour
            if (showInConsoleCheckbox.Checked)
            {
                Color sendColor = Color.Green;
                monitorTextbox.SelectionColor = sendColor;
                monitorTextbox.SelectionFont = new Font(monitorTextbox.Font, FontStyle.Italic);
                monitorTextbox.AppendText(myMessage);
            }
            
            // add send message to the sent history if not empty
            if (myMessage.Trim().Length > 0) _sentCommands.Add(myMessage);

            // clear the input field after send if option checked
            if (clearInputTextAfterSendCheckbox.Checked)
                input_textbox.Clear();
        }

        private void MySerial_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            monitorTextbox.AppendText(_mySerial.ReadExisting());
        }

        private void CloseSerialPort()
        {
            _mySerial.Close();
            _mySerial.Dispose();
            connectButton.Text = "Connect";
            _connectedSerial = false;

            // disable input
            input_textbox.ReadOnly = true;
            sendButton.Enabled = false;
            refreshButton.Enabled = true;
            monitorTextbox.Enabled = false;
            monitorTextbox.BackColor = SystemColors.Control;
        }

        private void portsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // enable Connect button if there is a port selected
            connectButton.Enabled = portsComboBox.SelectedIndex >= 0;

            // disable connect button is handled by refreshPorts()
        }

        private void GoUpHistory()
        {
            // decrement the index
            _sentCommandsIndex--;
                    
            // if reach the beginning, reset to the last
            if (_sentCommandsIndex < 0) _sentCommandsIndex = _sentCommands.Count - 1;
            
            // get the next command from the list based on index
            var nextCommand = _sentCommands.ElementAtOrDefault(_sentCommandsIndex);
            if (nextCommand != null)
            {
                // set the input text to the next command
                input_textbox.Text = nextCommand;
                // move the cursor to the end of the text
                input_textbox.SelectionStart = input_textbox.Text.Length;
                input_textbox.SelectionLength = 0;
            }
        }
        
        private void GoDownHistory()
        {
            _sentCommandsIndex++;
                
            // if reach to the end, reset to the first
            if (_sentCommandsIndex == _sentCommands.Count) _sentCommandsIndex = 0;
            
            var nextCommand = _sentCommands.ElementAtOrDefault(_sentCommandsIndex);
            if (nextCommand != null)
            {
                input_textbox.Text = nextCommand;
                input_textbox.SelectionStart = input_textbox.Text.Length;
                input_textbox.SelectionLength = 0;
            }
        }
    }
}