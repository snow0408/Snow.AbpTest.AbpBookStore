using Volo.Abp.Modularity;

namespace Snow.AbpBookStore;

/* Inherit from this class for your domain layer tests. */
public abstract class AbpBookStoreDomainTestBase<TStartupModule> : AbpBookStoreTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
