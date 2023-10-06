using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling3
{
    class Department
    {
        public string[] dept;
        public ArrayList empList = new ArrayList();

        public Department()
        {
            this.dept = new String[] { "Account", "Sales", "Research", "Operations" };
            this.empList.Add(new Employee("Ayush", 10, "Boss"));
        }

        public Department(string[] dept)
        {
            this.dept = dept;
        }

        public void RegisterEmp(Employee emp)
        {
            if (IsPresent(emp.dept))
            {
            empList.Add(emp);
            Console.WriteLine("Employee Registered successfully : " + emp.name);

            }
            else
            {
                throw new DepartmentNotFoundException("No such department exists");
            }
        }

        private bool IsPresent(string edept)
        {
            foreach (String item in dept)
            {
                if (item == edept) return true;
            }
            return false;
        }

        public void ShowAllEmp()
        {
            Console.WriteLine(empList.Count);
            Console.WriteLine(empList);
        }

        public void SearchEmployee(string name)
        {
            bool ispresent = false;
            foreach (Employee emp in empList)
            {
                if (emp.name == name)
                {
                    ispresent = true;
                    Console.WriteLine(emp.name + "\t" + emp.dept + "\t" + emp.empId);
                }
            }
            if (ispresent == false)
            {
                throw new EmployeeNotFoundException("Employee not present in the database");
            }
        }



        public void searchDepartment(string name)
        {
            bool ispresent = false;
            foreach (string de in dept)
            {
                if (de == name)
                {
                    ispresent = true;
                }
            }
            if (ispresent == false)
            { 
                throw new DepartmentNotFoundException("No such Department exist");
            }
        }
    }
}
