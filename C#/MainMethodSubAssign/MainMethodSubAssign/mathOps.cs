using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodSubAssign
{
    class mathOps
    {
        public int doMath(int num1)  //  Method used if integer argument
        {
            int answer = num1 + 1;
            return answer;
        }

        public int doMath(decimal num1)  //  Method used if decimal argument
        {
            int answer = Convert.ToInt32(num1) * 2;
            return answer;
        }

        public int doMath(string num1)  //  Method used if string argument
        {
            int answer = Convert.ToInt32(num1) - 3;
            return answer;
        }
    }
}
