namespace The_Last_13_Lessons
{
    internal class Program
    {
        public class Employee
        {
            public string _firstName;
            public string _lastName;
            public string _fatherName;
            public int _age;
            public string _gender;
            public string _birthday;
            public string _city;


        }
        public class Task
        {
            public string _id;
            public string _name;
                    

        }
        public static void Main(string[] args)
        {
            #region 18.Has-a-RelationShip
            Employee employee = new Employee
            {
                _firstName = "Yusif",
                _lastName = "Huseynzade",
                _fatherName = "Qulu",
                _age = 25,
                _gender = "Male",
                _birthday = "26.08.1998"
            };
            Console.WriteLine(employee._firstName);
            Console.WriteLine(employee._lastName);
            Console.WriteLine(employee._fatherName);
            Console.WriteLine(employee._age);
            Console.WriteLine(employee._gender);
            Console.WriteLine(employee._birthday);


            #endregion 






        }

    }
}