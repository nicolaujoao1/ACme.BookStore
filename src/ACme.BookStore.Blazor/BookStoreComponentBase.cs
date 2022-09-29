using ACme.BookStore.Localization;
using Volo.Abp.AspNetCore.Components;

namespace ACme.BookStore.Blazor;

public abstract class BookStoreComponentBase : AbpComponentBase
{
    protected BookStoreComponentBase()
    {
        LocalizationResource = typeof(BookStoreResource);
    }
}
