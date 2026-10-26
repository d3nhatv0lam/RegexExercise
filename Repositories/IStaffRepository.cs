using RegexExercise.Models;

namespace RegexExercise.Repositories;

public interface IStaffRepository
{
    IReadOnlyList<Staff> GetAll();
    Staff? GetById(int id);
    bool Update(Staff staff);
}