using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace ACme.BookStore.Data;

/* This is used if database provider does't define
 * IBookStoreDbSchemaMigrator implementation.
 */
public class NullBookStoreDbSchemaMigrator : IBookStoreDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
