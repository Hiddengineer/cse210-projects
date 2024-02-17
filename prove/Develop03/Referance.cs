public class Referance{
    private string _book;
    private int _chapter;
    private int _startVerse;
    private int _endVerse;

    public Referance(string book, int chapter, int startVerse){
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
    }
    public Referance(string book, int chapter, int startVerse, int endVerse){
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = endVerse;
    }
    public string getReferance(){
        if (_endVerse == 0){
            return $"{_book} {_chapter} {_startVerse}";
        }else{
            return $"{_book} {_chapter} {_startVerse}-{_endVerse}";
        }
    }
    public void printReferance(){
        if (_endVerse == 0){
            Console.WriteLine($"{_book} {_chapter} {_startVerse}");
        }else{
            Console.WriteLine($"{_book} {_chapter} {_startVerse}-{_endVerse}");
        }
    }

}