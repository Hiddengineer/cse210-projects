class GoalManager{
private List<Goal> _currentGoals = new List<Goal>();
private List<Goal> _completedGoals = new List<Goal>();
private int _score;

public  GoalManager(){
    _score = 0;

}
public void DisplayCurrentScore(){
    Console.WriteLine($"your current score is {_score}");
}
public void AddScore(int score){
    _score += score;
}
public void DisplayListCurrentGoals(){
    foreach(Goal goal in _currentGoals){
        goal.DisplayGoal();
    }
}
public void  DisplayListCompletedGoals(){
    foreach(Goal goal in _completedGoals){
        goal.DisplayGoal();
    }
}
public void AddListCurrentGoals(Goal goal){
    _currentGoals.Add(goal);
}
public void RemoveListCurrentGoals(int goalPosition){
    _currentGoals.RemoveAt(goalPosition);
}
public void  AddListCompletedGoals(Goal goal){
    _completedGoals.Add(goal);
}
public Goal  ChooseGoal(int goalPosition){
    return _currentGoals[goalPosition];
}
public void  SaveGoals(){
    StreamWriter save = new StreamWriter("Goals.txt");
    save.WriteLine(_score);
    save.WriteLine($"CurrentGoals: {_currentGoals.Count}");
    for(int i = 0; i <  _currentGoals.Count;i ++){
        save.WriteLine(_currentGoals[i].SerializeGoal());
    }
    
    save.WriteLine($"CompletedGoals: {_completedGoals.Count}");
    for(int i = 0; i <  _completedGoals.Count; i ++){
        save.WriteLine(_completedGoals[i].SerializeGoal());
    }
    
    save.Close();
}
public void LoadGoals(){
    StreamReader load = new StreamReader("Goals.txt");
    _score = Int32.Parse(load.ReadLine());
    string firstLine = load.ReadLine();
    string[] currentGoalsBegining = firstLine.Split(":");
    for(int i = 0; i < Int32.Parse(currentGoalsBegining[1]); i++){
        string currentGoalLine = load.ReadLine();
        string[] currentLine = currentGoalLine.Split(":");
        switch(currentLine[0]){
            case "0": 
                Goal currentGoal = new Goal(currentLine[1], currentLine[2], Int32.Parse(currentLine[3]));
                _currentGoals.Add(currentGoal);
            break;

            case "1": 
                 Goal currentSimpleGoal = new SimpleGoal(currentLine[1], currentLine[2], Int32.Parse(currentLine[3]), Convert.ToBoolean(currentLine[4]));
                _currentGoals.Add(currentSimpleGoal);
            break;

            case "2": 
                Goal currentEternalGoal = new EternalGoal(currentLine[1], currentLine[2], Int32.Parse(currentLine[3]));
                _currentGoals.Add(currentEternalGoal);
            break;

            case "3": 
                Goal currentCheckListGoal = new CheckListGoal(currentLine[1], currentLine[2], Int32.Parse(currentLine[3]), 
                    Int32.Parse(currentLine[6]), Int32.Parse(currentLine[5]), Int32.Parse(currentLine[4]), Convert.ToBoolean(currentLine[7]));
                _currentGoals.Add(currentCheckListGoal);
            break;

            case "4": 
                Goal currentNegativeHabitGoal = new NegativeHabitGoal(currentLine[1], currentLine[2], Int32.Parse(currentLine[3]));
                _currentGoals.Add(currentNegativeHabitGoal);
            break;

            case "5": 
                List<string> parts = new List<string>();
                for(int o = 7; o < currentLine.Length; o++){
                    parts.Add(currentLine[o]);
                }
                Goal currentProgreshionGoal = new ProgreshionGoal(currentLine[1], currentLine[2], Int32.Parse(currentLine[3]), 
                    Int32.Parse(currentLine[5]), Int32.Parse(currentLine[4]), Convert.ToBoolean(currentLine[6]), parts);
                _currentGoals.Add(currentProgreshionGoal);
            break;
        }
    }
    string secondLine = load.ReadLine();
    string[] completedGoalsBegining = secondLine.Split(":");
    for(int i = 0; i < Int32.Parse(completedGoalsBegining[1]); i++){
        string completedGoalLine = load.ReadLine();
        string[] currentLine = completedGoalLine.Split(":");
        switch(currentLine[0]){
            case "0": 
                Goal currentGoal = new Goal(currentLine[1], currentLine[2], Int32.Parse(currentLine[3]));
                _completedGoals.Add(currentGoal);
            break;

            case "1": 
                 Goal currentSimpleGoal = new SimpleGoal(currentLine[1], currentLine[2], Int32.Parse(currentLine[3]), Convert.ToBoolean(currentLine[4]));
                _completedGoals.Add(currentSimpleGoal);
            break;

            case "2": 
                Goal currentEternalGoal = new EternalGoal(currentLine[1], currentLine[2], Int32.Parse(currentLine[3]));
                _completedGoals.Add(currentEternalGoal);
            break;

            case "3": 
                Goal currentCheckListGoal = new CheckListGoal(currentLine[1], currentLine[2], Int32.Parse(currentLine[3]), 
                    Int32.Parse(currentLine[6]), Int32.Parse(currentLine[5]), Int32.Parse(currentLine[4]), Convert.ToBoolean(currentLine[7]));
                _completedGoals.Add(currentCheckListGoal);
            break;

            case "4": 
                Goal currentNegativeHabitGoal = new NegativeHabitGoal(currentLine[1], currentLine[2], Int32.Parse(currentLine[3]));
                _completedGoals.Add(currentNegativeHabitGoal);
            break;

            case "5": 
                List<string> parts = new List<string>();
                for(int o = 7; o < currentLine.Length; o++){
                    parts.Add(currentLine[o]);
                }
                Goal currentProgreshionGoal = new ProgreshionGoal(currentLine[1], currentLine[2], Int32.Parse(currentLine[3]), 
                    Int32.Parse(currentLine[5]), Int32.Parse(currentLine[4]), Convert.ToBoolean(currentLine[6]), parts);
                _completedGoals.Add(currentProgreshionGoal);
            break;
        }
    }

    load.Close();
    TextWriter empty = new StreamWriter("Goal.txt", false);
    empty.Write(string.Empty);
    empty.Close();
    }

}