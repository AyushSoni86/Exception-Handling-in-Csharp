using ExceptionHandling3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ExceptionHandling3
{
    class Employee
    {
        public string name;
        public int empId;
        public string dept;
        public Employee()
        {
            Console.WriteLine("Employee Registration Form");
            Console.WriteLine("--------------------------");

            EnterName();
            EnterEmpId();
            EnterDept();
        }

        public Employee(string name, int empId, string dept)
        {
            this.name = name;
            this.empId = empId;
            this.dept = dept;
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
}
