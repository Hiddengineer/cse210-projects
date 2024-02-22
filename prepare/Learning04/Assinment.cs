public class Assinment{
    protected String _studentName;
    protected String _topic;

    public Assinment(string studentName, string topic){
        _studentName = studentName;
        _topic = topic;
    }
    public string GetSummary(){
        return $"{_studentName} - {_topic}";
    }
}