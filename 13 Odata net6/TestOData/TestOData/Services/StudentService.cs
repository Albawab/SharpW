using TestOData.Models;

namespace TestOData.Services
{
    public class StudentService : IStudentService
    {
        public List<Student> RetrieveAllStudents()
        {
            return new List<Student>
            {
                new Student() { Name ="Jos", Id = Guid.NewGuid(), Score = 10 },
                new Student() { Name ="Jos1", Id = Guid.NewGuid(), Score = 11 },
                new Student() { Name ="Jos2", Id = Guid.NewGuid(), Score = 12},
                new Student() { Name ="Jos3", Id = Guid.NewGuid(), Score = 13 },
                new Student() { Name ="Jos4", Id = Guid.NewGuid(), Score = 14 },
            };
        }
    }
}
