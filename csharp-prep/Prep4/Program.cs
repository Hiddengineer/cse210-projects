using System;


class Program
{
    static void Main(string[] args)
    {
        //Compute the sum,
/*Compute the sum, or total, of the numbers in the list.

Compute the average of the numbers in the list.

Find the maximum, or largest, number in the list.

Have the user
Have the user enter both positive and negative numbers, 
then find the smallest positive number (the positive number that is closest to zero).

Sort the numbers in the list and display the new, sorted list. 
Hint: There are C# libraries that can help you here, try searching the internet for them.*/
        float inputNumber = 1;
        List<float> inputs = new List<float>() {};
         Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        while (inputNumber != 0 )
        {
            Console.Write("Enter number: ");
            inputNumber = Single.Parse(Console.ReadLine());
            if (inputNumber != 0)
            {
            inputs.Add(inputNumber);
            }
        }
        inputs = inputs.OrderBy(item => item).ToList();
        float least = 0;
        float most = 0;
        float total = 0;
        float average = 0;
        float numNumbers = 0;

        foreach( float g in inputs ) 
        { 
            total = total + g;   

            if (g > 0)
            {
                if (least == 0)
                {
                    least = g;
                }else if (least > g)
                {
                    least = g;
                }
            }
            if (numNumbers == 0)
            {
                most = g;
            }else if (most < g )
            {
                most = g;
            }
            numNumbers = numNumbers + 1;
        }
        average = total / numNumbers;
        if ( numNumbers == 0)
        {
            Console.WriteLine("No numbers were entered for list.");
        } else if (least == 0)
        {
            Console.WriteLine($"The sum is: {total}");
            Console.WriteLine($"The average is: {average}");
            Console.WriteLine($"The largest number is: {most}");
            Console.WriteLine("The sorted list is:");
            foreach( float g in inputs ) 
            {
                Console.WriteLine(g);
            } 
        } else {
            Console.WriteLine($"The sum is: {total}");
            Console.WriteLine($"The average is: {average}");
            Console.WriteLine($"The largest number is: {most}");
            Console.WriteLine($"The smallest positive number is: {least}");
            Console.WriteLine("The sorted list is:");
            foreach( float g in inputs ) 
            {
                Console.WriteLine(g);
            }
        }
        
    }
}