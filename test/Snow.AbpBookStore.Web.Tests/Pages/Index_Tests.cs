using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace Snow.AbpBookStore.Pages;

public class Index_Tests : AbpBookStoreWebTestBase
{
    [Fact]
    public async Task Welcome_Page()
    {
        var response = await GetResponseAsStringAsync("/");
        response.ShouldNotBeNull();
    }
}
