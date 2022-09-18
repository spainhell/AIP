using AIP.Entities;

namespace AIP.UseCases.Students.Interfaces;

public interface IAddStudentUseCase
{
    Task ExecuteAsync(Student student);
}