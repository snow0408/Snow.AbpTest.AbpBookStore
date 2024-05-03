using Microsoft.AspNetCore.Builder;
using Snow.AbpBookStore;
using Volo.Abp.AspNetCore.TestBase;

var builder = WebApplication.CreateBuilder();
await builder.RunAbpModuleAsync<AbpBookStoreWebTestModule>();

public partial class Program
{
}
