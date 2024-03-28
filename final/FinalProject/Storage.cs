class Storage{
private List<PrintTest> _printTests;
private List<Filament> _filaments;

public Storage(){

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
        test.DisplayPrintTest();
    }
}
public PrintTest ChoosePrintTest(int test){
    return _printTests[test];
}
public Filament ChooseFilament(int filament){
    return _filaments[filament];

}
public void Save(){

}
public List<PrintTest> LoadPrintTest(){

}
public List<Filament> LoadFilament(){
    
}

}