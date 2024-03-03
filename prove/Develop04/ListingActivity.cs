public class ListingActivity: Activity{
    private List<Prompt> _prompts;
    private bool _allPromptsUsed;
    private List<string> _responses;
    private int _numResponses;

    public ListingActivity(string name, string description, List<Prompt> prompts): base(name, description){
        _prompts = prompts;
        _responses = new List<string>();
    }
    public void DisplayPrompt(){
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
    public void GetResponses(){
        //sections have been taken from Smirnov, Egor's gethub

        Console.WriteLine("wright responses to the prompt.");
        Console.WriteLine("Press Enter after each response.");

        DateTime endTime = DateTime.Now.AddSeconds(_time - 4);

        while (DateTime.Now < endTime)
        {
            string newItem = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(newItem))
                break;

            _responses.Add(newItem);
            
        }

    }
    public int CountResponses(){
        _numResponses = _responses.Count();
        return _numResponses;
    }
    public void DisplayResponses(){
        for(int i = 0; i < _responses.Count(); i++ ){
            Console.WriteLine(_responses[i]);
        }
    }
    public void DisplayListingActivity(){
        DisplayPrompt();
        CountDown(4);
        GetResponses();
        Console.WriteLine(CountResponses());
        DisplayResponses();
    }
}