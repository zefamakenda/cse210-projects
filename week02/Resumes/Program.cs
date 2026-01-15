using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Resumes Project.");

        Job job1 = new Job();
        job1._company = "Elite-TransCooling";
        job1._jobTitle = "Refrigeration Technician";
        job1._startYear = 2019;
        job1._endYear = 2022;

        Job job2 = new Job();
        job2._company = "Transfrig";
        job2._jobTitle = "Maintenance Technician";
        job2._startYear = 2022;
        job2._endYear = 2023;

        Resume myResume = new Resume("Zefa B Makenda");
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}
