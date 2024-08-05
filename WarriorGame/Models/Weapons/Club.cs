using WarriorGame.Models.Interfaces;

namespace WarriorGame.Models.Weapons
{
    public class Club : IWeapon
    {
        public string Name { get; private set; } = "Club";
        private int Damage { get; set; } = 8;

        public void Attack()
        {
            Console.WriteLine($"Hits with the {Name} and deals {Damage} damage.");
        }
    }
}
