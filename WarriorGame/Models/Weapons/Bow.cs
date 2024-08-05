using WarriorGame.Models.Interfaces;

namespace WarriorGame.Models.Weapons
{
    public class Bow : IWeapon
    {
        public string Name { get; set; } = "Bow";
        public int Damage { get; set; } = 8;

        public void Attack()
        {
            Console.WriteLine($"Fires an arrow and deals {Damage} damage.");
        }
    }
}
