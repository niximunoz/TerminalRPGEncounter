class Enemy
{
    public string Name { get; set; }
    public int Health { get; set; }

    public Enemy(string name, int health)
    {
        Name = name;
        Health = health;
    }

    public virtual void Attack(Human target)
    {}
}