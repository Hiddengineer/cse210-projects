static public class Display
{

    static public int UserMenu()
    {
        Console.WriteLine("Type the number of what you would like to do.");
        Console.WriteLine("1. Write new entry");
        Console.WriteLine("2. Display Jornal");
        Console.WriteLine("3. Save Jornal");
        Console.WriteLine("4. Load Jornal");
        Console.WriteLine("5. Quit");

       return int.Parse(Console.ReadLine());
    }

    static public void DisplayJornal(List<Entry> Jornal)
    {
        foreach (Entry entry in Jornal)
        {
            Console.WriteLine(entry.date);
            Console.WriteLine(entry.prompt);
            Console.WriteLine(entry.response);
            Console.WriteLine("");
        }
    }
}