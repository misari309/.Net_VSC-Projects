using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleObject_CSharp__1
{
    internal class ClassA
    {
        private string var1;
        public string Var1 
        {
            get { return var1; } 
            set { var1 = value; }
        }

        private string var2;
        public string Var2 
        {
            get { return var2; } 
            set { var2 = value; }
        }
        public ClassA() 
        { 
            
        }
        public ClassA(String var1, String var2)
        {
            this.var1 = var1;
            this.var2 = var2;        
        }

    }
}
