public class Scriptures{
    private List<Referance> _referances;
    private List<Scripture> _scriptures;

    public Scriptures(List<Referance> referances, List<Scripture> scriptures){
        _referances = referances;
        _scriptures = scriptures;
    }

    public void AddScripture(Referance referance, Scripture scripture){
        _referances.Add(referance);
        _scriptures.Add(scripture);
    }

    public void PrintFullScripture(int randScripture){
        _referances[randScripture].PrintReferance();
        _scriptures[randScripture].PrintScripture();
    }

    public List<Scripture> GetScriptures(){
        return _scriptures;
    }
}