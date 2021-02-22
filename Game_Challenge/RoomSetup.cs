using System;
using System.Collections.Generic;
using System.Text;

namespace Game_Challenge
{
    public class RoomSetup
    {
        public static void SetupRooms (Room[] _rooms)
        {
            // new Room parameters are: name, exits 1 - 4, sound, smell, description
             _rooms[0] = new Room("starting room", "north", "", "the faint odor of food coming from the north", "You are in a small room that feels cramped. You can see some light coming from a small archway to the north.");
        }

    }
}
