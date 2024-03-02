using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int numberMagic = randomGenerator.Next(1, 100);
        ///Console.Write("What is the magic number? ");
        ///int numberMagic = int.Parse(Console.ReadLine());

        int numberGuess;

        do
        {
            Console.Write("What is your guess? ");
            numberGuess = int.Parse(Console.ReadLine());

            if (numberGuess > numberMagic) 
            {
                Console.WriteLine("Lower");
            }
            else if (numberGuess == numberMagic)
            {
                Console.WriteLine("You guessed it!");
            }
            else
            {
                Console.WriteLine("Higher");            
            }
        } while (numberGuess != numberMagic);
    }
}