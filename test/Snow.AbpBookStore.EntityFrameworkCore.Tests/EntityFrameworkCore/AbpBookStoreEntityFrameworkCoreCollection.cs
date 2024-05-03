using Xunit;

namespace Snow.AbpBookStore.EntityFrameworkCore;

[CollectionDefinition(AbpBookStoreTestConsts.CollectionDefinitionName)]
public class AbpBookStoreEntityFrameworkCoreCollection : ICollectionFixture<AbpBookStoreEntityFrameworkCoreFixture>
{

}
