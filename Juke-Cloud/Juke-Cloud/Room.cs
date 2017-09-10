using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juke_Cloud
{
    /// <summary>
    /// This class holds rooms which can hold different users and playlists than other rooms.
    /// </summary>
    class Room
    {

        String roomID;

        List<User> users = new List<User>();

        public Room (String ID)
        {
            this.roomID = ID;
        }
        /// <summary>
        /// Add a new user to the room.
        /// </summary>
        /// <param name="Dat_User"></param>
        public void addUser(User Dat_User)
        {
            users.Add(Dat_User);
        }
        /// <summary>
        /// Remove a user from the room.
        /// </summary>
        /// <param name="Dat_User"></param>
        public void removeUser(User Dat_User)
        {
            users.Remove(Dat_User);
        }

    }
}
