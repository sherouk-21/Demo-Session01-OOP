using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace common
{
    //its project and external project{import}
    public class TypeA
    {
        public TypeA() { 
        TypeB typeB=new TypeB();
        }
        private int x; //class scoop only 
       internal  int y;//class scoop and its project only
        public int z; //class scoop , its project, exeternal project"import"
        void Print()
        {
            Console.WriteLine(x);
            Console.WriteLine(y);
        }

    }
    
    
}
