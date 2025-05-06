using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lr2
{
    internal class User
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        private string _password;

        public void SetPassword(string newPassword)
        {
            _password = newPassword;
        }

        public bool Authenticate(string inputPassword)
        {
            return _password == inputPassword;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Ім'я: {UserName} | Email: {Email}");
        }
    }
}
