using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using TestOData.Models;
using TestOData.Services;

namespace TestOData.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentsController : Controller
    {
        private IStudentService StudentService;

        public StudentsController(IStudentService studentService) => this.StudentService = studentService;
        

        [HttpGet]
        [EnableQuery]
        public ActionResult<List<Student>> GetAll()
        {
            List<Student> students = this.StudentService.RetrieveAllStudents();

            return Ok(students);
        }
    }
}
