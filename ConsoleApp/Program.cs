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
            Console.WriteLine("Enter your username");
            string username = Console.ReadLine();
            server1.ConnectToServer(username);
            Console.WriteLine("Enter Message");
            string msg = Console.ReadLine();
            server1.SendMessageToServer(msg);
        }
    }
}
