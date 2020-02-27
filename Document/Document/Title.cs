using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Document
{
    class Title
    {
        string content;

        public string Content
        {
            private get
            {
                if (content != null)
                {
                    return content;
                }
                else
                    return "satauri ar gvaqvs";
            }

            set
            {
                content = value;
            }
        }
        public void Show()
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine(content);
        }
    }
}
