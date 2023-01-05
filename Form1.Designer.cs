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
            this.sendNewlineCheckbox = new System.Windows.Forms.CheckBox();
            this.monitorTextbox = new System.Windows.Forms.TextBox();
            this.clearConsoleButton = new System.Windows.Forms.Button();
            this.clearInputTextAfterSendCheckbox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // sendButton
            // 
            this.sendButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sendButton.Location = new System.Drawing.Point(567, 16);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(100, 34);
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
            this.input_textbox.Size = new System.Drawing.Size(551, 34);
            this.input_textbox.TabIndex = 1;
            this.input_textbox.Text = "\r\n";
            // 
            // sendNewlineCheckbox
            // 
            this.sendNewlineCheckbox.Checked = true;
            this.sendNewlineCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.sendNewlineCheckbox.Location = new System.Drawing.Point(12, 52);
            this.sendNewlineCheckbox.Name = "sendNewlineCheckbox";
            this.sendNewlineCheckbox.Size = new System.Drawing.Size(165, 25);
            this.sendNewlineCheckbox.TabIndex = 2;
            this.sendNewlineCheckbox.Text = "Send with newline";
            this.sendNewlineCheckbox.UseVisualStyleBackColor = true;
            // 
            // monitorTextbox
            // 
            this.monitorTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.monitorTextbox.BackColor = System.Drawing.SystemColors.Window;
            this.monitorTextbox.Location = new System.Drawing.Point(12, 83);
            this.monitorTextbox.Multiline = true;
            this.monitorTextbox.Name = "monitorTextbox";
            this.monitorTextbox.ReadOnly = true;
            this.monitorTextbox.Size = new System.Drawing.Size(655, 275);
            this.monitorTextbox.TabIndex = 3;
            // 
            // clearConsoleButton
            // 
            this.clearConsoleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.clearConsoleButton.Location = new System.Drawing.Point(552, 364);
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
            this.clearInputTextAfterSendCheckbox.Location = new System.Drawing.Point(161, 52);
            this.clearInputTextAfterSendCheckbox.Name = "clearInputTextAfterSendCheckbox";
            this.clearInputTextAfterSendCheckbox.Size = new System.Drawing.Size(148, 24);
            this.clearInputTextAfterSendCheckbox.TabIndex = 5;
            this.clearInputTextAfterSendCheckbox.Text = "Clear After Send";
            this.clearInputTextAfterSendCheckbox.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 404);
            this.Controls.Add(this.clearInputTextAfterSendCheckbox);
            this.Controls.Add(this.clearConsoleButton);
            this.Controls.Add(this.monitorTextbox);
            this.Controls.Add(this.sendNewlineCheckbox);
            this.Controls.Add(this.input_textbox);
            this.Controls.Add(this.sendButton);
            this.Name = "Form1";
            this.Text = "SeriLink";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button clearConsoleButton;
        private System.Windows.Forms.CheckBox clearInputTextAfterSendCheckbox;

        private System.Windows.Forms.TextBox monitorTextbox;

        private System.Windows.Forms.CheckBox sendNewlineCheckbox;

        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.TextBox input_textbox;

        #endregion
    }
}