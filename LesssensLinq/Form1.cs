using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LesssensLinq
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var list = new List<string>
            {
               "ilia",
               "bequnia",
               "jay",

            };

            label1.Text = list.Aggregate("slava", (x, y) => y.Length > x.Length ? y : x);
            

            //var newlist = list.Where(x => new Ping().Send(x).RoundtripTime < 50);
            //label1.Text = string.Join(Environment.NewLine, newlist);


            //var newlist = list.Select(x => $"{x} {new Ping().Send(x).RoundtripTime}");
            //label1.Text += new Ping().Send(list[0]).RoundtripTime.ToString();
            //list.AsParallel().ForAll(x => File.Delete(x));

            //Enumerable.Range(0, 3).AsParallel().ForAll(x => File.Delete(list[x]));


            //var newlist = list.GroupBy(g => g).Where(g => g.Count()> 1).Select(g => g.Key); //gamoitans dublikats romelic meordeba


            //int i = 1;
            //var newlist = list.Select(x => $"{i++}  {x}");  //danomrva

            //var newlist = list.Select(x => x.Contains("o"));

            //var newlist = list.Where(x => x.Contains("o"));

            //var newlist = new List<string>();  //tu sheicavs o asos amatebs listshi
            //foreach(string line in list)
            //{
            //    if (line.Contains("o"))
            //    {
            //        newlist.Add(line);
            //    }
            //}

            /*var newlist = list.Union(list2);*/ //gaerTianeba listebis
            /* var newlist = list.Skip(1).Distinct();*/ // pirveli elementis gamotoveba da dublikatebis washla
                                                        //Array.Reverse(array); //amotrialebuli 
                                                        //List<string> newlist = array.Reverse().ToList();
                                                        //var newlist = array.Reverse();

            //label1.Text = string.Join(Environment.NewLine, newlist);
        }

        
    }
}
