using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassSubAssign
{
    public class Employee : Person  //  Inherit from the Person class
    {
        public override void SayName()  // inherit and override the SayName() method
        {
            Console.WriteLine("Employee: ");
            base.SayName();
        }

    }
}
