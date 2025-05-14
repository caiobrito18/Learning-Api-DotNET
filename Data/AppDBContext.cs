using LearningAPI1.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;

namespace LearningAPI1.Data
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Consultant> Consultants{ get; set; }
        public DbSet<Project> Projects{ get; set; }
        public DbSet<RoleRelation> RolesRelations{ get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Project>()
                .HasMany(e => e.Consultants)
                .WithMany(e => e.Projects)
                .UsingEntity<RoleRelation>(j =>
                j.Property(e =>
                e.CreatedAt).HasDefaultValueSql("getdate()"));
            modelBuilder.Entity<Consultant>().Property(b => b.CreatedAt).HasDefaultValue("getdate()");
            modelBuilder.Entity<Project>().Property(b => b.CreatedAt).HasDefaultValue("getdate()");
        }
    }
}
