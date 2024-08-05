using WarriorGame.Models.Interfaces;
using WarriorGame.Utilities;

namespace WarriorGame.Models.Weapons
{
    public class Crossbow : IWeapon
    {
        public string Name { get; private set; } = "Crossbow";
        private int Damage { get; set; } = 10;

        public void Attack()
        {
            WarriorConsole.DisplayWeaponAttack(this, $"Fires off the {Name} {WarriorConsole.WeaponIcons[Name]} and deals {Damage} damage {WarriorConsole.DamageIcon}");
        }
    }
}
