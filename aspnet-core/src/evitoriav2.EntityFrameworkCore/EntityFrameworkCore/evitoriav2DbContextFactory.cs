using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using evitoriav2.Configuration;
using evitoriav2.Web;

namespace evitoriav2.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class evitoriav2DbContextFactory : IDesignTimeDbContextFactory<evitoriav2DbContext>
    {
        public evitoriav2DbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<evitoriav2DbContext>();
            
            /*
             You can provide an environmentName parameter to the AppConfigurations.Get method. 
             In this case, AppConfigurations will try to read appsettings.{environmentName}.json.
             Use Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") method or from string[] args to get environment if necessary.
             https://docs.microsoft.com/en-us/ef/core/cli/dbcontext-creation?tabs=dotnet-core-cli#args
             */
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            evitoriav2DbContextConfigurer.Configure(builder, configuration.GetConnectionString(evitoriav2Consts.ConnectionStringName));

            return new evitoriav2DbContext(builder.Options);
        }
    }
}
