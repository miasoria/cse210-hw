using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magic_num = randomGenerator.Next(1, 100);

        int guess_num = -1;

        Console.WriteLine("Guess the magic number between 1 and 100");

        while (guess_num != magic_num)
        {
            Console.WriteLine("What is your guess?");
            string guess = Console.ReadLine();
            guess_num = int.Parse(guess);

            if (guess_num > magic_num)
            {
                Console.WriteLine("Lower");
            }

            else if (guess_num < magic_num)
            {
                Console.WriteLine("Higher");
            }

            else
            {
                Console.WriteLine("You guessed it!");
            }
        }
    }
}