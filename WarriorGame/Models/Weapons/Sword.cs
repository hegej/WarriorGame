using WarriorGame.Models.Interfaces;

namespace WarriorGame.Models.Weapons
{
    public class Sword : IWeapon
    {
        public string Name { get; private set; } = "Sword";
        private int Damage { get; set; } = 10;

        public void Attack()
        {
            Console.WriteLine($"Swing the {Name} and deals {Damage} damage.");

        }
    }
}
