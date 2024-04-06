class BedLevelingTest: PrintTest{
    private bool _selfLevelingDevice;

    public BedLevelingTest(Filament filamentUsed): base(filamentUsed){
        _description = "A flat print used to test the leveling of printer bed";
        
        _descriptions = new List<string>{"The size of gaps of the layer from non to stringy", 
            "If no gaps rate currling around nozel path from smooth to extreem ridges otherwise put 11"};

        
        _scores = new List<int>{};
    }
    public BedLevelingTest(string date, Filament filamentUsed, bool selfLevelingDevice, int lineGapScore, int smothness): base(date, filamentUsed){
        _description = "A flat print used to test the leveling of printer bed";

        _descriptions = new List<string>{"The size of gaps of the layer from non to stringy", 
            "If no gaps rate currling around nozel path from smooth to extreem ridges otherwise put 11"};
        
        _scores = new List<int>{lineGapScore, smothness};

        _selfLevelingDevice = selfLevelingDevice; 
    }
    
    public override void RecordPrint(){
        Console.WriteLine("Does your printer have a self leveler yes or no");
        
        switch(Console.ReadLine()){
            case "Yes": case "yes": 
                _selfLevelingDevice = true;
            break;
            case "No": case "no":
                _selfLevelingDevice = false;
            break;
        }
        
        Console.WriteLine("On a scale of 1 to 10 rate the quality of your print in these catagorys.");
        
        for(int i = 0; i < _descriptions.Count; i++){
            Console.WriteLine(_descriptions[i]);
            _scores.Add(Int32.Parse(Console.ReadLine()));
        }
    }
    public override string SerializePrint(){
        return  $"3: {_selfLevelingDevice}: {_scores[0]}: {_scores[1]}: {_date}: {_filamentUsed.SerializeFilament()}";
    }
    public override void RecomendSettings(){
        if(_selfLevelingDevice){
            if(_scores[0] < 8){
                Console.WriteLine("Raise sensor offset");
            }else if(_scores[1] < 8){
                Console.WriteLine("Lower sensor offset");
            }else{
                Console.WriteLine("Your sensor offset is good");
            }
        }
    }
    public override void RecomendPrinterModifications(){
        if(_selfLevelingDevice == false){
            if(_scores[0] < 8){
                Console.WriteLine("Raise Bed");
            }else if(_scores[1] < 8){
                Console.WriteLine("Lower Bed");
            }else{
                Console.WriteLine("Your Bed is good");
            }
        }
    }
    public override void DisplayPrint(){
        Console.WriteLine("Bed Leveling");
        Console.WriteLine(_date);
        _filamentUsed.DisplayFilament();
    }
}