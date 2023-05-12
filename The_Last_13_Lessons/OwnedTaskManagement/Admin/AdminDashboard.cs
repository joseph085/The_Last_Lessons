using OwnedTaskManagement.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OwnedTaskManagement.Admin
{
    public class AdminDashboard
    {
        public static void İntroduction()
        {
            Console.WriteLine("Hello dear Admin");
            while (true)
            {
                string command = Console.ReadLine();
                switch (command)
                {
                    case "/show-users":
                        ShowUsersCommands.Handle();
                        break;
                    case "/show-user-by-email":
                        ShowUserByEmailCommand.Handle();
                        break;
                    case "/show-user-by-id":
                        ShowUserByIdCommand.Handle();
                        break;
                    case "/add-user":
                        AddUserCommand.Handle();
                        break;
                    case "/logout":
                        Console.WriteLine("Bye-bye");
                        return;
                    default:
                        Console.WriteLine("Invalid command,pls try again");
                        break;
                }
            }
        }
    }
}
