namespace SchoolApiEntity.Model;

public class Matricula{
    public int MatriculaId {get;set;}
    public Guid AlumnoId {get;set;}
    public int Grado {get;set;}
    public DateTime Fecha {get;set;} 
}