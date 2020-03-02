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
            this.createButton = new System.Windows.Forms.Button();
            this.quitButton1 = new System.Windows.Forms.Button();
            this.joinButton = new System.Windows.Forms.Button();
            this.dontPushLink = new System.Windows.Forms.LinkLabel();
            this.errorLabel = new System.Windows.Forms.Label();
            this.roomListBox = new System.Windows.Forms.ListBox();
            this.quitButton = new System.Windows.Forms.Button();
            this.acceptButton = new System.Windows.Forms.Button();
            this.aliasBox = new System.Windows.Forms.TextBox();
            this.IPBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // createButton
            // 
            this.createButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.createButton.Location = new System.Drawing.Point(389, 270);
            this.createButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(108, 35);
            this.createButton.TabIndex = 17;
            this.createButton.Text = "New Room";
            this.createButton.UseVisualStyleBackColor = true;
            // 
            // quitButton1
            // 
            this.quitButton1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.quitButton1.Location = new System.Drawing.Point(281, 340);
            this.quitButton1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.quitButton1.Name = "quitButton1";
            this.quitButton1.Size = new System.Drawing.Size(108, 35);
            this.quitButton1.TabIndex = 16;
            this.quitButton1.Text = "Quit";
            this.quitButton1.UseVisualStyleBackColor = true;
            // 
            // joinButton
            // 
            this.joinButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.joinButton.Location = new System.Drawing.Point(169, 270);
            this.joinButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.joinButton.Name = "joinButton";
            this.joinButton.Size = new System.Drawing.Size(112, 35);
            this.joinButton.TabIndex = 15;
            this.joinButton.Text = "Join";
            this.joinButton.UseVisualStyleBackColor = true;
            // 
            // dontPushLink
            // 
            this.dontPushLink.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dontPushLink.AutoSize = true;
            this.dontPushLink.LinkColor = System.Drawing.Color.Black;
            this.dontPushLink.Location = new System.Drawing.Point(260, 468);
            this.dontPushLink.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dontPushLink.Name = "dontPushLink";
            this.dontPushLink.Size = new System.Drawing.Size(166, 20);
            this.dontPushLink.TabIndex = 14;
            this.dontPushLink.TabStop = true;
            this.dontPushLink.Text = "Please do not click me";
            this.dontPushLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.DontPushLink_LinkClicked);
            // 
            // errorLabel
            // 
            this.errorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.errorLabel.AutoSize = true;
            this.errorLabel.Location = new System.Drawing.Point(130, 347);
            this.errorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(0, 20);
            this.errorLabel.TabIndex = 13;
            // 
            // roomListBox
            // 
            this.roomListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.roomListBox.FormattingEnabled = true;
            this.roomListBox.ItemHeight = 20;
            this.roomListBox.Location = new System.Drawing.Point(169, 52);
            this.roomListBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.roomListBox.Name = "roomListBox";
            this.roomListBox.Size = new System.Drawing.Size(328, 184);
            this.roomListBox.Sorted = true;
            this.roomListBox.TabIndex = 12;
            // 
            // quitButton
            // 
            this.quitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.quitButton.Location = new System.Drawing.Point(528, 382);
            this.quitButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(112, 35);
            this.quitButton.TabIndex = 10;
            this.quitButton.Text = "Quit";
            this.quitButton.UseVisualStyleBackColor = true;
            // 
            // acceptButton
            // 
            this.acceptButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.acceptButton.Location = new System.Drawing.Point(528, 311);
            this.acceptButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(112, 35);
            this.acceptButton.TabIndex = 9;
            this.acceptButton.Text = "Accept";
            this.acceptButton.UseVisualStyleBackColor = true;
            this.acceptButton.Click += new System.EventHandler(this.acceptButton_Click);
            // 
            // aliasBox
            // 
            this.aliasBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.aliasBox.Location = new System.Drawing.Point(169, 316);
            this.aliasBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.aliasBox.Name = "aliasBox";
            this.aliasBox.Size = new System.Drawing.Size(328, 26);
            this.aliasBox.TabIndex = 11;
            this.aliasBox.Text = "Username";
            // 
            // IPBox
            // 
            this.IPBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IPBox.Location = new System.Drawing.Point(169, 352);
            this.IPBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.IPBox.Name = "IPBox";
            this.IPBox.Size = new System.Drawing.Size(328, 26);
            this.IPBox.TabIndex = 18;
            this.IPBox.Text = "IP";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 594);
            this.Controls.Add(this.IPBox);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.quitButton1);
            this.Controls.Add(this.joinButton);
            this.Controls.Add(this.dontPushLink);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.roomListBox);
            this.Controls.Add(this.aliasBox);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.acceptButton);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(600, 600);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.Text = "s";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button createButton;
        public System.Windows.Forms.Button quitButton1;
        public System.Windows.Forms.Button joinButton;
        private System.Windows.Forms.LinkLabel dontPushLink;
        private System.Windows.Forms.Label errorLabel;
        public System.Windows.Forms.ListBox roomListBox;
        public System.Windows.Forms.Button quitButton;
        public System.Windows.Forms.Button acceptButton;
        public System.Windows.Forms.TextBox aliasBox;
        public System.Windows.Forms.TextBox IPBox;
    }
}

