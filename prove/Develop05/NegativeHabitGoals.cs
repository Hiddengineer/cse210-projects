class NegativeHabitGoal: Goal{

public NegativeHabitGoal(string name, string description, int pointValue): base(name, description, pointValue){

}
/*public override int RecordGoal(){
    return _pointValue;
}
public override void DisplayGoal(){

}*/
public override string SerializeGoal(){
    return $"4: {_name}: {_description}: {_pointValue}";
}

}