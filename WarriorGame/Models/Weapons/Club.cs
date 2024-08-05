using WarriorGame.Models.Interfaces;

namespace WarriorGame.Models.Weapons
{
    public class Club : IWeapon
    {
        public string Name { get; set; } = "Club";
        public int Damage { get; set; } = 8;

        public void Attack()
        {
            Console.WriteLine($"Hits with the club and deals {Damage} damage.");
        }
    }
}
