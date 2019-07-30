using System.Net.Sockets;

namespace ChatApplication
{
    public class Connection
    {
        public void CloseConnection(Socket socket)
        {
            socket.Shutdown(SocketShutdown.Both);
            socket.Close();
        }
    }
}
