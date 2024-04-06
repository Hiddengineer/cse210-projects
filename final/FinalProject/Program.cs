using System;
using System.Net.Quic;

class Program
{
    static void Main(string[] args)
    {
        bool run = true;
        Storage store = new Storage();
        store.CheckInitialized();
        
        while(run){
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. display filaments");
            Console.WriteLine("2. start test");
            Console.WriteLine("3. display tests");
            Console.WriteLine("4. quit");
            
            switch(Console.ReadLine()){
                case "1": case "display filaments":
                    Console.Clear();
                    store.ListFilaments();
                break;

                case "2": case "start test":
                    Filament currentFilament = new Filament();
                    bool incorrectInput = true;
                    Console.Clear();
                    
                    while(incorrectInput){
                        Console.WriteLine("What is the name of the Filament you are testing?");
                        Console.WriteLine("1. PLA");
                        Console.WriteLine("2. PETG");
                        Console.WriteLine("3. TPU");
                        
                        switch (Console.ReadLine()){
                            case "PLA": case "1":
                                currentFilament = store.ChooseFilament(1);
                                incorrectInput = false;
                            break;

                            case "PETG": case "2":
                                currentFilament = store.ChooseFilament(2);
                                incorrectInput = false;
                            break;

                            case "TPU": case "3":
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
                    PrintTest currentPrint = new PrintTest(currentFilament);
                    
                    while(incorrectInput){
                        Console.WriteLine("What print are you going to do?");
                        Console.WriteLine("1. Benchy");
                        Console.WriteLine("2. Calibration Cube");
                        Console.WriteLine("3. Bed Leveling");
                        Console.WriteLine("4. I dont know");
                        
                        switch (Console.ReadLine()){
                            case "Benchy": case "1":
                                currentPrint = new BenchyTest(currentFilament);

                                incorrectInput = false;
                            break;

                            case "Calibration Cube": case "2":
                                currentPrint = new CalibrationCubeTest(currentFilament);
                                incorrectInput = false;
                            break;

                            case "Bed Leveling": case "3":
                                currentPrint = new BedLevelingTest(currentFilament);
                                incorrectInput = false;
                            break;

                            case "I dont know": case "4":
                                Console.Clear();
                                Console.WriteLine("Then start with a bed leveling test if you have already done that go to a Benchy then last the calibration cube.");
                            break;

                            default: 
                                Console.Clear();
                                Console.WriteLine("Not an option");
                            break;
                        }
                    }
                    Console.Clear();
                    
                    currentPrint.RecordPrint();
                    Console.Clear();
                    currentPrint.RecomendSettings();
                    currentPrint.RecomendPrinterModifications();
                    currentFilament.UpdateSettings(currentPrint.GetSettings());
                    store.AddPrintTest(currentPrint);

                    store.Save();
                break;

                case "3": case"display tests":
                    Console.Clear();
                    store.ListPrintTests();
                break;

                case "4": case "quit": 
                    Console.Clear();
                    run = false;
                break;
            }
        }
    }
}