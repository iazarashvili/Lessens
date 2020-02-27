using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessens11
{
    class Program
    {
        static void Main(string[] args)
        {
            var per = new Person("ilia", new DateTime (1989, 01, 11));
            Console.WriteLine(per.Age + " " + per.Name );
            
           
        }
    }
    class Person
    {
        public string Name { get; private set; }
        public DateTime BirtDate { get; private set; }

        public Person(string name, DateTime birtdate)
        {
            Name = name;
            BirtDate = birtdate;
        }
        public int Age
        {
            get
            {
                var span = DateTime.Now - BirtDate;
                return span.Days / 365;
            }
        }


    }
}
