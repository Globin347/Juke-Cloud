using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebSocketSharp;
using WebSocketSharp.Server;

namespace Juke_Cloud
{
    class User
    {

        string clientID;
        

        public User(string ID)
        {
            clientID = ID;
        }

    }
}
