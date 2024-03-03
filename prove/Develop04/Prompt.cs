public class Prompt{
    private string _userPrompt;
    private bool _notUsed; 

    public Prompt(string userPrompt){
        _userPrompt = userPrompt;
        _notUsed = true;
    }
    public void ChangeStatus(){
        if(_notUsed){
            _notUsed = false;
        }else{
            _notUsed = true;
        }
    }
    public bool GetStatus(){
        return _notUsed;
    }
    public string GetPrompt(){
        return _userPrompt;
    }
}