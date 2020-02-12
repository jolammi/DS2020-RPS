namespace RPSClient
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
            this.acceptButton = new System.Windows.Forms.Button();
            this.quitButton = new System.Windows.Forms.Button();
            this.aliasBox = new System.Windows.Forms.TextBox();
            this.roomListBox = new System.Windows.Forms.ListBox();
            this.errorLabel = new System.Windows.Forms.Label();
            this.dontPushLink = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // acceptButton
            // 
            this.acceptButton.Location = new System.Drawing.Point(528, 194);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(75, 23);
            this.acceptButton.TabIndex = 0;
            this.acceptButton.Text = "Accept";
            this.acceptButton.UseVisualStyleBackColor = true;
            this.acceptButton.Click += new System.EventHandler(this.AcceptButtonClick);
            // 
            // quitButton
            // 
            this.quitButton.Location = new System.Drawing.Point(528, 240);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(75, 23);
            this.quitButton.TabIndex = 1;
            this.quitButton.Text = "Quit";
            this.quitButton.UseVisualStyleBackColor = true;
            this.quitButton.Click += new System.EventHandler(this.QuitButton_Click);
            // 
            // aliasBox
            // 
            this.aliasBox.Location = new System.Drawing.Point(286, 196);
            this.aliasBox.Name = "aliasBox";
            this.aliasBox.Size = new System.Drawing.Size(223, 20);
            this.aliasBox.TabIndex = 2;
            // 
            // roomListBox
            // 
            this.roomListBox.FormattingEnabled = true;
            this.roomListBox.Location = new System.Drawing.Point(286, 25);
            this.roomListBox.Name = "roomListBox";
            this.roomListBox.Size = new System.Drawing.Size(223, 121);
            this.roomListBox.TabIndex = 3;
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Location = new System.Drawing.Point(260, 217);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(0, 13);
            this.errorLabel.TabIndex = 4;
            // 
            // dontPushLink
            // 
            this.dontPushLink.AutoSize = true;
            this.dontPushLink.LinkColor = System.Drawing.Color.Black;
            this.dontPushLink.Location = new System.Drawing.Point(341, 406);
            this.dontPushLink.Name = "dontPushLink";
            this.dontPushLink.Size = new System.Drawing.Size(114, 13);
            this.dontPushLink.TabIndex = 5;
            this.dontPushLink.TabStop = true;
            this.dontPushLink.Text = "Please do not click me";
            this.dontPushLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.DontPushLink_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dontPushLink);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.roomListBox);
            this.Controls.Add(this.aliasBox);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.acceptButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button acceptButton;
        public System.Windows.Forms.Button quitButton;
        public System.Windows.Forms.TextBox aliasBox;
        private System.Windows.Forms.ListBox roomListBox;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.LinkLabel dontPushLink;
    }
}

