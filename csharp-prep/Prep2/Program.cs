using System;
using System.IO.Pipes;

class Program
{
    static void Main(string[] args)
    {
        String letterGrade;
        letterGrade = " ";
        float percentGrade;
        Console.WriteLine("What is your grade as a whole number percent?");
        percentGrade = Single.Parse(Console.ReadLine());
        if (percentGrade >= 90 )
        {
            letterGrade = "A" ;
        } else if (percentGrade >= 80 & percentGrade < 90)
        {
            letterGrade = "B" ;
        } else if (percentGrade >= 70 & percentGrade < 80)
        {
            letterGrade = "C" ;
        } else if (percentGrade >= 60 & percentGrade < 70)
        {
            letterGrade = "D" ;
        } else if (percentGrade < 60)
        {
            letterGrade = "F" ;
        }
        String prefix;
        prefix = "a";
        if (letterGrade == "A")
        {
            prefix = "an";
        }
        float onesPlace = percentGrade % 10;
        if (onesPlace >= 7 & letterGrade != "A" & letterGrade != "F")
        {
            letterGrade = $"{letterGrade}+" ;
        } else if (onesPlace < 3 & letterGrade != "F")
        {
            letterGrade = $"{letterGrade}-" ;
        }
        Console.WriteLine($"Your grade is {prefix} {letterGrade}");
        if (percentGrade >= 70)
        {
            Console.WriteLine("Congradulations you passed the class continue to work hard.");
        } else {
            Console.WriteLine("Unfortunatly you did not pass the class but keep trying and you will be able to pass next time.");
        }


    }
}