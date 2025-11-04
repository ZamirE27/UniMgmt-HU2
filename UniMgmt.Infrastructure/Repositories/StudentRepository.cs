using Microsoft.EntityFrameworkCore;
using UniMgmt.Domain.Interfaces;
using UniMgmt.Domain.Models;
using UniMgmt.Infrastructure.Data;

namespace UniMgmt.Infrastructure.Repositories;

public class StudentRepository : Repository<Student>, IStudentRepository
{
    public StudentRepository(AppDbContext context) : base(context)
    {
    }

    public async Task<Student?> GetByDocumentNumberAsync(string documentNumber)
    {
        return await _dbSet
            .AsNoTracking()
            .FirstOrDefaultAsync(s => s.DocumentNumber == documentNumber);
    }

    public async Task<IEnumerable<Student>> GetByStatusAsync(int statusId)
    {
        return await _dbSet
            .Where(s => s.StudentStatusId == statusId)
            .ToListAsync();
    }

    public async Task<bool> ExistsWithDocumentAsync(string documentNumber)
    {
        return await _dbSet.AnyAsync(s => s.DocumentNumber == documentNumber);
    }
}