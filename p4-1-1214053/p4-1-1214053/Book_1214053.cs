using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p4_1_1214053
{
    internal class Book_1214053 : Product_1214053
    {
        protected string pageCount;

        public Book_1214053(string type, string title, string pagecount) : base(type, title)
            
        {
            this.pageCount = pagecount;
        }
        public string PageCount
        {
            get { return pageCount; }
            set { pageCount = value; }
        }
    }
}
