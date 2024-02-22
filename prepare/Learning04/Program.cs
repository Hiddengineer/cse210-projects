using System;

class Program
{
    static void Main(string[] args)
    {
        Assinment _multiAssin = new Assinment("Samuel Bennett", "Multiplication");
        Console.WriteLine($"{_multiAssin.GetSummary()}\n ");

        MathAssinment _fractAssin = new MathAssinment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        Console.WriteLine($"{_fractAssin.GetSummary()}");
        Console.WriteLine($"{_fractAssin.GetHomeworkList()}\n ");

        WrightingAssinment _euouropHistAssin = new WrightingAssinment("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine($"{_euouropHistAssin.GetSummary()}");
        Console.WriteLine($"{_euouropHistAssin.GetWrightingInformation()}\n ");
    }
}