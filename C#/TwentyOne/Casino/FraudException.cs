using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    public class FraudException : Exception  //  Inherit from Exception
    {
        public FraudException()
            : base() { }  //  Inheriting from base exception
        public FraudException(string message)  //  overloading the exception method
            : base(message) { }

    }
}
