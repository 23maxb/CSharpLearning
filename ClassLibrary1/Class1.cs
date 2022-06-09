using System;


namespace ClassLibrary1
{
    public class main
    {
        /**
         * Runs the thing
         */
        public static void Main()
        {
            guessingGame();
        }

        public static void guessingGame()
        {
            var real = roll(100);
            for (;;)
            {
                var guess = -1;
                Console.WriteLine("Guess (between 1 - 100):");
                guess = Convert.ToInt32(Console.ReadLine());
                if (guess > real)
                    Console.WriteLine("Guess too high");
                else if (guess < real)
                    Console.WriteLine("Guess too low");
                else
                {
                    Console.WriteLine("You guessed it!");
                    return;
                }
            }
        }

        public static int roll(int i)
        {
            return (int)((new Random().NextDouble()) * i) + 1;
        }
    }

    public class sorting()
    {
        public 
        
    }
}