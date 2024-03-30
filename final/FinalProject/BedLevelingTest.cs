class BedLevelingTest: PrintTest{
private bool _selfLevelingDevice;
private int _lineGapScore;
private string _lineGapDescription;
private int _flatnessScore;
private string _flatnessDescription;

public BedLevelingTest(Filament filamentUsed): base(filamentUsed){

}
public BedLevelingTest(int date, Filament filamentUsed, bool selfLevelingDevice, int lineGapScore, int flatnessScore): base(date, filamentUsed){

}
public override void RecordPrint(){

}
public override string SerializePrint(){
    return "";
}
public override string RecomendSettings(){
    return "";
}
public override string RecomendPrinterModifications(){
    return "";
}

}