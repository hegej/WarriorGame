using WarriorGame.Models.Interfaces;
using WarriorGame.Utilities;

namespace WarriorGame.Models.Weapons
{
    public class Club : IWeapon
    {
        public string Name { get; private set; } = "Club";
        private int Damage { get; set; } = 8;

        public void Attack()
        {
            WarriorConsole.DisplayWeaponAttack(this, $"Hits with the {Name} {WarriorConsole.WeaponIcons[Name]} and deals {Damage} damage {WarriorConsole.DamageIcon}");
        }
    }
}
