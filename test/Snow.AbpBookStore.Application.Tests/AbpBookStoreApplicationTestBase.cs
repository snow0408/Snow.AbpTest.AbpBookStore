using Volo.Abp.Modularity;

namespace Snow.AbpBookStore;

public abstract class AbpBookStoreApplicationTestBase<TStartupModule> : AbpBookStoreTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
