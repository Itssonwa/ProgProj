using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Chatbot
{
    public void start() 
    {
        Console.WriteLine(@" _______   _______ ___________  _____ _____ _____  ______  _____ _____ 
/  __ \ \ / / ___ \  ___| ___ \/  ___|  ___/  __ \ | ___ \|  _  |_   _|
| /  \/\ V /| |_/ / |__ | |_/ /\ `--.| |__ | /  \/ | |_/ /| | | | | |  
| |     \ / | ___ \  __||    /  `--. \  __|| |     | ___ \| | | | | |  
| \__/\ | | | |_/ / |___| |\ \ /\__/ / |___| \__/\ | |_/ /\ \_/ / | |  
 \____/ \_/ \____/\____/\_| \_|\____/\____/ \____/ \____/  \___/  \_/  
                                                                       
                                                                       ");

        Console.Title = "The Bot";

       
        Greeting();

        while (true)
        {
            Console.Write("\nYou: ");
            string userInput = Console.ReadLine();

            // ✅ Input validation
            if (string.IsNullOrWhiteSpace(userInput))
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine(" enter something");
                Console.ResetColor();
                continue;
            }

            userInput = userInput.ToLower();

            // ✅ Exit condition
            if (userInput == "EXIT")
            {
                Console.WriteLine("see ya partner");
                break;
            }

            // ✅ Predefined responses
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
                Console.WriteLine("Buck the bot. But you can call me BUCK(tips hat)");
                break;

            default:
                Console.WriteLine("sorry friend, I don't real know what to say to that.");
                break;
        }


    }
}
