using Spectre.Console;
using WarriorGame.Models.Interfaces;
using WarriorGame.Utilities;

namespace WarriorGame.Models
{
    public class Warrior
    {
        public string Name { get; }
        public IWeapon Weapon { get; private set; }

        public Warrior(string name, IWeapon weapon)
        {
            Name = name;
            Weapon = weapon;
        }

        public void Attack()
        {
            WarriorConsole.DisplayWarriorAttack(this, $"Warrior {Name} attack {WarriorConsole.AttackIcon}  with {Weapon.Name} {WarriorConsole.WeaponIcons[Weapon.Name]}");
            Weapon.Attack();
        }

        public void ChangeRandomWeapon(IWeapon newRandomWeapon)
        {
            string oldWeaponName = Weapon.Name;
            Weapon = newRandomWeapon;
            AnsiConsole.MarkupLine($"\n[bold]Weapon changed:[/] {WarriorConsole.WeaponIcons[oldWeaponName]} [strikethrough]{oldWeaponName}[/] -> {WarriorConsole.WeaponIcons[Weapon.Name]} [underline]{Weapon.Name}[/]");
        }
    }
}
