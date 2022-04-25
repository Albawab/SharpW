using TestOData.Models;

namespace TestOData.Services
{
    public interface IStudentService
    {
        List<Student> RetrieveAllStudents();
    }
}
