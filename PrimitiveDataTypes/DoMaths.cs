using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstVariable
{
    class DoMaths
    {
        static void Main()
        {
            double a = 0.33f;
            double b = 1.0f;
            double sum = 1.33f;

            Console.WriteLine(a + b == sum);

            float aa = 0.33f;
            float bb = 1.0f;
            float summ = 1.33f;

            Console.WriteLine(aa + bb == summ);

            double myWeight = 50.50000002;
            double yourWeight = 50.500005;

            double difference = myWeight - yourWeight;
            bool areEqual = difference < 0.00001;

            Console.WriteLine(areEqual);

            decimal c = 0.33m;
            decimal d = 1.0m;
            decimal all = 1.33m;

            Console.WriteLine(c + d == all);
        }
    }
}
