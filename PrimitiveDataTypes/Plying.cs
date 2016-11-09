using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Plying
{
    static void Main()
    {
        sbyte MinSByte = 0;
        byte ByteSize = 255;
        short ShortSize = -32768;
        ushort UshortSize = 65535;

        int IntegerMin = -2147483648;
        uint UIntMaxValue = 4294967295u;
        uint UIntMaxValUe = 4294967295U;

        int CastLong = 555555555;
        Console.WriteLine(ByteSize);

        long MaxLong = long.MaxValue;
        ulong MaxULong = ulong.MaxValue;

        Console.WriteLine(0.0f / 0.0f);
        Console.WriteLine(-1.0f / 0.0f);
        Console.WriteLine(1.0f / 0.0f);

        double Zero = Double.Epsilon;

    }
}

