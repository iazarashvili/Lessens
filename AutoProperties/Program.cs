using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            Author author1 = new Author()
            {
                Name = "Jeffrey Richter",
                Book = "CLR va C#"
            };

            Author author2 = new Author()
            {

                Name = "Steve McConnel",
                Book = "Code Complete"
            };

            Console.WriteLine("Name : {0}, Book: {1}", author1.Name, author1.Book);
            Console.WriteLine("Name : {0}, Book: {1}", author2.Name, author2.Book);
            Console.WriteLine("Name");
        }
    }
}
