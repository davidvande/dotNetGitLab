using Abp.Web.Mvc.Controllers;

namespace dotNetGitLab.Web.Controllers
{
    /// <summary>
    /// Derive all Controllers from this class.
    /// </summary>
    public abstract class dotNetGitLabControllerBase : AbpController
    {
        protected dotNetGitLabControllerBase()
        {
            LocalizationSourceName = dotNetGitLabConsts.LocalizationSourceName;
        }
    }
}