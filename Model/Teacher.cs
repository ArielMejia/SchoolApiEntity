namespace SchoolApiEntity.Model;

public class Teacher
{
    public Guid TeacherId {get;set;}
    public Guid PersonId {get;set;}
    public Contract ContractType {get;set;}
    public Person Person {get;set;}
    public ICollection<Course> Courses {get;set;}
}

public enum Contract
{
    Fulltime,
    Midtime,
    Perhour
}