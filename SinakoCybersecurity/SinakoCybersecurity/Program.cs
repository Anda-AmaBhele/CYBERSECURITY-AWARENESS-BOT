namespace CyberSecurityChatbot
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "CyberSecurity ChatbotApp"; //Set console Title  
            Console.ForegroundColor = ConsoleColor.Cyan; //Set Console Color theme  
            Console.Clear();

            // Play custom audio at the beginning  
            AudioPlayer audioPlayer = new AudioPlayer(@"C:\Users\kdynt\source\repos\CyberSecurityAI\CyberSecurittChatBot\Chatbot_voice.mp3");
            audioPlayer.Play();

            DisplayAsciiArt(); //Display ASCII Art Logo  
            GreetUser(); // Greet the user and start interaction  
        }

        static void DisplayAsciiArt()
        {
            Console.WriteLine(@"  
                    ______  
        /        \  
       |  CHATBOT  |  
       |  ______   |  
       | /      \  |  
       | |      |  |  
       | |      |  |  
       | \______/  |  
       \__________/  
           ||  
         [====]  
           ||  
       ___||___  
      /        \  
     |  ______  |  
     | | CHAT | |  
     | | BOT  | |  
     | |______| |  
     |__________|");
            Console.WriteLine("Welcome to the CyberSecurity Chatbot!");
            Console.WriteLine("--------------------------------------");
        }

        static void GreetUser()
        {
            Console.WriteLine("Please enter your name");
            string? userName = Console.ReadLine()?.Trim();

            while (string.IsNullOrEmpty(userName))
            {
                Console.Write("Invalid input. Please enter your name:");
                userName = Console.ReadLine()?.Trim();
            }
            Console.WriteLine($"\nHello, {userName}! I'm your CyberSecurity Chatbot.");
            Console.WriteLine("You can ask me about online safety, malware, password security and more.");
            Console.WriteLine("Type 'help' to see what you can ask or 'exit' to quit.");

            ChatLoop();
        }

        static void ChatLoop()
        {
            while (true)
            {
                Console.Write("\nAsk a cybersecurity question:");
                string? userInput = Console.ReadLine()?.Trim().ToLower();
                if (string.IsNullOrEmpty(userInput))
                {
                    Console.WriteLine("I didn't understand that. Could you rephrase?");
                    continue;
                }
                if (userInput == "exit")
                {
                    Console.WriteLine("Goodbye! Stay safe online");
                    break;
                }
                //Response system  
                if (userInput.Contains("how are you?"))
                {
                    Console.WriteLine("I'm just a bot, but I'm always ready to help!");
                }
                else if (userInput.Contains("purpose"))
                {
                    Console.WriteLine("I am here to educate you on cybersecurity best practices.");
                }
                else if (userInput.Contains("help") || userInput.Contains("what can i ask you about?"))
                {
                    Console.WriteLine("You can ask me about malware, password safety, and safe browsing.");
                }
                else if (userInput.Contains("malware"))
                {
                    Console.WriteLine("Malware is a cyber threat where attackers trick you into revealing personal information");
                }
                else if (userInput.Contains("password"))
                {
                    Console.WriteLine("A strong password should be at least 12 characters long, with a mix of uppercase and lowercase.");
                }
                else if (userInput.Contains("safe browsing"))
                {
                    Console.WriteLine("Hover over the link to see the actual URL. If it is suspicious, don't click.");
                }
                else
                {
                    Console.WriteLine("I didn't quite understand that. Could you rephrase?");
                }
            }
        }
    }
}
