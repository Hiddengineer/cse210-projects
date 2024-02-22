public class MathAssinment : Assinment{
    private string _textbookSection;
    private string _problems;

    public MathAssinment(string studentName, string topic, string textbookSection, string problems) : base(studentName, topic){
        _textbookSection = textbookSection;
        _problems = problems;
    }
    public string GetHomeworkList(){
        return $"Section {_textbookSection} Problems {_problems}";
    }
    }