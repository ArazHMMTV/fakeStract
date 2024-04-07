using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Book
    {
        public Book(string name, string authorName, double pageCount)
        {
            Name = name;
            AuthorName = authorName;
            PageCount = pageCount;
        }

        public string Name { get; set; }
        public string AuthorName { get; set; }
        public double PageCount { get; set; }
    }
}
