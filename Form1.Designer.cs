namespace SeriLink
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.sendButton = new System.Windows.Forms.Button();
            this.input_textbox = new System.Windows.Forms.TextBox();
            this.monitorTextbox = new System.Windows.Forms.TextBox();
            this.clearConsoleButton = new System.Windows.Forms.Button();
            this.clearInputTextAfterSendCheckbox = new System.Windows.Forms.CheckBox();
            this.lineEndingComboBox = new System.Windows.Forms.ComboBox();
            this.portsComboBox = new System.Windows.Forms.ComboBox();
            this.baudComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.refreshButton = new System.Windows.Forms.Button();
            this.connectButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sendButton
            // 
            this.sendButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sendButton.Enabled = false;
            this.sendButton.Location = new System.Drawing.Point(598, 16);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(112, 34);
            this.sendButton.TabIndex = 0;
            this.sendButton.Text = "Send";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // input_textbox
            // 
            this.input_textbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.input_textbox.Font = new System.Drawing.Font("MesloLGL Nerd Font Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input_textbox.Location = new System.Drawing.Point(12, 16);
            this.input_textbox.Name = "input_textbox";
            this.input_textbox.ReadOnly = true;
            this.input_textbox.Size = new System.Drawing.Size(580, 34);
            this.input_textbox.TabIndex = 1;
            this.input_textbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.input_textbox_KeyDown);
            // 
            // monitorTextbox
            // 
            this.monitorTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.monitorTextbox.BackColor = System.Drawing.SystemColors.Control;
            this.monitorTextbox.Enabled = false;
            this.monitorTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monitorTextbox.Location = new System.Drawing.Point(12, 83);
            this.monitorTextbox.Multiline = true;
            this.monitorTextbox.Name = "monitorTextbox";
            this.monitorTextbox.ReadOnly = true;
            this.monitorTextbox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.monitorTextbox.Size = new System.Drawing.Size(698, 348);
            this.monitorTextbox.TabIndex = 3;
            this.monitorTextbox.WordWrap = false;
            // 
            // clearConsoleButton
            // 
            this.clearConsoleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.clearConsoleButton.Location = new System.Drawing.Point(595, 437);
            this.clearConsoleButton.Name = "clearConsoleButton";
            this.clearConsoleButton.Size = new System.Drawing.Size(115, 32);
            this.clearConsoleButton.TabIndex = 4;
            this.clearConsoleButton.Text = "Clear Output";
            this.clearConsoleButton.UseVisualStyleBackColor = true;
            this.clearConsoleButton.Click += new System.EventHandler(this.clearConsoleButton_Click);
            // 
            // clearInputTextAfterSendCheckbox
            // 
            this.clearInputTextAfterSendCheckbox.Checked = true;
            this.clearInputTextAfterSendCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.clearInputTextAfterSendCheckbox.Location = new System.Drawing.Point(12, 53);
            this.clearInputTextAfterSendCheckbox.Name = "clearInputTextAfterSendCheckbox";
            this.clearInputTextAfterSendCheckbox.Size = new System.Drawing.Size(148, 24);
            this.clearInputTextAfterSendCheckbox.TabIndex = 5;
            this.clearInputTextAfterSendCheckbox.Text = "Clear After Send";
            this.clearInputTextAfterSendCheckbox.UseVisualStyleBackColor = true;
            // 
            // lineEndingComboBox
            // 
            this.lineEndingComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lineEndingComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lineEndingComboBox.FormattingEnabled = true;
            this.lineEndingComboBox.Items.AddRange(new object[] { "None", "NewLine", "Carriage Return", "NL & CR" });
            this.lineEndingComboBox.Location = new System.Drawing.Point(598, 53);
            this.lineEndingComboBox.Name = "lineEndingComboBox";
            this.lineEndingComboBox.Size = new System.Drawing.Size(112, 24);
            this.lineEndingComboBox.TabIndex = 6;
            // 
            // portsComboBox
            // 
            this.portsComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.portsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.portsComboBox.FormattingEnabled = true;
            this.portsComboBox.Location = new System.Drawing.Point(135, 442);
            this.portsComboBox.Name = "portsComboBox";
            this.portsComboBox.Size = new System.Drawing.Size(92, 24);
            this.portsComboBox.TabIndex = 7;
            this.portsComboBox.SelectedIndexChanged += new System.EventHandler(this.portsComboBox_SelectedIndexChanged);
            // 
            // baudComboBox
            // 
            this.baudComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.baudComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.baudComboBox.FormattingEnabled = true;
            this.baudComboBox.Items.AddRange(new object[] { "300", "600", "1200", "2400", "4800", "9600", "14400", "19200", "28800", "38400", "57600", "115200" });
            this.baudComboBox.Location = new System.Drawing.Point(285, 442);
            this.baudComboBox.Name = "baudComboBox";
            this.baudComboBox.Size = new System.Drawing.Size(74, 24);
            this.baudComboBox.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.Location = new System.Drawing.Point(235, 442);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 23);
            this.label1.TabIndex = 9;
            this.label1.Text = "Baud";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.Location = new System.Drawing.Point(92, 442);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 23);
            this.label2.TabIndex = 10;
            this.label2.Text = "Port";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // refreshButton
            // 
            this.refreshButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.refreshButton.Location = new System.Drawing.Point(12, 437);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(74, 32);
            this.refreshButton.TabIndex = 11;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // connectButton
            // 
            this.connectButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.connectButton.Enabled = false;
            this.connectButton.Location = new System.Drawing.Point(365, 437);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(87, 32);
            this.connectButton.TabIndex = 12;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 477);
            this.Controls.Add(this.connectButton);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.baudComboBox);
            this.Controls.Add(this.portsComboBox);
            this.Controls.Add(this.lineEndingComboBox);
            this.Controls.Add(this.clearInputTextAfterSendCheckbox);
            this.Controls.Add(this.clearConsoleButton);
            this.Controls.Add(this.monitorTextbox);
            this.Controls.Add(this.input_textbox);
            this.Controls.Add(this.sendButton);
            this.Name = "Form1";
            this.Text = "SeriLink";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button connectButton;

        private System.Windows.Forms.Button refreshButton;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.ComboBox portsComboBox;
        private System.Windows.Forms.ComboBox baudComboBox;

        private System.Windows.Forms.ComboBox lineEndingComboBox;

        private System.Windows.Forms.Button clearConsoleButton;
        private System.Windows.Forms.CheckBox clearInputTextAfterSendCheckbox;

        private System.Windows.Forms.TextBox monitorTextbox;

        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.TextBox input_textbox;

        #endregion
    }
}