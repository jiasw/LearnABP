using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using HelloABP.Authorization;

namespace HelloABP
{
    [DependsOn(
        typeof(HelloABPCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class HelloABPApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<HelloABPAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(HelloABPApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
