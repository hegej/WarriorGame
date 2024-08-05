using WarriorGame.Models.Interfaces;
using WarriorGame.Utilities;

namespace WarriorGame.Models.Weapons
{
    public class Bow : IWeapon
    {
        public string Name { get; private set; } = "Bow";
        private int Damage { get; set; } = 8;

        public void Attack()
        {
            WarriorConsole.DisplayWeaponAttack(this, $"Fires an arrow with the {Name} {WarriorConsole.WeaponIcons[Name]} and deals {Damage} damage {WarriorConsole.DamageIcon}");
        }
    }
}
