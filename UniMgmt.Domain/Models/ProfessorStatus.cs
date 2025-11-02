namespace UniMgmt.Domain.Models;

public class ProfessorStatus
{
    public int Id { get; set; }
    public string Name { get; set; }

    public List<Professor> Professor { get; set; } = new List<Professor>();
}