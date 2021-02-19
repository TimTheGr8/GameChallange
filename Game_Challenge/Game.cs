using System;
using System.Collections.Generic;
using System.Text;

namespace Game_Challenge
{
    class Game
    {
        private bool isPlayerAlive = true;
        private int timerCount = 10;

        private Room[] roomHolder = new Room[3];

        private Room currentRoom = null;

        public void Init()
        {
            for (int i = 0; i < roomHolder.Length; i++)
            {
                roomHolder[i] = new Room("starting room", "north", "", "the faint odor of food coming from the north");
            }
            currentRoom = roomHolder[0];
            currentRoom.RoomInitilization();
            GetPlayerInput(Console.ReadLine());
        }

        public bool IsGamePlaying()
        {
            return isPlayerAlive;
        }

        public void GetPlayerInput(string input)
        {
            string phrase = input;
            phrase.ToLower();
            string[] words = phrase.Split(' ');
            bool sucess = false;
            switch (words[0])
            {
                case "go":
                    currentRoom.ChangeRooms(roomHolder[0]);
                    break;
                case "smell":
                    currentRoom.UseSmell();
                    break;
                case "listen":
                    currentRoom.UseListen();
                    break;
                default:
                    Console.WriteLine("I am sorry, but I do not understand that response. Please try again.");
                    break;
            }
        }

        private void TryChangeRooms()
        {

        }

    } //Class ends here
}
