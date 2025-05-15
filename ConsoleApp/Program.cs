using ConsoleApp.Net.IO;
using System.Net.Sockets;
using System.Net;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main()
        {
            Server server1 = new Server();
            server1.msgReceivedEvent += () =>
                {
                    string msg2 = server1.PacketReader.ReadMessage();
                    Console.WriteLine(msg2);
                };
            Console.WriteLine("Enter your username");
            string username = Console.ReadLine();
            server1.ConnectToServer(username);
            while (true)
            {
                Console.WriteLine("Enter Message");
                string msg = Console.ReadLine();
                if (username != null)
                {
                    server1.SendMessageToServer(msg);
                }
                else
                {
                    break;
                }
            }
        }
    }
}
