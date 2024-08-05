using WarriorGame.Models.Interfaces;

namespace WarriorGame.Models.Weapons
{
    public class Axe : IWeapon
    {
        public string Name { get; private set; } = "Axe";
        private int Damage { get; set; } = 15;

        public void Attack()
        {
            Console.WriteLine($"Swings the {Name} and deals {Damage} damage.");
        }
    }
}
