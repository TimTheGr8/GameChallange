using System;
using System.Timers;

namespace Game_Challenge
{
    public class Game
    {
        private static bool isPlayerAlive = true;
        private bool isGameRuning = true;
        private static bool canType = true;
        private static int timerCount;
        static Timer aTimer;
        private string currentOutput;
        private Room[] roomHolder = new Room[12];

        private Room currentRoom;

        public void Init()
        {
            // Resting the variables for new playthrough
            isPlayerAlive = true;
            canType = true;
            currentOutput = "";
            roomHolder = new Room[12];
            aTimer = new Timer(1000);
            //Game starts here
            RoomSetup.SetupRooms(roomHolder);
            Console.Clear();
            DisplayInstructions();
            currentRoom = roomHolder[0];
            currentOutput += currentRoom.DisplayOpeningDescription();
            Console.WriteLine(currentOutput);
            //StartTimer();
            GetPlayerInput();
        }

        public bool IsGameRunning()
        {
            while (isGameRuning == true)
            {
                Init();
                while (isPlayerAlive == true)
                {
                    if (canType == true)
                    {
                        GetPlayerInput();
                    }
                }
                if (isGameRuning == true && currentRoom.GetRoomNumber() == 11)
                {
                    Console.WriteLine("If you would like to explore more type \"retry\" or \"quit\" to quit.");
                    isGameRuning = CheckRetry();
                }
                else if (isGameRuning == true)
                {
                    Console.WriteLine("You did not survive this round. Better luck next time.");
                    Console.WriteLine("To restart type \"retry\" or \"quit\" to quit the game");
                    isGameRuning = CheckRetry();
                }
            }
            return isGameRuning;
        }

        public void GetPlayerInput()
        {
            string phrase = Console.ReadLine().ToLower();
            if (canType == true)
            {
                string[] words = phrase.Split(' ');
                switch (words[0])
                {
                    case "go":
                        UpdateOutput(phrase);
                        ChangeRooms(words[1]);
                        break;
                    case "smell":
                        UpdateOutput(words[0], currentRoom.UseSmell());
                        Console.WriteLine(currentRoom.UseSmell());
                        break;
                    case "listen":
                        UpdateOutput(words[0], currentRoom.UseListen());
                        Console.WriteLine(currentRoom.UseListen());
                        break;
                    case "exit":
                        isPlayerAlive = false;
                        isGameRuning = false;
                        break;
                    case "quit":
                        isPlayerAlive = false;
                        isGameRuning = false;
                        break;
                    case "help":
                        Console.Clear();
                        DisplayHelp();
                        break;
                    case "retry":
                        aTimer.Elapsed -= OnTimedEvent;
                        aTimer.Enabled = false;
                        Console.Clear();
                        Init();
                        break;
                    default:
                        Console.WriteLine("I am sorry, but I do not understand that response. Please try again.");
                        break;
                }
            }
        }

        private void DisplayInstructions()
        {
            Console.WriteLine("Welcome to the great escape! You are not sure how, why, or where you are. All you know is that you must keep moving.\n" +
                              "If you stay in one place too long you fear the worst may happen. The goal is to make it to the exit. But how will\n" +
                              "you find the exit? Simple, you can use your sense of smell and hearing. All you need to do is type \"smell\" to see what\n" +
                              "scents are around you. For hearing type \"listen\" to hear any sounds that may be close. To navigate around you type \"go\" \n" +
                              "and then a direction. For example, to exit the current room to the north type \"go north\". As long as there is an exit in \n" +
                              "that direction you will go to that room. To exit or quit the game type \"quit\" or \"exit\". To restart the game type \"retry\".\n" +
                              "If at any time you forget what to do just type \"help\". This will bring up a list of commands that you are able to use. \n" +
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
            Console.Clear();
            Console.WriteLine(currentOutput);
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
                aTimer.Elapsed -= OnTimedEvent;
                aTimer.Enabled = false;
                currentRoom = roomHolder[nextRoom];
                UpdateOutput(currentRoom.DisplayOpeningDescription());
                Console.WriteLine(currentRoom.DisplayOpeningDescription());
            }
            else
                Console.WriteLine("There is no exit in that direction, just a wall.");

            CheckEndGame(currentRoom);
        }


        private void CheckEndGame(Room _room)
        {
            if (_room.GetRoomNumber() == 2)
            {
                Console.WriteLine();
                isPlayerAlive = false;
            }
            else if (_room.GetRoomNumber() == 11)
            {
                Console.WriteLine("You have won!");
                isPlayerAlive = false;
            }
            else
            {
                //StartTimer();
            }
        }

        private bool CheckRetry()
        {

            bool sucess = false;
            while (sucess == false)
            {
                string input = Console.ReadLine().ToLower();
                if (input == "retry")
                {
                    isGameRuning = true;
                    sucess = true;
                }
                else if (input == "exit" || input == "quit")
                {
                    isGameRuning = false;
                    sucess = true;
                }
                else
                {
                    Console.WriteLine("That is not a valid input. Please try again.");
                }
            }

            return isGameRuning;
        }

        public void StartTimer()
        {
            timerCount = 30;
            aTimer.Elapsed += OnTimedEvent;
            aTimer.Enabled = true;
        }

        static void OnTimedEvent(object source, ElapsedEventArgs e)
        {
            timerCount--;
            if (timerCount <= 0)
            {
                isPlayerAlive = false;
                canType = false;
                Console.WriteLine("You died! Press enter to continue.");
                aTimer.Elapsed -= OnTimedEvent;
                aTimer.Enabled = false;
            }
            else if (timerCount == 10)
                Console.WriteLine("\nYou hear a low growling behind you...It would seem that a beast is on your trail. Time is of the essence here, hurry and find the escape!");
        }

        private void UpdateOutput(string input)
        {
            currentOutput += "\n";
            currentOutput += input;
        }

        private void UpdateOutput(string input, string newAddition)
        {
            currentOutput += "\n";
            currentOutput += input;
            currentOutput += "\n";
            currentOutput += newAddition;
        }

    } //Class ends here
}
