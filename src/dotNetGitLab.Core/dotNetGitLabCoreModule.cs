using System.Reflection;
using Abp.Modules;

namespace dotNetGitLab
{
    public class dotNetGitLabCoreModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
