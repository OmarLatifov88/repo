using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace tapsirig20
{
    internal class Book : Library, IEntity
    {

        private static int _id { get; set; }
        public string Name;
        public string AuthorName;
        public int PageCount;
        
        public int Id { get; }
        
        public Book(string name, string authorname, int pagecount)
        {
            Name = name;
            AuthorName = authorname;
            PageCount = pagecount;
            Id = ++_id;
        }
        public string ShowInfo()
        {
            return $"Name {Name} AuthorName {AuthorName} PageCount {PageCount}";
        }
      
        
        public static bool operator <(Book book1, Book book2)
            {
              return book1.PageCount < book2.PageCount;
              
            }
        
        
        public static bool operator >(Book book1, Book book2)
        {
            return book1.PageCount > book2.PageCount;
        }
        //public override bool IsDeleted(Book book)
        //{
        //    for (int i = 0; i < books.Length; i++)
        //    {
        //        if (books[i] == book)

        //          return false;

        //    }
        //   return true;
        //}

   }
}
