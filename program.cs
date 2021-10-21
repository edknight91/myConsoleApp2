using System;

namespace myConsoleApp2
{
    class Program
    {

        static void Main(string[] args)
        {
            // int index;
            bool shouldRepeat = true;

            while (shouldRepeat)
            {
                Console.WriteLine("Enter the number of the multiplication table you'd like to view");
                string firstInput = (Console.ReadLine());

                //Check the user has entered a number

                int timesBy;
                bool isNumber = int.TryParse(firstInput, out timesBy);

                //If user has entered a number we run this

                if (isNumber)
                {
                    WriteTimesTables(timesBy);

                    Console.WriteLine("Press Y for another times table, press A to print all or press any other key to quit");

                    var secondInput = Console.ReadKey().Key;

                    switch (secondInput)
                    {
                        case ConsoleKey.Y:
                            Console.WriteLine($"\n");
                            break;

                        case ConsoleKey.A:
                            Program.WriteAllTimesTables();
                            break;

                        default:
                            shouldRepeat = false;
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine("See ya skip");
                            Console.WriteLine();
                            Console.WriteLine();
                            break;
                    }
                }

                // Quits program if the user didn't enter a number in the first instance
                else
                {
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("That's not a number you donut, start this thing again!");
                    shouldRepeat = false;
                }
            }
        }



        // Method runs WriteTimesTables 12 times if user selects all
        static void WriteAllTimesTables()

        {
            for (int index = 1; index <= 12; index++)
            {
                Console.WriteLine();
                Console.WriteLine($"This is the {index} times table");
                Console.WriteLine();
                WriteTimesTables(index);
            }
        }

        // Method prints the selected multplication table to the console
        public static void WriteTimesTables(int timesBy)
        {
            for (int index = 1; index <= 12; index++)
            {
                Console.WriteLine($"{index} X {timesBy} = {index * timesBy} \n");
            }
        }
    }
}