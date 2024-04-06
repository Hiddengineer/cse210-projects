class CalibrationCubeTest: PrintTest{
  public CalibrationCubeTest(Filament filamentUsed): base(filamentUsed){
    _description = "A cube print used to test the x y and z movement of your printer";
    
    _descriptions = new List<string>{"Distance between X sides on model", "distance between X sides on phisical cube",
      "Distance between Y sides on model", "distance between Y sides on phisical cube",
      "Distance between Z sides on model", "distance between Z sides on phisical cube"};

    _scores = new List<int>{};
  }
  public CalibrationCubeTest(string date, Filament filamentUsed, int modelXDimension, int phisicalXDimension, int modelYDimension,
    int phisicalYDimension, int modelZDimension, int phisicalZDimension): base(date, filamentUsed){
      
    _description = "A cube print used to test the x y and z movement of your printer";

    _descriptions = new List<string>{"Distance between X sides on model", "distance between X sides on phisical cube",
      "Distance between Y sides on model", "distance between Y sides on phisical cube",
      "Distance between Z sides on model", "distance between Z sides on phisical cube"};
    
    _scores = new List<int>{modelXDimension, phisicalXDimension, modelYDimension, phisicalYDimension, modelZDimension, phisicalZDimension};
    }

  public override void RecordPrint(){
    Console.WriteLine("Write the meshured length of");
    
    for(int i = 0; i < _descriptions.Count; i++){
      Console.WriteLine(_descriptions[i]);
      _scores.Add(Int32.Parse(Console.ReadLine()));
    }
  }
  public override string SerializePrint(){
    return  $"2: {_scores[0]}: {_scores[1]}: {_scores[2]}: {_scores[3]}: " +
      $"{_scores[4]}: {_scores[5]}: {_date}: {_filamentUsed.SerializeFilament()}";
  }
  public override void RecomendSettings(){
    double xPercent = (Double)_scores[0] / _scores[1] * 100;
    Console.WriteLine($"X axis scale {Math.Round(xPercent, 1)}%");

    double yPercent = (Double)_scores[2] / _scores[3] * 100;
    Console.WriteLine($"Y axis scale {Math.Round(yPercent, 1)}%");

    double zPercent = (Double)_scores[4] / _scores[5] * 100;
    Console.WriteLine($"Z axis scale {Math.Round(zPercent, 1)}%");
  }
  public override void DisplayPrint(){
    Console.WriteLine("Calibration Cube");
    Console.WriteLine(_date);
    _filamentUsed.DisplayFilament();
  }
}