using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p4_1_1214053
{
    internal class ProductTest_1214053
    {
        static void Main(string[] args)
        {
            /*Product_1214053 myProduct = new Product_1214053();

            myProduct.MyType = "DVD";

            Console.WriteLine(myProduct.MyType);*/

            Book_1214053 product1 = new Book_1214053("book", "C# OPP", "300");
            DVD_1214053 product2 = new DVD_1214053("she hhuls", "110");
            Console.WriteLine("product 1 is {0} called \"{1}\" and has {2} pages", product1.MyType, product1.MyTitle,product1.PageCount);
            Console.WriteLine("product 2 is {0} called \"{1}\" and has {2} duration", product2.MyType, product2.MyTitle, product2.Duration);

            //Console.WriteLine("\" the book {0} has {1} pages\"", myBook.MyTitle, myBook.PageCount);
        }
    }
}
