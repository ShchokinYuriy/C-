using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lr2
{
    internal class Admin : User
    {
        public void BlockUser(User user)
        {
            Console.WriteLine($"Користувача {user.UserName} заблоковано.");
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine("Роль: Адміністратор");
        }
    }
}
