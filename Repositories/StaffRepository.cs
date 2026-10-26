using System.Diagnostics;
using Microsoft.EntityFrameworkCore;
using RegexExercise.Data;
using RegexExercise.Models;

namespace RegexExercise.Repositories;

public class StaffRepository: IStaffRepository
{
    public async Task<IReadOnlyList<Staff>> GetAll()
    {
        await using var context = new AppDbContext();
        return await context.Staff.AsNoTracking().ToListAsync();
    }

    public async Task<Staff?> GetById(int id)
    {
        await using var context = new AppDbContext();
        return await context.Staff.FindAsync(id);
    }

    public async Task<bool> Update(Staff staff)
    {
        try
        {
            await using var context = new AppDbContext();
            context.Staff.Update(staff);
            await context.SaveChangesAsync();
            return true;
        }
        catch (Exception ex)
        {
            Debug.WriteLine(ex);
            return false;
        }
    }
}