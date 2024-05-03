using Snow.AbpBookStore.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Snow.AbpBookStore.Permissions;

public class AbpBookStorePermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var bookStoreGroup = context.AddGroup(AbpBookStorePermissions.GroupName, L("Permission:BookStore"));

        var booksPermission = bookStoreGroup.AddPermission(AbpBookStorePermissions.Books.Default, L("Permission:Books"));
        booksPermission.AddChild(AbpBookStorePermissions.Books.Create, L("Permission:Books.Create"));
        booksPermission.AddChild(AbpBookStorePermissions.Books.Edit, L("Permission:Books.Edit"));
        booksPermission.AddChild(AbpBookStorePermissions.Books.Delete, L("Permission:Books.Delete"));

        var authorsPermission = bookStoreGroup.AddPermission(
    AbpBookStorePermissions.Authors.Default, L("Permission:Authors"));

        authorsPermission.AddChild(
            AbpBookStorePermissions.Authors.Create, L("Permission:Authors.Create"));

        authorsPermission.AddChild(
            AbpBookStorePermissions.Authors.Edit, L("Permission:Authors.Edit"));

        authorsPermission.AddChild(
            AbpBookStorePermissions.Authors.Delete, L("Permission:Authors.Delete"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<AbpBookStoreResource>(name);
    }
}
