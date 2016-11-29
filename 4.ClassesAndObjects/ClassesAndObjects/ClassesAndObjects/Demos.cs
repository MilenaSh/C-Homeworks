using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
    class Demos
    {
        //the good practice for making new classes is in a separate file
        static void Main(string[] args)
        {
        }
    }

    class Cat
    {
        //we store data in a field.
        //the good practice is to make them private - not to be changeable from other people
        // private - only this class can access the data

        // 3 forward slashes for documentation of the code

        private string name;
        private int numOfPaws;
        private int age;
        private bool hasTail;
    }
}
