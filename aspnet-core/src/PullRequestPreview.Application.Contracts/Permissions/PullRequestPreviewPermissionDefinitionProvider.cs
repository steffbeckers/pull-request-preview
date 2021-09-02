using PullRequestPreview.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace PullRequestPreview.Permissions
{
    public class PullRequestPreviewPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(PullRequestPreviewPermissions.GroupName);
            //Define your own permissions here. Example:
            //myGroup.AddPermission(PullRequestPreviewPermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<PullRequestPreviewResource>(name);
        }
    }
}
