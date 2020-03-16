using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace HelloABP.EntityFrameworkCore
{
    public static class HelloABPDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<HelloABPDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<HelloABPDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
