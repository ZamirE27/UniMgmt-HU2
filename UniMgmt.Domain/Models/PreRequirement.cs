namespace UniMgmt.Domain.Models;

public class PreRequirement
{
    public int Id { get; set; }
    
    public int CourseId { get; set; }
    public Course? Course { get; set; }
    
    public int RequiredCourseId { get; set; }
    public Course? RequiredCourse { get; set; }
}