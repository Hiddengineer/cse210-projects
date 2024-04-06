class BenchyTest: PrintTest{
  public BenchyTest(Filament filamentUsed): base(filamentUsed){
    _description = "A Boat Print Used to figure out what settings are needed.";

    _descriptions = new List<string>{"The amount of tendrls betreen the sides of cabin from non to completly filled",
      "piles of melted filament on the ship from non to all over the place",
      "patterns of indents in the hull from non to al over",
      "filament pushed out from bottom of ship from non to melted mess",
      "the droop of the house windows from perfect arch to completly dangeling"};

    _scores = new List<int>{};
  }
  public BenchyTest(string date, Filament filamentUsed, int stringingScore, int blobsScore, int repetePatternsScore, 
    int elephantsFootScore, int windowDroopScore): base(date, filamentUsed){
    
    _description = "A Boat Print Used to figure out what settings are needed.";

    _descriptions = new List<string>{"The amount of tendrls betreen the sides of cabin from non to completly filled",
      "piles of melted filament on the ship from non to all over the place",
      "patterns of indents in the hull from non to al over",
      "filament pushed out from bottom of ship from non to melted mess",
      "the droop of the house windows from perfect arch to completly dangeling"};

    _scores = new List<int>{stringingScore, blobsScore, repetePatternsScore, elephantsFootScore, windowDroopScore};
    }

  public override void RecordPrint(){
    Console.WriteLine("On a scale of 1 to 10 rate the quality of your print in these catagorys.");

    for(int i = 0; i < _descriptions.Count; i++){
      Console.WriteLine(_descriptions[i]);
      _scores.Add(Int32.Parse(Console.ReadLine()));
    }
  }
  public override string SerializePrint(){
    return  $"1: {_scores[0]}: {_scores[1]}: {_scores[2]}: {_scores[3]}: " +
      $"{_scores[4]}: {_date}: {_filamentUsed.SerializeFilament()}";
  }
  public override void RecomendSettings(){
    switch(_scores[0]){
      case 7: case 6: case 5:
        double speedPercent1 = (double)_filamentUsed.GetSpeed()/100 * 5;
        _filamentUsed.UpdateSpeed(_filamentUsed.GetSpeed() + Convert.ToInt32(Math.Round(speedPercent1, 0)));
      break;

      case 4: case 3: case 2:
        double speedPercent2 = (double)_filamentUsed.GetSpeed()/100 * 10;
        _filamentUsed.UpdateSpeed(_filamentUsed.GetSpeed() + Convert.ToInt32(Math.Round(speedPercent2, 0)));
      break;

      case 1:
        double speedPercent3 = (double)_filamentUsed.GetSpeed()/100 * 15;
        _filamentUsed.UpdateSpeed(_filamentUsed.GetSpeed() + Convert.ToInt32(Math.Round(speedPercent3, 0)));
      break;
    }

    switch(_scores[1]){
      case 7: case 6: case 5:
        double extrushionPercent1 = (double)_filamentUsed.GetExtrusion()/100 * 5;
        _filamentUsed.UpdateExtrusion(_filamentUsed.GetExtrusion() + Convert.ToInt32(Math.Round(extrushionPercent1, 0)));
      break;

      case 4: case 3: case 2:
        double extrushionPercent2 = (double)_filamentUsed.GetExtrusion()/100 * 10;
        _filamentUsed.UpdateExtrusion(_filamentUsed.GetExtrusion() + Convert.ToInt32(Math.Round(extrushionPercent2, 0)));
      break;

      case 1:
        double extrushionPercent3 = (double)_filamentUsed.GetExtrusion()/100 * 15;
        _filamentUsed.UpdateExtrusion(_filamentUsed.GetExtrusion() + Convert.ToInt32(Math.Round(extrushionPercent3, 0)));
      break;
    }

    switch(_scores[2]){
      case 7: case 6: case 5:
        double nozelTempPercent1 = (double)_filamentUsed.GetNozelTemp()/100 * 2;
        _filamentUsed.UpdateNozelTemp(_filamentUsed.GetNozelTemp() + Convert.ToInt32(Math.Round(nozelTempPercent1, 0)));
      break;

      case 4: case 3: case 2:
        double nozelTempPercent2 = (double)_filamentUsed.GetNozelTemp()/100 * 4;
        _filamentUsed.UpdateNozelTemp(_filamentUsed.GetNozelTemp() + Convert.ToInt32(Math.Round(nozelTempPercent2, 0)));
      break;

      case 1:
        double nozelTempPercent3 = (double)_filamentUsed.GetNozelTemp()/100 * 6;
        _filamentUsed.UpdateNozelTemp(_filamentUsed.GetNozelTemp() + Convert.ToInt32(Math.Round(nozelTempPercent3, 0)));
      break;
    }

    switch(_scores[3]){
      case 7: case 6: case 5:
        double bedTempPercent1 = (double)_filamentUsed.GetBedTemp()/100 * 5;
        _filamentUsed.UpdateBedTemp(_filamentUsed.GetBedTemp() + Convert.ToInt32(Math.Round(bedTempPercent1, 0)));
      break;

      case 4: case 3: case 2:
        double bedTempPercent2 = (double)_filamentUsed.GetBedTemp()/100 * 10;
        _filamentUsed.UpdateBedTemp(_filamentUsed.GetBedTemp() + Convert.ToInt32(Math.Round(bedTempPercent2, 0)));
      break;

      case 1:
        double bedTempPercent3 = (double)_filamentUsed.GetBedTemp()/100 * 15;
        _filamentUsed.UpdateBedTemp(_filamentUsed.GetBedTemp() + Convert.ToInt32(Math.Round(bedTempPercent3, 0)));
      break;
    }

    switch(_scores[4]){
      case 7: case 6: case 5:
        double fanSpeedPercent1 = (double)_filamentUsed.GetFanSpeed()/100 * 5;
        _filamentUsed.UpdateFanSpeed(_filamentUsed.GetFanSpeed() + Convert.ToInt32(Math.Round(fanSpeedPercent1, 0)));
      break;

      case 4: case 3: case 2:
        double fanSpeedPercent2 = (double)_filamentUsed.GetFanSpeed()/100 * 10;
        _filamentUsed.UpdateFanSpeed(_filamentUsed.GetFanSpeed() + Convert.ToInt32(Math.Round(fanSpeedPercent2, 0)));
      break;

      case 1:
        double fanSpeedPercent3 = (double)_filamentUsed.GetFanSpeed()/100 * 15;
        _filamentUsed.UpdateFanSpeed(_filamentUsed.GetFanSpeed() + Convert.ToInt32(Math.Round(fanSpeedPercent3, 0)));
      break;
    }

    _filamentUsed.CheckSettingsFesability();
    Console.WriteLine("Use these settings.");
    _filamentUsed.DisplayFilament();
  }
  public override void DisplayPrint(){
    Console.WriteLine("Benchy");
    Console.WriteLine(_date);
    _filamentUsed.DisplayFilament();
  }
}