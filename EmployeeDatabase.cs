using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA_MethodOverloading_StephanieLopez
{
    public class EmployeeDatabase
    {
            // Overloaded method that adds an employee with just a name
            public void AddEmployee(string name)
            {
                Console.WriteLine($"Added employee: {name}");
            }

            // Overloaded method that adds an employee with name and age
            public void AddEmployee(string name, int age)
            {
                Console.WriteLine($"Added employee: {name}, Age: {age}");
            }

            // Overloaded method that adds an employee with name, age, and department
            public void AddEmployee(string name, int age, string department)
            {
                Console.WriteLine($"Added employee: {name}, Age: {age}, Department: {department}");
            }
    }
}
