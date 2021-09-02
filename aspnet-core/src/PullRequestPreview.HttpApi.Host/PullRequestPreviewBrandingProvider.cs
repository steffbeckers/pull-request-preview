using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace PullRequestPreview
{
    [Dependency(ReplaceServices = true)]
    public class PullRequestPreviewBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "PullRequestPreview";
    }
}
