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

namespace RPSClient
{
    public partial class Form1 : Form
    {
        public string alias;
        public string ip;
        public static string roomName;
        public static string createdRoom;

        public int _port = 5005;
        public static string PSA;

        public static bool newCommandFlag = false;
        public static bool firstTime = true;

        public static Tuple<string, string> dataStruct;

        public Tuple<NetworkStream, TcpClient> TcpTuple; 


        // 0 = Alias screen // 1 = Room selection screen // 2 = Inside room screen //
        public int screenOrder = 0;

        public Form1()
        {
            InitializeComponent();
            ScreenChanger(0);
        }

        private void QuitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AcceptButtonClick(object sender, EventArgs e)
        {
            if (aliasBox.Text.Length <= 0 || aliasBox.Text == "Username" || IPBox.Text.Length <= 0 || IPBox.Text == "IP")
            {
                errorLabel.Text = "Your Info was not entered properly. Please enter again.";
            }
            else
            {
                alias = aliasBox.Text;
                ip = IPBox.Text;
                TcpStart(ip, alias);
                ScreenChanger(1);

            }
        }

        public void ScreenChanger(int screenOrder)
        {
            switch (screenOrder)
            {
                case 0:
                    {
                        aliasBox.Show();
                        acceptButton.Show();
                        quitButton.Show();

                        joinButton.Hide();
                        createButton.Hide();
                        quitButton1.Hide();
                        roomListBox.Hide();
                        break;
                    }
                case 1:
                    {
                        joinButton.Show();
                        createButton.Show();
                        quitButton1.Show();
                        roomListBox.Show();

                        aliasBox.Hide();
                        acceptButton.Hide();
                        quitButton.Hide();
                        errorLabel.Hide();
                        errorLabel.ResetText();
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void quitButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void joinButton_Click(object sender, EventArgs e)
        {
            roomName = roomListBox.SelectedItem.ToString();
            ScreenChanger(2);
        }

        private void aliasBox_Click(object sender, EventArgs e)
        {
            errorLabel.ResetText();
            if(aliasBox.Text == "Username")
            {
                aliasBox.ResetText();
            }
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            Form2 popup = new Form2();
            popup.Show();
        }

        public void TcpStart(string ip, string alias)
        {
            while (true)
            {
                try
                {
                    errorLabel.Text = "Searching Connection...";
                    TcpClient client = new TcpClient(ip, _port);
                    NetworkStream stream = client.GetStream();
                    //Thread sendingThread = new Thread(() => SendThread(client, stream));
                    //Thread receivingThread = new Thread(() => ReceiveThread(client, stream));
                    //sendingThread.Start();
                    //receivingThread.Start();
                    //Tuple<NetworkStream, TcpClient> tuple = new Tuple<NetworkStream, TcpClient>(stream, client);
                    dataStruct = new Tuple<string, string>("alias", alias);
                    var message = System.Text.Encoding.ASCII.GetBytes(dataStruct.Item1 + " " + dataStruct.Item2);
                    stream.Write(message, 0, message.Length);
                    //return tuple;
                    //receivingThread.Join();
                    //sendingThread.Join();/
                }
                catch (SocketException e)
                {
                    errorLabel.Text = e.ToString();
                }
            }
        }

        public void SendThread(TcpClient client, NetworkStream stream)
        {
            while (true)
            {
                PSA = "Searching message...";
                try
                {
                    if (firstTime == true)
                        FirstTime(firstTime, stream);
                    else
                    {
                        if (newCommandFlag == true)
                            NewCommand();
                    }
                }
                catch (SocketException e)
                {
                    client.Close();
                }
            }
        }

        public void ReceiveThread(TcpClient client, NetworkStream stream)
        {
            byte[] data = new byte[1024];
            while (true)
            {
                try
                {
                    int respLength = stream.Read(data, 0, data.Length);
                    string stringData = Encoding.ASCII.GetString(data, 0, respLength);
                }
                catch (SocketException e)
                {
                    client.Close();
                }
            }
        }

        public void FirstTime(bool firstTime, NetworkStream stream)
        {
            dataStruct = new Tuple<string, string>("alias", alias);
            var message = System.Text.Encoding.ASCII.GetBytes(dataStruct.Item1 + " " + dataStruct.Item2);
            stream.Write(message, 0, message.Length);
            firstTime = false;
            PSA = "First time is used";
        }

        public void NewCommand()
        {
            switch (dataStruct.Item1)
            {
                // Rock / Paper / Scissors //
                case "response":
                    {

                        break;
                    }
                // Player name //
                case "alias":
                    {

                        break;
                    }
                // Creating new room //
                case "newRoom":
                    {

                        break;
                    }
            }
        }
    }
}
