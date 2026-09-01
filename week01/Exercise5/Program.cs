using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        
        string name = PromptUserName();

        int num = PromptUserNumber();

        int squared = SquareNumber(num);
        DisplayResult(name, squared);

    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {
        
        Console.Write("Please enter your name: ");
        string userName = Console.ReadLine();

        return userName;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        string number = Console.ReadLine();
        int userNumber = int.Parse(number);

        return userNumber;
    }

    static int SquareNumber(int squareNumber)
    {
        int squared = squareNumber * squareNumber;
        return squared;
    }

    static void DisplayResult(string userName, int squareNumber)
    {
        Console.WriteLine($"{userName}, the square of your number is {squareNumber}");
    }
}