

Mago mago1 = new Mago("Mago1");
Ninja ninja1 = new Ninja("Ninja1");
Samurai samurai1 = new Samurai("Samurai1");

mago1.ShowInfo();
Console.WriteLine("--------------------------");
ninja1.ShowInfo();
Console.WriteLine("--------------------------");
samurai1.ShowInfo();
Console.WriteLine("--------------------------");

mago1.Attack(samurai1);
mago1.ShowInfo();
Console.WriteLine("--------------------------");
samurai1.ShowInfo();
Console.WriteLine("--------------------------");




// Crear héroes
var ninja = new Ninja("Ninja");
var samurai = new Samurai("Samurai");
var wizard = new Mago("Mago");

// Crear enemigos
var zombie1 = new Zombie("Zombie 1");
var zombie2 = new Zombie("Zombie 2");
var spider = new Spider("Spider");

//  héroes y enemigos
var heroes = new List<Human> { ninja, samurai, wizard };
var enemies = new List<Enemy> { zombie1, zombie2, spider };




