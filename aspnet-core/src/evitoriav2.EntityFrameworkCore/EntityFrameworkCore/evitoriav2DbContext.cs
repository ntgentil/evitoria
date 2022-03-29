using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using evitoriav2.Authorization.Roles;
using evitoriav2.Authorization.Users;
using evitoriav2.MultiTenancy;

namespace evitoriav2.EntityFrameworkCore
{
    public class evitoriav2DbContext : AbpZeroDbContext<Tenant, Role, User, evitoriav2DbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public evitoriav2DbContext(DbContextOptions<evitoriav2DbContext> options)
            : base(options)
        {
        }
    }
}
