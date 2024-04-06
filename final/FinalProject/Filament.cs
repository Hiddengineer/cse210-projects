class Filament{
    protected Settings _recomendedSettings;
    protected Settings _currentSettings;

    public Filament(){
        _recomendedSettings = new Settings(90, 200, 55, 100, 90);
        _currentSettings = _recomendedSettings;
    }
    public Filament(Settings currentSettings){
        _currentSettings = currentSettings;
    }

    public virtual void CheckSettingsFesability(){}
    public virtual void DisplayFilament(){}
    public virtual string SerializeFilament(){
        return $"0: {_currentSettings.SerializeSettings()}";
    }

    public void UpdateSettings(Settings settings){
        _currentSettings = settings;
    }
    public void UpdateSpeed(int speed){
        _currentSettings.UpdateSpeed(speed);
    }
    public void UpdateNozelTemp(int nozelTemp){
        _currentSettings.UpdateNozelTemp(nozelTemp);
    }
    public void UpdateBedTemp(int bedTemp){
        _currentSettings.UpdateBedTemp(bedTemp);
    }
    public void UpdateExtrusion(int extrusion){
        _currentSettings.UpdateExtrusion(extrusion);
    }
    public void UpdateFanSpeed(int fanSpeed){
        _currentSettings.UpdateFanSpeed(fanSpeed);
    }

    public int GetSpeed(){
        return _currentSettings.GetSpeed();
    }
    public int GetNozelTemp(){
        return _currentSettings.GetNozelTemp();
    }
    public int GetBedTemp(){
        return _currentSettings.GetBedTemp();
    }
    public int GetExtrusion(){
        return _currentSettings.GetExtrushion();
    }
    public int GetFanSpeed(){
        return _currentSettings.GetFanSpeed();
    }
    public Settings GetSettings(){
        return _currentSettings;
    }
}