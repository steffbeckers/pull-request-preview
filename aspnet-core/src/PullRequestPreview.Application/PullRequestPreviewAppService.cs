using System;
using System.Collections.Generic;
using System.Text;
using PullRequestPreview.Localization;
using Volo.Abp.Application.Services;

namespace PullRequestPreview
{
    /* Inherit your application services from this class.
     */
    public abstract class PullRequestPreviewAppService : ApplicationService
    {
        protected PullRequestPreviewAppService()
        {
            LocalizationResource = typeof(PullRequestPreviewResource);
        }
    }
}
