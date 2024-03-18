using System;

class Program
{
    static void Main(string[] args)
   {
        string letter = "";
        string postive = "+";
        string negative = "-";

        
       // 1. Conditions to access the grade from user input.
        Console.Write("What is your grade percentage for this class? ");
         string userGrade = Console.ReadLine();
         int grade = int.Parse(userGrade);

        // Exceeding expectation. Logic to add a positive or negative sign after the grade letter
        // Grade A
        if (grade >= 90 && grade < 93)
        {
           letter = "A";
        }
        else if (grade >= 93 && grade < 97)
        {
            letter = "A" + negative;
        }
        else if (grade >= 97)
        {
            letter = "A" + postive;
        }

        // Grade B
        else if (grade >= 80 && grade < 83)
        {
            letter = "B";
        }
        else if (grade >= 83 && grade < 87)
        {
            letter = "B" + negative;
        }
        else if (grade >= 87)
        {
            letter = "B" + postive;
        }

        // Grade C
         else if (grade >= 70 && grade < 73)
        {
            letter = "C";
        }
        else if (grade >= 73 && grade < 77)
        {
            letter = "C" + negative;
        }
        else if (grade >= 77)
        {
            letter = "C" + postive;
        }
        
        // Grade D
         else if (grade >= 60 && grade < 63)
        {
            letter = "D";
        }
        else if (grade >= 63 && grade < 67)
        {
            letter = "D" + negative;
        }
        else if (grade >= 67)
        {
            letter = "D" + postive;
        }


        else
        {
            letter = "F";
        }

        // 3. Using a variable to show the grade Output
         Console.WriteLine($"Your grade is: {letter}");

        // 2. Condition to determine at least 70% pass or less
        if (grade >= 70)
        {
            Console.WriteLine("Good job! You passed!");
        }
        else
        {
            Console.WriteLine("Oops! You failed. Do better next time.");
        }
        
    }
    
}