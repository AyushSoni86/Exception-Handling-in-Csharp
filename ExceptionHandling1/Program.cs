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
                Employee employee = new Employee("ayu2sh soni", 10);
                Console.WriteLine("Employee name is valid.");
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
        public Employee() { }

        public Employee(string name, int empId)
        {
            if (!isValidName(name))
            {
                throw new InvalidEmpNameException("Employee name is not valid.");
            }
            this.name = name; 
            this.empId = empId;
        }

        public static bool isValidName(string name)
        {
            string pattern = "^[a-zA-Z ]+$";
            return Regex.IsMatch(name, pattern);      
        }
    }

}
