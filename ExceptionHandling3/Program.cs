using System;
using System.Collections;
using System.Text.RegularExpressions;


namespace ExceptionHandling3
{
    class Program
    {
        static void Main(string[] args)
        {
            Department app = new Department();
            Console.WriteLine("welcome to employee and department facilities ");
            Console.WriteLine("Choose any one of the following");
            Console.WriteLine("1. Register Employee");
            Console.WriteLine("2. Search Employee");
            Console.WriteLine("3. Search Departmenrt");

            while (true)
            {
                Console.WriteLine("Enter your Choice : ");
                int choice = Convert.ToInt32(Console.ReadLine());

                try
                {
                    switch (choice)
                    {
                        case 1:
                            Employee emp = new Employee();
                            app.RegisterEmp(emp);
                            break;

                        case 2:
                            Console.WriteLine("Enter the employee name to search : ");
                            string empName = Console.ReadLine();
                            app.SearchEmployee(empName);
                            break;

                        case 3:
                            Console.WriteLine("Enter the Department Name :");
                            string DepName = Console.ReadLine();
                            app.searchDepartment(DepName);
                            break;

                    }

                }
                catch (InvalidEmpNameException ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
                catch (EmployeeNotFoundException ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
                catch (DepartmentNotFoundException ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
                Console.ReadLine();
            }         

        }

    }
    
    public class InvalidEmpNameException : Exception
    {
        public InvalidEmpNameException() : base("Invalid employee name. Employee name cannot contain special characters or numeric values."){ }
        public InvalidEmpNameException(string message) : base(message){}
    }

    public class DepartmentNotFoundException : Exception
    {
        public DepartmentNotFoundException() : base("Invalid Department name please enter valid department name"){}
        public DepartmentNotFoundException(string message) : base(message){}
    }

    public class EmployeeNotFoundException : Exception
    {
        public EmployeeNotFoundException() : base("there is no such employee present plz enter valid employee name") { }
        public EmployeeNotFoundException(string message) : base(message) { }
    }
}

