using System;
using System.Windows.Forms;

namespace SeriLink
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void sendButton_Click(object sender, EventArgs e)
        {
            // by default, the text includes newline at the start
            // so we trim it
            var myMessage = input_textbox.Text.Trim();

            // append newline character if the option is enabled
            myMessage += sendNewlineCheckbox.Checked ? Environment.NewLine : "";

            monitorTextbox.Text += myMessage;

            // TODO: Send to serial port
            
            // clear the input field after send if option checked
            if (clearInputTextAfterSendCheckbox.Checked) 
                input_textbox.Clear();
        }

        private void clearConsoleButton_Click(object sender, EventArgs e)
        {
            monitorTextbox.Clear();
        }
    }
}