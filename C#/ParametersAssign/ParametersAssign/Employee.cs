using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParametersAssign
{
    public class Employee<T>
    {
        public List<T> things { get; set; } // Define the class object to be a list with as yet unspecified data type
    }
}
