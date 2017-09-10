using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juke_Cloud
{
    class Message
    {

        public string request { get; set; }

        public AudioObject song { get; set; }

        public string roomId { get; set; }

        public string userID { get; set; }

        public string roomPassword { get; set; }

        public string adminPassword { get; set; }
    }
}
