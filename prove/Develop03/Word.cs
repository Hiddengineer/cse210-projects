public class Word{
    private string _word;
    private bool _isHidden;

    public Word(string word){
        _word = word;
    }
    public Word(string word, bool hidden){
        _word = word;
        _isHidden = hidden;
    }
    public string getWord(){
        return _word;
    }
    public string getStatus(){
        return _isHidden;
    }
    public void changeStatus(){
        if (_isHidden == true){
            _isHidden = false;
        } else{
            _isHidden = true;
        }
    }
}