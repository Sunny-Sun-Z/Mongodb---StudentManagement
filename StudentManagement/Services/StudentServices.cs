using MongoDB.Driver;
using StudentManagement.Models;

namespace StudentManagement.Services
{
    public class StudentServices : IStudentServices
    {
        private readonly IMongoCollection<Student> _students;
        public StudentServices(IStudentStoreDatabaseSettings settings, IMongoClient mongonClient)
        {
            var db = mongonClient.GetDatabase(settings.DatabaseName);
            _students = db.GetCollection<Student>(settings.StudentCoursesCollectionName);
        }
        public Student Create(Student student)
        {
            throw new NotImplementedException();
        }

        public void Update(int id, Student student)
        {
            throw new NotImplementedException();
        }
        public void Remove(int id)
        {
            throw new NotImplementedException();
        }

        public Student GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Student> Get()
        {
            throw new NotImplementedException();
        }
    }
}



