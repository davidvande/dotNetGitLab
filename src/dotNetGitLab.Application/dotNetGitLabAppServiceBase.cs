using Abp.Application.Services;

namespace dotNetGitLab
{
    /// <summary>
    /// Derive your application services from this class.
    /// </summary>
    public abstract class dotNetGitLabAppServiceBase : ApplicationService
    {
        protected dotNetGitLabAppServiceBase()
        {
            LocalizationSourceName = dotNetGitLabConsts.LocalizationSourceName;
        }
    }
}