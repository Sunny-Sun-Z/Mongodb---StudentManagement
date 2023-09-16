using StudentManagement.Models;

namespace StudentManagement.Services
{
    public interface IStudentServices
    {
        List<Student> Get();
        Student GetById(string id);

        Student Create(Student student);
        void Update(string id, Student student);
        void Remove(string id);
    }
}
