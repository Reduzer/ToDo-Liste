using Microsoft.EntityFrameworkCore;
using Shared.Entity;

namespace DatabaseService.Context
{
	public class PasswordContext : DbContext
	{
		public virtual DbSet<User> vsoUser { get; set; }
		public virtual DbSet<Password> vsoPasswords { get; set; }
		public virtual DbSet<Task> vsoTasks { get; set; }
		public virtual DbSet<Project> vsoProjects { get; set; }

		public PasswordContext(DbContextOptions oOptions) : base() { }

		
	}
}
