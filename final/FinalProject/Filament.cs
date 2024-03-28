class Filament{
    protected Settings _recomendedSettings;
    protected Settings _currentSettings;

    public Filament(){}
    public Filament(Settings currentSettings){
        _currentSettings = currentSettings;
    }
    public virtual void CheckSettingsFesability(){}
    public virtual string SerializeFilament(){
        return $"0: {_recomendedSettings.SerializeSettings()}: {_currentSettings.SerializeSettings}";
    }
    public void UpdateSettings(int speed, int nozelTemp, int bedTemp, int extrusion, int fanSpeed){
        _currentSettings.UpdateSettings(speed, nozelTemp, bedTemp, extrusion, fanSpeed);
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
    public virtual void DisplayFilament(){}
}