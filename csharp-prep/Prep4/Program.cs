using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numList = new List<int>();
        int userNum = -1;
        
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        while (userNum != 0)
        {
            Console.Write("Enter number: ");
            string userInput = Console.ReadLine();
            userNum = int.Parse(userInput);

            // Add the number to the list
            numList.Add(userNum);  
        }

        // Remove the last number which definitely going to be a 0.
        numList.RemoveAt(numList.Count - 1);

        // Compute the sum of all the numbers in the list.
        Console.WriteLine("The Sum is: " + numList.Sum());

        // Compute the average number
        Console.WriteLine("The average is: " + numList.Average());

        // Compute the largest number
        Console.WriteLine("The largest number is: " + numList.Max());
    }
}