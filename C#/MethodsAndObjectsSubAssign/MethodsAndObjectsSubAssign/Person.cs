using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjectsSubAssign
{
    public class Person  // Create what will be a superclass for another class
    {
        public string FirstName { get; set; }  //  State properties of the class
        public string LastName { get; set; }

        public void SayName()  //  Create a method to print out full name
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }
    }
}
