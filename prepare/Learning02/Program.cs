using System;
//using Job;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "Barbietown News Channel";
        job1._jobTitle = "Reporter";
        job1._startYear = 2017;
        job1._endYear = 2024;
        
        Job job2 = new Job();
        job2._company = "BarbieTown Palace News";
        job2._jobTitle = "News from the Palace Man";
        job2._startYear = 2017;
        job2._endYear = 2020;

        Resume myResume = new Resume();
        myResume._name = "Bob Thompson";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);
        
        myResume.Display();
    }
}