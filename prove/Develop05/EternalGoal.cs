class EternalGoal: Goal{

public EternalGoal(string name, string description, int pointValue): base(name, description, pointValue){

}
public override string SerializeGoal(){
    return $"2: {_name}: {_description}: {_pointValue}";
}

}