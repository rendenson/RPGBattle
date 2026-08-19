namespace RPGBattle;

public class Character
{
    // Fields
    private readonly int _maxHealth;
    private int _health;
    
    // Constructor
    public Character(string name, int maxHealth)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            throw new ArgumentException("Name cannot be empty or whitespace", nameof(name));
        }
        Name = name.Trim();

        if (maxHealth <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(maxHealth), "Max health must be greater than 0");
        }
        _maxHealth = maxHealth;
        Health = maxHealth;
    }
    
    // Properties
    public int Health
    {
        get => _health;
        private set => _health = Math.Clamp(value, 0, _maxHealth); 
    }
    public string Name { get; }
    public bool IsAlive => Health > 0;

    // Methods
    public void TakeDamage(int damage)
    {
        if (damage <= 0) return;
        Health -= damage;
    }
    public void Heal(int amount)
    {
        if (!IsAlive) return;
        if (amount <= 0) return;
        int headroom = _maxHealth - Health;
        if (headroom == 0) return;
        Health += Math.Min(amount, headroom);
    }
}