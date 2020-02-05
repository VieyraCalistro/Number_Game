using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Number_Game_Class_Library
{
    public class Greetings
    {
        public static string UserName()
        {
            //Use validation proof to make sure you get something for a name or nickname

            while (true)
            {
                Console.Clear();
                SmileEmoji.Emoji();
                Console.WriteLine();
                Console.WriteLine("Lets play The Number Game!");
                //Ask the user for thier name and catch it in a string

                Console.WriteLine("\nWhat is your name?");
                Console.WriteLine();
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("When done Typing your Name press Enter");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("If you wish to exit the Number Game simply type the word \"exit\"");
                Console.BackgroundColor = ConsoleColor.Black;
                string aname = Console.ReadLine();
                aname = aname.ToUpper();
                Console.Clear();

                if (aname == "EXIT")
                {
                    Console.Clear();
                    ExitOption.Exit();
                }
                else if (aname.Length < 1)
                {
                    SmileEmoji.Emoji();
                    Console.WriteLine();
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Hmm..no name received..?");
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.WriteLine();
                    Console.WriteLine("Press any key to continue.");
                    Console.ReadKey();
                    continue;

                }
                else if(aname == " " || aname == "  " || aname == "   " || aname == "    " || aname == "     " || aname == "      " || aname == "       " || aname == "        " || aname == "         " || aname == "          ")
                {
                    SmileEmoji.Emoji();
                    Console.WriteLine();
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Hmm..no name received..?");
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.WriteLine();
                    Console.WriteLine("Press any key to continue.");
                    Console.ReadKey();
                    continue;
                }
                else if (aname.Length > int.MaxValue)
                {
                    SmileEmoji.Emoji();
                    Console.WriteLine();
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Hmm..could not register name..?");
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.WriteLine();
                    Console.WriteLine("Press any key to continue.");
                    Console.ReadKey();
                    continue;
                }
                else if (aname.Length > 0)
                {
                    
                    //Welcome the user by the name they had input

                    Console.WriteLine("\nHello " + aname + "! \n" + "\nWelcome to The Number Game!");
                    Console.WriteLine();
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine("Press any key to continue...");
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ReadKey();
                    Console.Clear();
                    return aname;
                }

            }
        }
    }
}
