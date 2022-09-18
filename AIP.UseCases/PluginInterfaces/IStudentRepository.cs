using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AIP.Entities;

namespace AIP.UseCases.PluginInterfaces
{
    public interface IStudentRepository
    {
        Task<IEnumerable<Student>> GetStudentsByNameAsync(string studentName);
        Task AddStudentAsync(Student student);
    }
}
