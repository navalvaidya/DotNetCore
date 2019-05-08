using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomTagHelpersDemo
{
    public class EmployeeFactory
    {

        public static List<Employee> GetEmployees()
        {
            List<Employee> emps = new List<Employee>();
            for(int i = 0; i < 20; i++)
            {
                emps.Add(new Employee
                {
                    Id = 100 + i,
                    Name = "Employee" + i.ToString(),
                    DOB = DateTime.Now.AddYears(-18 - i)

                });
            }
            return emps;
        }
        

    }

    public class Employee
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime DOB { get; set; }

    }
}


