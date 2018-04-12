using System.Data.Entity;
using System.Reflection;
using Abp.EntityFramework;
using Abp.Modules;
using dotNetGitLab.EntityFramework;

namespace dotNetGitLab
{
    [DependsOn(typeof(AbpEntityFrameworkModule), typeof(dotNetGitLabCoreModule))]
    public class dotNetGitLabDataModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = "Default";
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
            Database.SetInitializer<dotNetGitLabDbContext>(null);
        }
    }
}
