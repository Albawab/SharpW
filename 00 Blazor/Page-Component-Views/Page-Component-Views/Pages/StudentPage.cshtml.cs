using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Page_Component_Views.Controllers;
using Page_Component_Views.Model;

namespace Page_Component_Views.Pages
{
    public class StudentPageModel : PageModel
    {
       public List<Student> Students;
        public void OnGet()
        {
            StudentControllerComponent student = new StudentControllerComponent();
            Students = student.GetStudents();

        }
    }
}