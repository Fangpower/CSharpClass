internal class OlympicCountry {
    public string Name { get; set; }
    public int Gold { get; set; }
    public int Silver { get; set; }
    public int Bronze { get; set; }

    public OlympicCountry(string newName, int newGold, 
        int newSilver, int newBronze){
        Name = newName;
        Gold = newGold;
        Silver = newSilver;
        Bronze = newBronze;
    }

    public override string ToString() {
        return $"{Name}: {Gold} gold, {Silver} silver, {Bronze} bronze";
    }
}

