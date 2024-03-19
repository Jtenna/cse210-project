using System;

class Program
{
    static void Main(string[] args)
    {
    // Calling the functions
        DisplayWelcome();
        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        int squaredNumber = SquareNumber(userNumber);
        DisplayResult(userName, squaredNumber);  
    }
    // DisplayWelcome function returns void
    static void DisplayWelcome()
       {
        Console.WriteLine("Welcome to the Program!");
       }

    // PromptUserName function returns string
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        return Console.ReadLine();
    }
    
    //  PromptUserNumber function returns int
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        return Convert.ToInt32(Console.ReadLine());
    }

    // SquareNumber function returns int
    static int SquareNumber(int number)
    {
        return number * number;
    }
    
    // DisplayResult function returns void
    static void DisplayResult(string name, int squaredNumber)
    {
        Console.WriteLine($"{name}, the square of your number is {squaredNumber}");
    }
}