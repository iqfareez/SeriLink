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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.sendButton = new System.Windows.Forms.Button();
            this.input_textbox = new System.Windows.Forms.TextBox();
            this.clearConsoleButton = new System.Windows.Forms.Button();
            this.clearInputTextAfterSendCheckbox = new System.Windows.Forms.CheckBox();
            this.lineEndingComboBox = new System.Windows.Forms.ComboBox();
            this.portsComboBox = new System.Windows.Forms.ComboBox();
            this.baudComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.refreshButton = new System.Windows.Forms.Button();
            this.connectButton = new System.Windows.Forms.Button();
            this.showInConsoleCheckbox = new System.Windows.Forms.CheckBox();
            this.monitorTextbox = new System.Windows.Forms.RichTextBox();
            this.timestampCheckbox = new System.Windows.Forms.CheckBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportConsoleOutputToTXTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gitHubToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // sendButton
            // 
            this.sendButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sendButton.Enabled = false;
            this.sendButton.Location = new System.Drawing.Point(580, 38);
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
            this.input_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input_textbox.Location = new System.Drawing.Point(11, 38);
            this.input_textbox.Name = "input_textbox";
            this.input_textbox.ReadOnly = true;
            this.input_textbox.Size = new System.Drawing.Size(563, 27);
            this.input_textbox.TabIndex = 1;
            this.input_textbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.input_textbox_KeyDown);
            // 
            // clearConsoleButton
            // 
            this.clearConsoleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.clearConsoleButton.Location = new System.Drawing.Point(578, 432);
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
            this.clearInputTextAfterSendCheckbox.Location = new System.Drawing.Point(11, 75);
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
            this.lineEndingComboBox.Location = new System.Drawing.Point(580, 75);
            this.lineEndingComboBox.Name = "lineEndingComboBox";
            this.lineEndingComboBox.Size = new System.Drawing.Size(112, 24);
            this.lineEndingComboBox.TabIndex = 6;
            // 
            // portsComboBox
            // 
            this.portsComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.portsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.portsComboBox.FormattingEnabled = true;
            this.portsComboBox.Location = new System.Drawing.Point(135, 437);
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
            this.baudComboBox.Location = new System.Drawing.Point(285, 437);
            this.baudComboBox.Name = "baudComboBox";
            this.baudComboBox.Size = new System.Drawing.Size(74, 24);
            this.baudComboBox.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.Location = new System.Drawing.Point(235, 437);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 23);
            this.label1.TabIndex = 9;
            this.label1.Text = "Baud";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.Location = new System.Drawing.Point(92, 437);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 23);
            this.label2.TabIndex = 10;
            this.label2.Text = "Port";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // refreshButton
            // 
            this.refreshButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.refreshButton.Location = new System.Drawing.Point(12, 432);
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
            this.connectButton.Location = new System.Drawing.Point(365, 432);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(87, 32);
            this.connectButton.TabIndex = 12;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // showInConsoleCheckbox
            // 
            this.showInConsoleCheckbox.Checked = true;
            this.showInConsoleCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showInConsoleCheckbox.Location = new System.Drawing.Point(155, 75);
            this.showInConsoleCheckbox.Name = "showInConsoleCheckbox";
            this.showInConsoleCheckbox.Size = new System.Drawing.Size(148, 24);
            this.showInConsoleCheckbox.TabIndex = 13;
            this.showInConsoleCheckbox.Text = "Show in console";
            this.showInConsoleCheckbox.UseVisualStyleBackColor = true;
            // 
            // monitorTextbox
            // 
            this.monitorTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.monitorTextbox.Enabled = false;
            this.monitorTextbox.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monitorTextbox.Location = new System.Drawing.Point(12, 105);
            this.monitorTextbox.Name = "monitorTextbox";
            this.monitorTextbox.ReadOnly = true;
            this.monitorTextbox.Size = new System.Drawing.Size(679, 321);
            this.monitorTextbox.TabIndex = 14;
            this.monitorTextbox.Text = "";
            // 
            // timestampCheckbox
            // 
            this.timestampCheckbox.Checked = true;
            this.timestampCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.timestampCheckbox.Location = new System.Drawing.Point(294, 75);
            this.timestampCheckbox.Name = "timestampCheckbox";
            this.timestampCheckbox.Size = new System.Drawing.Size(148, 24);
            this.timestampCheckbox.TabIndex = 15;
            this.timestampCheckbox.Text = "Timestamp";
            this.timestampCheckbox.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.fileToolStripMenuItem, this.aboutToolStripMenuItem });
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(703, 28);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.exportConsoleOutputToTXTToolStripMenuItem });
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exportConsoleOutputToTXTToolStripMenuItem
            // 
            this.exportConsoleOutputToTXTToolStripMenuItem.Name = "exportConsoleOutputToTXTToolStripMenuItem";
            this.exportConsoleOutputToTXTToolStripMenuItem.Size = new System.Drawing.Size(235, 24);
            this.exportConsoleOutputToTXTToolStripMenuItem.Text = "Export console to .TXT...";
            this.exportConsoleOutputToTXTToolStripMenuItem.Click += new System.EventHandler(this.exportConsoleOutputToTXTToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.gitHubToolStripMenuItem });
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // gitHubToolStripMenuItem
            // 
            this.gitHubToolStripMenuItem.Name = "gitHubToolStripMenuItem";
            this.gitHubToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.gitHubToolStripMenuItem.Text = "GitHub...";
            this.gitHubToolStripMenuItem.Click += new System.EventHandler(this.gitHubToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 472);
            this.Controls.Add(this.timestampCheckbox);
            this.Controls.Add(this.monitorTextbox);
            this.Controls.Add(this.showInConsoleCheckbox);
            this.Controls.Add(this.connectButton);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.baudComboBox);
            this.Controls.Add(this.portsComboBox);
            this.Controls.Add(this.lineEndingComboBox);
            this.Controls.Add(this.clearInputTextAfterSendCheckbox);
            this.Controls.Add(this.clearConsoleButton);
            this.Controls.Add(this.input_textbox);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "SeriLink";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gitHubToolStripMenuItem;

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportConsoleOutputToTXTToolStripMenuItem;

        private System.Windows.Forms.CheckBox timestampCheckbox;

        private System.Windows.Forms.RichTextBox monitorTextbox;

        private System.Windows.Forms.CheckBox showInConsoleCheckbox;

        private System.Windows.Forms.Button connectButton;

        private System.Windows.Forms.Button refreshButton;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.ComboBox portsComboBox;
        private System.Windows.Forms.ComboBox baudComboBox;

        private System.Windows.Forms.ComboBox lineEndingComboBox;

        private System.Windows.Forms.Button clearConsoleButton;
        private System.Windows.Forms.CheckBox clearInputTextAfterSendCheckbox;

        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.TextBox input_textbox;

        #endregion
    }
}