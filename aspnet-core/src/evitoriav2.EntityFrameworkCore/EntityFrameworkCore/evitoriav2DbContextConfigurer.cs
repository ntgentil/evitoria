using System;
using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace evitoriav2.EntityFrameworkCore
{
    public static class evitoriav2DbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<evitoriav2DbContext> builder, string connectionString)
        {
            var serverVersion = new MySqlServerVersion(new Version(8, 0, 27));
            builder.UseMySql(connectionString, serverVersion);
        }

        public static void Configure(DbContextOptionsBuilder<evitoriav2DbContext> builder, DbConnection connection)
        {
            var serverVersion = new MySqlServerVersion(new Version(8, 0, 27));
            builder.UseMySql(connection, serverVersion);
        }
    }
}
