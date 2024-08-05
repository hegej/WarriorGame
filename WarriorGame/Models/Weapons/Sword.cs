using WarriorGame.Models.Interfaces;
using WarriorGame.Utilities;

namespace WarriorGame.Models.Weapons
{
    public class Sword : IWeapon
    {
        public string Name { get; private set; } = "Sword";
        private int Damage { get; set; } = 10;

        public void Attack()
        {
            WarriorConsole.DisplayWeaponAttack(this, $"Swing the {Name} {WarriorConsole.WeaponIcons[Name]} and deals {Damage} damage {WarriorConsole.DamageIcon}");
        }
    }
}
