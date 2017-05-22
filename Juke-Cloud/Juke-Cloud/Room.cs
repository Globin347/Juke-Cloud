using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juke_Cloud
{
    class Room
    {

        String roomID;

        List<User> users = new List<User>();

        public Room (String ID)
        {
            this.roomID = ID;
        }

        public void addUser(User Dat_User)
        {
            users.Add(Dat_User);
        }

        public void removeUser(User Dat_User)
        {
            users.Remove(Dat_User);
        }

    }
}
