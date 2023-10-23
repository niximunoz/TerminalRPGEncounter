class Zombie : Enemy
{
    public Zombie(string name) : base(name, 50) { }

    public override void Attack(Human target)
    {
        int damage = 10;
        target.Health -= damage;
        Console.WriteLine($"{Name} attacked {target.Name} for {damage} damage!");
    }
}