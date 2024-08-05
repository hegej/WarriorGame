
using WarriorGame.Models.Interfaces;

namespace WarriorGame.Models
{
    public class Warrior
    {
        private string Name { get; }
        public IWeapon Weapon { get; private set; }

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

        public void ChangeRandomWeapon(IWeapon newRandomWeapon)
        {
            Weapon = newRandomWeapon;
            Console.WriteLine($"\nWarrior {Name} changed weapon to {Weapon.Name}.");
        }
    }
}
