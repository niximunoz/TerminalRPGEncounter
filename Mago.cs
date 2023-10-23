class Mago : Human
{
    public Mago(string name) : base(name, 10, 25, 10, 50) { }

    //reduce la salud del objetivo en 3 * Inteligencia y cura al Mago por la cantidad de daño infligido
    public override int Attack(Human target)
    {
        int damage = 3 * Intelligence;
        target.Health -= damage;
        Health += damage;
        return target.Health;
    }

    //cura al humano objetivo en 3 * Inteligencia.
    public void Heal(Human target)
    {
        int healing = 3 * Intelligence;
        target.Health += healing;
    }
    public override void ShowInfo()
    {
        base.ShowInfo();
    }
}

