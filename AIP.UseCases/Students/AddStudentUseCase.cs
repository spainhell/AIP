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
    public class AddStudentUseCase : IAddStudentUseCase
    {
        private readonly IStudentRepository _studentRepository;

        public AddStudentUseCase(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }
        public async Task ExecuteAsync(Student student)
        {
            await this._studentRepository.AddStudentAsync(student);
        }
    }
}
