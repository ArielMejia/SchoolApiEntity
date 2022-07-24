namespace SchoolApiEntity.Model;

public class Person
{
    public Guid PersonId {get; set;}
    public string FirstName {get;set;}
    public string LastName {get; set;}
    public string Ruc {get;set;}
    public Teacher Teacher {get;set;}
    public Student Student {get;set;}
}