using Microsoft.EntityFrameworkCore;
using UniMgmt.Domain.Interfaces;
using UniMgmt.Domain.Models;
using UniMgmt.Infrastructure.Data;

namespace UniMgmt.Infrastructure.Repositories;

public class SectionRepository : Repository<Section>, ISectionRepository
{
    public SectionRepository(AppDbContext context) : base(context)
    {
    }

    public async Task<IEnumerable<Section>> GetByCoursesAsync(int courseId)
    {
        return await _dbSet.Where(pr => pr.CourseId == courseId).ToListAsync();
    }

    public async Task<IEnumerable<Section>> GetByProfessorsAsync(int professorId)
    {
        return await _dbSet.Where(pr => pr.ProfessorId == professorId).ToListAsync();
    }

    public async Task<IEnumerable<Section>> GetByClassroomsAsync(int classroomId)
    {
        return await _dbSet.Where(s => s.ClassRoomId == classroomId).ToListAsync();
    }

    public async Task<bool> IsScheduleAvailableAsync(int classroomId, DayOfWeek day, TimeSpan start, TimeSpan end)
    {
        var hasConflict = await _context.Sections
            .AnyAsync(s =>
                s.ClassRoomId == classroomId &&
                s.DayOfWeek == day &&
                start < s.EndTime &&
                end > s.StartTime
            );

        return !hasConflict; 
    }
}