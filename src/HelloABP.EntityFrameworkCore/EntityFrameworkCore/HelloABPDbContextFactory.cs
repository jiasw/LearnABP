using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using HelloABP.Configuration;
using HelloABP.Web;

namespace HelloABP.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class HelloABPDbContextFactory : IDesignTimeDbContextFactory<HelloABPDbContext>
    {
        public HelloABPDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<HelloABPDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            HelloABPDbContextConfigurer.Configure(builder, configuration.GetConnectionString(HelloABPConsts.ConnectionStringName));

            return new HelloABPDbContext(builder.Options);
        }
    }
}
