namespace RPSClient
{
    partial class Form3
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
            this.roomListBox = new System.Windows.Forms.ListBox();
            this.leaveButton = new System.Windows.Forms.Button();
            this.userInfoLabel = new System.Windows.Forms.Label();
            this.roomNameLabel = new System.Windows.Forms.Label();
            this.wonLabel = new System.Windows.Forms.Label();
            this.countLabel = new System.Windows.Forms.Label();
            this.scissorButton = new System.Windows.Forms.Button();
            this.paperButton = new System.Windows.Forms.Button();
            this.rockButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // roomListBox
            // 
            this.roomListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.roomListBox.FormattingEnabled = true;
            this.roomListBox.ItemHeight = 20;
            this.roomListBox.Location = new System.Drawing.Point(125, 293);
            this.roomListBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.roomListBox.Name = "roomListBox";
            this.roomListBox.Size = new System.Drawing.Size(200, 164);
            this.roomListBox.Sorted = true;
            this.roomListBox.TabIndex = 13;
            // 
            // leaveButton
            // 
            this.leaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.leaveButton.Location = new System.Drawing.Point(125, 479);
            this.leaveButton.Name = "leaveButton";
            this.leaveButton.Size = new System.Drawing.Size(159, 47);
            this.leaveButton.TabIndex = 14;
            this.leaveButton.Text = "Leave";
            this.leaveButton.UseVisualStyleBackColor = true;
            this.leaveButton.Click += new System.EventHandler(this.leaveButton_Click);
            // 
            // userInfoLabel
            // 
            this.userInfoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.userInfoLabel.AutoSize = true;
            this.userInfoLabel.Location = new System.Drawing.Point(121, 268);
            this.userInfoLabel.Name = "userInfoLabel";
            this.userInfoLabel.Size = new System.Drawing.Size(51, 20);
            this.userInfoLabel.TabIndex = 15;
            this.userInfoLabel.Text = "Users";
            // 
            // roomNameLabel
            // 
            this.roomNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.roomNameLabel.AutoSize = true;
            this.roomNameLabel.Location = new System.Drawing.Point(447, 23);
            this.roomNameLabel.Name = "roomNameLabel";
            this.roomNameLabel.Size = new System.Drawing.Size(96, 20);
            this.roomNameLabel.TabIndex = 16;
            this.roomNameLabel.Text = "Room name";
            // 
            // wonLabel
            // 
            this.wonLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wonLabel.AutoSize = true;
            this.wonLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wonLabel.Location = new System.Drawing.Point(455, 350);
            this.wonLabel.Name = "wonLabel";
            this.wonLabel.Size = new System.Drawing.Size(357, 58);
            this.wonLabel.TabIndex = 17;
            this.wonLabel.Text = "Player X Won!!";
            // 
            // countLabel
            // 
            this.countLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.countLabel.AutoSize = true;
            this.countLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countLabel.Location = new System.Drawing.Point(568, 324);
            this.countLabel.Name = "countLabel";
            this.countLabel.Size = new System.Drawing.Size(188, 113);
            this.countLabel.TabIndex = 18;
            this.countLabel.Text = "20!";
            // 
            // scissorButton
            // 
            this.scissorButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.scissorButton.Image = global::RPSClient.Properties.Resources._15FiskarsSS2017_iso_HV1;
            this.scissorButton.Location = new System.Drawing.Point(658, 68);
            this.scissorButton.Name = "scissorButton";
            this.scissorButton.Size = new System.Drawing.Size(200, 200);
            this.scissorButton.TabIndex = 2;
            this.scissorButton.Text = "Scissor";
            this.scissorButton.UseVisualStyleBackColor = true;
            this.scissorButton.Click += new System.EventHandler(this.scissorButton_Click);
            // 
            // paperButton
            // 
            this.paperButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.paperButton.Image = global::RPSClient.Properties.Resources.b1415cc2e32686ee130749dca12f0ef81;
            this.paperButton.Location = new System.Drawing.Point(396, 68);
            this.paperButton.Name = "paperButton";
            this.paperButton.Size = new System.Drawing.Size(200, 200);
            this.paperButton.TabIndex = 1;
            this.paperButton.Text = "Paper";
            this.paperButton.UseVisualStyleBackColor = true;
            this.paperButton.Click += new System.EventHandler(this.paperButton_Click);
            // 
            // rockButton
            // 
            this.rockButton.Image = global::RPSClient.Properties.Resources.mgid_ao_image_mtv3;
            this.rockButton.Location = new System.Drawing.Point(125, 68);
            this.rockButton.Name = "rockButton";
            this.rockButton.Size = new System.Drawing.Size(200, 200);
            this.rockButton.TabIndex = 0;
            this.rockButton.Text = "Rock";
            this.rockButton.UseVisualStyleBackColor = true;
            this.rockButton.Click += new System.EventHandler(this.rockButton_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 560);
            this.Controls.Add(this.countLabel);
            this.Controls.Add(this.wonLabel);
            this.Controls.Add(this.roomNameLabel);
            this.Controls.Add(this.userInfoLabel);
            this.Controls.Add(this.leaveButton);
            this.Controls.Add(this.roomListBox);
            this.Controls.Add(this.scissorButton);
            this.Controls.Add(this.paperButton);
            this.Controls.Add(this.rockButton);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button rockButton;
        private System.Windows.Forms.Button paperButton;
        private System.Windows.Forms.Button scissorButton;
        public System.Windows.Forms.ListBox roomListBox;
        private System.Windows.Forms.Button leaveButton;
        private System.Windows.Forms.Label userInfoLabel;
        private System.Windows.Forms.Label roomNameLabel;
        private System.Windows.Forms.Label wonLabel;
        private System.Windows.Forms.Label countLabel;
    }
}