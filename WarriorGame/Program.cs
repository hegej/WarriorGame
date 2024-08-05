using Spectre.Console;
using WarriorGame.Models;
using WarriorGame.Models.Interfaces;
using WarriorGame.Models.Weapons;


List<IWeapon> weapons = new List<IWeapon>
{
    new Sword(),
    new Axe(),
    new Club(),
    new Spear(),
    new Bow(),
    new Dagger(),
    new WarHammer(),
    new Staff(),
    new Crossbow(),
    new Halberd()
};

Random random = new Random();
IWeapon randomWeapon = weapons[random.Next(weapons.Count)];

Warrior warrior = new Warrior("Uhtred Ragnarsson", randomWeapon);

warrior.Attack();

while (true)
{     
    Console.Write("\nDo you want to change the weapon? Y/N (default N) : ");
    var userInput = Console.ReadLine();

    if (userInput.ToUpper() == "Y")
    {
        warrior.ChangeRandomWeapon(weapons[random.Next(weapons.Count)]);
        warrior.Attack();
    }
    else
    {
        break;
    }
}