using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "math tutor";
        job1._company = "columbiaBasinColege";
        job1._startYear = 2023;
        job1._endYear = 2024;

        Job job2 = new Job();
        job2._jobTitle = "math tutor";
        job2._company = "BYUI";
        job2._startYear = 2023;
        job2._endYear = 2025;

        Resume resume1 = new Resume();
        resume1._name = "James";
        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);
        resume1.Display();

    }
}