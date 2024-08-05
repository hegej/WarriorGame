using WarriorGame.Models.Interfaces;

namespace WarriorGame.Models.Weapons
{
    public class Staff : IWeapon
    {
        public string Name { get; private set; } = "Staff";
        private int Damage { get; set; } = 6;

        public void Attack()
        {
            Console.WriteLine($"Hits with the {Name} and deals {Damage} damage.");
        }
    }
}
