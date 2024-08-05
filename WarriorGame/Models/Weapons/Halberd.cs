using WarriorGame.Models.Interfaces;

namespace WarriorGame.Models.Weapons
{
    public class Halbred : IWeapon
    {
        public string Name { get; set; } = "Halbred";
        public int Damage { get; set; } = 12;

        public void Attack()
        {
            Console.WriteLine($"Swings the halbred and deals {Damage} damage.");
        }
    }
}
