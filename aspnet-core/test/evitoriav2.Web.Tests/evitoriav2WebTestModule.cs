using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using evitoriav2.EntityFrameworkCore;
using evitoriav2.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace evitoriav2.Web.Tests
{
    [DependsOn(
        typeof(evitoriav2WebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class evitoriav2WebTestModule : AbpModule
    {
        public evitoriav2WebTestModule(evitoriav2EntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(evitoriav2WebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(evitoriav2WebMvcModule).Assembly);
        }
    }
}