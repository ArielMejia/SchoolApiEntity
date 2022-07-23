namespace SchoolApiEntity.Model;

public class Course
{
    public string CourseID {get;set;}
    public Guid TeacherId {get;set;}
    public string CourseName {get;set;}
    public int Hours {get;set;}
    public virtual Teacher Teacher {get;set;}
}