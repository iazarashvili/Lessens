using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Document
{
    class Document
    {
        Title title = null;
        Footer footer = null;
        Body body = null;

        public void Initializer()
        {
            this.body = new Body();
            this.title = new Title();
            this.footer = new Footer();
        }

        public Document(string title)
        {
            Initializer();
            this.title.Content = title;
        }

        public void Show()
        {
            this.title.Show();
            this.footer.Show();
            this.body.Show();
        }

        public string Body
        {
            set
            {
                this.body.Content = value;
            }
        }
        public string Footer
        {
            set
            {
                this.footer.Content = value;
            }
        }
    }
}
