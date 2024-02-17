public class Scripture{
    private List<Word> _scripture = new List<Word>();
    private bool _allHidden;

    private int _wordsReplaced;
        private int _currentWord;
        private int _scriptureLength;
        private bool _wordStatus;

    Scripture(List<Word> scripture){
        _scripture = scripture;
        _allHidden = false;
    }
    Scripture(List<Word> scripture, bool hidden){
        _scripture = scripture;
        _allHidden = hidden;
    }
     public void changeStatus(){
        if (_allHidden == true){
            _allHidden = false;
        } else{
            _allHidden = true;
        }
    }
    public void replaceThreeWords(){
        while (_wordsReplaced != 3){
            

        }
            
        
    }
    public bool getStatus(){
        return _allHidden;
    }
    public List<Word> getScripture(){
        return _scripture;
    }
    public void printScripture(){

    }

}