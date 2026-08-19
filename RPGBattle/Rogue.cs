namespace RPGBattle;

public class Rogue : Character
{
    // Constructor
    public Rogue(string name, int maxHealth, int agility) : base(name, maxHealth)
    {
        if (agility <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(agility), "Agility must be greater than 0");
        }
        Agility = agility;
    }
    
    // Properties
    public int Agility { get; }
}