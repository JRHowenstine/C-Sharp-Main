using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodCallingSubAssign
{
    class mathOps
    {
        public int doMath1(int num1)  //  Create first method
        {
            int answer = num1 + 1;  //  Take user number add 1
            return answer;
        }

        public int doMath2(int num1)  //  Create second method
        {
            int answer = num1 * 2;  //  Take user number multiply by 2
            return answer;
        }

        public int doMath3(int num1)  //  Create third method
        {
            int answer = num1 - 3;  //  Take user number subtract 3
            return answer;
        }

    }
}
