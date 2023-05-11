using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Authentication.Commands;
using Authentication.Database;
using Authentication.Utilities;


namespace Authentication
{
    public class Program
    {
        static void Main(string[] args)
        {
            DataContext database = new DataContext();

            while (true)
            {
                string command = Console.ReadLine()!; //==> ! isaresini ona gore sona atiriqki eksi olsun diye
                switch (command)
                {
                    case "/register":
                        RegisterCommand registerCommand = new RegisterCommand();
                        registerCommand.Handle();
                        break;
                    case "/login":
                        LoginCommand loginCommand = new LoginCommand();
                        loginCommand.Handle();
                        break;
                    case "/exit":
                        Console.WriteLine("Bye-bye");
                        return;
                    default:
                        Console.WriteLine("Invalid command pls try again :");
                        break;
                }

            }
        }
    }


}    