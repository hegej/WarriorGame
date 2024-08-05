using WarriorGame.Models.Interfaces;
using WarriorGame.Utilities;

namespace WarriorGame.Models.Weapons
{
    public class Staff : IWeapon
    {
        public string Name { get; private set; } = "Staff";
        private int Damage { get; set; } = 6;

        public void Attack()
        {
            WarriorConsole.DisplayWeaponAttack(this, $"Hits with the {Name} {WarriorConsole.WeaponIcons[Name]} and deals {Damage} damage {WarriorConsole.DamageIcon}");
        }
    }
}
