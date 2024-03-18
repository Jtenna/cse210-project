using System;

class Program
{
    static void Main(string[] args)
    {
       Journal theJournal = new Journal();
       Entry anEntry = new Entry();
       PromptGenerator promptGenerator = new PromptGenerator();
    }
}  


// Create a menu with five options
// 1. Write new entry
// 2. Display journal
// 3. Load journal from file
// 4. Save journal to file
// 5. Exit

// A menu class
public class Menu
{
    public void DisplayMenu()
    {
        Console.WriteLine("Welcome to the Journal Program!");
        Console.WriteLine("What do you want to do? Please select one.");
        Console.WriteLine("1. Write new entry");
        Console.WriteLine("2. Display journal");
        Console.WriteLine("3. Load journal from file");
        Console.WriteLine("4. Save journal to file");
        Console.WriteLine("5. Exit");
    }  
}
