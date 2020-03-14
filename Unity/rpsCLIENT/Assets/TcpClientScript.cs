using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Net;
using UnityEngine;
using UnityEngine.UI;

public class TcpClientScript : MonoBehaviour
{

    [SerializeField]
    public string alias;
    public string ip;
    public static string roomName;
    public static string createdRoom;

    public static string roomData;

    public int respLength;

    public static Tuple<string, string> dataStruct;

    public Tuple<NetworkStream, TcpClient> TcpTuple;

    public TcpClient client;

    public NetworkStream stream;

    public bool plsConnect = false;
    public bool firstTime = false;
    public bool buttonPressed = false;
    public byte[] data = new byte[1024];

    public int _port = 5005;

    public static bool newCommandFlag = false;
    public bool newCountdown = false;
    public bool newOutcome = false;
    public bool errorMessage = false;
    public bool newUDPMessage = false;

    public string UDPPackage = null;
    public string countData = null;
    public string outcomeData = null;
    public string errorData = null;

    public static List<string> roomList = new List<string>();

    public GameObject nameInput;
    public GameObject ipInput;

    public string name = null;
    public string ipText = null;

    public GameObject rockButton = null;
    public GameObject paperButton = null;
    public GameObject scissorsButton = null;


    void Start()
    {
        // Get references for gameobjects //
        nameInput = GameObject.Find("NameInput").transform.FindChild("NameText").gameObject;
        ipInput = GameObject.Find("IPInput").transform.FindChild("IPText").gameObject;
        rockButton = GameObject.Find("RockButton");
        paperButton = GameObject.Find("PaperButton");
        scissorsButton = GameObject.Find("ScissorsButton");

        // Starting the Client looker thread //
        Thread looking = new Thread(() => Looking());
        looking.Start();
    }

    // Update is called once per frame
    void Update()
    {
        // Gets update for the ip and alias for other uses //
        alias = nameInput.GetComponent<Text>().text;
        ip = ipInput.GetComponent<Text>().text;

        // UDP for getting IP address //
        if(newUDPMessage == true)
        {
            try
            {
                GameObject.Find("ErrorText").GetComponent<Text>().text = UDPPackage;
                ipInput.GetComponent<Text>().text = UDPPackage;
                ip = UDPPackage;
                newUDPMessage = false;
            }
            catch (Exception ex)
            {
                Debug.Log(ex);
            }
        }

        // Checks if there are new count down messages //
        if (newCountdown == true)
        {
            try
            {
                GameObject.Find("CountText").GetComponent<Text>().text = countData;
                newCountdown = false;
            }
            catch(Exception ex)
            {
                Debug.Log(ex);
            }

        }

        // Checks i fthere are new Outcome messages //
        if (newOutcome == true)
        {
            SplitAndWrite(outcomeData);
            rockButton.SetActive(true);
            paperButton.SetActive(true);
            scissorsButton.SetActive(true);
            newOutcome = false;
        }

        // Checks if there are any instruction messages //
        if (errorMessage == true)
        {
            GameObject.Find("ErrorText").GetComponent<Text>().text = errorData;
            errorMessage = false;
        }
    }

    // TCP Server looker thread that looks for server//
    public void Looking()
    {
        while (true)
        {
            try
            {
                errorData = "Connecting...";
                errorMessage = true;
                Debug.Log("Connecting...");
                TcpStart();
                errorData = "Connected";
                errorMessage = true;
                Debug.Log("Connected!");
                break;
            }
            catch (Exception ex)
            {
                Debug.Log(ex);
            }
        }
        Thread.CurrentThread.Abort();
    }

    // This tries to connect to a TCP Server and loops and breaks when it is found // 
    public void TcpStart()
    {
        while (true)
        {
            try
            {
                TcpClient client = new TcpClient(ip, _port);
                NetworkStream stream = client.GetStream();
                errorData = "Connection Established!!!";
                errorMessage = true;
                Debug.Log("Connection started");
                Thread sendingThread = new Thread(() => SendThread(client, stream));
                Thread receivingThread = new Thread(() => ReceiveThread(client, stream));
                sendingThread.Start();
                receivingThread.Start();
                break;
            }
            catch (Exception ex)
            {
                Debug.Log(ex);
            }
        }
        Thread.Sleep(1);
    }

    // Handler for the Join button //
    public void AcceptButton()
    {
        //Thread looking = new Thread(() => Looking());
        //looking.Start();
        firstTime = true;
        buttonPressed = true;
        SceneChangerScript.SceneChanger(2);
    }

    // Thread that handles sending of the messages to the server //
    public void SendThread(TcpClient client, NetworkStream stream)
    {
        while (true)
        {
            try
            {
                // When join button is pressed this executes //
                if(buttonPressed == true)
                {
                    if (firstTime == true)
                        FirstTime(stream);
                }
                // When there are new messages to be sent //
                else
                {
                    if (newCommandFlag == true)
                    {
                        NewCommand(stream);
                        newCommandFlag = false;
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.Log("Exception: " + ex);
            }
            Thread.Sleep(1);
        }
    }

    // This is thread for receiving messages // 
    public void ReceiveThread(TcpClient client, NetworkStream stream)
    {
        byte[] data = new byte[512];
        while (true)
        {
            try
            {   
                int respLength = stream.Read(data, 0, data.Length);
                string stringData = Encoding.ASCII.GetString(data, 0, respLength);
                Debug.Log(stringData);
                string[] splitter = { "; " };
                string[] splitData = stringData.Split(splitter, System.StringSplitOptions.RemoveEmptyEntries);
                // This is for receiving outcomes // 
                if (splitData[0] == "Outcome")
                {
                    outcomeData = splitData[1];
                    newOutcome = true;
                }
                // This is for receiving count Down //
                else if (splitData[0] == "Countdown")
                {
                    countData = splitData[1] + " !";
                    newCountdown = true;
                }                
            }
            catch (Exception ex)
            {
                Debug.Log(ex);
                //client.Close();
            }
            Thread.Sleep(1);
        }
    }

    // ´For sending the first time message //
    public void FirstTime(NetworkStream stream)
    {
        dataStruct = new Tuple<string, string>("connect", alias);
        var message = System.Text.Encoding.ASCII.GetBytes("msgtype: " + dataStruct.Item1 + "; " + "alias" + ": " + dataStruct.Item2);
        stream.Write(message, 0, message.Length);
        firstTime = false;
        buttonPressed = false;
    }

    // This chooses the right response for the sendable message //
    public void NewCommand(NetworkStream stream)
    {
        switch (dataStruct.Item1)
        {
            // Rock / Paper / Scissors //
            case "answer":
                {   
                    //msgtype: TYPE; alias: MESSAGE //
                    var message = System.Text.Encoding.ASCII.GetBytes("msgtype: play; alias: "+ alias + "; " + dataStruct.Item1 + ": " + dataStruct.Item2);
                    stream.Write(message, 0, message.Length);
                    break;
                }
        }
        newCommandFlag = false;
    }

    // This handles the splitting and writing of the message for UI for the results of the round //
    public void SplitAndWrite(string data)
    {
        GameObject.Find("ResultsText").GetComponent<Text>().text = " ";
        string[] splitter = { ", " };
        string[] splitData = data.Split(splitter, System.StringSplitOptions.RemoveEmptyEntries);

        foreach(string player in splitData)
        {
            try
            {
                GameObject.Find("ResultsText").GetComponent<Text>().text += player + Environment.NewLine;
            }
            catch(Exception ex)
            {
                Debug.Log(ex);
            }

        }
    }

    public void Udpstarter()
    {
        Thread udplook = new Thread(() => Udp());
        udplook.Start();
    }

    public void Udp()
    {
        while (true)
        {
            try
            {
                var Client = new UdpClient();
                var RequestData = Encoding.ASCII.GetBytes("SomeRequestData");
                var ServerEp = new IPEndPoint(IPAddress.Any, 0);

                Client.EnableBroadcast = true;
                Client.Send(RequestData, RequestData.Length, new IPEndPoint(IPAddress.Broadcast, 4801));

                var ServerResponseData = Client.Receive(ref ServerEp);
                var ServerResponse = Encoding.ASCII.GetString(ServerResponseData);

                newUDPMessage = true;
                UDPPackage = ServerEp.Address.ToString();
                Debug.Log(ServerEp.Address.ToString());
                //GameObject.Find("ErrorText").GetComponent<Text>().text = "UDP" + ServerResponse + " " + ServerEp.Address.ToString();

                Client.Close();
                Thread.CurrentThread.Abort();
            }
            catch (Exception ex)
            {
                Debug.Log(ex);
            }
        }
    }


    // Handles the Rock button //
    public void Rock()
    {
        dataStruct = new Tuple<string, string>("answer", "rock");
        rockButton.SetActive(false);
        paperButton.SetActive(false);
        scissorsButton.SetActive(false);
        newCommandFlag = true;
    }

    // Handles the Paper button //
    public void Paper()
    {
        dataStruct = new Tuple<string, string>("answer", "paper");
        rockButton.SetActive(false);
        paperButton.SetActive(false);
        scissorsButton.SetActive(false);
        newCommandFlag = true;
    }

    // Handles the Scissors button //
    public void Scissors()
    {
        dataStruct = new Tuple<string, string>("answer", "scissors");
        rockButton.SetActive(false);
        paperButton.SetActive(false);
        scissorsButton.SetActive(false);
        newCommandFlag = true;
    }
}
