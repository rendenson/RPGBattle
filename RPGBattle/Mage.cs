namespace RPGBattle;

public class Mage : Character
{
    // Fields
    private readonly int _manaPool;
    private int _mana;
    
    // Constructor
    public Mage(string name, int maxHealth, int manaPool) : base(name, maxHealth)
    {
        if (manaPool <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(manaPool), "Mana pool must be greater than 0");
        }
        _manaPool = manaPool;
        Mana = manaPool;
    }
    
    // Properties
    public int Mana { 
        get => _mana; 
        private set => _mana = Math.Clamp(value, 0, _manaPool); }
}   