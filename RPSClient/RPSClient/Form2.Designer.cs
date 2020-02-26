namespace RPSClient
{
    partial class Form2
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
            this.newRoomBox = new System.Windows.Forms.TextBox();
            this.roomNameInfoLabel = new System.Windows.Forms.Label();
            this.errorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // createButton
            // 
            this.createButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.createButton.Location = new System.Drawing.Point(216, 93);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(75, 31);
            this.createButton.TabIndex = 0;
            this.createButton.Text = "Create Room";
            this.createButton.UseVisualStyleBackColor = true;
            // 
            // newRoomBox
            // 
            this.newRoomBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.newRoomBox.Location = new System.Drawing.Point(44, 93);
            this.newRoomBox.Name = "newRoomBox";
            this.newRoomBox.Size = new System.Drawing.Size(144, 26);
            this.newRoomBox.TabIndex = 1;
            this.newRoomBox.Text = "Room name";
            this.newRoomBox.Click += new System.EventHandler(this.newRoomBox_Click);
            // 
            // roomNameInfoLabel
            // 
            this.roomNameInfoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.roomNameInfoLabel.AutoSize = true;
            this.roomNameInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomNameInfoLabel.Location = new System.Drawing.Point(40, 33);
            this.roomNameInfoLabel.Name = "roomNameInfoLabel";
            this.roomNameInfoLabel.Size = new System.Drawing.Size(218, 25);
            this.roomNameInfoLabel.TabIndex = 2;
            this.roomNameInfoLabel.Text = "Please name your room";
            // 
            // errorLabel
            // 
            this.errorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.errorLabel.AutoSize = true;
            this.errorLabel.Location = new System.Drawing.Point(41, 137);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(0, 20);
            this.errorLabel.TabIndex = 3;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 198);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.roomNameInfoLabel);
            this.Controls.Add(this.newRoomBox);
            this.Controls.Add(this.createButton);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Label roomNameInfoLabel;
        public System.Windows.Forms.TextBox newRoomBox;
        public System.Windows.Forms.Label errorLabel;
    }
}