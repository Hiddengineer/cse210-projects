public class BreathingActivity: Activity{
    private string _breathIn;
    private string _breathOut;

    public BreathingActivity(string name, string description): base(name, description){}
    public void DisplayBreathingRhythm(){
        int timeLeft = _time;
        
        while(timeLeft != 0){
            if(timeLeft >= 8){
                Console.Write("Breath in   ");
                CountDown(4);
                Console.SetCursorPosition(Console.CursorLeft - 12, Console.CursorTop);
                Console.Write("Breath Out  ");
                CountDown(4);
                Console.SetCursorPosition(Console.CursorLeft - 12, Console.CursorTop);
                Console.Write("            ");
                Console.SetCursorPosition(Console.CursorLeft - 12, Console.CursorTop);
                timeLeft -= 8;
            } else if(timeLeft >= 4){
                Console.Write("Breath in   ");
                CountDown(4);
                Console.SetCursorPosition(Console.CursorLeft - 12, Console.CursorTop);
                Console.Write("            ");
                Console.SetCursorPosition(Console.CursorLeft - 12, Console.CursorTop);
                timeLeft -= 4;
            } else{
                Console.Write("            ");
                Console.SetCursorPosition(Console.CursorLeft - 12, Console.CursorTop);
                CountDown(timeLeft);
                timeLeft = 0;
            }
        }
    }
}