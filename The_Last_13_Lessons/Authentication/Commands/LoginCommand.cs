using Authentication.Database;
using Authentication.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authentication.Commands
{
    public class LoginCommand
    {
        public void Handle(DataContext database)
        {
            string email = Console.ReadLine();
            string password = Console.ReadLine();
            foreach (User user in database.Users)
            {
                if (user._email == email && user._password == password)
                {
                    if (user._isAdmin)
                        Console.WriteLine("Hello dear admin");
                    else Console.WriteLine($"Hello! : {user._email} {user._password}");
                }
            }
        }

        internal void Handle()
        {
            throw new NotImplementedException();
        }
    }
}
