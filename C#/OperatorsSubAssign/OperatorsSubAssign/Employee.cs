using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsSubAssign
{
    public class Employee
    {
        public string firstName { get; set; }  //  Defining Properties
        public string lastName { get; set; }
        public int employeeID { get; set; }

        public Employee(string firstName, string lastName, int employeeID)  //  Defining objects
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.employeeID = employeeID;
        }

        public static bool operator ==(Employee employee, Employee employee2)  //  Overloading operator to compare employee ids
        {
            if (employee.employeeID == employee2.employeeID)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator !=(Employee employee, Employee employee2)  //  Overloaded comparison operator pair
        {
            if (employee.employeeID != employee2.employeeID)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
