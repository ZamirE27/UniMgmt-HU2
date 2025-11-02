namespace UniMgmt.Domain.Models;

public class Section
{
    public int Id { get; set; }
    
    public int CourseId { get; set; }
    public Course? Course { get; set; }
    
    public int ClassRoomId { get; set; }
    public ClassRoom? ClassRoom { get; set; }
    
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public int MaxPlace { get; set; }

    public List<Enrollment> Enrollments { get; set; } = new List<Enrollment>();
}