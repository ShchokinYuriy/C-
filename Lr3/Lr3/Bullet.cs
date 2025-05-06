using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lr3
{
    public class Bullet : Projectile
    {
        private static Random rng = new Random();

        public Bullet(int baseDamage) : base(baseDamage) { }

        public override void HitTarget(IDamageable target)
        {
            int scatteredDamage = damage + rng.Next(-2, 3); // від -2 до +2
            Console.WriteLine($"Bullet hits with damage: {scatteredDamage}");
            target.TakeDamage(scatteredDamage);
        }
    }
}
