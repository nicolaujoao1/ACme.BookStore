using System;
using System.Collections.Generic;
using System.Text;
using ACme.BookStore.Localization;
using Volo.Abp.Application.Services;

namespace ACme.BookStore;

/* Inherit your application services from this class.
 */
public abstract class BookStoreAppService : ApplicationService
{
    protected BookStoreAppService()
    {
        LocalizationResource = typeof(BookStoreResource);
    }
}
