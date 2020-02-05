using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Number_Game_Class_Library
{
    class ExitOption
    {
        public static void Exit()
        {
            while (true)
            {
                SmileEmoji.Emoji();
                Console.WriteLine();
                Console.Write("Are you sure you want to exit? Type: 1)No or 2)Yes: ");
                string response = Console.ReadLine();
                int answer;
                bool x = int.TryParse((response), out answer);

                Console.WriteLine();
                if (!x)
                {
                    Console.WriteLine("Only number 1 or 2 is accepted");
                    Console.WriteLine();
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine("Press Enter...");
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ReadLine();
                    Console.Clear();
                }
                else if (answer < 1 || answer > 2)
                {
                    Console.WriteLine("Choices involve only number 1 or number 2");
                    Console.WriteLine();
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine("Press Enter...");
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ReadLine();
                    Console.Clear();
                }
                else if (answer == 1)
                {
                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine("Okay returning back to The Number Game...");
                    Console.WriteLine();
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine("Press Enter");
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ReadLine();
                    Console.Clear();
                    return;
                }
                else if (answer == 2)
                {
                    Console.Clear();
                    Console.WriteLine();
                    SmileEmoji.Emoji();
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Thanks for PLaying the Number Game! GoodBye");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.ReadLine();

                    Environment.Exit(0);

                }
            }
        }
    }
}
