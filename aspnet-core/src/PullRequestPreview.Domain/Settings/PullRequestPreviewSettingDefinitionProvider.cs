using Volo.Abp.Settings;

namespace PullRequestPreview.Settings
{
    public class PullRequestPreviewSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(PullRequestPreviewSettings.MySetting1));
        }
    }
}
