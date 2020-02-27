using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();

            //myClass.SetField("rao gogo");

            //string saxeli = myClass.GetField();

            //Console.WriteLine(saxeli);

            myClass.Field = "ilia";
            Console.WriteLine(myClass.Field);

            myClass.Field = "rao patara";
            Console.WriteLine(myClass.Field);

            Console.WriteLine(new string('-', 29));

            myClass.Field = "hello world";
            Console.WriteLine(myClass.Field);
        }
    }
}
