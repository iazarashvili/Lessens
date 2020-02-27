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
            prod.Code = "AAA";
            var search = new SearchProducts(new ProductData().Products);
            //string code = Console.ReadLine().ToUpper().Trim();
            //search.SearchProduct("AAA");
            Console.WriteLine(search.SearchProduct(prod.Code));
            Console.WriteLine(search.SearchCode("Twix"));
            Console.ReadLine();
        }
    }

    public class Products
    {

        public string ProductName { get; set; }
        public ProductCode ProductCode { get; set; }
    }
    public class ProductCode
    {
        public string Code { get; set; }
        public Products Products { get; set; }
    }

    public class SearchProducts
    {
        private List<ProductCode> data;
        public SearchProducts(List<ProductCode> data)
        {
            this.data = data;

        }
        
        public  string SearchProduct(string kodi)
        {
            foreach (var saxeli in data)
            {
                if (saxeli.Code == kodi)
                {
                    return saxeli.Products.ProductName;
                }
            }
            return null;
        }

        public string SearchCode(string model)
        {
            foreach (var code in data)
            {
                if (code.Products.ProductName == model)
                {
                    return code.Code;
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




