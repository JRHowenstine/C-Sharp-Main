using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClassSubAssign
{
    class voidMethod
    {
        public static void voidMeth(int num1, int num2 )
        {
            int mathOp = num1 + 10;
            Console.WriteLine("{0} is your first number plus 10, {1} is your second number.", mathOp, num2);
            Console.ReadLine();
        }
    }
}
