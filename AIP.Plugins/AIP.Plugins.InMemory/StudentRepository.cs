using System.Runtime.CompilerServices;
using AIP.Entities;
using AIP.UseCases.PluginInterfaces;

namespace AIP.Plugins.InMemory
{
    public class StudentRepository : IStudentRepository
    {
        private List<Student> _students;

        public StudentRepository()
        {
            _students = new List<Student>()
            {
                new Student()
                {
                    Id = 1, Active = true, FirstName = "Aneta", LastName = "Špaňhelová",
                    BirthDate = new DateTime(2017, 12, 19), Account = "123", Bank = "0100", CollectionPayment = true
                },
                new Student()
                {
                    Id = 2, Active = true, FirstName = "Filip", LastName = "Bejček",
                    BirthDate = new DateTime(2015, 1, 19), Account = "", Bank = "", CollectionPayment = true
                },
                new Student()
                {
                    Id = 3, Active = true, FirstName = "Sebastian", LastName = "Slezák",
                    BirthDate = new DateTime(2017, 8, 11), Account = "", Bank = "", CollectionPayment = true
                },
                new Student()
                {
                    Id = 4, Active = true, FirstName = "Romana", LastName = "Konopásková",
                    BirthDate = new DateTime(2018, 4, 4), Account = "456", Bank = "0200", CollectionPayment = true
                }
            };
        }

        public async Task<IEnumerable<Student>> GetStudentsByNameAsync(string studentName)
        {
            if (string.IsNullOrEmpty(studentName)) return await Task.FromResult(_students);

            return _students.Where(x => x.LastName.Contains(studentName, StringComparison.CurrentCultureIgnoreCase));
        }

        public Task AddStudentAsync(Student student)
        {
            if (_students.Any(x =>
                    x.LastName.Equals(student.LastName, StringComparison.CurrentCultureIgnoreCase)
                    && x.FirstName.Equals(student.FirstName, StringComparison.CurrentCultureIgnoreCase)
                    && x.BirthDate.Equals(student.BirthDate)
                )) return Task.CompletedTask;

            var maxId = _students.Max(x => x.Id);
            student.Id = maxId + 1;
            _students.Add(student);

            return Task.CompletedTask;
        }
    }
}