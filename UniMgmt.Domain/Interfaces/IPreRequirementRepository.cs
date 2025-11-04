using UniMgmt.Domain.Models;

namespace UniMgmt.Domain.Interfaces;

public interface IPreRequirementRepository : IRepository<PreRequirement>
{
    Task<bool> ExistsAsync(int courseId, int requiredCourseId);
    Task<IEnumerable<PreRequirement>> GetByCourseIdAsync(int courseId);
}