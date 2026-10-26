using System.Diagnostics;
using Microsoft.EntityFrameworkCore;
using RegexExercise.Data;
using RegexExercise.Models;

namespace RegexExercise.Repositories;

public class StaffRepository: IStaffRepository
{
    public IReadOnlyList<Staff> GetAll()
    {
        using var context = new AppDbContext();
        return [.. context.Staff.AsNoTracking()];
    }

    public Staff? GetById(int id)
    {
        using var context = new AppDbContext();
        return context.Staff.Find(id);
    }

    public bool Update(Staff staff)
    {
        try
        {
            using var context = new AppDbContext();
            context.Staff.Update(staff);
            context.SaveChanges();
            return true;
        }
        catch (Exception ex)
        {
            Debug.WriteLine(ex);
            return false;
        }
    }
}