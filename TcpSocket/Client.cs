using System;
using System.IO;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace TcpSocket
{
    public class Client
    {
        private ClientForm clientForm;
        private TcpClient client;
        private Thread thread;
        private NetworkStream networkStream;

        public Client(ClientForm clientForm)
        {
            this.clientForm = clientForm;
        }

        public void Start(string host, int port)
        {
            try
            {
                client = new TcpClient();
                clientForm.SetMessage("Connecting...");
                client.Connect(host, port);
            }
            catch { }
            
            thread = new Thread(new ThreadStart(ClientStartThread));
            thread.IsBackground = true;
            thread.Priority = ThreadPriority.Highest;
            thread.Name = "ClientStartThread";
            thread.Start();
        }

        private void ClientStartThread()
        {
            try
            {
                do
                {
                    networkStream = client.GetStream();

                    if (networkStream.CanRead)
                    {
                        byte[] bytes = new byte[client.ReceiveBufferSize];
                        networkStream.Read(bytes, 0, Convert.ToInt32(client.ReceiveBufferSize));

                        string returnData = Encoding.ASCII.GetString(bytes);
                        if (returnData.Replace("\0", "") == "Closing connection...")
                        {
                            clientForm.SetMessage(returnData);
                            clientForm.Disconnect();
                        }
                    }
                    else
                    {
                        clientForm.SetMessage("Error");
                        clientForm.Disconnect();
                    }
                } while (client.Connected);
            }
            catch (IOException)
            {
                clientForm.SetMessage("Client disconnected...");
            }
            catch (InvalidOperationException)
            {
                clientForm.SetMessage("Server is offline...");
                clientForm.Disconnect();
            }
        }

        public void Disconnect()
        {
            if (thread != null)
                if (thread.ThreadState == ThreadState.Running)
                    thread.Abort();

            client.Close();
        }

        public void SendMessage(string message)
        {
            if (networkStream.CanWrite)
            {
                byte[] sendBytes = Encoding.ASCII.GetBytes(message);
                networkStream.Write(sendBytes, 0, sendBytes.Length);
                clientForm.SetMessage(message);
            }else
            {
                clientForm.SetMessage("Error");
                Disconnect();
            }
        }
    }
}
