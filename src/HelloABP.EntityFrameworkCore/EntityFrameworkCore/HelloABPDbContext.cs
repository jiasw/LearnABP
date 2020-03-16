using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using HelloABP.Authorization.Roles;
using HelloABP.Authorization.Users;
using HelloABP.MultiTenancy;
using HelloABP.PhoneBooks.Persons;
using HelloABP.PhoneBooks.PhoneNumbers;

namespace HelloABP.EntityFrameworkCore
{
    public class HelloABPDbContext : AbpZeroDbContext<Tenant, Role, User, HelloABPDbContext>
    {
        /* Define a DbSet for each entity of the application */


        public DbSet<Person> Persons { get; set; }
        public DbSet<PhoneNumber> PhoneNumbers { get; set; }
        public HelloABPDbContext(DbContextOptions<HelloABPDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>().ToTable("Person", "PB");
            modelBuilder.Entity<PhoneNumber>().ToTable("PhoneNumber", "PB");
            base.OnModelCreating(modelBuilder);
        }
    }
}
