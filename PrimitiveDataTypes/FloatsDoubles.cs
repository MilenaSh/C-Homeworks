using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstVariable
{
    class FloatsDoubles
    {
        static void Main()
        {
            float myMoney = 10.5f;
            //f is literal - using syntax to create a specific value
            double yourMoney = 0.5;
            double hisMoney = 0.9f;
            double yourMoneyy = 0.5 / 0;

            //when deviding to 0 we don't actualy divide to 0 

            Console.WriteLine(yourMoney * 0);

            float floatPi = 3.141592653589793238f;
            double doublePi = 3.141592653589793238;

            Console.WriteLine(floatPi);
            Console.WriteLine(doublePi);

            //double gives greater precision

        }
    }
}
