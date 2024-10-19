using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.EntityFrameworkCore;
using MVC5_Day15.Models;

namespace MVC5_Day15.Context
{
    public class TrainingContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = DESKTOP-S5UM1N8\\SQLEXPRESS ; Database = MVC.ITI ;Trusted_Connection=true ; Encrypt=false");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>()
            .HasOne(d => d.Department)
            .WithMany(c => c.Students)
            .HasForeignKey(d => d.DepartmentId).OnDelete(DeleteBehavior.SetNull);
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Instructore>()
               .HasOne(d => d.Department)
               .WithMany(c => c.Instructores)
               .HasForeignKey(d => d.DepartmentId).OnDelete(DeleteBehavior.SetNull);
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Instructore>()
               .HasOne(d => d.Course)
               .WithMany(c => c.Instructores)
               .HasForeignKey(d => d.CourseId).OnDelete(DeleteBehavior.SetNull);
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Course_Result>()
               .HasOne(d => d.Student)
               .WithMany(c => c.Course_Results)
               .HasForeignKey(d => d.SSN).OnDelete(DeleteBehavior.SetNull);
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Course_Result>()
               .HasOne(d => d.Course)
               .WithMany(c => c.Course_Results)
               .HasForeignKey(d => d.CourseId).OnDelete(DeleteBehavior.SetNull);
            base.OnModelCreating(modelBuilder);


            modelBuilder.Entity<Course>()
               .HasOne(d => d.Department)
               .WithMany(c => c.Courses)
               .HasForeignKey(d => d.DepartmentId).OnDelete(DeleteBehavior.SetNull);
            base.OnModelCreating(modelBuilder);
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Instructore> Instructores { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Course_Result> Course_Results { get; set; }
    }
}
