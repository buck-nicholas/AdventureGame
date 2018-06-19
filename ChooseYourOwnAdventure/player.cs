using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChooseYourOwnAdventure
{
    class Player
    {
        // Member Variables
        public string playerName;
        public string playerSize;
        public string playerGender;

        // Constructor
        public Player()
        {
            playerName = GetUserInput("What is your name young padiwon?");
            playerSize = GetPlayerSize();
            playerGender = GetPlayerGender();
            Console.Write("Hello " + playerName + ". You are of the " + playerSize + " size and are a " + playerGender + ". Hurry, your quests await you!");
            Console.ReadLine();
        }

        // methods
        public string GetUserInput(string message)
        {
            string userInput;
            Console.WriteLine(message);
            userInput = Console.ReadLine();
            return userInput;
        }
        public string GetPlayerSize()
        {
            string userInput = GetUserInput("My eye sight is a little dull, how tall are you? [1] I am quite tall [2] I am uninterestingly average [3] Hey! I am down here!");
            string size = "medium";
            switch(userInput)
            {
                case "1":
                    size = "tall";
                    break;
                case "2":
                    size = "medium";
                    break;
                case "3":
                    size = "small";
                    break;
                default:
                    Console.WriteLine("Please enter a valid option! Example: 1");
                    GetPlayerSize();
                    break;
            }
            return size;
        }
        public string GetPlayerGender()
        {
            string userInput = GetUserInput("Are you either [1] Male or [2] Female?");
            string gender = "male";
            if (userInput != "1" && userInput != "2")
            {
                Console.WriteLine("Please enter an appropriate selection.");
                GetPlayerGender();
            }
            if (userInput == "2")
            {
                gender = "male";
            }
            else
            {
                gender = "female";
            }
            return gender;
        }
    }
}
