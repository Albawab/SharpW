using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ODataV4Service.Models;
using Microsoft.AspNet.OData;
using System.Net;

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

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(string isbn)
        {
            return "value";
        }

        // POST api/values
        [EnableQuery]
        public async Task<IActionResult> Post([FromBody]Book book)
        {
            _db.Books.Add(book);
            _db.SaveChanges();
            return Created(book);
        }
        [EnableQuery]
        public async Task<IActionResult> Patch([FromODataUri] Guid key, [FromBody] Delta<Book> book)
        {
            var entity = await _db.Books.FindAsync(key);
            book.Patch(entity);
                await _db.SaveChangesAsync();
            return Updated(entity);
        }

        // PUT api/values/"5"
        [EnableQuery]
        public async Task<IActionResult> Put([FromODataUri]Guid key, [FromBody] Book book)
        {
            var entity = await _db.Books.FindAsync(book.Id);
            _db.Entry(entity).CurrentValues.SetValues(book);
            await _db.SaveChangesAsync();
            return Updated(book);
        }

        // DELETE api/values/5
        [EnableQuery]
        public Guid Delete([FromODataUri]Guid key)
        {
            var od = _db.Books.Find(key);

            _db.Books.Remove(od);
            _db.SaveChanges();
            return key;
            //return StatusCode((int)HttpStatusCode.NoContent);
        }
    }
}
