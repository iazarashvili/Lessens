using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethods
{
    class MyClass
    {
        private string field = null;

        //public string Field
        //{

        //    set
        //    {
        //        if (value == "fool")
        //        {
        //            Console.WriteLine("sheyvanili sityva daushvebelia");
        //        }
        //        else
        //            field = value;
        //    }

        //    get
        //    {
        //        if (field == null)
        //        {
        //            return "carielia";
        //        }
        //        else if (field == "hello world")
        //        {
        //            return field.ToUpper() + "!";
        //        }
        //        else
        //        {
        //            return field;
        //        }
        //    }
        //}

        //public void SetField(string value)
        //{
        //    field = value;
        //}

        //public string GetField()
        //{
        //    return field;
        //}

        public string Field
        {
            get
            {
                return field;
            }
            set
            {
                field = value;
            }
        }


    }
}
