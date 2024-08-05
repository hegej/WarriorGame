
using WarriorGame.Models.Interfaces;

namespace WarriorGame.Models
{
    public class Warrior
    {
        public string Name { get; }
        public IWeapon Weapon { get; }

        public Warrior(string name, IWeapon weapon)
        {
            Name = name;
            Weapon = weapon;
        }

        public void Attack()
        {
            Console.WriteLine($"Warrior {Name} attack with {Weapon.Name}.");
            Weapon.Attack();
        }
    }
}
