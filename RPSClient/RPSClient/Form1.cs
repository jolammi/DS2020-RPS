using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace RPSClient
{
    public partial class Form1 : Form
    {
        private string alias;

        // 0 = Alias screen // 1 = Room selection screen // 2 = Inside room screen //
        private int screenOrder = 0;

        public Form1()
        {
            InitializeComponent();
            InitScreen0();
            Thread sceneThread = new Thread(ScreenChanger);
            sceneThread.Start();
        }

        private void QuitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AcceptButtonClick(object sender, EventArgs e)
        {
            if (aliasBox.Text.Length <= 0)
            {
                errorLabel.Text = "Your alias was not entered properly. Please enter one.";
            }
            else
            {

                alias = aliasBox.Text;
            }
        }
        private void InitScreen0()
        {
            roomListBox.Hide();
        }

        private void ScreenChanger()
        {
            switch (screenOrder)
            {
                case 0:
                    {
                        aliasBox.Show();
                        break;
                    }
                case 1:
                    {
                        aliasBox.Hide();
                        break;
                    }
                case 2:
                    {
                        break;
                    }
            }
        }

        private void DontPushLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://media.giphy.com/media/PApKgKr6r20mc/giphy.gif");
        }
    }
}
