class CheckListGoal: Goal{
private int _timesCompleted;

private int _endTimesCompleted;
private int _finalPointValue;
private bool _completedFully;

public CheckListGoal(string name, string description, int pointValue, int finalPointValue, int endTimesCompleted):
    base(name, description, pointValue){
    
    _finalPointValue = finalPointValue;
    _endTimesCompleted = endTimesCompleted;
    _completedFully = false;
    _timesCompleted = 0;
}
public CheckListGoal(string name, string description, int pointValue, int finalPointValue, int endTimesCompleted,
    int timesCompleted, bool completedFully):
    base(name, description, pointValue){
    
    _finalPointValue = finalPointValue;
    _endTimesCompleted = endTimesCompleted;
    _timesCompleted = timesCompleted;
    _completedFully = completedFully;
}
public override int RecordGoal(){
    _timesCompleted += 1;
    if(_timesCompleted == _endTimesCompleted){
        _completedFully = true;
        return _finalPointValue;
    }else{
        return _pointValue;
    }
}
public override void DisplayGoal(){
    Console.WriteLine(_name);
    Console.WriteLine(_description);
    Console.WriteLine($"It's worth {_pointValue} points every time completed,");
    Console.WriteLine($"but is worth {_finalPointValue} points");
    Console.WriteLine($"on the {_endTimesCompleted} time when it will be completed.");
    Console.WriteLine($"This goal has already been completed {_timesCompleted} times.");

}
public override string SerializeGoal(){
    return $"3: {_name}: {_description}: {_pointValue}: {_timesCompleted}: {_endTimesCompleted}: " +
        $"{_finalPointValue}: {_completedFully}";
}
public bool GetFullCompletion(){
    return _completedFully;
}
public int GetPartCompletion(){
    return _timesCompleted;
}

}