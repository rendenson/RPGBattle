namespace RPGBattle;

public class Warrior : Character
{
    // Constructor
    public Warrior(string name, int maxHealth, int attackPower) : base(name, maxHealth)
    {
        if (attackPower <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(attackPower), "Attack must be greater than 0.");
        }
        AttackPower = attackPower;
    }
    
    // Properties
    public int AttackPower { get; }
}