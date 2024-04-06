class Settings{
    private int _speed;
    private int _nozelTemp;
    private int _bedTemp;
    private int _extrusion;
    private int _fanSpeed;

    public Settings(int speed, int nozelTemp, int bedTemp, int extrusion, int fanSpeed){
        _speed = speed;
        _nozelTemp = nozelTemp;
        _bedTemp = bedTemp;
        _extrusion = extrusion;
        _fanSpeed = fanSpeed;
    }
    
    public void UpdateSettings(int speed, int nozelTemp, int bedTemp, int extrusion, int fanSpeed){
        _speed = speed;
        _nozelTemp = nozelTemp;
        _bedTemp = bedTemp;
        _extrusion = extrusion;
        _fanSpeed = fanSpeed;
    }
    public void UpdateSpeed(int speed){
        _speed = speed;
    }
    public void UpdateNozelTemp(int nozelTemp){
        _nozelTemp = nozelTemp;
    }
    public void UpdateBedTemp(int bedTemp){
        _bedTemp = bedTemp;
    }
    public void UpdateExtrusion(int extrusion){
        _extrusion = extrusion;
    }
    public void UpdateFanSpeed(int fanSpeed){
        _fanSpeed = fanSpeed;
    }
    public void DisplaySettings(){
        Console.WriteLine($"Print Speed: {_speed}");
        Console.WriteLine($"Tempreture of nozel: {_nozelTemp}");
        Console.WriteLine($"Tempreture of bed: {_bedTemp}");
        Console.WriteLine($"Extrushion rate: {_extrusion}");
        Console.WriteLine($"Fan speed: {_fanSpeed}");
    }
    public string SerializeSettings(){
        return $"{_speed}: {_nozelTemp}: {_bedTemp}: {_extrusion}: {_fanSpeed}";
    }
    public int GetSpeed(){
        return _speed;
    }
    public int GetNozelTemp(){
        return _nozelTemp;
    }
    public int GetBedTemp(){
        return _bedTemp;
    }
    public int GetExtrushion(){
        return _extrusion;
    }
    public int GetFanSpeed(){
        return _fanSpeed;
    }
}