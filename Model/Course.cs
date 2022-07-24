namespace SchoolApiEntity.Model;

public class Course
{
    public string CourseID {get;set;}
    //public Guid TeacherID {get;set;}
    //public Guid TeacherId {get;set;}
    public string CourseName {get;set;}
    public int Hours {get;set;}
    public  Teacher Teacher {get;set;}
    public ICollection<CourseStudent> CourseStudents {get;set;}
}