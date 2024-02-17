using System;
using System.Collections.Concurrent;
using System.Net.Quic;

class Program
{
    static void Main(string[] args)
    {
        Referance _refer1 = new Referance("Matthew", 22, 36, 39);
        Scripture _script1 = new Scripture("Master which is the great commandment in the law Jesus " + 
            "said unto him Thou shalt love the Lord thy God with all thy heart and with all thy soul and with all thy mind "+
            "This is the first and great commandment And the second is like unto it Thou shalt love thy neighbour as thyself");

        Referance _refer2 = new Referance("John", 17 ,3);
        Scripture _script2 = new Scripture("And this is life eternal that they might know thee the only true God and Jesus Christ whom thou hast sent");

        Referance _refer3 = new Referance("John", 7 , 17);
        Scripture _script3 = new Scripture("If any man will do his will he shall know of the doctrine whether it be of God or whether I speak of myself");

        Referance _refer4 = new Referance("John", 3, 16);
        Scripture _script4 = new Scripture("For God so loved the world that he gave his only begotten Son that whosoever believeth in him should not"+
            " perish but have everlasting life");

        Referance _refer5 = new Referance("John", 3 , 5);
        Scripture _script5 = new Scripture("Jesus answered Verily verily I say unto thee Except a man be born of water and of the Spirit he cannot "+
            "enter into the kingdom of God");

        Referance _refer6 = new Referance("Luke", 24, 36 , 39);
        Scripture _script6 = new Scripture("And as they thus spake Jesus himself stood in the midst of them and saith unto them Peace be unto you "+
            "But they were terrified and affrighted and supposed that they had seen a spirit And he said unto them Why are ye troubled and why do "+
            "thoughts arise in your hearts Behold my hands and my feet that it is I myself handle me and see for a spirit hath not flesh and bones as ye see me have");

        Referance _refer7 = new Referance("Luke", 22, 19, 20);
        Scripture _script7 = new Scripture( "And he took bread and gave thanks and brake it and gave unto them saying This is my body which is given "+
            "for you this do in remembrance of me Likewise also the cup after supper saying This cup is the new testament in my blood which is shed for you");

        Referance _refer8 = new Referance("Luke", 2, 10, 12);
        Scripture _script8 = new Scripture("And the angel said unto them Fear not for behold I bring you good tidings of great joy which shall be to "+
            "all people For unto you is born this day in the city of David a Saviour which is Christ the Lord And this shall be a sign unto you Ye shall "+
            "find the babe wrapped in swaddling clothes lying in a manger");

        List<Referance> _referances = new List<Referance>{_refer1,_refer2,_refer3,_refer4,_refer5,_refer6,_refer7,_refer8};
        List<Scripture> _scriptures = new List<Scripture>{_script1,_script2,_script3,_script4,_script5,_script6,_script7,_script8};
        Scriptures _newTestamentDM = new Scriptures(_referances,_scriptures);

        Random _rnd = new Random();
        int _currentScripture = _rnd.Next(0, _referances.Count);

        String _userInput;
        
        bool _userInputB = true;
        bool _incorrectInput;

        while(_userInputB){

            _incorrectInput = true;

            _userInput = "";

            Console.Clear();
            Console.Clear();

            if(_newTestamentDM.GetScriptures()[_currentScripture].GetStatus()){
                _userInputB = false;
            }

            _newTestamentDM.PrintFullScripture(_currentScripture);
            Console.WriteLine($"\nClick Enter to hide 3 words. Type quit to end program.");

            _userInput = Console.ReadLine();
            
            while(_incorrectInput){
                if(_userInput == ""){
                    _newTestamentDM.GetScriptures()[_currentScripture].ReplaceThreeWords();
                    _incorrectInput = false;
                }else if(_userInput == "quit"){
                    _userInputB = false;
                    _incorrectInput = false;
                }else if(_userInput == "Quit"){
                    _userInputB = false;
                    _incorrectInput = false;
                }else if(_userInput == "q"){
                    _userInputB = false;
                    _incorrectInput = false;
                }else if(_userInput == "Q"){
                    _userInputB = false;
                    _incorrectInput = false;
                }else{
                    Console.WriteLine("Not a valid input try again.");
                    _userInput = Console.ReadLine();
                }
            }
        }
    }
}