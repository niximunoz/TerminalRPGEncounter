public class Human
{
    public string Name { get; set; }
    public int Strength { get; set; }
    public int Intelligence { get; set; }
    public int Dexterity { get; set; }
    public int Health { get; set; }



    public Human(string name, int str, int intel, int dex, int hp)
    {
        Name = name;
        Strength = str;
        Intelligence = intel;
        Dexterity = dex;
        Health = hp;
    }

    // Build Attack method
    public virtual int Attack(Human target)
    {
        int damage = Strength * 3;
        target.Health -= damage;
        Console.WriteLine($"{Name} attacked {target.Name} for {damage} damage!");
        return target.Health;
    }

    // Fields and constructor removed for brevity
    public virtual void ShowInfo()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Strength: {Strength}");
        Console.WriteLine($"Intelligence: {Intelligence}");
        Console.WriteLine($"Dexterity: {Dexterity}");
        Console.WriteLine($"Health: {Health}");
    }  
}
