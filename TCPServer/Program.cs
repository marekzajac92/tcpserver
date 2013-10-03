using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NLog;

namespace TCPServer
{
    class Program
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();
        static void Main(string[] args)
        {
            logger.Info("Application start");
            logger.Info("Application terminated");
        }
    }
}