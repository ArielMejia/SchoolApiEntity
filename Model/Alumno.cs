namespace SchoolApiEntity.Model;

public class Alumno
{
    public Guid AlumnoId {get;set;}
    public Guid PersonaId {get;set;}
    public string Carrera {get;set;}
    public string Facultad {get;set;}
    public virtual Persona Persona {get;set;}

}