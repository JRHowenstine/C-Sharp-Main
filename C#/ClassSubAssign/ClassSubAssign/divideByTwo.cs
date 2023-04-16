using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSubAssign
{
    class divideByTwo
    {
        public void divTwo(int numb1)
        {
            int numb2 = 2;  //  Set Value 
            int numb3 = numb1 / numb2;
            Console.WriteLine(numb3);  //  Output the result to console
        }

        public static void divTwo(out int numb1)  //  overloaded method with output parameters and declared static
        {
            numb1 = 1000;  //  Set values
            int numb2 = 2;
            int numb3 = numb1 / numb2;
            Console.WriteLine("If you divide {0} by {1} it equals {2}.", numb1, numb2, numb3);
        }
    }
}
