using WarriorGame.Models.Interfaces;
using WarriorGame.Utilities;

namespace WarriorGame.Models.Weapons
{
    public class Spear : IWeapon
    {
        public string Name { get; private set; } = "Spear";
        private int Damage { get; set; } = 9;

        public void Attack()
        {
            WarriorConsole.DisplayWeaponAttack(this, $"Attacks with the {Name} {WarriorConsole.WeaponIcons[Name]} and deals {Damage} damage {WarriorConsole.DamageIcon}");
        }
    }
}
