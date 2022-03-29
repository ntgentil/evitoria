using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using evitoriav2.Configuration;

namespace evitoriav2.Web.Host.Startup
{
    [DependsOn(
       typeof(evitoriav2WebCoreModule))]
    public class evitoriav2WebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public evitoriav2WebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(evitoriav2WebHostModule).GetAssembly());
        }
    }
}
