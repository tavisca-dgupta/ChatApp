using System.Net;
using System.Net.Sockets;

namespace ChatApplication
{
    public class Network
    {
        IPEndPoint localEndPoint;

        public Socket GetSocket(string address)
        {
            IPAddress ipAddr = IPAddress.Parse(address);
            localEndPoint = new IPEndPoint(ipAddr, 11111);
            return new Socket(ipAddr.AddressFamily,
                 SocketType.Stream, ProtocolType.Tcp);
        }
        public void Connect(Socket sender)
        {
            sender.Connect(localEndPoint);
        }

        public void BindSocket(Socket listenerSocket)
        {
            listenerSocket.Bind(localEndPoint);
        }
    }
}
