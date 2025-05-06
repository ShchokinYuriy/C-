using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lr3
{
    public class Rocket : Projectile
    {
        public Rocket(int baseDamage) : base(baseDamage) { }

        public override void HitTarget(IDamageable target)
        {
            Console.WriteLine($"Rocket explodes with damage: {damage}");
            target.TakeDamage(damage);
        }
    }
}
