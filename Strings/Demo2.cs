using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Demo2
{
    static void Main()
    {
        string filename = @"C:\Pics\Summer2009.jpg";
        int index = filename.LastIndexOf(@"\");
        string nameAndExtension = filename.Substring(index + 1);

        Console.WriteLine(index);
        Console.WriteLine(nameAndExtension);
        // nameAndExtension is Summer2009.jpg
    }
}
