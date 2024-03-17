class SimpleGoal: Goal{
private bool _Completion;

public SimpleGoal(string name, string description, int pointValue): base(name, description, pointValue){
    _Completion = false;
}
public SimpleGoal(string name, string description, int pointValue, bool completed): base(name, description, pointValue){
    _Completion = completed;
}
public override int RecordGoal(){
    _Completion = true;
    return _pointValue;
}
public override void DisplayGoal(){
    Console.WriteLine(_name);
    Console.WriteLine(_description);
    Console.WriteLine($"It's worth {_pointValue} points.");
    if(_Completion){
        Console.WriteLine("This goal has been completed.");
    }else{
        Console.WriteLine("This goal has not been completed.");
    }
}
public override string SerializeGoal(){
    return $"1: {_name}: {_description}: {_pointValue}: {_Completion}";
}
public bool GetCompletion(){
    return _Completion;
}
}