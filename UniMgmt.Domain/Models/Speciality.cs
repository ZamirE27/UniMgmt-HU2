using UniMgmt.Domain.Models;

namespace UniMgmt.Domain;

public class Speciality
{
    public int Id { get; set; }
    public string Name { get; set; }

    public List<Professor> Professors { get; set; } = new List<Professor>();
}