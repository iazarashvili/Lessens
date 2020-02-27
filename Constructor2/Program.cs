using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor2
{
    class Program
    {
        static void Main(string[] args)
        {
            Point point = new Point("A");
            Console.WriteLine("{0}.X = {1}, {0}.Y = {2}",point.Name ,point.X, point.Y);

            // clasis metodis gadacema meore klasistvis

            MyClass my = new MyClass();

            Myclass2 myclass2 = new Myclass2();

            myclass2.CallMethod(my);
        }
    }

    // clasis metodis gadacema meore klasistvis

    class MyClass
    {
        public void Method()
        {
            Console.WriteLine("pirveli klasis metodi");
        }
    }
    class Myclass2
    {
        public void CallMethod(MyClass my)
        {
            my.Method();
        }
    }
}
