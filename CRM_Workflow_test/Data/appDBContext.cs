using CRM_Workflow_test.Models;
using Microsoft.EntityFrameworkCore;

namespace CRM_Workflow_test.Data
{
    public class appDBContext : DbContext
    {
        public appDBContext(DbContextOptions<appDBContext> options) : base(options) { }

        public DbSet<user> Users { get; set; }
        public DbSet<task> Tasks { get; set; }
        public DbSet<taskTransition> TasksTransition { get; set; }
        public DbSet<taskInstance> TaskInstances { get; set; }
        public DbSet<WFInitiation> WFInitiations { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<taskTransition>()
                .HasOne<task>(tt => tt.task)
                .WithMany()
                .HasForeignKey(tt => tt.taskId)
                .OnDelete(DeleteBehavior.Restrict); // Prevent cascade loops

            modelBuilder.Entity<taskTransition>()
                .HasOne<task>(tt => tt.childTask)
                .WithMany()
                .HasForeignKey(tt => tt.childId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
