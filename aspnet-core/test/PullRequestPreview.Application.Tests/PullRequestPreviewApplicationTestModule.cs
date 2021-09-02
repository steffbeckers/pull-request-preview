using Volo.Abp.Modularity;

namespace PullRequestPreview
{
    [DependsOn(
        typeof(PullRequestPreviewApplicationModule),
        typeof(PullRequestPreviewDomainTestModule)
        )]
    public class PullRequestPreviewApplicationTestModule : AbpModule
    {

    }
}