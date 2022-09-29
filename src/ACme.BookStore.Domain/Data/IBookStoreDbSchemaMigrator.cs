using System.Threading.Tasks;

namespace ACme.BookStore.Data;

public interface IBookStoreDbSchemaMigrator
{
    Task MigrateAsync();
}
