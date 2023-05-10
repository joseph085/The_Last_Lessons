namespace Authentication
{
    class User
    {
        public string _name;
        public string _lastName;
        public string _password;
        public string _email;

        public User(string name, string lastName, string password, string email)
        {
            _name = name;
            _lastName = lastName;
            _password = password;
            _email = email;
        }
    }

    class LoginCommand
    {
        public void Handle()
        {

        }
    }

    class RegisterCommand
    {
        public void Handle()
        {

        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
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