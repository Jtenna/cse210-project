using System;

class Program
{
    // First Object for the Job class
    static void Main(string[] args)
    {
    Job job1 = new Job(); 

    job1._company = "Microsoft";
    job1._jobTitle = "Software Engineer";
    job1._startYear = 2017;
    job1._endYear = 2020;
   
    // job1.DisplayJobDetails();

    // Second Object/Instance for the Job class
    Job job2 = new Job(); 

    job2._company = "Apple";
    job2._jobTitle = "Manager";
    job2._startYear = 2021;
    job2._endYear = 2024;

    // job2.DisplayJobDetails(); 

    // First object/Instance for the Resume class
    Resume myResume = new Resume();
    myResume._name = "Justin Gabriel";
    myResume._jobs.Add(job1);
    myResume._jobs.Add(job2);

    // Call and Display Full Resume
    myResume.DisplayResume();
    }
  
}


