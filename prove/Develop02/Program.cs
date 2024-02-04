using System;

class Program
{
    static void Main(string[] args)
    {
        DateTime theCurrentTime = DateTime.Now;
        List<Entry> jornal = new List<Entry>();

        int input = 0;
        while(input != 5)
        {
            input = Display.UserMenu();
            
            switch (input)
            {
                case 1:
                    string dateText = theCurrentTime.ToShortDateString();
                    string prompt = Prompts.RandomPrompt();
                    Console.WriteLine(prompt);
                    string response = Console.ReadLine();
                    Entry newEntry = new Entry();
                    newEntry.date = dateText;
                    newEntry.prompt = prompt;
                    newEntry.response = response;

                    jornal.Add(newEntry);

                    break;
                case 2:
                    Display.DisplayJornal(jornal);
                    break;
                case 3:
                    Console.WriteLine("What is the file name?");
                    String fileSave = Console.ReadLine();

                    FileSystem.SaveJornal(fileSave, jornal);
                    
                    Console.WriteLine("saved");

                    break;
                case 4:
                    Console.WriteLine("What is the file name?");
                    String fileLoad = Console.ReadLine();
                    
                    jornal = FileSystem.LoadJornal(fileLoad);
                    
                    Console.WriteLine("loaded");
                    break;
                default:
                    break;

            }
        }
    }
}