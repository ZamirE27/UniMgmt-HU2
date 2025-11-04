using UniMgmt.Domain.Models;

namespace UniMgmt.Domain.Interfaces;

public interface IEnrollmentRepository :  IRepository<Enrollment>
{
    Task<IEnumerable<Enrollment>> GetByStatusAsync(int enrollmentId);
    Task<bool> AnySectionByIdAsync(int sectionId);
    Task<bool> AnyStudentByIdAsync(int studentId);
    Task<bool> AnyEnrollmentAsync(int sectionId, int studentId);
}