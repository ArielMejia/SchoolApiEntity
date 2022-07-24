namespace SchoolApiEntity.Model;

public class CourseStudent
{
    //public Guid CourseStudentID {get;set;}
    public Guid StudentId {get;set;}
    public string CourseId {get;set;}
    public int Nota {get;set;}
    public  Student Student {get;set;}
    public  Course Course {get;set;}
}