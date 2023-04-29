using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchAssign
{
    public class ZeroException : Exception  //  inheirt from exception class
    {
        public ZeroException()  //  ZeroException inherits base from Exception class
            : base() { }
        public ZeroException(string message)  //  ZeroException uses base of Exception class with one string parameter
            : base(message) { }
    }
}
