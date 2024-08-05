using WarriorGame.Models.Interfaces;
using WarriorGame.Utilities;

namespace WarriorGame.Models.Weapons
{
    public class Dagger : IWeapon
    {
        public string Name { get; private set; } = "Dagger";
        private int Damage { get; set; } = 7;

        public void Attack()
        {
            WarriorConsole.DisplayWeaponAttack(this, $"Stabs with the {Name} {WarriorConsole.WeaponIcons[Name]} and deals {Damage} damage {WarriorConsole.DamageIcon}");
        }
    }
}
