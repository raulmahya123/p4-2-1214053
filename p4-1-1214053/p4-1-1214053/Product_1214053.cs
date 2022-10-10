using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace p4_1_1214053
{
    public class Product_1214053
    {
        //protected string myType = "Book";
        /*protecd tu hayang di dalam satu class */
        private string myType;
        private string myTitle;
        
        public Product_1214053()
        {

        }
        public Product_1214053(string type, string title)
        {
            this.myType = type;
            this.myTitle = title;
            
        }
        public string MyType
        {
            get
            {
                return myType;
            }
            set
            {
                myType = value;
            }
        }
        public string MyTitle
        {
            get
            {
                return myTitle;
            }
            set
            {
                myTitle = value;
            }
        }
    }
}
