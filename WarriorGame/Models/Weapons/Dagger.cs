﻿using WarriorGame.Models.Interfaces;

namespace WarriorGame.Models.Weapons
{
    public class Dagger : IWeapon
    {
        public string Name { get; private set; } = "Dagger";
        private int Damage { get; set; } = 7;

        public void Attack()
        {
            Console.WriteLine($"Stabs with the {Name} and deals {Damage} damage.");
        }
    }
}
