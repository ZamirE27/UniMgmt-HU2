namespace UniMgmt.Domain.Models;

public class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
    
    public int StudentStatusId { get; set; }
    public StudentStatus? StudentStatus { get; set; }
    
}