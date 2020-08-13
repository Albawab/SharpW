using Page_Component_Views.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Page_Component_Views.Controllers
{
    public class StudentControllerComponent
    {

        public List<Student> GetStudents()
        {
            return new List<Student>
            {
                new Student(){id =1, name="Jos", Birthday= DateTime.Now},
                new Student(){id =2, name="Adam", Birthday= DateTime.Now},
                new Student(){id =3, name="Aty", Birthday= DateTime.Now},
                new Student(){id =4, name="Piet", Birthday= DateTime.Now},
                new Student(){id =5, name="Jan", Birthday= DateTime.Now}
            };
        }
    }
}
