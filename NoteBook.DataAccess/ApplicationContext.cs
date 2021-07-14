using Microsoft.EntityFrameworkCore;
using NoteBook.DataAccess.Configuration;
using NoteBook.DataAccess.Model;

namespace NoteBook.DataAccess
{
    public sealed class ApplicationContext : DbContext
    {
        public DbSet<Issue> Issues { get; set; }
        public DbSet<IssueType> IssueTypes { get; set; }

        public ApplicationContext()
        {
            //Database.EnsureDeleted();
            //Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=DayPlanner;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new IssueConfiguration());
            modelBuilder.ApplyConfiguration(new IssueTypeConfiguration());
        }
    }
}
