using Microsoft.EntityFrameworkCore;
using UniMgmt.Domain.Interfaces;
using UniMgmt.Domain.Models;
using UniMgmt.Infrastructure.Data;

namespace UniMgmt.Infrastructure.Repositories;

public class CourseRepository : Repository<Course>, ICourseRepository
{
    public CourseRepository(AppDbContext context) : base(context)
    {
    }

    public async Task<IEnumerable<Course>> GetByStatusAsync(int statusId)
    {
        return await _dbSet.Where(c => c.CourseStatusId == statusId).ToListAsync();
    }

    public async Task<IEnumerable<Course>> GetCourseWithPrerequisitesAsync()
    {
        return await _dbSet
            .Include(c => c.PreRequirements)
            .ThenInclude(pr => pr.RequiredCourse)
            .ToListAsync();
    }

    public async Task<bool> HasPrerequisiteAsync(int courseId, int prerequisiteId)
    {
        return await _context.PreRequirements
            .AnyAsync(pr => pr.CourseId == courseId && pr.RequiredCourseId == prerequisiteId);
    }
}