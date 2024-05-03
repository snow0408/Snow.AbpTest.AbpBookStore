using Snow.AbpBookStore.Samples;
using Xunit;

namespace Snow.AbpBookStore.EntityFrameworkCore.Domains;

[Collection(AbpBookStoreTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<AbpBookStoreEntityFrameworkCoreTestModule>
{

}
