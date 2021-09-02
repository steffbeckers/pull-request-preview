using PullRequestPreview.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace PullRequestPreview.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class PullRequestPreviewController : AbpController
    {
        protected PullRequestPreviewController()
        {
            LocalizationResource = typeof(PullRequestPreviewResource);
        }
    }
}