class PLAFilament: Filament{
    public PLAFilament(): base(){}
    public PLAFilament(Settings currentSettings): base(currentSettings){
        _recomendedSettings = new Settings(90, 200, 55, 100, 90);
    }
    public override void CheckSettingsFesability(){
        if(_currentSettings.GetSpeed() >= 60 && _currentSettings.GetSpeed() <= 120){
            _currentSettings.UpdateSpeed(_recomendedSettings.GetSpeed());
        }
        else if(_currentSettings.GetNozelTemp() >= 190 && _currentSettings.GetSpeed() <= 220){
            _currentSettings.UpdateNozelTemp(_recomendedSettings.GetNozelTemp());
        }
        else if(_currentSettings.GetBedTemp() >= 50 && _currentSettings.GetSpeed() <= 60){
           _currentSettings.UpdateBedTemp(_recomendedSettings.GetBedTemp()); 
        }
        else if(_currentSettings.GetExtrushion() >= 90 && _currentSettings.GetSpeed() <= 110){
            _currentSettings.UpdateExtrusion(_recomendedSettings.GetExtrushion());
        }
        else if(_currentSettings.GetFanSpeed() >= 80 && _currentSettings.GetSpeed() <= 100){
            _currentSettings.UpdateFanSpeed(_recomendedSettings.GetFanSpeed());
        }
    }
    public override string SerializeFilament(){
        return $"1: {_recomendedSettings.SerializeSettings()}: {_currentSettings.SerializeSettings}";
    }
    public override void DisplayFilament(){
        Console.WriteLine("PLA:");
        _currentSettings.DisplaySettings();
    }
}