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
            this.components = new System.ComponentModel.Container();
            this.quitButton1 = new System.Windows.Forms.Button();
            this.dontPushLink = new System.Windows.Forms.LinkLabel();
            this.errorLabel = new System.Windows.Forms.Label();
            this.acceptButton = new System.Windows.Forms.Button();
            this.aliasBox = new System.Windows.Forms.TextBox();
            this.IPBox = new System.Windows.Forms.TextBox();
            this.quitButton = new System.Windows.Forms.Button();
            this.scissorButton = new System.Windows.Forms.Button();
            this.paperButton = new System.Windows.Forms.Button();
            this.rockButton = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.outcomeLabel = new System.Windows.Forms.Label();
            this.countLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // quitButton1
            // 
            this.quitButton1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.quitButton1.Location = new System.Drawing.Point(341, 382);
            this.quitButton1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.quitButton1.Name = "quitButton1";
            this.quitButton1.Size = new System.Drawing.Size(237, 35);
            this.quitButton1.TabIndex = 16;
            this.quitButton1.Text = "Quit";
            this.quitButton1.UseVisualStyleBackColor = true;
            // 
            // dontPushLink
            // 
            this.dontPushLink.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dontPushLink.AutoSize = true;
            this.dontPushLink.LinkColor = System.Drawing.Color.Black;
            this.dontPushLink.Location = new System.Drawing.Point(379, 455);
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
            this.errorLabel.Location = new System.Drawing.Point(337, 27);
            this.errorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(0, 20);
            this.errorLabel.TabIndex = 13;
            // 
            // acceptButton
            // 
            this.acceptButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.acceptButton.Location = new System.Drawing.Point(341, 333);
            this.acceptButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(237, 35);
            this.acceptButton.TabIndex = 9;
            this.acceptButton.Text = "Accept";
            this.acceptButton.UseVisualStyleBackColor = true;
            this.acceptButton.Click += new System.EventHandler(this.acceptButton_Click);
            // 
            // aliasBox
            // 
            this.aliasBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.aliasBox.Location = new System.Drawing.Point(264, 242);
            this.aliasBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.aliasBox.Name = "aliasBox";
            this.aliasBox.Size = new System.Drawing.Size(412, 26);
            this.aliasBox.TabIndex = 11;
            this.aliasBox.Text = "Username";
            // 
            // IPBox
            // 
            this.IPBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IPBox.Location = new System.Drawing.Point(264, 278);
            this.IPBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.IPBox.Name = "IPBox";
            this.IPBox.Size = new System.Drawing.Size(412, 26);
            this.IPBox.TabIndex = 18;
            this.IPBox.Text = "IP";
            // 
            // quitButton
            // 
            this.quitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.quitButton.Location = new System.Drawing.Point(373, 495);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(159, 47);
            this.quitButton.TabIndex = 22;
            this.quitButton.Text = "Quit";
            this.quitButton.UseVisualStyleBackColor = true;
            this.quitButton.Click += new System.EventHandler(this.QuitButton_Click);
            // 
            // scissorButton
            // 
            this.scissorButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.scissorButton.Image = global::RPSClient.Properties.Resources._15FiskarsSS2017_iso_HV1;
            this.scissorButton.Location = new System.Drawing.Point(615, 90);
            this.scissorButton.Name = "scissorButton";
            this.scissorButton.Size = new System.Drawing.Size(200, 200);
            this.scissorButton.TabIndex = 21;
            this.scissorButton.Text = "Scissor";
            this.scissorButton.UseVisualStyleBackColor = true;
            this.scissorButton.Click += new System.EventHandler(this.scissorButton_Click);
            // 
            // paperButton
            // 
            this.paperButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.paperButton.Image = global::RPSClient.Properties.Resources.b1415cc2e32686ee130749dca12f0ef81;
            this.paperButton.Location = new System.Drawing.Point(353, 90);
            this.paperButton.Name = "paperButton";
            this.paperButton.Size = new System.Drawing.Size(200, 200);
            this.paperButton.TabIndex = 20;
            this.paperButton.Text = "Paper";
            this.paperButton.UseVisualStyleBackColor = true;
            this.paperButton.Click += new System.EventHandler(this.paperButton_Click);
            // 
            // rockButton
            // 
            this.rockButton.Image = global::RPSClient.Properties.Resources.mgid_ao_image_mtv3;
            this.rockButton.Location = new System.Drawing.Point(82, 90);
            this.rockButton.Name = "rockButton";
            this.rockButton.Size = new System.Drawing.Size(200, 200);
            this.rockButton.TabIndex = 19;
            this.rockButton.Text = "Rock";
            this.rockButton.UseVisualStyleBackColor = true;
            this.rockButton.Click += new System.EventHandler(this.rockButton_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // outcomeLabel
            // 
            this.outcomeLabel.AutoSize = true;
            this.outcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outcomeLabel.Location = new System.Drawing.Point(365, 352);
            this.outcomeLabel.Name = "outcomeLabel";
            this.outcomeLabel.Size = new System.Drawing.Size(189, 46);
            this.outcomeLabel.TabIndex = 23;
            this.outcomeLabel.Text = "You Lost!";
            // 
            // countLabel
            // 
            this.countLabel.AutoSize = true;
            this.countLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countLabel.Location = new System.Drawing.Point(417, 352);
            this.countLabel.Name = "countLabel";
            this.countLabel.Size = new System.Drawing.Size(86, 46);
            this.countLabel.TabIndex = 30;
            this.countLabel.Text = "20 !";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 594);
            this.Controls.Add(this.countLabel);
            this.Controls.Add(this.outcomeLabel);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.scissorButton);
            this.Controls.Add(this.paperButton);
            this.Controls.Add(this.rockButton);
            this.Controls.Add(this.IPBox);
            this.Controls.Add(this.quitButton1);
            this.Controls.Add(this.dontPushLink);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.aliasBox);
            this.Controls.Add(this.acceptButton);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(596, 591);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.Text = "Rock, Pape, Scissors 420 NoScope Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Button quitButton1;
        private System.Windows.Forms.LinkLabel dontPushLink;
        private System.Windows.Forms.Label errorLabel;
        public System.Windows.Forms.Button acceptButton;
        public System.Windows.Forms.TextBox aliasBox;
        public System.Windows.Forms.TextBox IPBox;
        private System.Windows.Forms.Button quitButton;
        private System.Windows.Forms.Button scissorButton;
        private System.Windows.Forms.Button paperButton;
        private System.Windows.Forms.Button rockButton;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label outcomeLabel;
        private System.Windows.Forms.Label countLabel;
    }
}

