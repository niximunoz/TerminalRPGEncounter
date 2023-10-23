class Spider : Enemy
{
    public Spider(string name) : base(name, 30) { }

    public override void Attack(Human target)
    {
        int damage = 8;
        target.Health -= damage;
        Console.WriteLine($"{Name} attacked {target.Name} for {damage} damage!");
    }
}