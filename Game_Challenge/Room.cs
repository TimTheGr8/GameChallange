using System;
using System.Collections.Generic;
using System.Text;

namespace Game_Challenge
{
    public class Room
    {
        private string roomName;
        private string descritption;
        private string[] exits;
        private string sounds;
        private string smells;


        #region Constructors
        public Room(string _name, string _exit1, string _sounds, string _smells, string _description)
        {
            roomName = _name;
            exits = new string[] { _exit1 };
            smells = _smells;
            sounds = _sounds;
            descritption = _description;
        }
        public Room(string _name, string _exit1, string _exit2, string _sounds, string _smells, string _description)
        {
            roomName = _name;
            exits = new string[] { _exit1, _exit2 };
            smells = _smells;
            sounds = _sounds;
            descritption = _description;
        }
        public Room(string _name, string _exit1, string _exit2, string _exit3, string _sounds, string _smells, string _description)
        {
            roomName = _name;
            exits = new string[] { _exit1, _exit2, _exit3 };
            smells = _smells;
            sounds = _sounds;
            descritption = _description;
        }
        public Room(string _name, string _exit1, string _exit2, string _exit3, string _exit4, string _sounds, string _smells, string _description)
        {
            roomName = _name;
            exits = new string[] { _exit1, _exit2, _exit3, _exit4 };
            smells = _smells;
            sounds = _sounds;
            descritption = _description;
        }
        #endregion

        public  void RoomInitilization()
        {
            DisplayOpeningDescription();
        }

        public  void UseSmell()
        {
            string output = "";
            if(smells == "")
            {
                output = "You ";
            }
            Console.WriteLine($"You sniff the air and can smell {smells}.");
        }

        public void UseListen()
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
            Console.WriteLine(output);
        }

        public void DisplayOpeningDescription()
        {
            Console.WriteLine(descritption);
        }

        public void ChangeRooms(Room nextRoom, string direction)
        {
            nextRoom.RoomInitilization();
        }
    }
}
