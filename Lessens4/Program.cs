using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessens4
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Ilia";
            string surname = "azarashvili";

            //sityvis gaertianeba
            string gaertianeba = $"{name} {surname}";
            Console.WriteLine(gaertianeba);

            int[] array = { 1, 5, 7, 99 };
            string list = string.Join(";", array);
            Console.WriteLine("List: " + list);

            char initialName = name[0];
            char initialSurname = surname[0];
            Console.WriteLine($"Initials: {initialName}{initialSurname}");

            //name[0] = 'q'; 

            string newLine = "Hello, \n my name is Yuri";
            string newLineEnvironment = "Hello" + Environment.NewLine + "my name is Yuri.";
            Console.WriteLine("New Line Example");
            Console.WriteLine(newLine);
            Console.WriteLine(newLineEnvironment);

            Console.WriteLine("Tab Example");
            string tab = "Hello, \t \t \t my name is Yuri";
            Console.WriteLine(tab);

            Console.WriteLine("Äðóãèå");
            string other = "\'Hello, \\ my name is Yuri\"";
            Console.WriteLine(other);

            Console.WriteLine("Paths Verbatim Strings");
            string pathMessy = "c:\\programfiles\\myprogram\\good";
            string path = @"c:\programfiles\myprogram\good";
            Console.WriteLine(path);

        }
    }
}
