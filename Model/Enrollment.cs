namespace SchoolApiEntity.Model;

public class Enrollment{
    public int EnrollmentId {get;set;}
    public Guid StudentId {get;set;}
    public int Grade {get;set;}
    public DateTime CurrentDate {get;set;} 
}