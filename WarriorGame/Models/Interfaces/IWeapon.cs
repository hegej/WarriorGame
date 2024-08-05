
namespace WarriorGame.Models.Interfaces
{
    public interface IWeapon
    {
        string Name { get; }
        int Damage { get; }
        void Attack();
    }
}
