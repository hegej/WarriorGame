using WarriorGame.Models.Interfaces;

namespace WarriorGame.Models.Weapons
{
    public class Spear : IWeapon
    {
        public string Name { get; private set; } = "Spear";
        private int Damage { get; set; } = 9;

        public void Attack()
        {
            Console.WriteLine($"Attacks with the {Name} and deals {Damage} damage.");
        }
    }
}
