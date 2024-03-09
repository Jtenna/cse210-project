using System;

// Create a new class called Resume
public class Resume
{
    public string _name;
    public List<Job> _jobs = new List<Job>();

    // Add a method to display the full resume.
     public void DisplayResume()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine($"Jobs:");

        foreach (Job j in _jobs)
            {
                // My method (It works but not too clean)
                // Console.WriteLine($"{j._jobTitle} ({j._company}) {j._startYear}-{j._endYear}");
             
               //  from sample solution
               // This calls the Display method on each job
                j.DisplayJobDetails();
            }
    
    }
}