using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home3
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book();
            book1.title = "The Sealed Nector";
            book1.Author = "Safiur Rahman Mubarakpuri";
            book1.ISBN = "9786035001106";
            book1.Price = 4500;

            book1.DisplayDatail();
            book1.ApplyDiscount(10);
        }
    }
}
