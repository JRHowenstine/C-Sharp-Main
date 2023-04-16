using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassSubAssign
{
    public abstract class Person  //  Define the abstract class
    {
        public string firstName { get; set; }
        public string lastName { get; set; }

        public virtual void SayName()  // Define a virtual method to be inherited
        {
            Console.WriteLine(firstName + " " + lastName);
        }
    }
}
