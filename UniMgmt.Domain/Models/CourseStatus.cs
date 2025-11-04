namespace UniMgmt.Domain.Models;

public class CourseStatus
{
    public int Id { get; set; }
    public string Name { get; set; }

    public List<Course> Courses { get; set; } = new List<Course>();
}