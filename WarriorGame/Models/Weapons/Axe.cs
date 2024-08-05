using WarriorGame.Models.Interfaces;

namespace WarriorGame.Models.Weapons
{
    public class Axe : IWeapon
    {
        public string Name { get; set; } = "Axe";
        public int Damage { get; set; } = 15;

        public void Attack()
        {
            Console.WriteLine($"Swings the axe and deals {Damage} damage.");
        }
    }
}
