using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ThreeNumbers
{
    static void Main()
    {


        string companyName = Console.ReadLine();
        string address = Console.ReadLine();
        string phone = Console.ReadLine();
        string fax = Console.ReadLine();
        string website = Console.ReadLine();
        string firstName = Console.ReadLine();
        string lastName = Console.ReadLine();
        string age = Console.ReadLine();
        string managerPhone = Console.ReadLine();

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine(companyName);
        Console.WriteLine("Address:" + " " + address);
        Console.WriteLine("Tel." + " " + phone);

        if (fax.Length == 0)
        {
            Console.WriteLine("Fax: (no fax)");
        }
        else
        {
            Console.WriteLine("Fax:" + " " + fax);
        }
        
        Console.WriteLine("Web site:" + " " + website);
        Console.WriteLine("Manager:" + " " + firstName + " " + lastName + " " + "(age:" + " " + age + ", " + "tel." + " " + managerPhone + ")");
        Console.WriteLine();
        Console.WriteLine();
    }
}

