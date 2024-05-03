using System;
using System.Collections.Generic;
using System.Text;
using Snow.AbpBookStore.Localization;
using Volo.Abp.Application.Services;

namespace Snow.AbpBookStore;

/* Inherit your application services from this class.
 */
public abstract class AbpBookStoreAppService : ApplicationService
{
    protected AbpBookStoreAppService()
    {
        LocalizationResource = typeof(AbpBookStoreResource);
    }
}
