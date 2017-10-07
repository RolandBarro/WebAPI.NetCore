using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WebApplicationAPI.Models
{
    public partial class D__RANDYFAMADOR_API_TRAINING_SAMPLEDB_MDFContext : DbContext
    {
        public virtual DbSet<Person> Person { get; set; }

        public D__RANDYFAMADOR_API_TRAINING_SAMPLEDB_MDFContext(DbContextOptions<D__RANDYFAMADOR_API_TRAINING_SAMPLEDB_MDFContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>(entity =>
            {
                entity.Property(e => e.Firstname).HasColumnType("varchar(50)");

                entity.Property(e => e.LastName).HasColumnType("varchar(50)");
            });
        }
    }
}