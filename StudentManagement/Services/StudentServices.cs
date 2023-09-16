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
            _students.InsertOne(student);
            return student;
        }

        public void Update(string id, Student student)
        {
            _students.ReplaceOne(s => s.Id == id, student);
        }
        public void Remove(string id)
        {
            _students.DeleteOne(s => s.Id == id);
        }

        public Student GetById(string id)
        {
            return _students.Find(s => s.Id == id).FirstOrDefault();
        }

        public List<Student> Get()
        {
            return _students.Find(student => true).ToList();
        }
    }
}



