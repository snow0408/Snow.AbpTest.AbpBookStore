using Snow.AbpBookStore.Books;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Snow.AbpBookStore.EntityFrameworkCore.Applications.Books
{
    [Collection(AbpBookStoreTestConsts.CollectionDefinitionName)]
    public class EfCoreBookAppService_Tests : BookAppService_Tests<AbpBookStoreEntityFrameworkCoreTestModule>
    {

    }
}
