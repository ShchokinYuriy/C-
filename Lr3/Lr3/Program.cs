namespace Lr3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IDamageable enemy = new Enemy(20);
            IDamageable wall = new BreakableWall(15);
            IDamageable armored = new ArmoredEnemy(30, 3);

            Projectile bullet = new Bullet(7);
            Projectile rocket = new Rocket(15);

            Console.WriteLine("=== Bullet hits Enemy ===");
            bullet.HitTarget(enemy);

            Console.WriteLine("\n=== Bullet hits Wall ===");
            bullet.HitTarget(wall);

            Console.WriteLine("\n=== Rocket hits ArmoredEnemy ===");
            rocket.HitTarget(armored);

            Console.WriteLine("\n=== Bullet hits ArmoredEnemy ===");
            bullet.HitTarget(armored);
        }
    }
}
