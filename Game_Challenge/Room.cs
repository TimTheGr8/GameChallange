using System;
using System.Collections.Generic;
using System.Text;

namespace Game_Challenge
{
    public class Room
    {
        private int roomNumber;
        private string descritption;
        private string[] exits;
        public int[] connectingRooms;
        private string sounds;
        private string smells;


        #region Constructors
        public Room(int _number, string _exit1, string _sounds, string _smells, string _description)
        {
            roomNumber = _number;
            exits = new string[] { _exit1 };
            smells = _smells;
            sounds = _sounds;
            descritption = _description;
        }
        public Room(int _number, string _exit1, string _exit2, string _sounds, string _smells, string _description)
        {
            roomNumber = _number;
            exits = new string[] { _exit1, _exit2 };
            smells = _smells;
            sounds = _sounds;
            descritption = _description;
        }
        public Room(int _number, string _exit1, string _exit2, string _exit3, string _sounds, string _smells, string _description)
        {
            roomNumber = _number;
            exits = new string[] { _exit1, _exit2, _exit3 };
            smells = _smells;
            sounds = _sounds;
            descritption = _description;
        }
        public Room(int _number, string _exit1, string _exit2, string _exit3, string _exit4, string _sounds, string _smells, string _description)
        {
            roomNumber = _number;
            exits = new string[] { _exit1, _exit2, _exit3, _exit4 };
            smells = _smells;
            sounds = _sounds;
            descritption = _description;
        }
        #endregion

        public  string UseSmell()
        {
            string output = "";
            if(smells == "")
            {
                output = "You try to catch a wiff of anything, but nothing really stands out.";
            }
            else
            {
                output = $"You sniff the air and can smell {smells}.";
            }
            return output;
        }

        public string UseListen()
        {
            string output = "";
            if(sounds == "")
            {
                output = "You strain your ears, but can hear nothing";
            }
            else
            {
                output = $"You listen carefully and hear {sounds}.";
            }
            return output;
        }

        public string DisplayOpeningDescription()
        {
            return descritption;
        }

        public int GetRoomNumber()
        {
            return roomNumber;
        }

        public string[] GetExits()
        {
            return exits;
        }

    } // Class ends here
}
