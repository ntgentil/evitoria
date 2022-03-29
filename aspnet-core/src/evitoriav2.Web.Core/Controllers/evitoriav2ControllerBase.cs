using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace evitoriav2.Controllers
{
    public abstract class evitoriav2ControllerBase: AbpController
    {
        protected evitoriav2ControllerBase()
        {
            LocalizationSourceName = evitoriav2Consts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
