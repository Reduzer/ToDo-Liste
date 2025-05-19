using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Database.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using Shared.Entity;

namespace Database.Context
{
	internal class ToDoContext : DbContext
	{
		public ToDoContext(DbContextOptions options) : base(options){}

		public virtual DbSet<User> Users { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<User>().ToTable("Users");
			modelBuilder.Entity<Password>().ToTable("Passwords");
			modelBuilder.Entity<Entity.Task>().ToTable("Tasks");
			modelBuilder.Entity<Project>().ToTable("Project");
		}
	}
}
