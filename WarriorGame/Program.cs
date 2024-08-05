using WarriorGame.Models;
using WarriorGame.Models.Interfaces;
using WarriorGame.Models.Weapons;
using WarriorGame.Utilities;

Console.OutputEncoding = System.Text.Encoding.UTF8;

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

WarriorConsole.Initialize();
WarriorConsole.DisplayWarriorStat(warrior);
WarriorConsole.DisplayAction(warrior, "enters the battle, ready to attack!");
warrior.Attack();

while (true)
{
    if (!WarriorConsole.ConfirmAction("Do you want to change weapon?"))
        break;

    string oldWeapon = warrior.Weapon.Name;
    warrior.ChangeRandomWeapon(weapons[random.Next(weapons.Count)]);
    WarriorConsole.DisplayWeaponChange(warrior, oldWeapon);

    WarriorConsole.DisplayWarriorStat(warrior);
    WarriorConsole.DisplayAction(warrior, "prepares an attack with the new weapon!");
    warrior.Attack();
}

    WarriorConsole.EndGame();
