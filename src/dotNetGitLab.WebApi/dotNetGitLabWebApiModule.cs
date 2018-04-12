using System.Reflection;
using Abp.Application.Services;
using Abp.Configuration.Startup;
using Abp.Modules;
using Abp.WebApi;

namespace dotNetGitLab
{
    [DependsOn(typeof(AbpWebApiModule), typeof(dotNetGitLabApplicationModule))]
    public class dotNetGitLabWebApiModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());

            Configuration.Modules.AbpWebApi().DynamicApiControllerBuilder
                .ForAll<IApplicationService>(typeof(dotNetGitLabApplicationModule).Assembly, "app")
                .Build();
        }
    }
}
