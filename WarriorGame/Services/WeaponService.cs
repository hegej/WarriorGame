
using WarriorGame.Models.Interfaces;
using WarriorGame.Models.Weapons;

namespace WarriorGame.Services
{
    public class WeaponService
    {
        private readonly List<IWeapon> _weapon;

        public WeaponService()
        {
            _weapon = new List<IWeapon>
            {
                new Axe(),
                new Bow(),
                new Club(),
                new Dagger(),
                new WarHammer()
            };
        }
    }
}
