using System.Security;

class ProgreshionGoal: Goal{
private List<string> _parts;
private int _timesCompleted;
private int _finalPointValue;
private bool _completedFully;

public ProgreshionGoal(string name, string description, int pointValue, int finalPointValue, List<string> parts): base(name, description, pointValue){
    _finalPointValue = finalPointValue;
    _completedFully = false;
    _parts = parts;
}
public ProgreshionGoal(string name, string description, int pointValue, int finalPointValue, int timesCompleted, bool completedFully,
    List<string> parts): base(name, description, pointValue){
    _timesCompleted = timesCompleted;
    _finalPointValue = finalPointValue;
    _completedFully = completedFully;

}
public override int RecordGoal(){
    _timesCompleted += 1;
    if(_timesCompleted == _parts.Count){
        _completedFully = true;
        return _finalPointValue;
    }else{
        return _pointValue;
    }
}
public override void DisplayGoal(){
    Console.WriteLine(_name);
    Console.WriteLine(_description);
    Console.WriteLine($"It's worth {_pointValue} points for each step completed,");
    Console.WriteLine($"but is worth {_finalPointValue} points");
    Console.WriteLine($"on the {_parts.Count} time when it will be completed.");
    Console.WriteLine($"This goal has already been completed {_timesCompleted} times.");
}
public override string SerializeGoal(){
    string Serialized = $"5: {_name}: {_description}: {_pointValue}: {_timesCompleted}: " +
        $"{_finalPointValue}: {_completedFully}";
    foreach (string part in _parts){
        Serialized += $": {part}";
    }
    return Serialized;
}

}