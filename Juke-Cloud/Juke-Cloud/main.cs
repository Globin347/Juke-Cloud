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
        /// <summary>
        /// This program is intended to set up a simple audio server with which any user can add new audio tracks
        /// to the playlist at any time.
        /// 
        /// To be honest, the main reason we're doing it is so that we can slip Siivagunner videos into party playlists,
        /// but it's good practice.
        /// </summary>
        /// <param name="args"></param>
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
