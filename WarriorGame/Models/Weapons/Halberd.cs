using WarriorGame.Models.Interfaces;

namespace WarriorGame.Models.Weapons
{
    public class Halberd : IWeapon
    {
        public string Name { get; set; } = "Halberd";
        public int Damage { get; set; } = 12;

        public void Attack()
        {
            Console.WriteLine($"Swings the Halberd and deals {Damage} damage.");
        }
    }
}
