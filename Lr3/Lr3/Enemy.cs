using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lr3
{
    public class Enemy : IDamageable
    {
        public int Health { get; private set; }

        public Enemy(int health)
        {
            Health = health;
        }

        public void TakeDamage(int amount)
        {
            Health -= amount;
            Console.WriteLine($"Enemy takes {amount} damage. Health now: {Health}");

            if (Health <= 0)
            {
                Console.WriteLine("Enemy destroyed!");
            }
        }
    }
}
