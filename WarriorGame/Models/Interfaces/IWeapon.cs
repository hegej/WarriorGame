
namespace WarriorGame.Models.Interfaces
{
    public interface IWeapon
    {
        string Name { get; set; }
        int Damage { get; set; }
        void Attack();
    }
}
