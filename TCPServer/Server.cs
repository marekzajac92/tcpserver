using System;
using System.Net;
using System.Net.Sockets;
using NLog;

namespace TCPServer
{
    class Server
    {
        private Logger logger = LogManager.GetCurrentClassLogger();

        private TcpListener listener;
        private TcpClient client;

        public Server()
        {
            logger.Info("Server object was created");

            int port = ReadPort();

            listener = new TcpListener(IPAddress.Any, port);
            client = default(TcpClient);
        }

        public void Run()
        {
            logger.Info("Server run");

            listener.Start();

            while (true)
            {
                client = listener.AcceptTcpClient();

                SingleConnection connection = new SingleConnection(client);
            }
        }

        private int ReadPort()
        {
            int port;
            Console.WriteLine("Port:");
            if (!Int32.TryParse(Console.ReadLine(), out port))
            {
                port = 8888;
            }

            return port;
        }
    }
}
