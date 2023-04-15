using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodSubAssign2
{
    class doubleInt
    {
        public static int optionalArgs(int userNum1, int optNum1 = 10)  // create class with second argument set with default so is optional
        {
            int result = userNum1 * optNum1;  //  Set method to multiply arguments and return integer answer
            return result;
        }
    }
}
