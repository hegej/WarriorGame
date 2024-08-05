using WarriorGame.Models.Interfaces;

namespace WarriorGame.Models.Weapons
{
    public class Crossbow : IWeapon
    {
        public string Name { get; set; } = "Crossbow";
        public int Damage { get; set; } = 10;

        public void Attack()
        {
            Console.WriteLine($"Fires off the {Name} and deals {Damage} damage.");
        }
    }
}
