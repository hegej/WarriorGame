using WarriorGame.Models.Interfaces;

namespace WarriorGame.Models.Weapons
{
    public class Spear : IWeapon
    {
        public string Name { get; set; } = "Spear";
        public int Damage { get; set; } = 9;

        public void Attack()
        {
            Console.WriteLine($"Attacks with the spear and deals {Damage} damage.");
        }
    }
}
