using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Core.Models
{
    public class Library
    {
        Book[] book = new Book[] { };

        public Library()
        {
            book = new Book[0];
        }

        public void FindAllBooksByName(string name)
        {
            Book[] filteredNameBooks = new Book[] { };
            {
                for (int i = 0; i < book.Length; i++)
                {
                    if (book[i].Name == name)
                    {
                        Array.Resize(ref filteredNameBooks, filteredNameBooks.Length + 1);
                        filteredNameBooks[filteredNameBooks.Length - 1] = book[i];
                    }
                }
            }
        }
        public void RemoveAllBookByName(string name)
        {
            Book[] filteredRemoveName = new Book[] { };

            for (int i = 0; i < book.Length; i++)
            {
                if (book[i].Name != name)
                {
                    Array.Resize(ref filteredRemoveName, filteredRemoveName.Length + 1);
                    filteredRemoveName[filteredRemoveName.Length - 1] = book[i];
                }
            }
            filteredRemoveName = book;
        }

        public Book[] SearchBooks(string value)
        {
            Book[] searchingAll = new Book[] { };

            for (int i = 0; i < book.Length; i++)
            {
                if (book[i].Name.Contains(value) || book[i].AuthorName.Contains(value) || book[i].PageCount.ToString().Contains(value))
                {
                    Array.Resize(ref searchingAll, searchingAll.Length + 1);
                    searchingAll[searchingAll.Length - 1] = book[i];
                }
            }
            return searchingAll;
        }


    }
}
