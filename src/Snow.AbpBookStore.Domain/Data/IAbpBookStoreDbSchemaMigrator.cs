using System.Threading.Tasks;

namespace Snow.AbpBookStore.Data;

public interface IAbpBookStoreDbSchemaMigrator
{
    Task MigrateAsync();
}
