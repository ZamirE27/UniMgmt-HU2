using UniMgmt.Domain.Models;

namespace UniMgmt.Domain.Interfaces;

public interface ICourseRepository : IRepository<Course>
{
    Task<IEnumerable<Course>> GetByStatusAsync(int statusId);
    Task<IEnumerable<Course>> GetCourseWithPrerequisitesAsync();
    Task<bool> HasPrerequisiteAsync(int courseId, int prerequisiteId);
}