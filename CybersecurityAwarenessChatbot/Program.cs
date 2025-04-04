using Figgle;
using System.Diagnostics.Metrics;
using System.Speech.Synthesis;



namespace CybersecurityAwarenessChatbot
{
    class Program
    {
        static void Main(string[] args)
        {
            SpeechSynthesizer synth = new SpeechSynthesizer();
            synth.Volume = 100;
            synth.Rate = 0;

         // Welcome message
            Console.Clear();
            DisplayHeader();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("chatbot: Hello! I can talk.");
            synth.Speak("Hello I can talk");
            UserInteraction(synth);
        }

        // Method to display the ASCII art header
        static void DisplayHeader()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(FiggleFonts.Standard.Render("Cybersecurity Awareness Bot"));
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Welcome to the Cybersecurity Awareness Bot!\n");
        }

        // Method for user interaction
        static void UserInteraction(SpeechSynthesizer synth)
        {
            Console.Write("Please enter your name: ");
            synth.Speak("Please enter your name");
            Console.ForegroundColor = ConsoleColor.White;
            string name = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"\nHello, {name}! I’m here to help you stay safe online.\n");
            synth.Speak($"\nHello, {name}! I’m here to help you stay safe online.\n");
            Console.ResetColor();

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write("How can I assist you today? ");
                synth.Speak("How can I assist you today?");

                Console.ForegroundColor = ConsoleColor.White; // User input color
                string userInput = Console.ReadLine();
                Console.ResetColor();

                // Basic Response System
                RespondToUser(userInput, synth);
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write("I didn’t quite understand that. Could you rephrase? ");
                synth.Speak("I didn’t quite understand that. Could you rephrase? ");
                Console.ForegroundColor = ConsoleColor.White;
                string continueChat = Console.ReadLine();
                if (continueChat.ToLower() != "yes")
                {
                    break; // Exit the loop if the user doesn't want to continue
                }
            }
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Thank you for using the Cybersecurity Awareness Bot! Stay safe!");
            synth.Speak("Thank you for using the Cybersecurity Awareness Bot! Stay safe!");
        }

        // Basic response system to user inputs
        static void RespondToUser(string userInput, SpeechSynthesizer synth)
        {
            if (string.IsNullOrWhiteSpace(userInput))
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("\nWould you like to ask something else? (yes/no");
                synth.Speak("\nWould you like to ask something else? (yes/no");
            }
            else if (userInput.Contains("how are you", StringComparison.OrdinalIgnoreCase))
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("I'm a chatbot, but I'm here to help you!");
                synth.Speak("I'm a chatbot, but I'm here to help you!");
                
            }
            else if (userInput.Contains("purpose", StringComparison.OrdinalIgnoreCase))
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("My purpose is to help you understand cybersecurity better.");
                synth.Speak("My purpose is to help you understand cybersecurity better.");
            }
            else if (userInput.Contains("password safety", StringComparison.OrdinalIgnoreCase))
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Always use strong passwords. Consider a password manager.");
                synth.Speak("Always use strong passwords. Consider a password manager.");
            }
            else if (userInput.Contains("phishing", StringComparison.OrdinalIgnoreCase))
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Avoid clicking on suspicious links. Always verify the source.");
                synth.Speak("Avoid clicking on suspicious links. Always verify the source.");
            }
            else if (userInput.Contains("safe browsimg",StringComparison.OrdinalIgnoreCase))
            { 
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("safe browsing is a security feature that protects users from harmful online content,such as malware,phishing scams,and deceptive websites.");
                synth.Speak("safe browsing is a security feature that protects users from harmful online content,such as malware,phishing scams,and deceptive websites.");

            }
            
        }
    }
}
