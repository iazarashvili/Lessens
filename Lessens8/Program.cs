using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.IO;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {

        static void Main(string[] args)
        {
            var prod = new ProductCode();
            Console.WriteLine("produqtis dzebna sheiyvane 'AAA' an 'BBB' ");
            string code = Console.ReadLine().ToUpper().Trim();

            Console.WriteLine(SearchProducts.SearchProduct(prod.Code = code));

            Console.ReadLine();
        }
    }

    public class Products {

        public string ProductName { get; set; }
        public ProductCode ProductCode { get; set; }
    }
    public class ProductCode
    {
        public string Code { get; set; }
        public Products Products {get; set;}
    }

    public class SearchProducts
    {
         public static string SearchProduct(string kodi)
        {
            var ProdBaza = new ProductData();

            foreach (var saxeli in ProdBaza.Products)
            {
                if (saxeli.Code == kodi)
                {
                    return saxeli.Products.ProductName;
                }
            }
            return null;
        }
    }

    public class ProductData
    {
        public List<ProductCode> Products = new List<ProductCode>
       {
           new ProductCode() {Code = "AAA", Products = new Products() {ProductName = "Twix" } },
           new ProductCode() {Code = "BBB", Products = new Products() {ProductName = "Albina" } }
       };
    }
}




