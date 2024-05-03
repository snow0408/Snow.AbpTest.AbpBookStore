using Snow.AbpBookStore.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace Snow.AbpBookStore.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(AbpBookStoreEntityFrameworkCoreModule),
    typeof(AbpBookStoreApplicationContractsModule)
    )]
public class AbpBookStoreDbMigratorModule : AbpModule
{
}
