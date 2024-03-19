using System;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        int guessNum = random.Next(1, 101);
        int userGuess = 0;
        int allGuesses = 0;

        while (guessNum != userGuess)
        {
            Console.Write("What is the magic number? ");
            string userInput = Console.ReadLine();
            userGuess = int.Parse(userInput);
            allGuesses++;

            if (userGuess < guessNum)
            {
                Console.WriteLine("Guess higher!");
            }
            else if (userGuess > guessNum)
            {
                Console.WriteLine("Guess lower!");
            }
            else
            {
                Console.WriteLine("You guessed right!");
            }

        }
        
        // Stretch challenge. Keep track of user guesses.
        Console.WriteLine($"You made {allGuesses} guesses.");

     }
}