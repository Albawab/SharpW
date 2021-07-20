using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ODataV4Service.Models;
using Microsoft.AspNet.OData;
using Microsoft.AspNet.OData.Extensions;
using Microsoft.AspNet.OData.Query;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNet.OData.Routing;

namespace ODataV4Service.Controllers
{
    [Route("api/[controller]")]
    public class BooksController : ODataController
    {
        private BookStoreContext _db;

        public BooksController(BookStoreContext context)
        {
            _db = context;
            if (context.Books.Count() == 0)
            {
                foreach (var b in DataSource.GetBooks())
                {
                    context.Books.Add(b);
                }
                context.SaveChanges();
            }

        }
        // GET api/values
        [HttpGet]
        [EnableQuery]
        //[System.Web.Http.AllowAnonymous]
        public IActionResult Get()

        {
            return Ok(_db.Books);
        }

        public async Task<IActionResult> Post([FromBody] Book book)
        {
            _db.Books.Add(book);
            _db.SaveChanges();
            return Created(book);
        }

        public async Task<IActionResult> Patch([FromODataUri] int key, [FromBody] Delta<Book> book)
        {
            var entity = await _db.Books.FindAsync(key);
            book.Patch(entity);
            await _db.SaveChangesAsync();
            return Updated(entity);
        }

        // PUT api/values/"5"

        public async Task<IActionResult> Put([FromODataUri] int key, [FromBody] Book book)
        {
            var entity = await _db.Books.FindAsync(book.Id);
            _db.Entry(entity).CurrentValues.SetValues(book);
            await _db.SaveChangesAsync();
            return Updated(book);
        }

        // DELETE api/values/5
        public int Delete([FromODataUri] int key)
        {
            var od = _db.Books.Find(key);

            _db.Books.Remove(od);
            _db.SaveChanges();
            return key;
            //return StatusCode((int)HttpStatusCode.NoContent);
        }
    }
}
