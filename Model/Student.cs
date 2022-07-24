namespace SchoolApiEntity.Model;

public class Student
{
    public Guid StudenId {get;set;}
    public Guid PersonId {get;set;}
    public string Career {get;set;}
    public string Faculty {get;set;}
    public  Person Person {get;set;}
    public  Enrollment Enrollment {get;set;}
    public ICollection<CourseStudent> CourseStudents {get;set;}
}