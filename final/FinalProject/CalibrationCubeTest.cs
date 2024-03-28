class CalibrationCubeTest: PrintTest{
private int _modelXDimension;
private int _phisicalXDimension;
private int _modelYDimension;
private int _phisicalYDimension;
private int _modelZDimension;
private int _phisicalZDimension;

public CalibrationCubeTest(Filament filamentUsed): base(filamentUsed){

}
public CalibrationCubeTest(int date, Filament filamentUsed, int modelXDimension, int phisicalXDimension, int modelYDimension,
  int phisicalYDimension, int modelZDimension, int phisicalZDimension): base(date, filamentUsed){

  }
public override void RecordPrint(){

}
public override void SerializePrint(){

}
public override void RecomendSettings(){

}
public override void RecomendPrinterModifications(){

}

}