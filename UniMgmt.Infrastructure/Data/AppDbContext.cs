using Microsoft.EntityFrameworkCore;
using UniMgmt.Domain;
using UniMgmt.Domain.Models;

namespace UniMgmt.Infrastructure.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }


    public DbSet<Course> Courses { get; set; }
    public DbSet<Student> Students { get; set; }
    public DbSet<Professor> Professors { get; set; }
    public DbSet<Enrollment> Enrollments { get; set; }
    public DbSet<ClassRoom> ClassRooms { get; set; }
    public DbSet<Speciality> Specialities { get; set; }
    public DbSet<DocumentType> DocumentTypes { get; set; }
    public DbSet<PreRequirement> PreRequirements { get; set; }
    public DbSet<Section> Sections { get; set; }
    public DbSet<ProfessorStatus> ProfessorStatuses { get; set; }
    public DbSet<CourseStatus> CourseStatuses { get; set; }
    public DbSet<StudentStatus> StudentStatuses { get; set; }
    public DbSet<EnrollmentStatus> EnrollmentStatuses { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Student>()
            .HasIndex(s => s.DocumentNumber)
            .IsUnique();
        modelBuilder.Entity<Professor>()
            .HasIndex(p => p.DocumentNumber)
            .IsUnique();
        modelBuilder.Entity<Enrollment>()
            .HasIndex(e => e.EnrollmentNumber)
            .IsUnique();

        modelBuilder.Entity<PreRequirement>(entity =>
        {
            entity.HasOne(pr => pr.Course)
                .WithMany(c => c.PreRequirements)
                .HasForeignKey(pr => pr.CourseId)
                .OnDelete(DeleteBehavior.Restrict);

            entity.HasOne(pr => pr.RequiredCourse)
                .WithMany(c => c.RequiredByOtherCourses)
                .HasForeignKey(pr => pr.RequiredCourseId)
                .OnDelete(DeleteBehavior.Restrict);
        });

    }
}