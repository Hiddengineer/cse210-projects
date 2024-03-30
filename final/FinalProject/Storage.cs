class Storage{
private List<PrintTest> _printTests = new List<PrintTest>();
private List<Filament> _filaments = new List<Filament>();

public Storage(){

}
public void CheckInitialized(){
    if(File.Exists("PrinterSetup.txt")){
    }else{
        File.Create("PrinterSetup.txt").Close();
        _filaments.Add(new Filament());
        _filaments.Add(new PLAFilament());
        _filaments.Add(new PETGFilament());
        _filaments.Add(new TPUFilament());
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
       // test.DisplayPrintTest();
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
        string[] begining = firstLine.Split(":");
        for(int i = 0; i < Int32.Parse(begining[1]); i++){
            string currentGoalLine = load.ReadLine();
            string[] currentLine = currentGoalLine.Split(":");
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
    /*string secondLine = load.ReadLine();
    string[] completedGoalsBegining = secondLine.Split(":");
    for(int i = 0; i < Int32.Parse(completedGoalsBegining[1]); i++){
        string completedGoalLine = load.ReadLine();
        string[] currentLine = completedGoalLine.Split(":");
        switch(currentLine[0]){
            case "0": 
                Goal currentGoal = new Goal(currentLine[1], currentLine[2], Int32.Parse(currentLine[3]));
                _completedGoals.Add(currentGoal);
            break;

            case "1": 
                 Goal currentSimpleGoal = new SimpleGoal(currentLine[1], currentLine[2], Int32.Parse(currentLine[3]), Convert.ToBoolean(currentLine[4]));
                _completedGoals.Add(currentSimpleGoal);
            break;

            case "2": 
                Goal currentEternalGoal = new EternalGoal(currentLine[1], currentLine[2], Int32.Parse(currentLine[3]));
                _completedGoals.Add(currentEternalGoal);
            break;

            case "3": 
                Goal currentCheckListGoal = new CheckListGoal(currentLine[1], currentLine[2], Int32.Parse(currentLine[3]), 
                    Int32.Parse(currentLine[6]), Int32.Parse(currentLine[5]), Int32.Parse(currentLine[4]), Convert.ToBoolean(currentLine[7]));
                _completedGoals.Add(currentCheckListGoal);
            break;
        }
    }*/

    load.Close();
    TextWriter empty = new StreamWriter("PrinterSetup.txt", false);
    empty.Write(string.Empty);
    empty.Close();
    }

}