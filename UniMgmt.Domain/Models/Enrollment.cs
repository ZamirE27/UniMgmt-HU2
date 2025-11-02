namespace UniMgmt.Domain.Models;

public class Enrollment
{
    public int Id { get; set; }
    
    public int SectionId { get; set; }
    public Section? Section { get; set; }
    
    public int StudentId { get; set; }
    public Student? Student { get; set; }
    
    public int EnrollmentStatusId { get; set; }
    public EnrollmentStatus? EnrollmentStatus { get; set; }
    
    public DateTime EnrollmentDate { get; set; }
}