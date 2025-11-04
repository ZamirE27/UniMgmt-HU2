using Microsoft.EntityFrameworkCore;
using UniMgmt.Domain.Interfaces;
using UniMgmt.Domain.Models;
using UniMgmt.Infrastructure.Data;

namespace UniMgmt.Infrastructure.Repositories;

public class PreRequirementRepository : Repository<PreRequirement>, IPreRequirementRepository
{
    public PreRequirementRepository(AppDbContext context) : base(context)
    {
    }

    public async Task<bool> ExistsAsync(int courseId, int requiredCourseId)
    {
        return await _dbSet
            .AnyAsync(pr => pr.CourseId == courseId && pr.RequiredCourseId == requiredCourseId);
    }

    public async Task<IEnumerable<PreRequirement>> GetByCourseIdAsync(int courseId)
    {
        return await _dbSet
            .Include(pr => pr.RequiredCourse)
            .Where(pr => pr.CourseId == courseId)
            .ToListAsync();
    }
}