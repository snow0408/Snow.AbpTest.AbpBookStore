using Snow.AbpBookStore.Samples;
using Xunit;

namespace Snow.AbpBookStore.EntityFrameworkCore.Applications;

[Collection(AbpBookStoreTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<AbpBookStoreEntityFrameworkCoreTestModule>
{

}
