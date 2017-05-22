using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebSocketSharp;
using WebSocketSharp.Server;

namespace Juke_Cloud
{
    class main
    {

        List<Room> rooms = new List<Room>();
        Room newRoom = new Room("Dat_Room");

        public static void Main(String[] args)
        {



            var server = new WebSocketServer();
            server.AddWebSocketService<SocketServer>("/");
            server.Start();
            Console.ReadKey(true);
            server.Stop();
        }

    }
}
