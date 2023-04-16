using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassSubAssign
{
    public class Employee : Person, IQuittable  //  Inherit from the Person class and the IQuittable interface
    {
        public override void SayName()  // inherit and override the SayName() method
        {
            Console.WriteLine("Employee: ");
            base.SayName();
        }

        public void Quit()  //  Defining quit() method for this class
        {
            Console.WriteLine("Quit");
        }

    }
}
