using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction Fra1 = new Fraction();
        Fraction Fra2 = new Fraction();
        Fraction Fra3 = new Fraction();
        
        Fra1.fraction();
        Fra2.fraction(4);
        Fra3.fraction(5,7);

        Console.WriteLine(Fra1.getFractionString());
        Console.WriteLine(Fra2.getFractionString());
        Console.WriteLine(Fra3.getFractionString());
        Console.WriteLine(Fra1.getDecimalValue());
        Console.WriteLine(Fra2.getDecimalValue());
        Console.WriteLine(Fra3.getDecimalValue());

        Fra1.setNumerator(3);
        Fra1.setDenominator(2);

        Console.WriteLine(Fra1.getFractionString());
        Console.WriteLine(Fra1.getDecimalValue());
        
    }
}