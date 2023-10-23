class Ninja : Human
{
    public Ninja(string name) : base(name, 10, 10, 75, 100) { }

    //reduce la salud del objetivo en su cantidad de Destreza y tiene un 20 % de posibilidades de infligir 10 puntos de daño adicional
    public override int Attack(Human target)
    {
        int damage = Dexterity;
        if (new Random().Next(1, 6) == 1) 
        {
            damage += 10;
        }
        target.Health -= damage;
        return target.Health;
    }

    //reduce salud de humano objetivo en 5 y agrega esta cantidad a su propia salud.
    public void Steal(Human target)
    {
        target.Health -= 5;
        Health += 5;
    }
    public override void ShowInfo()
    {
        base.ShowInfo();
    }
}