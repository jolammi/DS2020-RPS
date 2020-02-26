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
    public partial class Form3 : Form
    {
        public string option;

        public Form3()
        {
            InitializeComponent();
        }

        private void leaveButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void scissorButton_Click(object sender, EventArgs e)
        {
            option = "scissor";
        }

        private void paperButton_Click(object sender, EventArgs e)
        {
            option = "paper";
        }

        private void rockButton_Click(object sender, EventArgs e)
        {
            option = "rock";
        }
    }
}
