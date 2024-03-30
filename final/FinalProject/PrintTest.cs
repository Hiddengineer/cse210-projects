class PrintTest{
protected string _description;
protected int _date;
protected Filament _filamentUsed;

public PrintTest(Filament filamentUsed){

}
public PrintTest(int date, Filament filamentUsed){

}
public virtual void RecordPrint(){

}
public virtual string SerializePrint(){
    return "";
}
public virtual string RecomendSettings(){
    return "";
}
public virtual string RecomendPrinterModifications(){
    return "";
}
public string GetDiscription(){
    return "";
}

}