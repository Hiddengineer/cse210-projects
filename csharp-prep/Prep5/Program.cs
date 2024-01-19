using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcomeMessage();
        string userName = PromptUserName();
        float userNumber = PromptUserNumber();
        float squaredNumber = SquareNumber(userNumber);
        DisplayResult(userName, squaredNumber);
    }

    static void DisplayWelcomeMessage()
    {
        
        Console.WriteLine("Welcome to the program!");
    }

    static void DisplayResult(string name, float square)
    {
        Console.WriteLine($"{name}, the square of your number is {square}");
    }
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }

    static float PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        float number = float.Parse(Console.ReadLine());
        return number;
    }

    static float SquareNumber(float number)
    {
        
        float square = number * number;
        return square;
    }
}