using System;

namespace MyFirstVariable
{
    class Startup
    {
        static void Main()
        {
            DateTime today = DateTime.Today;
            int age = 0;
            //default value is 0 but it is better to always define a value
            Console.WriteLine(today);

            int max = int.MaxValue;
            int min = int.MinValue;
            Console.WriteLine(max);
            Console.WriteLine(min);

            byte maxbyte = byte.MaxValue;
            byte minbyte = byte.MinValue;
            Console.Write(maxbyte);
            Console.Write(minbyte);

            //converting

            int Age = 500;
            byte byteAge = (byte)Age;

            //if printed it will be cut
        }
    }
}
