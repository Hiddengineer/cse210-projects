class PrintTest{
    protected string _description;
    protected string _date;
    protected Filament _filamentUsed;
    protected List<int> _scores;
    protected List<string> _descriptions;

    public PrintTest(Filament filamentUsed){
        _filamentUsed = filamentUsed;
        DateTime dateTime = new DateTime();
        _date = dateTime.ToString("dd/MM/yyyy");
    }
    public PrintTest(string date, Filament filamentUsed){
        _date = date;
        _filamentUsed = filamentUsed;
    }

    public virtual void RecordPrint(){}
    public virtual void RecomendSettings(){}
    public virtual void RecomendPrinterModifications(){}
    public virtual void DisplayPrint(){}
    public virtual string SerializePrint(){
        return  $"0: {_date}: {_filamentUsed.SerializeFilament()}";
    }

    public string GetDiscription(){
        return _description;
    }
    public Settings GetSettings(){
        return _filamentUsed.GetSettings();
    }
}