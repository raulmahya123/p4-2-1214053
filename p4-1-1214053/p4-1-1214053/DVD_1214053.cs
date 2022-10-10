using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p4_1_1214053
{
    internal class DVD_1214053 : Product_1214053
    {
        protected String duration;

        public DVD_1214053(string title, string duration) //method dengan construktor pake 2 parameter
        {
            this.MyTitle = title;
            this.MyType = "DVD";
            this.duration = duration;

            Console.WriteLine("ini dari class dvd");
        }
        public string Duration
        {
            get { return duration; }
            set { duration = value; }
        }
    }
}
