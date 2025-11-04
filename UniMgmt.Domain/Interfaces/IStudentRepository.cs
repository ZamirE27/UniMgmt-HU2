using UniMgmt.Domain.Models;

namespace UniMgmt.Domain.Interfaces;

public interface IStudentRepository : IRepository<Student>
{
    Task<Student?> GetByDocumentNumberAsync(string documentNumber);
    Task<IEnumerable<Student>> GetByStatusAsync(int statusId);
    Task<bool> ExistsWithDocumentAsync(string documentNumber);
}