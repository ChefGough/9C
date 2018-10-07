using System;

namespace Bisectional
{
    class Program
    {
        static void Main(string[] args)
        {
            int guesses = 0;
            Random random = new Random();
            int num = random.Next(1, 100);
            Console.WriteLine("Pick between 1 and 100");

            int i = 0;

            while (guesses != num)
            {
                try
                {
                    guesses = Convert.ToInt32(Console.ReadLine());

                    if (guesses > num)
                    {
                        Console.WriteLine("Guess too high");
                    }
                    else
                    {
                        Console.WriteLine("Guess too low");
                    }
                }
                catch
                {
                    Console.WriteLine("Your entry must be a whole number.");
                }

                i++;
            }
            Console.WriteLine("That is correct! You needed " + i + " guesses to get the correct number");
            Console.ReadLine();
            
        }
        
        
    }
}
