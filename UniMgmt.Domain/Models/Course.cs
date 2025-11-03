namespace UniMgmt.Domain.Models;

public class Course
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    
    public int CourseStatusId { get; set; }
    public CourseStatus? CourseStatus { get; set; }

    public List<PreRequirement> PreRequirements { get; set; } = new List<PreRequirement>();
    
    public List<PreRequirement> RequiredByOtherCourses { get; set; } = new List<PreRequirement>();

    public List<Section> Sections { get; set; } = new List<Section>();
}