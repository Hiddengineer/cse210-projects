using System.IO;
using System.Security.Cryptography.X509Certificates;

static public class FileSystem
{
    static List<Entry> jornal = new List<Entry>();



    static public List<Entry> LoadJornal(string fileName)
    {
        
        string[] lines = System.IO.File.ReadAllLines(fileName+".txt");
        foreach (string line in lines)
        {
            string[] entryParts = line.Split(",");
            
            Entry entry = new Entry();

            entry.date= entryParts[0];
            entry.prompt = entryParts[1];
            entry.response = entryParts[2];

            jornal.Add(entry);

        }
        return jornal;
    }

    static public void SaveJornal(string fileName, List<Entry> Jornal)
    {
        FileStream file = new FileStream(fileName+".txt",FileMode.Create);
        StreamWriter outputFile = new StreamWriter(file);
        foreach (Entry entry in Jornal)
        {
            outputFile.WriteLine($"{entry.date},{entry.prompt},{entry.response}");
        }
        outputFile.Close();
        file.Close();
        

    }

}