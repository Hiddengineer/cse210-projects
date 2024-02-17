public class Scripture{
    private List<Word> _scripture = new List<Word>();
    private bool _allHidden;

    public Scripture(string scripture){
        List<String> _words = scripture.Split(' ').ToList();
        
        for(int i = 0; i < _words.Count; i++){
            _scripture.Add(new Word(_words[i]));
        }

        _allHidden = false;
    }
    public Scripture(string scripture, bool hidden){
        List<String> _words = scripture.Split(' ').ToList();
        
        for(int i = 0; i < _words.Count; i++){
            _scripture.Add(new Word(_words[i]));
        }

        _allHidden = hidden;
    }
     public void ChangeStatus(){
        if(_allHidden == true){
            _allHidden = false;
        }else{
            _allHidden = true;
        }
    }
    public void ReplaceThreeWords(){
        int _wordsReplaced = 0;
        
        if(_allHidden){
            //Hidden nothing to hide
        }else{
            while(_wordsReplaced != 3){
                Random rnd = new Random();
                int _randWord  = rnd.Next(0, _scripture.Count);   
                
                if(_scripture[_randWord].GetStatus()){
                    //word is already blank
                }else{
                    _scripture[_randWord].ReplaceWord();
                    _wordsReplaced += 1;
                }
                
                for(int i = 0; i < _scripture.Count; i++){
                    if(_scripture[i].GetStatus()){
                        _allHidden = true;
                    }else{
                        i = _scripture.Count;
                        _allHidden = false;
                    }
                }
                
                if(_allHidden){
                    _wordsReplaced = 3;
                }
            }
        }  
    }
    public bool GetStatus(){
        return _allHidden;
    }
    public List<Word> GetScripture(){
        return _scripture;
    }
    public void PrintScripture(){
        for(int i = 0; i < _scripture.Count; i++){
            if((i)%9 == 0){
                Console.Write($"\n{_scripture[i].GetWord()} ");
            }else{
                Console.Write($"{_scripture[i].GetWord()} ");
            }
        }

    }

}