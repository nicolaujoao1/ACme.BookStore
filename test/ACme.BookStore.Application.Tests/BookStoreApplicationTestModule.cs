using Volo.Abp.Modularity;

namespace ACme.BookStore;

[DependsOn(
    typeof(BookStoreApplicationModule),
    typeof(BookStoreDomainTestModule)
    )]
public class BookStoreApplicationTestModule : AbpModule
{

}
