using System;

class Program
{
    static void Main(string[] args)
    {
        Storage store = new Storage();
        Filament currentFilament;
        store.CheckInitialized();
        store.Load();
        bool incorrectInput = true;

        while(incorrectInput){
            Console.WriteLine("What is the name of the Filament you are testing?");
            Console.WriteLine("1. PLA");
            Console.WriteLine("2. PETG");
            Console.WriteLine("3. TPU");
            switch (Console.ReadLine()){
                case "PLA":
                    currentFilament = store.ChooseFilament(1);
                    incorrectInput = false;
                break;

                case "PETG":
                    currentFilament = store.ChooseFilament(2);
                    incorrectInput = false;
                break;

                case "TPU":
                    currentFilament = store.ChooseFilament(3);
                    incorrectInput = false;
                break;

                default: 
                    Console.Clear();
                    Console.WriteLine("Not a filament");
                break;
            }
        }
        incorrectInput = true;
        Console.Clear();

        store.Save();

    }
}