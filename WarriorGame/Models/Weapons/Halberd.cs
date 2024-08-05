using WarriorGame.Models.Interfaces;
using WarriorGame.Utilities;

namespace WarriorGame.Models.Weapons
{
    public class Halberd : IWeapon
    {
        public string Name { get; private set; } = "Halberd";
        private int Damage { get; set; } = 12;

        public void Attack()
        {
            WarriorConsole.DisplayWeaponAttack(this, $"Swings the {Name} {WarriorConsole.WeaponIcons[Name]} and deals {Damage} damage {WarriorConsole.DamageIcon}");
        }
    }
}
