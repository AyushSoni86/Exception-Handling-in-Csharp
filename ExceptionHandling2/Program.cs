using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ExceptionHandling1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Employee employee = new Employee();
                Department department = new Department();
                department.RegisterEmp(employee);
            }
            catch (InvalidEmpNameException ex)
            {
                Console.WriteLine($"Invalid employee name: {ex}");
            }


           

            Console.ReadLine();

        }
    }

    class InvalidEmpNameException : Exception
    {
        public InvalidEmpNameException(string msg) : base(msg)
        {

        }

    }

    class Employee
    {
        public string name;
        public int empId;
        public string dept;
        public Employee() {
            Console.WriteLine("Employee Registration Form");
            Console.WriteLine("--------------------------");

            EnterName();
            EnterEmpId();
            EnterDept();
        }


        public static bool isValidName(string name)
        {
            string pattern = "^[a-zA-Z ]+$";
            return Regex.IsMatch(name, pattern);
        }

        void EnterName()
        {
            Console.Write("Enter employee name: ");
            this.name = Console.ReadLine();
            if (!isValidName(name))
            {
                throw new InvalidEmpNameException("Employee name is not valid.");
            }
        }

        void EnterEmpId()
        {
            Console.Write("Enter employee ID: ");
            this.empId = Convert.ToInt32(Console.ReadLine());
        }

        void EnterDept()
        {
            Console.Write("Enter department: ");
            this.dept = Console.ReadLine();
        }

    }

    class Department
    {
        public string[] dept;

        public Department() {
            this.dept = new String []{ "Account", "Sales", "Research", "Operations" };
        }

        public Department(string[] dept)
        {
            this.dept = dept;
        }

        public void RegisterEmp(Employee emp)
        {
            Console.WriteLine("Employee Registered successfully : "+ emp.name);
        }

        
    }
}
