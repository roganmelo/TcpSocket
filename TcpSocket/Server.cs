using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace TcpSocket
{
    public class Server
    {
        private string host;
        private int port;
        private ServerForm serverForm;
        private IPAddress ipAddress;
        private TcpListener listener;
        private TcpClient client;
        private Thread thread;
        private NetworkStream networkStream;

        public Server(ServerForm serverForm)
        {
            this.serverForm = serverForm;
        }

        public void Start(string host, int port)
        {
            this.host = host;
            this.port = port;

            ipAddress = Dns.GetHostAddresses(host)[0];
            
            listener = new TcpListener(ipAddress, port);
            listener.Start();
            serverForm.SetMessage("Listening on port: " + port + "...");

            thread = new Thread(new ThreadStart(ServerStartThread));
            thread.IsBackground = true;
            thread.Priority = ThreadPriority.Highest;
            thread.Name = "ServerStartThread";
            thread.Start();
        }

        private void ServerStartThread()
        {
            try
            {
                client = listener.AcceptTcpClient();
                serverForm.SetMessage("Connection accepted...");

                do
                {
                    networkStream = client.GetStream();

                    if (networkStream.CanRead)
                    {
                        byte[] bytes = new byte[client.ReceiveBufferSize];
                        networkStream.Read(bytes, 0, Convert.ToInt32(client.ReceiveBufferSize));

                        string clientData = Encoding.ASCII.GetString(bytes);
                        if (clientData.Replace("\0", "").Trim() != "")
                            serverForm.SetMessage(clientData);
                        else
                            client = null;
                    }
                } while (client != null);

                Stop();
                Start(host, port);
            }
            catch { }
        }

        public void Stop()
        {
            SendMessage("Closing connection...");

            if (thread != null)
                if (thread.ThreadState == ThreadState.Running)
                    thread.Abort();

            if (client != null)
                client.Client.Disconnect(true);

            listener.Stop();
            listener = null;

            serverForm.SetMessage("Connection lost...");
        }

        private void SendMessage(string message)
        {
            if (CanWrite())
            {
                byte[] sendBytes = Encoding.ASCII.GetBytes(message);
                networkStream.Write(sendBytes, 0, sendBytes.Length);
            }
        }

        public bool CanWrite()
        {
            if (networkStream == null)
                return false;

            if (networkStream.CanWrite && client != null)
                return true;
            else
                return false;
        }
    }
}
