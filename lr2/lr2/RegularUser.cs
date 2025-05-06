using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lr2
{
    internal class RegularUser : User
    {
        public void PostComment()
        {
            Console.WriteLine("Коментар опубліковано.");
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine("Роль: Звичайний користувач");
        }
    }
}
