using ACme.BookStore.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace ACme.BookStore;

[DependsOn(
    typeof(BookStoreEntityFrameworkCoreTestModule)
    )]
public class BookStoreDomainTestModule : AbpModule
{

}
