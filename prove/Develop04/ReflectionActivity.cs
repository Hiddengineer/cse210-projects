class ReflectionActivity: Activity{
    private List<Prompt> _prompts;
    private bool _allPromptsUsed;
    private List<Prompt> _reflections;
    private bool _allReflectionsUsed;

    public ReflectionActivity(string name, string description, List<Prompt> prompts, List<Prompt> reflections): base(name, description){
        _prompts = prompts;
        _reflections = reflections;
        _allPromptsUsed = false;
        _allReflectionsUsed = false;
    }
    public void ShowPrompt(){
        Random rnd = new Random();
        bool promptNotShown = true;

        if(_allPromptsUsed){
            for(int i = 0; i < _prompts.Count(); i++){
                _prompts[i].ChangeStatus();
            }
            _allPromptsUsed = false;
        }

        while(promptNotShown){
            int randPrompt  = rnd.Next(0, _prompts.Count());
            if(_prompts[randPrompt].GetStatus()){
                Console.WriteLine(_prompts[randPrompt].GetPrompt());
                _prompts[randPrompt].ChangeStatus();
                promptNotShown = false;
            }
        }

        for(int i = 0; i < _prompts.Count(); i++){
            if(_prompts[i].GetStatus()){
                i = _prompts.Count;
                _allPromptsUsed = false;
            }else{
                _allPromptsUsed = true;
            }
        }
        
    }
    public void ShowReflect(){
        Random rnd = new Random();
        bool reflectionNotShown = true;
        
        if(_allReflectionsUsed){
            for(int i = 0; i < _reflections.Count(); i++){
                _reflections[i].ChangeStatus();
            }
            _allReflectionsUsed = false;
        }
        
        while(reflectionNotShown){
            int randReflection  = rnd.Next(0, _reflections.Count());
            if(_reflections[randReflection].GetStatus()){
                Console.WriteLine(_reflections[randReflection].GetPrompt());
                _reflections[randReflection].ChangeStatus();
                reflectionNotShown = false;
            }
        }
        
        for(int i = 0; i < _reflections.Count(); i++){
            if(_reflections[i].GetStatus()){
                i = _reflections.Count();
                _allReflectionsUsed = false;
            }else{
                _allReflectionsUsed = true;
            }
        }
    }
    public void Reflecting(){
        int timeLeft = _time;
        
        while(timeLeft != 0){
            if(timeLeft >= 8){
                ShowPrompt();
                CountDown(4);
                ShowReflect();
                CountDown(4);
                timeLeft -= 8;
            }else if(timeLeft >= 4){
                ShowPrompt();
                CountDown(2);
                ShowReflect();
                CountDown(2);
                timeLeft -= 4;
            }else{
                CountDown(timeLeft);
                timeLeft = 0;
            }
        }
    }
}