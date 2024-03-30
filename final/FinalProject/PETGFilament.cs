class PETGFilament: Filament{
    public PETGFilament(): base(){
        _recomendedSettings = new Settings(90, 230, 60, 100, 50);
        _currentSettings = _recomendedSettings;
    }
    public PETGFilament(Settings currentSettings): base(currentSettings){
        _recomendedSettings = new Settings(90, 230, 60, 100, 50);
    }
    public override void CheckSettingsFesability(){
        if(_currentSettings.GetSpeed() >= 50 && _currentSettings.GetSpeed() <= 120){
            _currentSettings.UpdateSpeed(_recomendedSettings.GetSpeed());
        }
        else if(_currentSettings.GetNozelTemp() >= 220 && _currentSettings.GetSpeed() <= 250){
            _currentSettings.UpdateNozelTemp(_recomendedSettings.GetNozelTemp());
        }
        else if(_currentSettings.GetBedTemp() >= 50 && _currentSettings.GetSpeed() <= 80){
           _currentSettings.UpdateBedTemp(_recomendedSettings.GetBedTemp()); 
        }
        else if(_currentSettings.GetExtrushion() >= 90 && _currentSettings.GetSpeed() <= 110){
            _currentSettings.UpdateExtrusion(_recomendedSettings.GetExtrushion());
        }
        else if(_currentSettings.GetFanSpeed() >= 30 && _currentSettings.GetSpeed() <= 70){
            _currentSettings.UpdateFanSpeed(_recomendedSettings.GetFanSpeed());
        }
    }
    public override string SerializeFilament(){
        return $"2: {_currentSettings.SerializeSettings()}";
    }
    public override void DisplayFilament(){
        Console.WriteLine("PETG:");
        _currentSettings.DisplaySettings();
    }
}