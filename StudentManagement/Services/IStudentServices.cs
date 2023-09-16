using StudentManagement.Models;

namespace StudentManagement.Services
{
    public interface IStudentServices
    {
        List<Student> Get();
        Student GetById(int id);

        Student Create(Student student);
        void Update(int id, Student student);
        void Remove(int id);
    }
}
