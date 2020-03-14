using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace sunshine2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Joo");
            var Server = new UdpClient(4801);
            var ResponseData = Encoding.ASCII.GetBytes("SomeResponseData");
            Console.WriteLine(Server);
            Console.WriteLine("2");
            Console.WriteLine(ResponseData);


            while (true)
            {
                Console.WriteLine("3");
                var ClientEp = new IPEndPoint(IPAddress.Any, 0);
                Console.WriteLine(ClientEp.Address);
                Console.WriteLine("4");
                var ClientRequestData = Server.Receive(ref ClientEp);
                Console.WriteLine("5");
                Console.WriteLine(ClientRequestData);
                var ClientRequest = Encoding.ASCII.GetString(ClientRequestData);

                Console.WriteLine("Recived {0} from {1}, sending response", ClientRequest, ClientEp.Address.ToString());
                Server.Send(ResponseData, ResponseData.Length, ClientEp);
            }
        }
    }
}
