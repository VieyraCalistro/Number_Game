using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Number_Game_Class_Library
{
    public class Level4
    {
        public static void PrintGuesses(ValidGuess[] previousGuesses1)
        {
            Console.WriteLine();
            Console.Write("Previous Valid Guesses: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("# Color Low  ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("# Color High");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            Console.Write("Previous Valid Guesses: ");
            for (int i = 8; i > 1; i--)
            {

                if (previousGuesses1[i].Guess == 0)
                {
                    Console.Write("-");
                }
                else if (previousGuesses1[i].Guess != 0)
                {
                    if (previousGuesses1[i].Color == "Too Low")
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(previousGuesses1[i].Guess);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("," + " ");
                    }
                    else if (previousGuesses1[i].Color == "Too High")
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write(previousGuesses1[i].Guess);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("," + " ");
                    }
                    else if (previousGuesses1[i].Color == "You got it")
                    {
                        Console.Write(previousGuesses1[i].Guess + "," + " ");
                    }

                }

            }
            if (previousGuesses1[1].Guess == 0)
            {
                Console.Write("-");
            }
            else if (previousGuesses1[1].Guess != 0)
            {
                if (previousGuesses1[1].Color == "Too Low")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(previousGuesses1[1].Guess);
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else if (previousGuesses1[1].Color == "Too High")
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write(previousGuesses1[1].Guess);
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else if (previousGuesses1[1].Color == "You got it")
                {
                    Console.Write(previousGuesses1[1].Guess);
                }
            }
        }

        public static void Welcome(int counter1)
        {
            Console.WriteLine();
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Welcome to level 4");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine();
            Console.WriteLine("Lets see if you can guess the new number I just thought of, it's a WHOLE number between 90 and 200 inclusively, you have " + counter1 + " guesses!");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Climbing up the ladder!");
            Console.ForegroundColor = ConsoleColor.White;
            ContinueKey();
        }

        public static void ContinueKey()
        {
            Console.WriteLine();
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Press any key to continue");
            Console.BackgroundColor = ConsoleColor.Black;
        }

        public static void VeryCloseTooLow(float number1)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(number1 + ": You are Very close");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Too Low");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void VeryCloseTooHigh(float number1)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(number1 + ": You are Very close");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Too High");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void SuperCLoseTooLow(float number1)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(number1 + ": You are SUPER close");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Too Low");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void SuperCloseTooHigh(float number1)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(number1 + ": You are SUPER close");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Too High");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void CheckingForRepeatedLowGuesses(ref ValidGuess[] previousGuesses1, float number1, ref int counter1)
        {
            for (int index = 0; index < previousGuesses1.Length; index++)
            {
                if (number1 == previousGuesses1[index].Guess && number1 != 0)
                {
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Careful you have already guessed " + number1 + ".");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                }
                if (index == previousGuesses1.Length - 1)
                {
                    previousGuesses1[counter1].Guess = number1;
                    previousGuesses1[counter1].Color = "Too Low";
                    counter1--;
                    break;
                }
            }
        }

        public static void CheckingForRepeatedHighGuesses(ref ValidGuess[] previousGuesses1, float number1, ref int counter1)
        {
            for (int index = 0; index < previousGuesses1.Length; index++)
            {
                if (number1 == previousGuesses1[index].Guess && number1 != 0)
                {
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Careful you have already guessed " + number1 + ".");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                }
                if (index == previousGuesses1.Length - 1)
                {
                    previousGuesses1[counter1].Guess = number1;
                    previousGuesses1[counter1].Color = "Too High";
                    counter1--;
                    break;
                }
            }
        }

        public static void NumberGuessRange()
        {
            SmileEmoji.Emoji();

            //Make an array to display previous guesses

            ValidGuess[] previousGuesses = new ValidGuess[9];

            for (int index = 0; index < previousGuesses.Length; index++)
            {
                previousGuesses[index] = new ValidGuess();
            }

            //Initiate a guess count

            int counter = 8;

            //Give user intructions on game

            Welcome(counter);
            Console.ReadKey();
            Console.Clear();
            SmileEmoji.Emoji();
            Welcome(counter);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("                                                |-------------|");
            Console.WriteLine("                                                |---       ---|");
            Console.WriteLine("                                                |---Level 4---|");
            Console.WriteLine("                                                |---       ---|");
            Console.WriteLine("                                                |-------------|");
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("                                             Press any key to continue                                                  ");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ReadKey();
            Console.Clear();

            //Create a random number for the user to guess

            Random rr = new Random();
            int RR = (rr.Next(90, 201));

            //Make scenario options according to user input and loop until out of guesses

            while (counter > 0)
            {
                Console.WriteLine();
                Console.BackgroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine("You have " + counter + " guesses");
                Console.BackgroundColor = ConsoleColor.Black;
                PrintGuesses(previousGuesses);
                Console.WriteLine();
                Console.Write("Pick a ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("WHOLE ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("number between 90-200 inclusively, or type 1000 to exit: ");
                string guess = Console.ReadLine();
                Console.Clear();

                bool x = float.TryParse((guess), out float number);

                if (!x)
                {
                    Console.WriteLine();
                    Console.WriteLine("You can only enter a number between 90-200 inclusively, answer is a WHOLE number");

                    continue;
                }
                else if (number == 1000)
                {

                    Console.Clear();
                    ExitOption.Exit();

                }
                else if (number == RR)
                {
                    SmileEmoji.Emoji();
                    Console.WriteLine();
                    previousGuesses[counter].Guess = number;
                    previousGuesses[counter].Color = "You got it";
                    counter--;
                    PrintGuesses(previousGuesses);
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("You got the secret number!");
                    ContinueKey();
                    Console.ReadKey();
                    Console.Clear();
                    SmileEmoji.Emoji();
                    PrintGuesses(previousGuesses);
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.BackgroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine("The secret number is " + RR);
                    Console.BackgroundColor = ConsoleColor.Black;
                    ContinueKey();
                    Console.ReadKey();
                    Console.Clear();
                    SmileEmoji.Emoji();
                    Console.WriteLine();
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine("...Moving up to the next level!!...");
                    Console.BackgroundColor = ConsoleColor.Black;
                    ContinueKey();
                    Console.ReadKey();
                    Console.Clear();
                    return;
                }
                else if (number == RR - 6 && number < 201 && number > 89)
                {
                    CheckingForRepeatedLowGuesses(ref previousGuesses, number, ref counter);
                    Console.WriteLine();
                    VeryCloseTooLow(number);

                }
                else if (number == RR - 5 && number < 201 && number > 89)
                {
                    CheckingForRepeatedLowGuesses(ref previousGuesses, number, ref counter);
                    Console.WriteLine();
                    VeryCloseTooLow(number);

                }
                else if (number == RR - 4 && number < 201 && number > 89)
                {
                    CheckingForRepeatedLowGuesses(ref previousGuesses, number, ref counter);
                    Console.WriteLine();
                    VeryCloseTooLow(number);

                }
                else if (number == RR - 3 && number < 201 && number > 89)
                {
                    CheckingForRepeatedLowGuesses(ref previousGuesses, number, ref counter);
                    Console.WriteLine();
                    SuperCLoseTooLow(number);

                }
                else if (number == RR - 2 && number < 201 && number > 89)
                {
                    CheckingForRepeatedLowGuesses(ref previousGuesses, number, ref counter);
                    Console.WriteLine();
                    SuperCLoseTooLow(number);

                }
                else if (number == RR - 1 && number < 201 && number > 89)
                {
                    CheckingForRepeatedLowGuesses(ref previousGuesses, number, ref counter);
                    Console.WriteLine();
                    SuperCLoseTooLow(number);

                }
                else if (number == RR + 6 && number < 201 && number > 89)
                {
                    CheckingForRepeatedHighGuesses(ref previousGuesses, number, ref counter);
                    Console.WriteLine();
                    VeryCloseTooHigh(number);

                }
                else if (number == RR + 5 && number < 201 && number > 89)
                {
                    CheckingForRepeatedHighGuesses(ref previousGuesses, number, ref counter);
                    Console.WriteLine();
                    VeryCloseTooHigh(number);

                }
                else if (number == RR + 4 && number < 201 && number > 89)
                {
                    CheckingForRepeatedHighGuesses(ref previousGuesses, number, ref counter);
                    Console.WriteLine();
                    VeryCloseTooHigh(number);

                }
                else if (number == RR + 3 && number < 201 && number > 89)
                {
                    CheckingForRepeatedHighGuesses(ref previousGuesses, number, ref counter);
                    Console.WriteLine();
                    SuperCloseTooHigh(number);

                }
                else if (number == RR + 2 && number < 201 && number > 89)
                {
                    CheckingForRepeatedHighGuesses(ref previousGuesses, number, ref counter);
                    Console.WriteLine();
                    SuperCloseTooHigh(number);

                }
                else if (number == RR + 1 && number < 201 && number > 89)
                {
                    CheckingForRepeatedHighGuesses(ref previousGuesses, number, ref counter);
                    Console.WriteLine();
                    SuperCloseTooHigh(number);

                }
                else if (number > 200)
                {
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine(number + " :Too high, remember the answer is a Whole number between 90-200 inclusively only");
                    Console.ForegroundColor = ConsoleColor.White;

                    continue;
                }
                else if (number < 90)
                {
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(number + " :Too Low, remember the answer is a Whole number between 90-200 inclusively only");
                    Console.ForegroundColor = ConsoleColor.White;

                    continue;
                }
                else if (number % 1 != 0)
                {
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(number + ": Remember the answer is going to be a Whole number");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else if (number < RR)
                {
                    CheckingForRepeatedLowGuesses(ref previousGuesses, number, ref counter);
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(number + " :Too Low!");
                    Console.ForegroundColor = ConsoleColor.White;

                    continue;
                }
                else if (number > RR)
                {
                    CheckingForRepeatedHighGuesses(ref previousGuesses, number, ref counter);
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine(number + " :Too High!");
                    Console.ForegroundColor = ConsoleColor.White;

                    continue;
                }

            }

            //Create an outro if the user runs out of guesses

            PrintGuesses(previousGuesses);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Sorry you have ran all out of guesses");
            ContinueKey();
            Console.ReadKey();
            Console.Clear();
            PrintGuesses(previousGuesses);
            Console.WriteLine();
            Console.WriteLine();
            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("The secret number was " + RR);
            Console.BackgroundColor = ConsoleColor.Black;
            ContinueKey();
            Console.ReadKey();
            Console.Clear();
            SmileEmoji.Emoji();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Thanks for playing the Number Game, give it another try!");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Press any key to exit...");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ReadKey();

            Environment.Exit(0);
        }
    }
}
