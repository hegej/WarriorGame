using WarriorGame.Models.Interfaces;
using WarriorGame.Utilities;

namespace WarriorGame.Models.Weapons
{
    public class Axe : IWeapon
    {
        public string Name { get; private set; } = "Axe";
        private int Damage { get; set; } = 15;

        public void Attack()
        {
            WarriorConsole.DisplayWeaponAttack(this, $"Swings the {Name} {WarriorConsole.WeaponIcons[Name]} and deals {Damage} damage {WarriorConsole.DamageIcon}");
        }
    }
}
