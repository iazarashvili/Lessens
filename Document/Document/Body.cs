using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Document
{
    class Body
    {
        string content;

        public string Content
        {
            private get
            {
                if (content == null)
                {
                    return content;
                }
                else
                    return "is rac documentshia";
            }
                 set
            {
                content = value;
            }
        }
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(Content);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
