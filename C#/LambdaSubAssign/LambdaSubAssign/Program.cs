using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaSubAssign
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Employee> employees = new List<Employee>();  //  Instantiating a new list of employees

            Employee employee1 = new Employee();  //  Create 10 objects of employee class
            employee1.FirstName = "Joe";
            employee1.LastName = "Schmoe";
            employee1.Id = 01;
            employees.Add(employee1);

            Employee employee2 = new Employee();
            employee2.FirstName = "Joe";
            employee2.LastName = "Bubblegum";
            employee2.Id = 02;
            employees.Add(employee2);

            Employee employee3 = new Employee();
            employee3.FirstName = "Frank";
            employee3.LastName = "Sinatra";
            employee3.Id = 03;
            employees.Add(employee3);

            Employee employee4 = new Employee();
            employee4.FirstName = "Chelsea";
            employee4.LastName = "Butler";
            employee4.Id = 04;
            employees.Add(employee4);

            Employee employee5 = new Employee();
            employee5.FirstName = "Abigail";
            employee5.LastName = "Baldwin";
            employee5.Id = 05;
            employees.Add(employee5);

            Employee employee6 = new Employee();
            employee6.FirstName = "Richard";
            employee6.LastName = "Osman";
            employee6.Id = 06;
            employees.Add(employee6);

            Employee employee7 = new Employee();
            employee7.FirstName = "Richard";
            employee7.LastName = "Ayoade";
            employee7.Id = 07;
            employees.Add(employee7);

            Employee employee8 = new Employee();
            employee8.FirstName = "Dara";
            employee8.LastName = "O'Briian";
            employee8.Id = 08;
            employees.Add(employee8);

            Employee employee9 = new Employee();
            employee9.FirstName = "Greg";
            employee9.LastName = "Davies";
            employee9.Id = 09;
            employees.Add(employee9);

            Employee employee10 = new Employee();
            employee10.FirstName = "Mae";
            employee10.LastName = "Martin";
            employee10.Id = 10;
            employees.Add(employee10);

            List<Employee> joeList = new List<Employee>();  //  Instantiate a new list that will be populated from the foreach loop

            foreach (Employee employee in employees)  // Use a foreach loop to find all the employees with first name Joe and populate the new list
            {
                if (employee.FirstName == "Joe")
                {
                    joeList.Add(employee);
                }
            }

            List<Employee> lambdaList = employees.Where(x => x.FirstName == "Joe").ToList();  // Use a lambda expression to find all the employees with first name Joe and populate the new list

            List<Employee> lambdaList1 = employees.Where(x => x.Id > 5).ToList();  // Use a lambda expression to find all the employees with Id greater than 5 and populate the new list

        }
    }
}
