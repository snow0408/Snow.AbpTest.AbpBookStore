using Volo.Abp.Modularity;

namespace Snow.AbpBookStore;

[DependsOn(
    typeof(AbpBookStoreApplicationModule),
    typeof(AbpBookStoreDomainTestModule)
)]
public class AbpBookStoreApplicationTestModule : AbpModule
{

}
