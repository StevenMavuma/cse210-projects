using System;

class Program
{
    static void Main(string[] args)
    {
        string play;

        do
        {
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 101);
            int guess = -1;
            int attempt = 0;

            while (guess != magicNumber)
            {
                attempt++;
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());

                if (guess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine($"It took you {attempt} attempts and you guessed it!");
                }
            }
            Console.Write("Do you want to play again? (yes/no) ");
            play = Console.ReadLine().ToLower();
        }while(play=="yes");
    }
}