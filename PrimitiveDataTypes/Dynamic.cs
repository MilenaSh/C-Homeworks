using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstVariable
{
    class Dynamic
    {
        static void Main()
        {
            dynamic sth = 5;
            dynamic otherth = new object();

            Console.WriteLine(sth + otherth);

            //it will give an error. We lose the type safety of C#
            //we can change freely the types in one dynamic
        }
    }
}
