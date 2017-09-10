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
        /// <summary>
        /// This function recieves messages sent to the server.
        /// </summary>
        /// <param name="e"></param>
        /// <returns></returns>
        protected override Task OnMessage (MessageEventArgs e)
        {
            Console.WriteLine("messaged...?");
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
