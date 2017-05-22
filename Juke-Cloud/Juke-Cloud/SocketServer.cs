using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebSocketSharp;
using WebSocketSharp.Server;

namespace Juke_Cloud
{
    class SocketServer : WebSocketBehavior
    {

        protected override Task OnMessage (MessageEventArgs e)
        {
            Console.WriteLine("messaged...?");
            return base.OnMessage(e);
        }

        protected override Task OnOpen()
        {
            Console.WriteLine("Opened");
            return base.OnOpen();
            
        }

    }
}
