namespace UniMgmt.Domain.Models;

public class ClassRoom
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Capacity { get; set; }

    public List<Section> Sections { get; set; } = new List<Section>();
}