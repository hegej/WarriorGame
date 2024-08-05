using WarriorGame.Models.Interfaces;

namespace WarriorGame.Models.Weapons
{
    public class Dagger : IWeapon
    {
        public string Name { get; set; } = "Dagger";
        public int Damage { get; set; } = 7;

        public void Attack()
        {
            Console.WriteLine($"Stabs with the dagger and deals {Damage} damage.");
        }
    }
}
