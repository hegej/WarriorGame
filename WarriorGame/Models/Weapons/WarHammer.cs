using WarriorGame.Models.Interfaces;

namespace WarriorGame.Models.Weapons
{
    public class WarHammer : IWeapon
    {
        public string Name { get; set; } = "WarHammer";
        public int Damage { get; set; } = 15;

        public void Attack()
        {
            Console.WriteLine($"Hits with the {Name} and deals {Damage} damage.");
        }
    }
}
