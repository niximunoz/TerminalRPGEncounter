class Samurai : Human
{
    public Samurai(string name) : base(name, 10, 10, 10, 200) { }

    //reduce la salud del objetivo a 0 si le quedan menos de 50 puntos de vida.
    public override int Attack(Human target)
    {
        int remainingHealth = base.Attack(target);
        if (remainingHealth < 50)
        {
            target.Health = 0;
        }
        return target.Health;
    }

    //Samurai recupera su salud completa
    public void Meditate()
    {
        Health = 200;
    }
    public override void ShowInfo()
    {
        base.ShowInfo();
    }
}