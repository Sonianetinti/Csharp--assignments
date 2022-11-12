using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class AssignQ6
    {
        public struct Book
        {
            public int iBookid,iBookType;
            public string strBooktitle;
            public double dprice;

        }
        public enum BookType
        {
            Mazagine=1,
            Novels=2,
            Referenebook=3,
            Misellonories=4

        }

        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Enter the book details:");
            Book B;
            B.iBookid = Convert.ToInt32(Console.ReadLine());
            B.strBooktitle = (Console.ReadLine());
            B.iBookType = Convert.ToInt32(Console.ReadLine());
            B.dprice = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Details of the book");
            Console.WriteLine("Id of the book:"+ B.iBookid);
            Console.WriteLine("title of the book:"+B.strBooktitle);
            Console.WriteLine("price of the book:"+B.dprice  );
            string strBooktype = Enum.GetName(typeof(BookType), B.iBookType);
            Console.WriteLine("book type:" + strBooktype);



            //Console.WriteLine("type of the book");
            Console.ReadKey();

        }
        

      
       









    }
}
