using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Snow.AbpBookStore.Data;
using Volo.Abp.DependencyInjection;

namespace Snow.AbpBookStore.EntityFrameworkCore;

public class EntityFrameworkCoreAbpBookStoreDbSchemaMigrator
    : IAbpBookStoreDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreAbpBookStoreDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolve the AbpBookStoreDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<AbpBookStoreDbContext>()
            .Database
            .MigrateAsync();
    }
}
