using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace HelloABP.Controllers
{
    public abstract class HelloABPControllerBase: AbpController
    {
        protected HelloABPControllerBase()
        {
            LocalizationSourceName = HelloABPConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
