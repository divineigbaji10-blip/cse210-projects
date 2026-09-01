using System;

class Program
{
    static void Main(string[] args)
    {

        int magicNumber;
        int guess = -1;
        int numberOfGuess = 0;

        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1,101);
        magicNumber = number;
        
        //Console.Write("What is the magic number? ");
        //string magic = Console.ReadLine();
        //magicNumber = int.Parse(magic);
        
        while (guess != magicNumber)
        {   
            Console.Write("What is your guess? ");
            string guessNumber = Console.ReadLine();
            guess = int.Parse(guessNumber);
            numberOfGuess ++;

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
                Console.WriteLine("You guessed it!");
            }
        }
        Console.WriteLine($"You made {numberOfGuess} guesses.");
    }   
    
}