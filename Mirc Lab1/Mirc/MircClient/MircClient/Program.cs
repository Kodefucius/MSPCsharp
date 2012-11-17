using System;
using System.ServiceModel.Security;
using System.Threading;
using MircClient.MircService;

namespace MircClient
{
    internal class Program
    {
        private static MircServiceClient _mircServiceClient;

        private static void Main(string[] args)
        {
            _mircServiceClient = new MircServiceClient();
            string username = "User" + Guid.NewGuid().ToString();
            new Thread(ReadMessages).Start();

            while (true)
            {
                Console.Write("Gigi : ");
                string readLine = Console.ReadLine();
                _mircServiceClient.SendMessage(new Message{Info = readLine,Username = username});
            }
        }

        public static void ReadMessages()
        {
            while(true)
            {
                Console.Clear();
                string[] messages = _mircServiceClient.GetMessages();
                foreach (var message in messages)
                {
                    Console.WriteLine(message);
                }
                Thread.Sleep(500);
            }
        }
    }
}