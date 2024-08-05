using WarriorGame.Models.Interfaces;

namespace WarriorGame.Models.Weapons
{
    public class Bow : IWeapon
    {
        public string Name { get; private set; } = "Bow";
        private int Damage { get; set; } = 8;

        public void Attack()
        {
            Console.WriteLine($"Fires an arrow with the {Name} and deals {Damage} damage.");
        }
    }
}
