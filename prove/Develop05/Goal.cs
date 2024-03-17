class Goal{
protected string _name;
protected string _description;
protected int _pointValue;

public Goal(string name, string description, int pointValue){
    _name = name;
    _description = description;
    _pointValue = pointValue;
}
public virtual int RecordGoal(){
    return _pointValue;
}
public virtual void DisplayGoal(){
    Console.WriteLine(_name);
    Console.WriteLine(_description);
    Console.WriteLine($"It's worth {_pointValue} points.");
}
public virtual String SerializeGoal(){
    return $"0: {_name}: {_description}: {_pointValue}";
}
public string GetName(){
    return _name;
}
public string GetDiscription(){
    return _description;
}
}
