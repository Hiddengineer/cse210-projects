public class Word{
    private string _word;
    private bool _isHidden;

    public Word(string word){
        _word = word;
        _isHidden = false;
    }
    public Word(string word, bool hidden){
        _word = word;
        _isHidden = hidden;
    }
    public string GetWord(){
        return _word;
    }
    public bool GetStatus(){
        return _isHidden;
    }
    public void ChangeStatus(){
        if(_isHidden == true){
            _isHidden = false;
        } else{
            _isHidden = true;
        }
    }
    public void ReplaceWord(){
        for(int i = 0; i < _word.Length; i++){
            _word = _word.Remove(i, Math.Min(1, _word.Length - i)).Insert(i, "_");
        }
        
        ChangeStatus(); 
    }
    
}