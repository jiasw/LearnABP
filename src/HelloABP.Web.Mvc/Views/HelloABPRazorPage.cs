using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;
using Microsoft.AspNetCore.Mvc.Razor.Internal;

namespace HelloABP.Web.Views
{
    public abstract class HelloABPRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected HelloABPRazorPage()
        {
            LocalizationSourceName = HelloABPConsts.LocalizationSourceName;
        }
    }
}
