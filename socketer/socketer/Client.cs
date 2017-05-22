using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WebSocket4Net;

namespace socketer
{
    class Client
    {

        String clientID;

        static void Main(string[] args)
        {
            WebSocket socket = new WebSocket("ws://localhost");
            socket.Open();
            Console.ReadLine();
            socket.Send("connection!");
            Console.ReadLine();
            socket.Close();
        }
    }
}
