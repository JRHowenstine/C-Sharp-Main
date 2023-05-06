using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorSubAssign
{
    class Class1
    {
        public string Name { get; set; }
        public int Purse { get; set; }


        public Class1(string name, int purse)
        {
            Name = name;
            Purse = purse;
        }

        public Class1(string name) : this(name, 100)
        {
        }
    }
}
