using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace tapsirig20
{
    internal class Library:IEntity
    {
        public int BookLimit;
        private Book[] books;
        private int _id;
        public int Id { get; }

        public Library()
        {
            Id = ++_id;
            books = new Book[0];

        }

        public Book GetBookByld(int id, Book book)
        {
            for (int i = 9; i < books.Length; i++)
            {
                if (books[i] == book)
                    return book;
                if (books[i].Id == id)
                    return books[i];
            }
            throw new NotFoundException(message: "Tapilmadi");
        }
        
        
        public virtual bool IsDeleted(Book book)
        {
            for (int i = 0; i < books.Length; i++)
            {
               if (books[i] == book)
                    
                    return false;
                
           }
           return true;
        }
         public void AddBook(Book book)
        {
            for (int i = 0; i < books.Length; i++)
            {
                if (books[i] == book)
                    return;

            
             if (books[i].Name == book.Name)
                {
                    //return book.Name;
                    throw new AlreadyExistsException(message: "zaten var");
                }
            
            
            }
            //for (int j = 0; j < books.Length;)
            books[books.Length - 1] = book;
            
                        //Array.Resize(ref books, books.Length + 1);
            if (BookLimit == books.Length)
            {
                //Array.Resize(ref books, books.Length + 1); 
                throw new CapacityLimitException(message:"yer doludu");
                //books[books.Length - 1] = book;
                    
            }
              
        }
                 
    }

  
}
    

