using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace common
{ // its project only 
    internal class TypeB
    {
        public TypeB() 
        {
            TypeA typeA = new TypeA();
            //TypeA.x = 10;
            typeA.y = 1;
        }
    }
}
