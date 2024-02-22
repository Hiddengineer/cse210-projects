public class WrightingAssinment : Assinment{
    private String _title;

    public WrightingAssinment(string studentName, string topic, string title) : base(studentName, topic){
        _title = title;
    }
    public string GetWrightingInformation(){
        return $"{_title} by {_studentName}";
    }
}