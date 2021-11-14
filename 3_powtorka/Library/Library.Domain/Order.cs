using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Domain
{
    public class Order
    {
        public DateTime Date { get; set; }
        public List<BookOrdered> BooksOrderedList { get; set; }

        public Order()
        {
            Date = DateTime.Now;
            BooksOrderedList = new List<BookOrdered>();
        }

        public override string ToString()
        {
            var str = $"Order: {this.Date}";
            foreach (var item in this.BooksOrderedList)
            {
                str += $"Book: {item.BookId} Count: {item.NumerOrdered} ";
            }

            return str;
        }



    }
}
