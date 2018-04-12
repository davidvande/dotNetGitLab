using Abp.Web.Mvc.Views;

namespace dotNetGitLab.Web.Views
{
    public abstract class dotNetGitLabWebViewPageBase : dotNetGitLabWebViewPageBase<dynamic>
    {

    }

    public abstract class dotNetGitLabWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected dotNetGitLabWebViewPageBase()
        {
            LocalizationSourceName = dotNetGitLabConsts.LocalizationSourceName;
        }
    }
}