using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using evitoriav2.Authorization;

namespace evitoriav2
{
    [DependsOn(
        typeof(evitoriav2CoreModule), 
        typeof(AbpAutoMapperModule))]
    public class evitoriav2ApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<evitoriav2AuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(evitoriav2ApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
