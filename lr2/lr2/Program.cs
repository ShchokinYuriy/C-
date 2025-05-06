namespace lr2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Admin admin = new Admin { UserName = "AdminUser", Email = "admin@example.com" };
            admin.SetPassword("admin123");

            Moderator moderator = new Moderator { UserName = "ModUser", Email = "mod@example.com" };
            moderator.SetPassword("wrongpass");

            RegularUser regularUser = new RegularUser { UserName = "RegUser", Email = "user@example.com" };
            regularUser.SetPassword("user123");

            List<User> users = new List<User> { admin, moderator, regularUser };

            Console.WriteLine("=== Інформація про користувачів ===");
            foreach (var user in users)
            {
                user.DisplayInfo();
            }

            Console.WriteLine("\n=== Тестування методів ===");
            foreach (var user in users)
            {
                if (user is Admin a)
                {
                    a.BlockUser(regularUser);
                }
                else if (user is Moderator m)
                {
                    m.ModerateContent();
                }
                else if (user is RegularUser r)
                {
                    r.PostComment();
                }
            }

            Console.WriteLine("\n=== Перевірка аутентифікації ===");
            Console.WriteLine($"{admin.UserName}: {(admin.Authenticate("admin123") ? "Успішна аутентифікація" : "Невірний пароль")}");
            Console.WriteLine($"{moderator.UserName}: {(moderator.Authenticate("mod123") ? "Успішна аутентифікація" : "Невірний пароль")}");
            Console.WriteLine($"{regularUser.UserName}: {(regularUser.Authenticate("user123") ? "Успішна аутентифікація" : "Невірний пароль")}");

        }
    }
}
