using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            /*string author;
            string title;
            int price;



            Console.WriteLine("Press enter to add new book...");
            Console.ReadLine();

            Console.WriteLine("Title of the book:");
            title = Console.ReadLine();
            Console.WriteLine("Name of the author:");
            author = Console.ReadLine();
            Console.WriteLine("Price for the book:");
            price = int.Parse(Console.ReadLine());

            Console.WriteLine()*/

            

            Book book1 = new Book("Olli Jalonen", "Taivaanpallo", "00001", 24.95F);
            Console.WriteLine(book1.Kuvaus());

            Book book2 = new Book("Blake Crouch", "Pimeää ainetta", "00002", 29.99F);
            Console.WriteLine(book2.Kuvaus());

            Book book3 = new Book("Paula Hawkins", "Tummiin vesiin", "00003", 19.99F);
            Console.WriteLine(book3.Kuvaus());

            Console.WriteLine(book1.Vertailu(book2));

            Console.ReadLine();
        }
    }
}
