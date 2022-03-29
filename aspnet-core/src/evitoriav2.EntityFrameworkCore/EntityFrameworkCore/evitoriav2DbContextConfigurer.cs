using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace evitoriav2.EntityFrameworkCore
{
    public static class evitoriav2DbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<evitoriav2DbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<evitoriav2DbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
