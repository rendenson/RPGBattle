using RPGBattle;

var hero = new Character("Conan", 100);
Console.WriteLine($"{hero.Name}: {hero.Health} HP, alive: {hero.IsAlive}");
hero.TakeDamage(int.MinValue);
Console.WriteLine($"{hero.Name}: {hero.Health} HP, alive: {hero.IsAlive}");


// Character Nikitos = new Character("Nikitos", 100);
// Console.WriteLine($"Is {Nikitos.Name} alive? {Nikitos.IsAlive}");
// Console.WriteLine($"Health: {Nikitos.Health}");
//
// Console.WriteLine("Attacking...");
// Nikitos.TakeDamage(5);
// Console.WriteLine($"Health: {Nikitos.Health}");
// Console.WriteLine($"Is {Nikitos.Name} alive? {Nikitos.IsAlive}");
//
// Console.WriteLine("Healing...");
// Nikitos.Heal(-50);
// Console.WriteLine($"Health: {Nikitos.Health}");
// Console.WriteLine($"Is {Nikitos.Name} alive? {Nikitos.IsAlive}");