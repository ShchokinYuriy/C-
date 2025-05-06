using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lr3
{
    public class BreakableWall : IDamageable
    {
        public int Durability { get; private set; }

        public BreakableWall(int durability)
        {
            Durability = durability;
        }

        public void TakeDamage(int amount)
        {
            Durability -= amount;
            Console.WriteLine($"Wall takes {amount} damage. Durability now: {Durability}");

            if (Durability <= 0)
            {
                Console.WriteLine("Wall is broken!");
            }
        }
    }
}
