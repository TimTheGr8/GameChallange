using System;
using System.Collections.Generic;
using System.Text;

namespace Game_Challenge
{
    public class Room
    {
        private string roomName;
        private string[] exits;
        private string sounds;
        private string smells;


        #region Constructors
        public Room(string _name, string _exit1, string _sounds, string _smells)
        {
            roomName = _name;
            exits = new string[] { _exit1 };
            smells = _smells;
            sounds = _sounds;
        }
        public Room(string _name, string _exit1, string _exit2, string _sounds, string _smells)
        {
            roomName = _name;
            exits = new string[] { _exit1, _exit2 };
            smells = _smells;
            sounds = _sounds;
        }
        public Room(string _name, string _exit1, string _exit2, string _exit3, string _sounds, string _smells)
        {
            roomName = _name;
            exits = new string[] { _exit1, _exit2, _exit3 };
            smells = _smells;
            sounds = _sounds;
        }
        public Room(string _name, string _exit1, string _exit2, string _exit3, string _exit4, string _sounds, string _smells)
        {
            roomName = _name;
            exits = new string[] { _exit1, _exit2, _exit3, _exit4 };
            smells = _smells;
            sounds = _sounds;
        }
        #endregion

        public  void RoomInitilization()
        {
            DisplayOpeningDescription();
        }

        public  void UseSmell()
        {
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
            Console.WriteLine("The room you are in is dark and feels cramped. Through the darkness you can see a small beam of light coming from the north wall.");
        }

        public void ChangeRooms(Room nextRoom)
        {
            Console.WriteLine("You have walked to the north and escpaed with your life!!!!!.");
            //nextRoom.RoomInitilization();
        }
    }
}
