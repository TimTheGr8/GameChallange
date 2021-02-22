using System;
using System.Collections.Generic;
using System.Text;

namespace Game_Challenge
{
    public class RoomSetup
    {
        public static void SetupRooms (Room[] _rooms)
        {
            // new Room parameters are: name, exits 1 - 4, sound : You listen carefully and hear, smell: You sniff the air and can smell, description
            _rooms[0] = new Room(0, "north", "west", "", "the faint odor of food coming from the north", "You are in a small room that feels cramped. You can see some light coming from a small archway to the north.");
            _rooms[1] = new Room(1, "north","south", "east", "west", "what sounds like a deep growl coming from the east", "little scraps of food all around the room", "The floor of this room has debris scattered around. There are door ways leading to the north, south east and west.");
            _rooms[2] = new Room(2, "west", "", "", "As you walk into this room you see a giant cat grinning widely at you. AS you turn to run you feel claws dig into you and the last thing you see is the light from the doorway fading as you breathe your last breath.");

            SetupExits(_rooms);
        }

        private static void SetupExits(Room[] _rooms)
        {
            // Room 0 connectingrooms
            _rooms[0].connectingRooms = new int[2];
            _rooms[0].connectingRooms[0] = 1;
            _rooms[0].connectingRooms[1] = 3;
            // Room 1 connectingRooms
            _rooms[1].connectingRooms = new int[4];
            _rooms[1].connectingRooms[0] = 6;
            _rooms[1].connectingRooms[1] = 0;
            _rooms[1].connectingRooms[2] = 2;
            _rooms[1].connectingRooms[3] = 3;
        }

    }
}
