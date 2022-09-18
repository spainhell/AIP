using AIP.Entities;

namespace AIP.UseCases.Students.Interfaces;

public interface IViewStudentsByNameUseCase
{
    Task<IEnumerable<Student>> ExecuteAsync(string name = "");
}