using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AIP.Entities;
using AIP.UseCases.PluginInterfaces;
using AIP.UseCases.Students.Interfaces;

namespace AIP.UseCases.Students
{
    public class ViewStudentsByNameUseCase : IViewStudentsByNameUseCase
    {
        private readonly IStudentRepository studentRepository;

        public ViewStudentsByNameUseCase(IStudentRepository studentRepository)
        {
            this.studentRepository = studentRepository;
        }

        public async Task<IEnumerable<Student>> ExecuteAsync(string name = "")
        {
            return await studentRepository.GetStudentsByNameAsync(name);
        }
    }
}
