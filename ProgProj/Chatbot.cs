using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



public class Chatbot
{
    private User user;
    private AudioPlayer audio;

    public Chatbot()
    {
        user = new User();
        audio = new AudioPlayer();
    }
    public void Start()
    {
        ShowAsciiArt();
        audio.PlayGreeting();

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Buck: Howdy,welcome to the Cybersecurity Chatbot![tips hat]");
        Console.ResetColor();

        user.GetName();

        while (true)
        {
            Console.Write("You: ");
            string input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input))
            {
                ShowError("Ya gotta type something,friend.");
                continue;
            }

            input = input.ToLower();
            if (input == "EXIT")
            {
                Console.WriteLine("Buck: Stay safe online Partner. Adios!");
                break;
            }
            Respond(input);
        }
    }
    private void Respond(string input)
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        switch (input)
        {
            case "what is phishing":
                Console.WriteLine("Buck: Phishing's like a snake oil salesman lakin' to you, tryin' to swindle your secrets outta ya.");
                break;  
            case "what is malware":
                Console.WriteLine("Buck: Malware's like a rustler sneakin' into your digital ranch, intent on causin' trouble for your computer.");
                break;
            case "how to stay safe online":
                Console.WriteLine("Buck: Try use stronger passwords, keep a keen eye out for suspicious links, and keep your software updated,partner.");
                break;
            default:
                Console.WriteLine("Buck: I’m not sure about that friend. How about ya ask about cybersecurity.");
                break;
        }

        Console.ResetColor();
    }
    private void ShowAsciiArt()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(@"______ _   _ _____  _   __  _____ _   _  _____  ______  _____ _____ 
| ___ \ | | /  __ \| | / / |_   _| | | ||  ___| | ___ \|  _  |_   _|
| |_/ / | | | /  \/| |/ /    | | | |_| || |__   | |_/ /| | | | | |  
| ___ \ | | | |    |    \    | | |  _  ||  __|  | ___ \| | | | | |  
| |_/ / |_| | \__/\| |\  \   | | | | | || |___  | |_/ /\ \_/ / | |  
\____/ \___/ \____/\_| \_/   \_/ \_| |_/\____/  \____/  \___/  \_/  
                                                                    
                                                                    
    ");
        Console.ResetColor();
    }
    private void ShowError(string message)
    {
     Console.ForegroundColor = ConsoleColor.Red;
     Console.WriteLine("Buck: " + message);
     Console.ResetColor();
    }
}