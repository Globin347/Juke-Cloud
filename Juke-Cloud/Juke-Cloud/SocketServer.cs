using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebSocketSharp;
using WebSocketSharp.Server;

namespace Juke_Cloud
{
    /// <summary>
    /// This is the server connection reciever- a socket server.
    /// </summary>
    class SocketServer : WebSocketBehavior
    {
        static Dictionary<string, Room> roomsMasterList = new Dictionary<string, Room>();
        /// <summary>
        /// This function recieves messages sent to the server.
        /// </summary>
        /// <param name="e"></param>
        /// <returns></returns>
        protected override Task OnMessage(MessageEventArgs e)
        {
            Message message;
            try
            {
                message = JsonConvert.DeserializeObject<dynamic>(e.Text.ReadToEnd());
            }
            catch
            {
                Console.WriteLine("json does not fit into message object");
                return null;
            }
            Console.WriteLine("messaged");



            switch (message.request)
            {
                case "newRoom":
                    if (message.roomId.Length > 5 && message.roomId.Length < 50)
                    {
                        Room room = new Room(message.roomId);
                        roomsMasterList.Add(message.roomId, room);
                    }
                    else
                    {
                        Console.WriteLine("Roomid out of bounds");
                    }

                    break;
                case "addSong":
                    Room rooom;
                    roomsMasterList.TryGetValue(message.roomId, out rooom);
                break;
                case "pause":

                    break;


            }


            return base.OnMessage(e);

        }

        /// <summary>
        /// This function is called when a user
        /// connects to the server.
        /// </summary>
        /// <returns></returns>
        protected override Task OnOpen()
        {
            Console.WriteLine("Opened");
            return base.OnOpen();
            
        }

    }
}
