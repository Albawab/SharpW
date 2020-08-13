using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ODataV4Service.Models
{
    public static class DataSource
    {
        private static IList<Book> _books { get; set; }

        public static IList<Book> GetBooks()
        {
            if (_books != null)
            {
                return _books;
            }
            _books = new List<Book>();
            var newGuid = Guid.NewGuid();

            if (_books.Count() == 0)
            {
                int code = 10000;
                for (int i = 1; i < 200; i++)
                {
                    _books.Add(new Book(code + 1, "978-0-321-832892-3", "Essential C#5.0", "Dave ", 89.99m));
                    _books.Add(new Book(code + 2, "978-0-321-832892-3", "Essential C#1.0", "Case ", 22.99m));
                    _books.Add(new Book(code + 3, "978-0-321-832892-3", "Essential C#2.0", "Bers ", 21.99m));
                    _books.Add(new Book(code + 4, "978-0-321-832892-3", "Essential C#3.0", "Asdds ", 29.99m));
                    _books.Add(new Book(code + 5, "978-0-321-832892-3", "Essential C#4.0", "tgda ", 11.99m));
                    code += 5;
                }
            }

            

            

            //Book related = new Book
            //{
            //    Id = 0,
            //    guid = newGuid,
            //    ISBN = "978-0-321-832892-3",
            //    Title = "Essential C#5.0",
            //    Author = "Dave ",
            //    Price = 89.99m,
            //    Branch = BranchType.Direccion,
            //    Regime = Region.Centro,
            //    RelatedOrderId = newGuid
            //};
            //_books.Add(related);

            //// book #1
            //Book book = new Book
            //{
            //    Id = 1,
            //    guid = Guid.Parse("e5ce9175-1445-4cf4-a885-1cf748f34755"),
            //    ISBN = "978-0-321-87758-1",
            //    Title = "Essential C#7.0",
            //    Author = "Mark Michaelis",
            //    Price = 59.99m,
            //     Branch = BranchType.Direccion,
            //     Regime = Region.Centro,
            //     RelatedOrderId = related.guid
            //};
            //_books.Add(book);

            //// book #2
            //book = new Book
            //{
            //    Id = 2,
            //    guid = Guid.Parse("98f4b22b-0b57-425b-901e-b6fb75de3456"),
            //    ISBN = "063-6-920-02371-5",
            //    Title = "Enterprise Games",
            //    Author = "Michael Hugos",
            //    Price = 49.99m,
            //    Branch = BranchType.Modulo,
            //    Regime = Region.Occidente,
            //     RelatedOrderId = related.guid
            //};
            //_books.Add(book);

            return _books;
        }
    }
}
