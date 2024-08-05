using WarriorGame.Models.Interfaces;
using WarriorGame.Utilities;

namespace WarriorGame.Models.Weapons
{
    public class WarHammer : IWeapon
    {
        public string Name { get; private set; } = "WarHammer";
        private int Damage { get; set; } = 15;

        public void Attack()
        {
            WarriorConsole.DisplayWeaponAttack(this, $"Hits with the {Name} {WarriorConsole.WeaponIcons[Name]} and deals {Damage} damage {WarriorConsole.DamageIcon}");
        }
    }
}
