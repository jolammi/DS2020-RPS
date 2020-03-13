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
using System.Net.Sockets;
using System.Diagnostics;

namespace RPSClient
{
    public partial class Form1 : Form
    {
        public string alias;
        public string ip;

        public int _port = 5005;
        public static string PSA;

        public static bool newCommandFlag = false;
        public static bool firstTime = true;
        public bool newCountdown = false;
        public bool newOutcome = false;

        public string countData = null;
        public string outcomeData = null;

        public static Tuple<string, string> dataStruct = null;
        public static List<string> roomList = new List<string>();

        public Tuple<NetworkStream, TcpClient> TcpTuple;


        // 0 = Alias screen // 1 = Room selection screen // 2 = Inside room screen //
        public static int screenOrder = 0;

        public Form1()
        {
            InitializeComponent();
            Thread updateThread = new Thread(() => Update());
            updateThread.Start();
            updateThread.Join();
            ScreenChanger(0);
        }

        private void QuitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void ScreenChanger(int screenOrder)
        {
            switch (screenOrder)
            {
                case 0:
                    {

                        aliasBox.Show();
                        IPBox.Show();
                        acceptButton.Show();
                        quitButton1.Show();

                        countLabel.Hide();
                        outcomeLabel.Hide();
                        quitButton.Hide();
                        rockButton.Hide();
                        paperButton.Hide();
                        scissorButton.Hide();
                        break;
                    }
                case 1:
                    {
                        countLabel.Show();
                        outcomeLabel.Show();
                        rockButton.Show();
                        paperButton.Show();
                        scissorButton.Show();
                        aliasBox.Show();
                        IPBox.Show();
                        acceptButton.Show();
                        quitButton.Show();

                        aliasBox.Hide();
                        IPBox.Hide();
                        acceptButton.Hide();
                        quitButton1.Hide();
                        break;
                    }
            }
        }

        private void DontPushLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://media.giphy.com/media/PApKgKr6r20mc/giphy.gif");
        }

        private void aliasBox_Click(object sender, EventArgs e)
        {
            errorLabel.ResetText();
            if(aliasBox.Text == "Username")
            {
                aliasBox.ResetText();
            }
        }
        public void TcpStart(string ip, string alias)
        {
            while (true)
            {
                try
                {
                    TcpClient client = new TcpClient(ip, _port);
                    NetworkStream stream = client.GetStream();
                    Debug.Write("Connection started");
                    Thread sendingThread = new Thread(() => SendThread(client, stream));
                    Thread receivingThread = new Thread(() => ReceiveThread(client, stream));
                    sendingThread.Start();
                    receivingThread.Start();
                    break;
                    //receivingThread.Join();
                    //sendingThread.Join();
                }
                catch (Exception ex)
                {
                    errorLabel.Text = ex.ToString();
                }
            }
        }

        public void SendThread(TcpClient client, NetworkStream stream)
        {
            while (true)
            {
                try
                {
                    if (firstTime == true)
                        FirstTime(stream);
                    else
                    {
                        if (newCommandFlag == true)
                            NewCommand(stream);
                    }
                }
                catch (Exception ex)
                {
                    Debug.Write("Eception: " + ex);
                }
                Thread.Sleep(1);
            }
        }

        public void ReceiveThread(TcpClient client, NetworkStream stream)
        {
            byte[] data = new byte[512];
            while (true)
            {
                try
                {
                    int respLength = stream.Read(data, 0, data.Length);
                    string stringData = Encoding.ASCII.GetString(data, 0, respLength);                   
                    Debug.Write(stringData);
                    string[] splitter = {": "};
                    string[] splitter2 = {", "};
                    string[] splitData = stringData.Split(splitter, System.StringSplitOptions.RemoveEmptyEntries);
                    if (splitData[0] == "Outcome")
                    {
                        string[] splittedPlayers = splitData[1].Split(splitter2, System.StringSplitOptions.RemoveEmptyEntries);
                        int i;
                        for(i = 0; i <= splittedPlayers.Length - 1; i++)
                        {
                            if(splittedPlayers[i] ==  alias)
                            {
                                outcomeData = "You Won!";
                            }
                            else if(i == splittedPlayers.Length - 1 && splittedPlayers[i] != alias)
                            {
                                outcomeData = "You Lost!";
                            }
                            newOutcome = true;
                        }
                    }
                    else if(splitData[0] == "Countdown")
                    {
                        countData = splitData[1] + " !";
                        newCountdown = true;
                    }
                }
                catch (Exception ex)
                {
                    //client.Close();
                }
                Thread.Sleep(1);
            }
        }

        public void FirstTime(NetworkStream stream)
        {
            dataStruct = new Tuple<string, string>("alias", alias);
            var message = System.Text.Encoding.ASCII.GetBytes(dataStruct.Item1 + ": " + dataStruct.Item2);
            stream.Write(message, 0, message.Length);
            firstTime = false;
            PSA = "First time is used";
        }

        public void NewCommand(NetworkStream stream)
        {
            switch (dataStruct.Item1)
            {
                // Rock / Paper / Scissors //
                case "answer":
                    {
                        var message = System.Text.Encoding.ASCII.GetBytes(dataStruct.Item1 + ": " + dataStruct.Item2);
                        stream.Write(message, 0, message.Length);
                        break;
                    }
            }
            newCommandFlag = false;
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            if (aliasBox.Text.Length <= 0 || aliasBox.Text == "Username" || IPBox.Text.Length <= 0 || IPBox.Text == "IP")
            {
                errorLabel.Text = "Your Info was not entered properly. Please enter again.";
            }
            else
            {
                alias = aliasBox.Text;
                ip = IPBox.Text;
                while (true)
                {
                    try
                    {
                        Thread TcpThread = new Thread(() => TcpStart(ip, alias));
                        TcpThread.Start();
                        ScreenChanger(1);
                        break;
                    }
                    catch(Exception ex)
                    {
                        errorLabel.Text = "Error: " + ex;
                    }
                }
            }
        }

        private void rockButton_Click(object sender, EventArgs e)
        {
            dataStruct = new Tuple<string, string>("answer", "rock");
            rockButton.Enabled = false;
            paperButton.Enabled = false;
            scissorButton.Enabled = false;
        }

        private void paperButton_Click(object sender, EventArgs e)
        {
            dataStruct = new Tuple<string, string>("answer", "paper");
            rockButton.Enabled = false;
            paperButton.Enabled = false;
            scissorButton.Enabled = false;
        }

        private void scissorButton_Click(object sender, EventArgs e)
        {
            dataStruct = new Tuple<string, string>("answer", "scissors");
            rockButton.Enabled = false;
            paperButton.Enabled = false;
            scissorButton.Enabled = false;
        }
    }
}
