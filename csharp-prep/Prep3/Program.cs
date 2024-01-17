using System;

class Program
{
    static void Main(string[] args)
    {
        String playAgain = "yes";
        while (playAgain == "yes") 
        {
            Boolean guessedCorrect = false;
            float magicNumber;
            float guess;
            Random rnd = new Random();
            int numberOfGuesses = 0;
            magicNumber = rnd.Next(1, 101);
            while (guessedCorrect == false)
            {    
                Console.Write("What is your guess? ");
                guess = Single.Parse(Console.ReadLine());
                numberOfGuesses = numberOfGuesses + 1;
                if ( guess < magicNumber)
                {
                    Console.WriteLine("Higher");
                } else if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                } else if (guess == magicNumber)
                {
                    guessedCorrect = true;
                }
            }
        
        Console.WriteLine($"You guessed it in {numberOfGuesses}!");
        Console.WriteLine("Would you like to play again?");
        playAgain = Console.ReadLine();
        }
    }
}