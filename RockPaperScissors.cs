using System.Globalization;

namespace RockPaperScissor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool onGame = true;

            while (onGame == true)
            {
                Console.WriteLine("You´re playing rock, paper, scissors... Please enter");
                Console.WriteLine("R: For Rock");
                Console.WriteLine("P: For Paper");
                Console.WriteLine("S: For Scissor");
                string input = Console.ReadLine();
                input = input.ToUpper();

                if ((input == "R" || input == "P" || input == "S") && input.Length < 2)
                {
                    Console.Clear();
                    Console.WriteLine("You´re now playing");
                    Random random = new Random();
                    string consoleInput = "NOTDEFINE";
                    int randomNum = random.Next(1, 3000);
                    if (randomNum % 3 == 0)
                    {
                        consoleInput = "R";
                    }
                    else if (randomNum % 3 == 1)
                    {
                        consoleInput = "P";
                    }
                    else
                    {
                        consoleInput = "S";
                    }

                    Console.WriteLine(consoleInput);
                    Result(input, consoleInput);

                    Console.WriteLine("Do you wanna keep playing?");
                    Console.WriteLine("true : Yes");
                    Console.WriteLine("false : No");
                    bool waitAnswer = true;
                    while (waitAnswer)
                    {

                        try
                        {
                            
                            onGame = bool.Parse(Console.ReadLine());
                            waitAnswer = false;
                        }
                        catch
                        {
                            Console.WriteLine("Enter a stated value ");
                        }
                    }

                    }
                else
                {
                    Console.WriteLine("Enter a stated value");
                }

            }
        }



        public static void Result(string input, string consoleInput)
        {
            if ((input == "R" && consoleInput == "S") || (input == "P" && consoleInput == "R") || (input == "S" && consoleInput == "P"))
            {
                Console.WriteLine("The player Wins");
            }
            else if ((input == "S" && consoleInput == "R") || (input == "S" && consoleInput == "R") || (input == "P" && consoleInput == "S"))
            {
                Console.WriteLine("The Computer Wins");
            }
            else
            {
                Console.WriteLine("Is a tie");
            }
        }
    }
}