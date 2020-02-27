using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Document
{
    class Program
    {
        static void Main(string[] args)
        {
            Document document = new Document("Satauri");
            document.Body = "rao patara";
            document.Footer = "aba wavida wavida";
            document.Show();
        }
    }
}
