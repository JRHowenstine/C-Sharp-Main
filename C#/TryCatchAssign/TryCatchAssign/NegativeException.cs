using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchAssign
{
    public class NegativeException : Exception  //  inheirt from exception class
    {
        public NegativeException() // NegativeException uses base of Exception class 
           : base() { }
        public NegativeException(string message) // NegativeException uses base of Exception class with one string parameter
            : base(message) { }
    }
}
