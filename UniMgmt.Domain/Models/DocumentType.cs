namespace UniMgmt.Domain.Models;

public class DocumentType
{
    public int Id { get; set; }
    public string Name { get; set; }

    public List<Student> Students { get; set; } = new List<Student>();
    public List<Professor> Professors { get; set; } = new List<Professor>();
}