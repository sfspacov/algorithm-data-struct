using System;
using System.Collections.Generic;

namespace Algorithms {
    class Employee {

        string name;
        int id;
        string department;

        public Employee(string name, int id, string department) {
            this.name = name;
            this.id = id;
            this.department = department;
        }

        static void Main(string[] args) {
            var employee = new Employee("Robby", 3827, "Technology");
            var employee2 = new Employee("Bobby", 9415, "Marketing");
            var employee3 = new Employee("Sally", 2519, "Sales");

            //Run-time exception if try to add repetead key
            var employeesById = new Dictionary<int, Employee>();
            employeesById.Add(employee.id, employee);
            employeesById.Add(employee2.id, employee2);
            employeesById.Add(employee3.id, employee3);

            Employee e;
            if (employeesById.TryGetValue(3827, out e))
                Console.WriteLine($"{e.name}: {e.department}");
            
            var productCodes = new HashSet<string>();
            productCodes.Add("KUW92JW");
            productCodes.Add("67W8OJJ");
            //No exception if try to add repetead value. Just don't add it
            productCodes.Add("67W8OJJ");

            Console.WriteLine(productCodes.Contains("67W8OJJ"));
            Console.WriteLine(productCodes.Contains("68W8OJJ"));
        }
    }
}