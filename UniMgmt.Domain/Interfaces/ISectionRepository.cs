using UniMgmt.Domain.Models;

namespace UniMgmt.Domain.Interfaces;

public interface ISectionRepository : IRepository<Section>
{
    Task<IEnumerable<Section>> GetByCoursesAsync(int courseId);
    Task<IEnumerable<Section>> GetByProfessorsAsync(int professorId);
    Task<IEnumerable<Section>> GetByClassroomsAsync(int classroomId);
    Task<bool> IsScheduleAvailableAsync(int classroomId, DayOfWeek day, TimeSpan start, TimeSpan end);
    
}