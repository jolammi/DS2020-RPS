using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPSClient
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            if (newRoomBox.Text == "Room name" || newRoomBox.Text.Length <= 0)
            {
                errorLabel.Text = "Your alias was not entered properly. Please enter one.";
            }
            else
            {
                Form1.createdRoom = newRoomBox.Text;
                this.Close();
            }
        }

        private void newRoomBox_Click(object sender, EventArgs e)
        {
            errorLabel.ResetText();
            if (newRoomBox.Text == "Room name")
            {
                newRoomBox.ResetText();
            }
        }
    }
}
