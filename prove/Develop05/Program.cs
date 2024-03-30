using System;
using System.Net;

class Program
{
    static void Main(string[] args){
        GoalManager manager = new GoalManager();
        bool notDone = true;
        while(notDone){
            manager.DisplayCurrentScore();
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. RecordGoal");
            Console.WriteLine("3. Display Current goals");
            Console.WriteLine("4. Display finished goals");
            Console.WriteLine("5. Load goals");
            Console.WriteLine("6. Save goals");
            Console.WriteLine("7. quit");

            switch(Console.ReadLine()){
                case "1":
                    Console.WriteLine("What type of goal are you makeing?");
                    Console.WriteLine("1. Simple Goal");
                    Console.WriteLine("2. Eternal Goal");
                    Console.WriteLine("3. Check-list Goal");
                    Console.WriteLine("4. Negative Habit Goal");
                    Console.WriteLine("5. Progreshion Goal");
                    switch(Console.ReadLine()){
                        case "1":
                            Console.WriteLine("what is the name of the goal?");
                            string sName = Console.ReadLine();
                            Console.WriteLine("What is the description of the goal?");
                            string sDescription = Console.ReadLine();
                            Console.WriteLine("What is the point value of the goal?");
                            int sPointValue = Int32.Parse(Console.ReadLine());
                            SimpleGoal simple = new SimpleGoal(sName, sDescription, sPointValue);
                            manager.AddListCurrentGoals(simple);
                        break;

                        case "2":
                            Console.WriteLine("what is the name of the goal?");
                            string eName = Console.ReadLine();
                            Console.WriteLine("What is the description of the goal?");
                            string eDescription = Console.ReadLine();
                            Console.WriteLine("What is the point value of the goal?");
                            int ePointValue = Int32.Parse(Console.ReadLine());
                            EternalGoal eternal = new EternalGoal(eName, eDescription, ePointValue);
                            manager.AddListCurrentGoals(eternal);
                        break;

                        case "3":
                            Console.WriteLine("what is the name of the goal?");
                            string cName = Console.ReadLine();
                            Console.WriteLine("What is the description of the goal?");
                            string cDescription = Console.ReadLine();
                            Console.WriteLine("What is the point value of the goal?");
                            int cPointValue = Int32.Parse(Console.ReadLine());
                            Console.WriteLine("What is the final point value of the goal?");
                            int cFinalPointValue = Int32.Parse(Console.ReadLine());
                            Console.WriteLine("How many times will this goal be completed?");
                            int cEndTimesCompleted = Int32.Parse(Console.ReadLine());
                            CheckListGoal checkList = new CheckListGoal(cName, cDescription, cPointValue, cFinalPointValue, cEndTimesCompleted);
                            manager.AddListCurrentGoals(checkList);
                        break;

                        case "4":
                            Console.WriteLine("what is the name of the goal?");
                            string nName = Console.ReadLine();
                            Console.WriteLine("What is the description of the goal?");
                            string nDescription = Console.ReadLine();
                            Console.WriteLine("What is the positive point value of the goal?");
                            int nPointValue = Int32.Parse(Console.ReadLine());
                            NegativeHabitGoal negative = new NegativeHabitGoal(nName, nDescription, nPointValue * -1);
                            manager.AddListCurrentGoals(negative);
                        break;

                        case "5":
                            Console.WriteLine("what is the name of the goal?");
                            string pName = Console.ReadLine();
                            Console.WriteLine("What is the description of the goal?");
                            string pDescription = Console.ReadLine();
                            Console.WriteLine("What is the point value of the goal?");
                            int pPointValue = Int32.Parse(Console.ReadLine());
                            Console.WriteLine("What is the final point value of the goal?");
                            int pFinalPointValue = Int32.Parse(Console.ReadLine());
                            List<string> parts = new List<string>();
                            bool next = true;
                            Console.WriteLine("Wright the parts of the goal one at a time clicking enter after each one.");
                            Console.WriteLine("Then enter Quit to stop finish.");
                            while(next){
                                string input = Console.ReadLine();
                                switch(input){
                                    case "Q":
                                        next = false;
                                    break;
                                    case "q":
                                        next = false;
                                    break;
                                    case "Quit":
                                        next = false;
                                    break;
                                    case "quit":
                                        next = false;
                                    break;

                                    default:
                                        parts.Add(input);
                                    break;
                                }
                            }
                            ProgreshionGoal progreshion = new ProgreshionGoal(pName, pDescription, pPointValue, pFinalPointValue, parts);
                            manager.AddListCurrentGoals(progreshion);
                        break;
                    }
                break;

                case "2":
                    Console.WriteLine("which number goal do you want to record?");
                    Console.WriteLine("if you dont know first display current goals.");

                    manager.AddScore(manager.ChooseGoal(Int32.Parse(Console.ReadLine())).RecordGoal());
                break;

                case "3":
                    manager.DisplayListCurrentGoals();
                break;
                    
                case "4":
                    manager.DisplayListCompletedGoals();
                break;

                case "5":
                    manager.LoadGoals();
                break;

                case "6":
                    manager.SaveGoals();
                break;

                case "7":
                    notDone = false;
                break;
            }
        }
    }
}