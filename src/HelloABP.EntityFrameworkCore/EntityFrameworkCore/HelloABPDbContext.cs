using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using HelloABP.Authorization.Roles;
using HelloABP.Authorization.Users;
using HelloABP.MultiTenancy;

namespace HelloABP.EntityFrameworkCore
{
    public class HelloABPDbContext : AbpZeroDbContext<Tenant, Role, User, HelloABPDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public HelloABPDbContext(DbContextOptions<HelloABPDbContext> options)
            : base(options)
        {
        }
    }
}
