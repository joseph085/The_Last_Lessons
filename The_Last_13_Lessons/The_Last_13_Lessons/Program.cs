namespace The_Last_13_Lessons
{
    internal class Program
    {
        #region HAS_A_RELTIONSHIP
        public class Employee
        {
            public string _firstName;
            public string _lastName;
            public string _fatherName;
            public int _age;
            public string _gender;
            public string _birthday;
            public string _city;
            private string? firstName;
            private string? lastName;
            private string? fatherName;
            private int age;
            private string? gender;

            public Employee(string? firstName, string? lastName, string? fatherName, int age, string? gender)
            {
                this.firstName = firstName;
                this.lastName = lastName;
                this.fatherName = fatherName;
                this.age = age;
                this.gender = gender;
            }
        }
        public class Task
        {
            public string _name;
            public string _deadLine;
            public string _description;
            public string _status;
            //Create, in Progress, Done....
            public Employee _assignedTo; // has-a-relationship...

        }
        public static void Main(string[] args)
        {
            #region Has-a-RelationsShips new task....
            Employee[] employees = new Employee[2];
            Task[] tasks = new Task[3];
            int i = 0;
            Console.WriteLine("Pls enter person");
            while (i < 1)
            {
                string firstName = Console.ReadLine();
                string lastName = Console.ReadLine();
                string fatherName = Console.ReadLine();
                int age = int.Parse(Console.ReadLine());
                string gender = Console.ReadLine();

                //Employee employee = new Employee
                //{
                //    _firstName = firstName,
                //    _lastName = lastName,
                //    _fatherName = fatherName,
                //    _age = age,
                //    _gender = gender
                //};
                Employee employee = new Employee(firstName,lastName,fatherName,age,gender);
                employees[i] = employee;
                i++;

            }
            Console.WriteLine("Pls enter tasks");
            #endregion

            #region 18.Has-a-RelationShip
            //Employee employee = new Employee
            //{
            //    _firstName = "Yusif",
            //    _lastName = "Huseynzade",
            //    _fatherName = "Qulu",
            //    _age = 25,
            //    _gender = "Male",
            //    _birthday = "26.08.1998"
            //};
            //Task task = new Task
            //{
            //    _name = "Added task name all response",
            //    _description = "Add monitoring announcement year response",
            //    _deadLine = "06.04.2023",
            //    _status = "OK",
            //    _assignedTo = employee
            //};
            ////Console.WriteLine(employee._firstName);
            ////Console.WriteLine(employee._lastName);
            ////Console.WriteLine(employee._fatherName);
            ////Console.WriteLine(employee._age);
            ////Console.WriteLine(employee._gender);
            ////Console.WriteLine(employee._birthday);

            //Console.WriteLine($"Task name : {task._name}");
            //Console.WriteLine($"Task name : {task._description}");
            //Console.WriteLine($"Task name : {task._deadLine}");
            //Console.WriteLine();
            //Console.WriteLine($"Task name : {task._status}");
            //Console.WriteLine($"Task name : {task._assignedTo._firstName} {task._assignedTo._lastName}");

            #endregion






        }
        #endregion 
    }
}