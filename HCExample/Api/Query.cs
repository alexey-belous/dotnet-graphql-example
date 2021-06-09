using HCExample.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HCExample.Api
{
    public class Query
    {
        public Book GetBookById(int bookId) =>
            new Book
            {
                Title = "C# in depth.",
                Author = new Author
                {
                    Name = "Jon Skeet"
                }
            };

        public IEnumerable<Book> GetBooks() =>
            new Book[]{
                new Book
                {
                    Title = "C# in depth.2",
                    Author = new Author
                    {
                        Name = "Jon Skeet"
                    }
                }};
    }
}
