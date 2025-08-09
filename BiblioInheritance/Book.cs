using System;

namespace BiblioInheritance
{
    class Book : Resource
    {
        public string Author
        {
            get; set;
        }
        public int PageCount
        {
            get; set;
        }
        public Book(string title, string category, string author, int pageCount) : base(title, category)
        {
            this.Author = author;
            this.PageCount = pageCount;
        }
    }
}