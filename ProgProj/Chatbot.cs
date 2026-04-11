using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Chatbot
{
    public void start() 
    {
        Console.WriteLine(@"______ _   _ _____  _   __  _____ _   _  _____  ______  _____ _____ 
| ___ \ | | /  __ \| | / / |_   _| | | ||  ___| | ___ \|  _  |_   _|
| |_/ / | | | /  \/| |/ /    | | | |_| || |__   | |_/ /| | | | | |  
| ___ \ | | | |    |    \    | | |  _  ||  __|  | ___ \| | | | | |  
| |_/ / |_| | \__/\| |\  \   | | | | | || |___  | |_/ /\ \_/ / | |  
\____/ \___/ \____/\_| \_/   \_/ \_| |_/\____/  \____/  \___/  \_/  
                                                                    
                                                                    ");

        Console.Title = "The Bot";

        Greeting();

        while (true)
        {
            Console.Write("\nYou: ");
            string userInput = Console.ReadLine();

            
            if (string.IsNullOrWhiteSpace(userInput))
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine(" enter something");
                Console.ResetColor();
                continue;
            }

            userInput = userInput.ToLower();

            
            if (userInput == "EXIT")
            {
                Console.WriteLine("see ya partner");
                break;
            }

         
            Respond(userInput);
        }
    }

    static void Greeting()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Howdy partner. Welcome to me, the chatbot ");
        Console.ResetColor();
    }

    static void Respond(string input)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;

        switch (input)
        {
            case "hello":
                Console.WriteLine("hey there friend.");
                break;

            case "how are you":
                Console.WriteLine("code runninin smoothly,partner.");
                break;

            case "what is your name":
                Console.WriteLine("Buck the bot. But you can call me BUCK.(tips hat)");
                break;

            default:
                Console.WriteLine("sorry friend, I don't real know what to say to that.");
                break;
        }


    }
}
