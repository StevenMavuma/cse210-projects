using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "NBI";
        job1._jobTitle = "Technician";
        job1._startYear = 2013;
        job1._endYear = 2016;

        // job1.Display();


        Job job2 = new Job();
        job2._company = "Amazon";
        job2._jobTitle = "Customer Support Assistant";
        job2._startYear = 2019;
        job2._endYear = 2020;

        // job2.Display();

        Resume myResume = new Resume();
        myResume._name = "Steven Mavuma";
        myResume._jobs = [job1, job2];
        myResume.Display();
    }
}