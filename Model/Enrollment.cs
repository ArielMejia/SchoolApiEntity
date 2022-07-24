namespace SchoolApiEntity.Model;

public class Enrollment{
    public int EnrollmentId {get;set;}
    public Guid StudentId {get;set;}
    public Grade Grade {get;set;}
    public DateTime CurrentDate {get;set;} 
    public  Student Student {get;set;}
    //public virtual ICollection<Enrollment> Enrollments {get;set;}
}

public enum Grade{
    Primero,
    Segundo,
    Tercero
}