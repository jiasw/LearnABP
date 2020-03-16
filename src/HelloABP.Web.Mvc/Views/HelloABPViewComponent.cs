using Abp.AspNetCore.Mvc.ViewComponents;

namespace HelloABP.Web.Views
{
    public abstract class HelloABPViewComponent : AbpViewComponent
    {
        protected HelloABPViewComponent()
        {
            LocalizationSourceName = HelloABPConsts.LocalizationSourceName;
        }
    }
}
