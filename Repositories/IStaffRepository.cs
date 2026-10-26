using RegexExercise.Models;

namespace RegexExercise.Repositories;

public interface IStaffRepository
{
    Task<IReadOnlyList<Staff>> GetAll();
    Task<Staff?> GetById(int id);
    Task<bool> Update(Staff staff);
}