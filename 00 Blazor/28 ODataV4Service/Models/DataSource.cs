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

            Book related = new Book
            {
                Id = 1,
                Name = "Customer1",
                LastName = "LastName1",
                Email = "customer1@prosa.com.mx",
                Gender = Gender.Male,
                RegistrationDate = DateTime.Now,
                Active = true,
                IsDeleted = false,
                CreditLimit = 1000                
            };
            _books.Add(related);

            // book #1
            Book book = new Book
            {
                Id = 2,               
                Name = "Customer2",
                LastName = "LastName2",
                Email = "customer2@prosa.com.mx",
                Gender = Gender.Female,
                RegistrationDate = DateTime.Now.AddDays(-2),
                Active = false,
                IsDeleted = false,
                CreditLimit = 2000
            };
            _books.Add(book);

            // book #2
            book = new Book
            {
                Id = 3,               
                Name = "Customer3",
                LastName = "LastName3",
                Email = "customer3@prosa.com.mx",
                Gender = Gender.Female,
                RegistrationDate = DateTime.Now.AddDays(-3),
                Active = true,
                IsDeleted = false,
                CreditLimit = 3000
            };
            _books.Add(book);

            book = new Book
            {
                Id = 4,
               
                Name = "Customer4",
                LastName = "LastName4",
                Email = "customer4@prosa.com.mx",
                Gender = Gender.Male,             
                RegistrationDate = DateTime.Now.AddDays(-4),
                Active = false,
                IsDeleted = false,
                CreditLimit = 4000
            };
            _books.Add(book);

            book = new Book
            {
                Id = 5,
               
                Name = "Customer5",
                LastName = "LastName5",
                Email = "customer5@prosa.com.mx",
                Gender = Gender.Female,              
                RegistrationDate = DateTime.Now.AddDays(-5),
                Active = false,
                IsDeleted = false,
                CreditLimit = 5000
            };
            _books.Add(book);


            book = new Book
            {
                Id = 6,
             
                Name = "Customer6",
                LastName = "LastName6",
                Email = "customer6@prosa.com.mx",
                Gender = Gender.Female,               
                RegistrationDate = DateTime.Now.AddDays(-6),
                Active = false,
                IsDeleted = false,
                CreditLimit = 6000
            };
            _books.Add(book);


            book = new Book
            {
                Id = 7,
               
                Name = "Customer7",
                LastName = "LastName7",
                Email = "customer7@prosa.com.mx",
                Gender = Gender.Female,              
                RegistrationDate = DateTime.Now.AddDays(-7),
                Active = false,
                IsDeleted = false,
                CreditLimit = 7000
            };
            _books.Add(book);



            book = new Book
            {
                Id = 8,                
                Name = "Customer8",
                LastName = "LastName8",
                Email = "customer8@prosa.com.mx",
                Gender = Gender.Male,            
                RegistrationDate = DateTime.Now.AddDays(-8),
                Active = true,
                IsDeleted = false,
                CreditLimit = 8000
            };
            _books.Add(book);


            book = new Book
            {
                Id = 9,              
                Name = "Customer9",
                LastName = "LastName9",
                Email = "customer9@prosa.com.mx",
                Gender = Gender.Male,              
                RegistrationDate = DateTime.Now.AddDays(-8),
                Active = true,
                IsDeleted = false,
                CreditLimit = 9000
            };
            _books.Add(book);

            return _books;
        }
    }
}
