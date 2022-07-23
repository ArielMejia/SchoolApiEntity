namespace SchoolApiEntity.Model;

public class CourseStudent
{
    public Guid StudentId {get;set;}
    public int CourseId {get;set;}
    public int Nota {get;set;}
    public virtual Student Student {get;set;}
    public virtual Course Course {get;set;}
}