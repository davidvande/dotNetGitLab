using System.Reflection;
using Abp.Modules;

namespace dotNetGitLab
{
    [DependsOn(typeof(dotNetGitLabCoreModule))]
    public class dotNetGitLabApplicationModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
