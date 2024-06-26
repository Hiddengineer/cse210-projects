class Storage{
    private List<PrintTest> _printTests = new List<PrintTest>();
    private List<Filament> _filaments = new List<Filament>();

    public Storage(){}
    
    public void CheckInitialized(){
        if(File.Exists("PrinterSetup.txt")){
            Load();
        }else{
            File.Create("PrinterSetup.txt").Close();
            _filaments.Add(new Filament());
            _filaments.Add(new PLAFilament());
            _filaments.Add(new PETGFilament());
            _filaments.Add(new TPUFilament());
            Save();
        }
    }
    public void ListFilaments(){
        Console.WriteLine("Your Filaments are:");
        
        foreach(Filament fil in _filaments){
            fil.DisplayFilament();
        }
    }
    public void ListPrintTests(){
        Console.WriteLine("Your past prints:");
        
        foreach(PrintTest test in _printTests){
        test.DisplayPrint();
        }
    }
    public void AddPrintTest(PrintTest test){
        _printTests.Add(test);
    }
    public PrintTest ChoosePrintTest(int test){
        return _printTests[test];
    }
    public Filament ChooseFilament(int filament){
        return _filaments[filament];
    }
    public void Save(){
        TextWriter empty = new StreamWriter("PrinterSetup.txt", false);
        empty.Write(string.Empty);
        empty.Close();

        StreamWriter save = new StreamWriter("PrinterSetup.txt");
        save.WriteLine($"filaments: {_filaments.Count}");
        for(int i = 0; i <  _filaments.Count; i ++){
            save.WriteLine(_filaments[i].SerializeFilament());
        }
        
        save.WriteLine($"printTests: {_printTests.Count}");
        for(int i = 0; i <  _printTests.Count; i ++){
            save.WriteLine(_printTests[i].SerializePrint());
        }
        
        save.Close();
    }
    public void Load(){
        StreamReader load = new StreamReader("PrinterSetup.txt");
        string firstLine = load.ReadLine();
        
        if(firstLine == null){}else{
            string[] begining = firstLine.Split(": ");
            
            for(int i = 0; i < Int32.Parse(begining[1]); i++){
                string currentGoalLine = load.ReadLine();
                string[] currentLine = currentGoalLine.Split(": ");
                
                switch(currentLine[0]){
                    case "0": 
                        Settings filset = new Settings(Int32.Parse(currentLine[1]), Int32.Parse(currentLine[2]), Int32.Parse(currentLine[3]), Int32.Parse(currentLine[4]), Int32.Parse(currentLine[5]));
                        Filament filament = new Filament(filset);
                        _filaments.Add(filament); 
                    break;

                    case "1": 
                        Settings PLAset = new Settings(Int32.Parse(currentLine[1]), Int32.Parse(currentLine[2]), Int32.Parse(currentLine[3]), Int32.Parse(currentLine[4]), Int32.Parse(currentLine[5]));
                        Filament PLAFilament = new PLAFilament(PLAset);
                        _filaments.Add(PLAFilament);
                    break;

                    case "2": 
                        Settings PETGset = new Settings(Int32.Parse(currentLine[1]), Int32.Parse(currentLine[2]), Int32.Parse(currentLine[3]), Int32.Parse(currentLine[4]), Int32.Parse(currentLine[5]));
                        Filament PETGFilament = new PETGFilament(PETGset);
                        _filaments.Add(PETGFilament);
                    break;

                    case "3": 
                        Settings TPUset = new Settings(Int32.Parse(currentLine[1]), Int32.Parse(currentLine[2]), Int32.Parse(currentLine[3]), Int32.Parse(currentLine[4]), Int32.Parse(currentLine[5]));
                        Filament TPUFilament = new TPUFilament(TPUset);
                        _filaments.Add(TPUFilament);
                    break;
                }
            }
        }
        string secondLine = load.ReadLine();
        string[] completedGoalsBegining = secondLine.Split(": ");
        
        for(int i = 0; i < Int32.Parse(completedGoalsBegining[1]); i++){
            string completedGoalLine = load.ReadLine();
            string[] currentLine = completedGoalLine.Split(": ");
            
            switch(currentLine[0]){
                case "0": 
                    Settings filset1 = new Settings(Int32.Parse(currentLine[3]), Int32.Parse(currentLine[4]), 
                        Int32.Parse(currentLine[5]), Int32.Parse(currentLine[6]), Int32.Parse(currentLine[7]));
                    Filament filament1;
                    PrintTest print;
                    
                    switch(currentLine[2]){
                        case "0":
                            filament1 = new Filament(filset1);
                            print = new PrintTest(currentLine[1], filament1);  
                            _printTests.Add(print);
                        break;

                        case "1":
                            filament1 = new Filament(filset1);
                            print = new PrintTest(currentLine[1], filament1);  
                            _printTests.Add(print);
                        break;
                            
                        case "2":
                            filament1 = new Filament(filset1);
                            print = new PrintTest(currentLine[1], filament1);  
                            _printTests.Add(print);
                        break;

                        case "3":
                            filament1 = new Filament(filset1);
                            print = new PrintTest(currentLine[1], filament1);  
                            _printTests.Add(print);
                        break;
                    } 
                break;

                case "1": 
                    Settings filset2 = new Settings(Int32.Parse(currentLine[8]), Int32.Parse(currentLine[9]), 
                        Int32.Parse(currentLine[10]), Int32.Parse(currentLine[11]), Int32.Parse(currentLine[12]));
                    Filament filament2;
                    PrintTest benchy; 
                    
                    switch(currentLine[7]){
                        case "0":
                            filament2 = new Filament(filset2);  
                            benchy = new BenchyTest(currentLine[6], filament2, Int32.Parse(currentLine[1]),
                                Int32.Parse(currentLine[2]), Int32.Parse(currentLine[3]), Int32.Parse(currentLine[4]), 
                                Int32.Parse(currentLine[5]));  
                    
                            _printTests.Add(benchy); 
                        break;

                        case "1":
                            filament2 = new PLAFilament(filset2); 
                            benchy = new BenchyTest(currentLine[6], filament2, Int32.Parse(currentLine[1]),
                                Int32.Parse(currentLine[2]), Int32.Parse(currentLine[3]), Int32.Parse(currentLine[4]), 
                                Int32.Parse(currentLine[5]));  
                    
                            _printTests.Add(benchy); 
                        break;
                            
                        case "2":
                            filament2 = new PETGFilament(filset2); 
                            benchy = new BenchyTest(currentLine[6], filament2, Int32.Parse(currentLine[1]),
                                Int32.Parse(currentLine[2]), Int32.Parse(currentLine[3]), Int32.Parse(currentLine[4]), 
                                Int32.Parse(currentLine[5]));  
                    
                            _printTests.Add(benchy); 
                        break;

                        case "3":
                            filament2 = new TPUFilament(filset2); 
                            benchy = new BenchyTest(currentLine[6], filament2, Int32.Parse(currentLine[1]),
                                Int32.Parse(currentLine[2]), Int32.Parse(currentLine[3]), Int32.Parse(currentLine[4]), 
                                Int32.Parse(currentLine[5]));  
                    
                            _printTests.Add(benchy); 
                        break;
                    }  
                break;

                case "2": 
                    Settings filset3 = new Settings(Int32.Parse(currentLine[9]), Int32.Parse(currentLine[10]), 
                        Int32.Parse(currentLine[11]), Int32.Parse(currentLine[12]), Int32.Parse(currentLine[13]));
                    Filament filament3;
                    PrintTest calibrateCube;
                    
                    switch(currentLine[8]){
                        case "0":
                            filament3 = new Filament(filset3);  
                            calibrateCube = new CalibrationCubeTest(currentLine[7], filament3, Int32.Parse(currentLine[1]),
                                Int32.Parse(currentLine[2]), Int32.Parse(currentLine[3]), Int32.Parse(currentLine[4]), 
                                Int32.Parse(currentLine[5]), Int32.Parse(currentLine[6]));  
                    
                            _printTests.Add(calibrateCube); 
                        break;

                        case "1":
                            filament3 = new PLAFilament(filset3); 
                            calibrateCube = new CalibrationCubeTest(currentLine[7], filament3, Int32.Parse(currentLine[1]),
                                Int32.Parse(currentLine[2]), Int32.Parse(currentLine[3]), Int32.Parse(currentLine[4]), 
                                Int32.Parse(currentLine[5]), Int32.Parse(currentLine[6]));  
                    
                            _printTests.Add(calibrateCube); 
                        break;
                            
                        case "2":
                            filament3 = new PETGFilament(filset3); 
                            calibrateCube = new CalibrationCubeTest(currentLine[7], filament3, Int32.Parse(currentLine[1]),
                                Int32.Parse(currentLine[2]), Int32.Parse(currentLine[3]), Int32.Parse(currentLine[4]), 
                                Int32.Parse(currentLine[5]), Int32.Parse(currentLine[6]));  
                    
                            _printTests.Add(calibrateCube); 
                        break;

                        case "3":
                            filament3 = new TPUFilament(filset3); 
                            calibrateCube = new CalibrationCubeTest(currentLine[7], filament3, Int32.Parse(currentLine[1]),
                                Int32.Parse(currentLine[2]), Int32.Parse(currentLine[3]), Int32.Parse(currentLine[4]), 
                                Int32.Parse(currentLine[5]), Int32.Parse(currentLine[6]));  
                    
                            _printTests.Add(calibrateCube); 
                        break;
                    }
                break;

                case "3": 
                    Settings filset4 = new Settings(Int32.Parse(currentLine[6]), Int32.Parse(currentLine[7]), 
                        Int32.Parse(currentLine[8]), Int32.Parse(currentLine[9]), Int32.Parse(currentLine[10]));
                    Filament filament4;
                    PrintTest bedLeveling;
                    
                    switch(currentLine[5]){
                        case "0":
                            filament4 = new Filament(filset4);  
                            bedLeveling = new BedLevelingTest(currentLine[4], filament4, bool.Parse(currentLine[1]), 
                                Int32.Parse(currentLine[2]), Int32.Parse(currentLine[3]));  
                    
                            _printTests.Add(bedLeveling); 
                        break;

                        case "1":
                            filament4 = new PLAFilament(filset4); 
                            bedLeveling = new BedLevelingTest(currentLine[4], filament4, bool.Parse(currentLine[1]), 
                                Int32.Parse(currentLine[2]), Int32.Parse(currentLine[3]));  
                    
                            _printTests.Add(bedLeveling); 
                        break;
                            
                        case "2":
                            filament4 = new PETGFilament(filset4); 
                            bedLeveling = new BedLevelingTest(currentLine[4], filament4, bool.Parse(currentLine[1]), 
                                Int32.Parse(currentLine[2]), Int32.Parse(currentLine[3])); 
                    
                            _printTests.Add(bedLeveling); 
                        break;

                        case "3":
                            filament4 = new TPUFilament(filset4); 
                            bedLeveling = new BedLevelingTest(currentLine[4], filament4, bool.Parse(currentLine[1]), 
                                Int32.Parse(currentLine[2]), Int32.Parse(currentLine[3]));  
                    
                            _printTests.Add(bedLeveling); 
                        break;
                    }
                break;
            }
        }
        load.Close();
    }
}