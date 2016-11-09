using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class BitExchange
    {
    static void Main()
    {
        //read number
        uint number = uint.Parse(Console.ReadLine());
        
        //make mask for small numbers
        uint maskSmall = 7 << 3;

        //use mask with the number
        uint nAndSmallMask = number & maskSmall;

        //make mask for big numbers
        uint maskBig = 7 << 24;

        //use mask with the number
        uint nAndBigMask = number & maskBig;

        //use both masks with the number
        uint res = number & ~(maskSmall | maskBig);
        // Put bits 3, 4, and 5 in place
        res = res | nAndSmallMask << 21;
        // Put bits 23, 24, and 25 in place
        res = res | nAndBigMask >> 21;

        //Console.WriteLine(Convert.ToString(res, 2).PadLeft(32, '0'));
        Console.WriteLine(res);
    }
}

