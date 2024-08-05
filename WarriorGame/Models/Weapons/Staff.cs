using WarriorGame.Models.Interfaces;

namespace WarriorGame.Models.Weapons
{
    public class Staff : IWeapon
    {
        public string Name { get; set; } = "Staff";
        public int Damage { get; set; } = 6;

        public void Attack()
        {
            Console.WriteLine($"Hits with the staff and deals {Damage} damage.");
        }
    }
}
