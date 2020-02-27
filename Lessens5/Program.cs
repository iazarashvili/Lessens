using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace ConsoleApp1
{
    class Program
    {

        static void Main(string[] args)
        {
            string name = "Ilia";
            string surname = "Azarashvili";
            string whiteSpace = "   Ilia";

           
            Console.WriteLine(name.ToUpper());

        
            Console.WriteLine(name.ToLower());

            // white space
            Console.WriteLine(whiteSpace);
            Console.WriteLine(whiteSpace.Trim());

          
            Console.WriteLine(surname.IndexOf('l')); 
            Console.WriteLine(surname.LastIndexOf('r'));
            Console.WriteLine(surname.IndexOf("rash")); 

            //substrings
            var tbilisi = "tbilisi didi qalaqia";
            var bigCity = tbilisi.Substring(7, 7);
            Console.WriteLine(bigCity);

            string x = null; //null
            string y = "";  //empty
            string h = "    "; //whitespace

            if (String.IsNullOrEmpty(tbilisi))
                Console.WriteLine("no tbilisi");

            if (String.IsNullOrWhiteSpace(tbilisi))
                Console.WriteLine("no tbilisi");

            //split
            var splitted = tbilisi.Split(' ');
            foreach (var i in splitted)
            {
                Console.Write(i);
            }
            Console.WriteLine();

           
            string s = "12345";
            int another = Convert.ToInt32(s); 
            int number = int.Parse(s);
            string back = another.ToString(); 
            string formatString = another.ToString("C0"); 
            Console.WriteLine(formatString);
            
            //C - currency, D - decimal , E - exponential, F - fixed point, X - Hexadecimal



            Console.ReadKey();
        }
    }


}
