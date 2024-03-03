using System.Diagnostics.Metrics;
using System.Runtime.InteropServices;

public class Activity{
    protected string _name;
    protected string _description;
    protected int _time;

    public Activity(string name, string description, int time){
        _name = name;
        _description = description;
        _time = time;
    }
    public Activity(string name, string description){
        _name = name;
        _description = description;
    }
    public void DisplayStartMessage(){
        Console.WriteLine($"This is the {_name} activity");
        CountDown(1);
        Console.WriteLine($"{_description}");
        CountDown(1);
        PromptForTime();
    }
    public void PromptForTime(){
        Console.WriteLine("How long do you have to do this activity in seconds?");
        _time = Int32.Parse(Console.ReadLine());
        CountDown(1);
    }
    public void DisplayEndMessage(){
        Console.WriteLine("Great job");
        CountDown(1);
        Console.WriteLine($"You have completed the {_name} activity");
        CountDown(1);
        Console.WriteLine($"You spent {_time}sec on the {_name} activity");
        CountDown(3);
    }
    public void CountDown(int time){
        for (int i = 0; i < (time*4); i++){
            //from a stack overflow question asked by Markus, edited by Daniel Ballinger and posted/answered by user131077
            switch (i % 4){
                case 0: Console.Write("|"); break;
                case 1: Console.Write("/"); break;
                case 2: Console.Write("-"); break;
                case 3: Console.Write("\\"); break;
            }
        
            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
            Thread.Sleep(250);
        }
        
        Console.Write(" ");
        Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
    }
    public int GetTime(){
        return _time;
    }
}