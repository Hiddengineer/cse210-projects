class TPUFilament: Filament{
    public TPUFilament(): base(){
        _recomendedSettings = new Settings(17, 230, 50, 100, 90);
        _currentSettings = _recomendedSettings;
    }
    public TPUFilament(Settings currentSettings): base(currentSettings){
        _recomendedSettings = new Settings(17, 230, 50, 100, 90);
    }
    
    public override void CheckSettingsFesability(){
        if(_currentSettings.GetSpeed() < 15 || _currentSettings.GetSpeed() > 20){
            _currentSettings.UpdateSpeed(_recomendedSettings.GetSpeed());
        }
        if(_currentSettings.GetNozelTemp() < 210 || _currentSettings.GetNozelTemp() > 250){
            _currentSettings.UpdateNozelTemp(_recomendedSettings.GetNozelTemp());
        }
        if(_currentSettings.GetBedTemp() < 40 || _currentSettings.GetBedTemp() > 60){
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
        return $"3: {_currentSettings.SerializeSettings()}";
    }
    public override void DisplayFilament(){
        Console.WriteLine("TPU:");
        _currentSettings.DisplaySettings();
    }
}