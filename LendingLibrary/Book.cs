using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LendingLibrary
{
    public class Book
    {
        public int BookNumber { get; }

        public string Title { get; }

        public BookCategory Category { get; }

        public Book(
            int bookNumber,
            string title,
            BookCategory category)
        {
            BookNumber = bookNumber;
            Title = title;
            Category = category;
        }
    }
}
