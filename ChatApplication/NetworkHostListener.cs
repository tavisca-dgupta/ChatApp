using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ChatApplication
{
    public class NetworkHostListener
    {
        private static Network network;

        public void StartListening()
        {
            Socket listenerSocket = network.GetSocket("ipaddress");
            network.BindSocket(listenerSocket);
            listenerSocket.Listen(10);

            Console.WriteLine("Waiting for connection ... ");
            Socket clientSocket = listenerSocket.Accept();
        }

        public void StopListening()
        {
            CloseConnection( socket)
        }
    }
}
