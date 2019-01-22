using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    class Book
    {

        public string bookAuthor;
        public string bookTitle;
        public string bookId;
        public float bookPrice;


        public Book(string bookAuthor, string bookTitle, string bookId, float bookPrice)
        {
            this.bookAuthor = bookAuthor;
            this.bookTitle = bookTitle;
            this.bookId = bookId;
            this.bookPrice = bookPrice;
        }

        public string Kuvaus()
        {
            return ID + " " + Author + " " + Title + " " + string.Format("{0:0.00}",Price);
        }

        public string Title
        {
            get { return bookTitle; }
            set { bookTitle = value; }
        }

        public string Author
        {
            get { return bookAuthor; }
            set { bookAuthor = value; }
        }

        public float Price
        {
            get { return bookPrice; }
            set { bookPrice = value; }
        }

        public string ID
        {
            get { return bookId; }
            set { bookId = value; }
        }


        public string Vertailu(Book book)
        {
            if (this.bookPrice > book.bookPrice)
                return $"{this.bookTitle} on kalliimpi kuin {book.bookTitle}";

            if (this.bookPrice < book.bookPrice)
                return $"{this.bookTitle} on halvempi kuin {book.bookTitle}";

            if (this.bookPrice == book.bookPrice)
                return $"{this.bookTitle} on halvempi kuin {book.bookTitle}";
            return "";

        }
    }
}
