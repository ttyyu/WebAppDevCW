using Microsoft.EntityFrameworkCore;
namespace WebAppDevCW.Models
{
public class CompanyContext : DbContext
    {
        public CompanyContext(DbContextOptions<CompanyContext> options) : base(options)
        {
        }

        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Task> Tasks { get; set; }
        public DbSet<TaskAssignment> TaskAssignments { get; set; }
	}
}
