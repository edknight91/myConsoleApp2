using System;

namespace myConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int index, timesBy;
            bool shouldRepeat = true;

            while (shouldRepeat)
            {
                Console.WriteLine("Enter the number of the multiplication table you'd like to view");
                timesBy = Convert.ToInt32(Console.ReadLine());

                for (index = 0; index <= 12; index++)
                {
                    Console.WriteLine($"{index} X {timesBy} = {index * timesBy} \n");
                }

                Console.WriteLine("Press Y for another times table or any other key to quit");

                var input = Console.ReadKey().Key;

                switch (input)
                {
                    case ConsoleKey.Y:
                        Console.WriteLine($"\n");
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
        }
    }
}