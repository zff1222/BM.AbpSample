using Abp.Web.Mvc.Views;

namespace BM.AbpSample.Web.Views
{
    public abstract class AbpSampleWebViewPageBase : AbpSampleWebViewPageBase<dynamic>
    {

    }

    public abstract class AbpSampleWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected AbpSampleWebViewPageBase()
        {
            LocalizationSourceName = AbpSampleConsts.LocalizationSourceName;
        }
    }
}