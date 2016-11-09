using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class FourDigits
{
    static void Main()
    {

        int number = int.Parse(Console.ReadLine());

        int digitFourth = number % 10;

        int digitThirthOne = number / 10;
        int digitThirth = digitThirthOne % 10;

        int digitSecondOne = digitThirthOne / 10;
        int digitSecond = digitSecondOne % 10;

        int digitFirstOne = digitSecondOne / 10;
        int digitFirst = digitFirstOne % 10;



        Console.WriteLine(digitFirst + digitSecond + digitThirth + digitFourth);

        int result2 = digitFourth * 1000 + digitThirth * 100 + digitSecond * 10 + digitFirst;
        Console.WriteLine("{0:0000}",result2);

        int result3 = digitFourth * 1000 + digitFirst * 100 + digitSecond * 10 + digitThirth;
        Console.WriteLine("{0:0000}", result3);

        int result4 = digitFirst * 1000 + digitThirth * 100 + digitSecond * 10 + digitFourth;
        Console.WriteLine("{0:0000}", result4);

    }
}

