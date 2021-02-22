using System;
using System.Collections.Generic;
using System.Text;

namespace Game_Challenge
{
    public class Game
    {
        public static bool isPlayerAlive = true;
        private int timerCount = 10;
        private string currentOutput = "";
        private Room[] roomHolder = new Room[3];

        private Room currentRoom;

        public void Init()
        {
            DisplayInstructions();
            RoomSetup.SetupRooms(roomHolder);
            currentRoom = roomHolder[0];
            currentRoom.RoomInitilization();
            GetPlayerInput();
        }

        public bool IsGamePlaying()
        {
            while(isPlayerAlive == true)
            {
                GetPlayerInput();
            }
            return isPlayerAlive;
        }

        public void GetPlayerInput()
        {
            string phrase = Console.ReadLine();
            phrase.ToLower();
            string[] words = phrase.Split(' ');
            switch (words[0])
            {
                case "go":
                    ChangeRooms(words[1]);
                    break;
                case "smell":
                    currentRoom.UseSmell();
                    break;
                case "listen":
                    currentRoom.UseListen();
                    break;
                case "exit":
                    isPlayerAlive = false;
                    break;
                case "quit":
                    isPlayerAlive = false;
                    break;
                case "help":
                    DisplayHelp();
                    break;
                default:
                    Console.WriteLine("I am sorry, but I do not understand that response. Please try again.");
                    break;
            }
        }

        private void DisplayInstructions()
        {
            Console.WriteLine("Welcome to the great escpae! You are not sure how, why, or where you are. All you know is that you must keep moving.\n" +
                              "If you stay in one place too long you fear the worst may happen. The goal is to make it to the exit. But how will\n" +
                              "you find the exit? Simple, you can use your sense of smell and hearing. All you need to do is type \"smell\" to see what\n" +
                              "scents are around you. For hearing type \"listen\" to hear any sounds that may be close. To navigate around you type \"go\" \n" +
                              "and then a direction. For example, to exit the current room to the north type \"go north\". As long as there is an exit in \n" +
                              "that direction you will go to that room. To exit or quit the game type \"quit\" or \"exit\". To restart the game type \"retry\".\n" +
                              "IF at any time you forget what to do just type \"help\". This will bring up a list of commands that you are able to use. \n" +
                              "Now get out there and find your way to the exit.\n" +
                              "\n" +
                              "Press any key to continue. ");

            Console.ReadKey();
            Console.Clear();
        }

        private void DisplayHelp()
        {
            Console.WriteLine("You can use your sense of smell and hearing. All you need to do is type \"smell\" to see what scents are around you. \n" +
                              "For hearing type \"listen\" to hear any sounds that may be close. To navigate around you type \"go\" and then a direction. \n" +
                              "As long as there is an exit in that direction you will go to that room. \n" +
                              "To exit or quit the game type \"quit\" or \"exit\". To restart the game type \"retry\".\n" +
                              "If at any time you forget what to do just type \"help\". This will bring up a list of commands that you are able to use. \n" +
                              "Now get out there and find your way to the exit.\n" +
                              "\n" +
                              "Press any key to continue. ");
            Console.ReadKey();
        }

        public void NewRoom(int nextRoom)
        {
            currentRoom = roomHolder[0];
            currentRoom.RoomInitilization();

            CheckForWin(currentRoom);
        }

        public void ChangeRooms(string direction)
        {
            int nextRoom = -1;
            for (int i = 0; i < currentRoom.GetExits().Length; i++)
            {
                if (direction == currentRoom.GetExits()[i])
                {
                    nextRoom = currentRoom.connectingRooms[i];
                    break;
                }
            }
            if (nextRoom >= 0)
            {
                currentRoom = roomHolder[nextRoom];
                currentRoom.RoomInitilization();
            }
            else
                Console.WriteLine("There is no exit in that direction, just a wall.");
        }


        private void CheckForWin(Room _room)
        {
            if(_room.GetRoomNumber() == 2)
            {
                isPlayerAlive = false;
            }
        }

    } //Class ends here
}
