using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lr3
{
    public class ArmoredEnemy : IDamageable
    {
        public int Health { get; private set; }
        private int armor;

        public ArmoredEnemy(int health, int armor)
        {
            Health = health;
            this.armor = armor;
        }

        public void TakeDamage(int amount)
        {
            int reducedDamage = Math.Max(amount - armor, 0);
            Health -= reducedDamage;
            Console.WriteLine($"ArmoredEnemy absorbs some damage. Takes {reducedDamage}. Health now: {Health}");

            if (Health <= 0)
            {
                Console.WriteLine("ArmoredEnemy destroyed!");
            }
        }
    }
}
