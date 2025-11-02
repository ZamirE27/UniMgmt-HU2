namespace UniMgmt.Domain.Models;

public class Professor
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
    
    public int SpecialityId { get; set; }
    public Speciality?  Speciality { get; set; }
    
    public int ProfessorStatusId { get; set; }
    public ProfessorStatus? ProfessorStatus { get; set; }
}