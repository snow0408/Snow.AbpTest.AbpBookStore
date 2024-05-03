using Volo.Abp.Modularity;

namespace Snow.AbpBookStore;

[DependsOn(
    typeof(AbpBookStoreDomainModule),
    typeof(AbpBookStoreTestBaseModule)
)]
public class AbpBookStoreDomainTestModule : AbpModule
{

}
