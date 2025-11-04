using Microsoft.EntityFrameworkCore;
using UniMgmt.Domain.Interfaces;
using UniMgmt.Domain.Models;
using UniMgmt.Infrastructure.Data;

namespace UniMgmt.Infrastructure.Repositories;

public class ProfessorRepository : Repository<Professor>, IProfessorRepository
{
    public ProfessorRepository(AppDbContext context) : base(context)
    {
    }

    public async Task<IEnumerable<Professor>> GetBySpecializationAsync(int specializationId)
    {
        return await _dbSet.Where(p => p.SpecialityId == specializationId).ToListAsync();
    }

    public async Task<IEnumerable<Professor>> GetByStatusAsync(int statusId)
    {
        return await _dbSet.Where(p => p.ProfessorStatusId == statusId).ToListAsync();
    }

    public async Task<bool> IsAvailableAsync(int professorId, DayOfWeek day, TimeSpan start, TimeSpan end)
    {
        var hasConflict = await _context.Sections
            .AnyAsync(s => s.ProfessorId == professorId &&
                           s.DayOfWeek == day &&
                           (
                               start < s.EndTime && end > s.StartTime
                           )
            );
        return !hasConflict;
    }
}