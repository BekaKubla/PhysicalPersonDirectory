using Microsoft.EntityFrameworkCore;
using PhysicalPersonDirectory.Domain.Entities;

namespace PhysicalPersonDirectory.Infrastructure.Data
{
    public class PersonAppDbContext : DbContext
    {
        public PersonAppDbContext(DbContextOptions<PersonAppDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RelationPerson>()
                        .HasOne(a => a.Person)
                        .WithMany(a => a.Relationship)
                        .HasForeignKey(a => a.PersonId)
                        .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<RelationPerson>()
                        .HasOne(e => e.RelatedPerson)
                        .WithMany(e => e.RelatedTo)
                        .HasForeignKey(e => e.RelatedPersonId)
                        .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
