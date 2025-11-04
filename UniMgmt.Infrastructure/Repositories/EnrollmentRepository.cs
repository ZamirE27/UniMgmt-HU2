using Microsoft.EntityFrameworkCore;
using UniMgmt.Domain.Interfaces;
using UniMgmt.Domain.Models;
using UniMgmt.Infrastructure.Data;

namespace UniMgmt.Infrastructure.Repositories;

public class EnrollmentRepository : Repository<Enrollment>, IEnrollmentRepository
{
    public EnrollmentRepository(AppDbContext context) : base(context)
    {
    }

    public async Task<IEnumerable<Enrollment>> GetByStatusAsync(int enrollmentStatusId)
    {
        return await _dbSet
            .Where(e => e.EnrollmentStatusId == enrollmentStatusId)
            .ToListAsync();
    }

    public async Task<bool> AnySectionByIdAsync(int sectionId)
    {
        return await _dbSet.AnyAsync(pr => pr.SectionId == sectionId);
    }

    public async Task<bool> AnyStudentByIdAsync(int studentId)
    {
        return await _dbSet.AnyAsync(pr => pr.StudentId == studentId);
    }

    public async Task<bool> AnyEnrollmentAsync(int sectionId, int studentId)
    {
        return await _dbSet.AnyAsync(pr =>
            pr.SectionId == sectionId && pr.StudentId == studentId);
    }
}