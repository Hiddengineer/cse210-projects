class BenchyTest: PrintTest{
private int _stringingScore;
private int _shiftedLayersScore;
private int _blobsScore;
private int _thinLayersScore;
private int _repetePatternsScore;
private int _bottomLinesGapScore;
private int _letersDefinitionScore;
private int _elephantsFootScore;
private int _windowDroopScore;
private int _deckhouseBulgeScore;
private int _chimneyScore;
private string _stringingDescription;
private string _shiftedLayersDescription;
private string _blobsDescription;
private string _thinLayersDescription;
private string _repetePatternsDescription;
private string _bottomLinesGapDescription;
private string _letersDefinitionDescription;
private string _elephantsFootDescription;
private string _windowDroopDescription;
private string _deckhouseBulgeDescription;
private string _chimneyDescription;

public BenchyTest(Filament filamentUsed): base(filamentUsed){

}
public BenchyTest(int date, Filament filamentUsed, int stringingScore, int shiftedLayersScore, int blobsScore, int thinLayersScore,
    int repetePatternsScore, int bottomLinesGapScore, int letersDefinitionScore, int elephantsFootScore,
    int windowDroopScore, int deckhouseBulgeScore, int chimneyScore): base(date, filamentUsed){

  }
public override void RecordPrint(){

}
public override string SerializePrint(){

}
public override string RecomendSettings(){

}
public override string RecomendPrinterModifications(){

}

}