using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Last_13_Lessons
{
    internal class _18
    {
        #region 18.HAS_A_RELATIONSHIP

        ///has a 
        //public class Employee
        //{
        //    public string _firstName;
        //    public string _lastName;
        //    public string _fatherName;
        //    public int _age;
        //    public string _gender;

        //    public Employee(string firstName, string lastName, string fatherName, int age, string gender)
        //    {
        //        _firstName = firstName;
        //        _lastName = lastName;
        //        _fatherName = fatherName;
        //        _age = age;
        //        _gender = gender;
        //    }
        //}

        //public class Task
        //{
        //    public string _name;
        //    public string _description;
        //    public string _deadline;
        //    public string _status;
        //    ///Created, In progress , Done
        //    public Employee _assignedTo; ///Biz bu yazilisa deyirik ki,HAS-A-RELATIONSHIP 

        //    public Task(string name, string description, string deadline, string status, Employee assignedTo)
        //    {
        //        _name = name;
        //        _description = description;
        //        _deadline = deadline;
        //        _status = status;
        //        _assignedTo = assignedTo;
        //    }


        //}

        //public class Programs
        //{
        //    #region HAS_A_R
        //    public static void Main()
        //    {
        //        ///Arraylerle verdikde nece olur 

        //        Employee[] employees = new Employee[2];
        //        Task[] tasks = new Task[3];
        //        int i = 0;
        //        Console.WriteLine("Pls enter persons ");
        //        while (i < 2)
        //        {
        //            Console.Write("First name :");
        //            string firstName = Console.ReadLine();

        //            Console.Write("Last name :");
        //            string lastName = Console.ReadLine();

        //            Console.Write("Father name :");
        //            string fatherName = Console.ReadLine();

        //            Console.Write("Age :");
        //            int age = int.Parse(Console.ReadLine());

        //            Console.Write("Check gender :");
        //            string gender = Console.ReadLine();
        //            Console.WriteLine("###############");

        //            Employee person = new Employee(firstName, lastName, fatherName, age, gender);
        //            //{
        //            //    _firstName = ,
        //            //    _lastName = ,
        //            //    _fatherName = ,
        //            //    _age = ,
        //            //    _gender = 
        //            //};

        //            employees[i] = person;
        //            i++;
        //        }

        //        Console.WriteLine("Pls enter tasks :");
        //        int k = 0;
        //        while (k < 3)
        //        {
        //            Console.Write("Task Name :");
        //            string name = Console.ReadLine();

        //            Console.Write("Task Description :");
        //            string description = Console.ReadLine();

        //            Console.Write("Task Deadline :");
        //            string deadline = Console.ReadLine();

        //            Console.Write("Task Status :");
        //            string status = Console.ReadLine();

        //            Console.Write("EmployeeName (assign To) :");
        //            string employeeName = Console.ReadLine();
        //            Employee employee = null;
        //            Console.WriteLine("###################");

        //            foreach (Employee person in employees)
        //            {
        //                if (person._firstName == employeeName)
        //                {
        //                    employee = person;
        //                }
        //            }
        //            Task task = new Task(name, description, deadline, status, employee);
        //            Console.WriteLine("Task successfully added! ");
        //            Console.WriteLine();
        //            tasks[k] = task;
        //            k++;
        //        }
        //        Console.WriteLine("Tasks :");

        //        foreach (Task task in tasks)
        //        {
        //            Console.WriteLine($"Task name : {task._name}");
        //            Console.WriteLine($"Task description : {task._description}");
        //            Console.WriteLine($"Task deadline : {task._deadline}");
        //            Console.WriteLine($"Task status : {task._status}");
        //            Console.WriteLine($"Task owner : {task._assignedTo._firstName} {task._assignedTo._lastName}");
        //            Console.WriteLine();
        //        }


        //        //Employee person = new Employee
        //        //{
        //        //    _firstName = "Yusif",
        //        //    _lastName = "Huseynzade",
        //        //    _fatherName = "Raqub",
        //        //    _age = 25
        //        //};

        //        //Task task = new Task
        //        //{
        //        //    _name = "Mahmooooood Garibov to give task",
        //        //    _description = "Terminalda mezennelerin gosterilmesi",
        //        //    _deadline = "15.05.2023",
        //        //    _status = "OK",
        //        //    _assignedTo = person
        //        //};

        //        //Console.WriteLine(task);
        //        ////Console.WriteLine(employee._firstName);
        //        ////Console.WriteLine(employee._lastName);
        //        ////Console.WriteLine(employee._fatherName);
        //        ////Console.WriteLine(employee._age);
        //        ////Console.WriteLine(employee._gender);
        //        ////Console.WriteLine(employee._birthday);
        //        //Console.WriteLine();
        //        //Console.WriteLine($"Task name : {task._name}");
        //        //Console.WriteLine($"Task description : {task._description}");
        //        //Console.WriteLine($"Task deadline : {task._deadline}");
        //        //Console.WriteLine();
        //        //Console.WriteLine($"Task status : {task._status}");
        //        //Console.WriteLine($"Task owner : {task._assignedTo._firstName} {task._assignedTo._lastName}");



        //        //Employee employee = new Employee
        //        //{
        //        //    _firstName = "Yusif",
        //        //    _lastName = "Huseynzade",
        //        //    _fatherName = "Qulu",
        //        //    _age = 25,
        //        //    _gender = "Male",
        //        //    _birthday = "26.08.1998"
        //        //};
        //        //Task task = new Task
        //        //{
        //        //    _name = "Added task name all response",
        //        //    _description = "Add monitoring announcement year response",
        //        //    _deadLine = "06.04.2023",
        //        //    _status = "OK",
        //        //    _assignedTo = employee
        //        //};
        //        #endregion
        //    }

        //}
        #endregion

    }
    internal class Relation
    {
        //public class Employee
        //{
        //    public int _id;
        //    public string _firstName;
        //    public string _lastName;
        //    public string _fatherName;
        //    public int _age;
        //    public string _gender;

        //    public Employee(int id, string firstName, string lastName, string fatherName, int age, string gender)
        //    {
        //        _id = id;
        //        _firstName = firstName;
        //        _lastName = lastName;
        //        _fatherName = fatherName;
        //        _age = age;
        //        _gender = gender;
        //    }
        //}
        //public class Task
        //{
        //    public int _id;
        //    public string _name;
        //    public string _description;
        //    public string _deadline;
        //    public string _status;
        //    ///Created, In progress , Done
        //    public Employee _assignedTo; ///Biz bu yazilisa deyirik ki,HAS-A-RELATIONSHIP 

        //    public Task(int id, string name, string description, string deadline, string status, Employee assignedTo)
        //    {
        //        _id = id;
        //        _name = name;
        //        _description = description;
        //        _deadline = deadline;
        //        _status = status;
        //        _assignedTo = assignedTo;
        //    }


        //}
        ///// <summary>
        ///// Id with check has a 
        ///// </summary>
        //public class Program
        //{
        //    #region HAS_A_RRR
        //    public static void Main()
        //    {
        //        ///Arraylerle verdikde nece olur 

        //        Employee[] employees = new Employee[2];
        //        int lastEmployeeId = 1;

        //        Task[] tasks = new Task[3];
        //        int lastTaskId = 1;

        //        Console.WriteLine("Pls enter persons ");
        //        int i = 0;
        //        while (i < 2)
        //        {
        //            Console.Write("First name :");
        //            string firstName = Console.ReadLine();

        //            Console.Write("Last name :");
        //            string lastName = Console.ReadLine();

        //            Console.Write("Father name :");
        //            string fatherName = Console.ReadLine();

        //            Console.Write("Age :");
        //            int age = int.Parse(Console.ReadLine());

        //            Console.Write("Check gender :");
        //            string gender = Console.ReadLine();
        //            Console.WriteLine("###############");

        //            Employee person = new Employee(lastEmployeeId, firstName, lastName, fatherName, age, gender);
        //            employees[i] = person;
        //            i++;
        //            lastEmployeeId++;
        //        }

        //        Console.WriteLine("Pls enter tasks :");
        //        int k = 0;
        //        while (k < 3)
        //        {
        //            Console.Write("Task Name :");
        //            string name = Console.ReadLine();

        //            Console.Write("Task Description :");
        //            string description = Console.ReadLine();

        //            Console.Write("Task Deadline :");
        //            string deadline = Console.ReadLine();

        //            Console.Write("Task Status :");
        //            string status = Console.ReadLine();

        //            Console.Write("Employee id (assign To) :");
        //            int employeeId = int.Parse(Console.ReadLine());
        //            Employee employee = null;
        //            Console.WriteLine("###################");

        //            foreach (Employee person in employees)
        //            {
        //                if (person._id == employeeId)
        //                {
        //                    employee = person;
        //                }
        //            }
        //            Task task = new Task(lastTaskId, name, description, deadline, status, employee);
        //            Console.WriteLine("Task successfully added! ");
        //            Console.WriteLine();
        //            tasks[k] = task;
        //            k++;
        //            lastTaskId++;
        //        }
        //        Console.WriteLine("Tasks :");

        //        foreach (Task task in tasks)
        //        {
        //            Console.WriteLine($"Task Id : {task._id}");
        //            Console.WriteLine($"Task name : {task._name}");
        //            Console.WriteLine($"Task description : {task._description}");
        //            Console.WriteLine($"Task deadline : {task._deadline}");
        //            Console.WriteLine($"Task status : {task._status}");
        //            Console.WriteLine($"Task owner : {task._assignedTo._firstName} {task._assignedTo._lastName}");
        //            Console.WriteLine($"Task owner id : {task._assignedTo._id} ");
        //            Console.WriteLine();
        //        }
        //        #endregion
        //    }

    }
}

