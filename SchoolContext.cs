using Microsoft.EntityFrameworkCore;
using SchoolApiEntity.Model;

namespace SchoolApiEntity;

public class SchoolContext : DbContext
{
    public DbSet<Person> Persons {get;set;}
    public DbSet<Enrollment> Enrollments {get;set;}
    public DbSet<Student> Students  {get;set;}
    public DbSet<Teacher> Teachers {get;set;}
    public DbSet<Course> Courses {get;set;}
    public DbSet<CourseStudent> CourseStudents {get;set;}

    public SchoolContext(DbContextOptions<SchoolContext> options) : base(options){}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Person>(person => 
        {
            person.ToTable("Person");
            person.HasKey(p => p.PersonId);
            person.Property(p => p.FirstName).IsRequired().HasMaxLength(40);
            person.Property(p => p.LastName).IsRequired().HasMaxLength(40);
            person.Property(p => p.Ruc).IsRequired().HasMaxLength(13);
        });

        modelBuilder.Entity<Enrollment>(enrollment =>
        {
            enrollment.ToTable("Enrollment");
            enrollment.HasKey(p => p.EnrollmentId);
            enrollment.HasOne(p => p.Student).WithOne(p => p.Enrollment).HasForeignKey<Enrollment>(p => p.StudentId);
            enrollment.Property(p => p.Grade).IsRequired();
            enrollment.Property(p => p.CurrentDate).IsRequired();
        });

        modelBuilder.Entity<Student>(student =>
        {
            student.ToTable("Student");
            student.HasKey(p => p.StudenId);
            student.HasOne(p => p.Person).WithOne(p => p.Student).HasForeignKey<Student>(p =>p.PersonId);
            student.Property(p => p.Career).IsRequired();
            student.Property(p => p.Faculty).IsRequired();
        });

        modelBuilder.Entity<Teacher>(teacher =>
        {
            teacher.ToTable("Teacher");
            teacher.HasKey(p => p.TeacherId);
            teacher.HasOne(p => p.Person).WithOne(p => p.Teacher).HasForeignKey<Teacher>(p => p.PersonId);
            teacher.Property(p => p.ContractType).IsRequired();
        });

        modelBuilder.Entity<Course>(course =>
        {
            course.ToTable("Course");
            course.HasKey(p => p.CourseID);
            course.HasOne(p => p.Teacher).WithMany(p => p.Courses);
        });

        modelBuilder.Entity<CourseStudent>(cEstudent => 
        {
            cEstudent.ToTable("CourseStudent");
            cEstudent.HasKey(p => new {p.StudentId, p.CourseId});
            cEstudent.HasOne(p => p.Course).WithMany(p => p.CourseStudents).HasForeignKey(p => p.CourseId);
            cEstudent.HasOne(p => p.Student).WithMany(p => p.CourseStudents).HasForeignKey(p => p.StudentId);
        });

    }
}