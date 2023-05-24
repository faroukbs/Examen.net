using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Numerics;
using TE.Core.Domain;
using TE.Data.Configuration;

namespace TE.Data
{
    public class TEContext:DbContext
    {
        public DbSet<Tache> Taches { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\mssqllocaldb;
                                        Initial Catalog = ScrumFaroukBoussaid; 
                                        Integrated Security = true");
            optionsBuilder.UseLazyLoadingProxies();
        }
    
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            modelBuilder.ApplyConfiguration(new TacheConfiguration());
            modelBuilder.Entity<Tache>().HasKey(e => new { e.SprintKey, e.MemberKey, e.Titre });
        }

        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            configurationBuilder.Properties<string>().HaveMaxLength(200);
          
        }

    }
}