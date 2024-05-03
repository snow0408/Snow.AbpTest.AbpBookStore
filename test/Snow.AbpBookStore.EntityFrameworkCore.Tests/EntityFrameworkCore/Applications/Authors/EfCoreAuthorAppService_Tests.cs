using Snow.AbpBookStore.Authors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Snow.AbpBookStore.EntityFrameworkCore.Applications.Authors
{
    [Collection(AbpBookStoreTestConsts.CollectionDefinitionName)]
    public class EfCoreAuthorAppService_Tests : AuthorAppService_Tests<AbpBookStoreEntityFrameworkCoreTestModule>
    {

    }
}
