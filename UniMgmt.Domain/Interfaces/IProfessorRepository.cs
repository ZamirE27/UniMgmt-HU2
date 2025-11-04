using UniMgmt.Domain.Models;

namespace UniMgmt.Domain.Interfaces;

public interface IProfessorRepository : IRepository<Professor>
{
    Task<IEnumerable<Professor>> GetBySpecializationAsync(int specializationId);
    Task<IEnumerable<Professor>> GetByStatusAsync(int statusId);
    Task<bool> IsAvailableAsync(int professorId, DayOfWeek day, TimeSpan start, TimeSpan end);
}