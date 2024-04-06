class PLAFilament: Filament{
    public PLAFilament(): base(){
        _recomendedSettings = new Settings(90, 200, 55, 100, 90);
        _currentSettings = _recomendedSettings;
    }
    public PLAFilament(Settings currentSettings): base(currentSettings){
        _recomendedSettings = new Settings(90, 200, 55, 100, 90);
    }

    public override void CheckSettingsFesability(){
        if(_currentSettings.GetSpeed() < 60 || _currentSettings.GetSpeed() > 120){
            _currentSettings.UpdateSpeed(_recomendedSettings.GetSpeed());
        }
        if(_currentSettings.GetNozelTemp() < 190 || _currentSettings.GetNozelTemp() > 220){
            _currentSettings.UpdateNozelTemp(_recomendedSettings.GetNozelTemp());
        }
        if(_currentSettings.GetBedTemp() < 50 || _currentSettings.GetBedTemp() > 60){
           _currentSettings.UpdateBedTemp(_recomendedSettings.GetBedTemp()); 
        }
        if(_currentSettings.GetExtrushion() < 90 || _currentSettings.GetExtrushion() > 110){
            _currentSettings.UpdateExtrusion(_recomendedSettings.GetExtrushion());
        }
        if(_currentSettings.GetFanSpeed() < 80 || _currentSettings.GetFanSpeed() > 100){
            _currentSettings.UpdateFanSpeed(_recomendedSettings.GetFanSpeed());
        }
    }
    public override string SerializeFilament(){
        return $"1: {_currentSettings.SerializeSettings()}";
    }
    public override void DisplayFilament(){
        Console.WriteLine("PLA:");
        _currentSettings.DisplaySettings();
    }
}