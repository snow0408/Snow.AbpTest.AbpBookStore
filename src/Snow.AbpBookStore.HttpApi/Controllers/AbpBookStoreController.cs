using Snow.AbpBookStore.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Snow.AbpBookStore.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class AbpBookStoreController : AbpControllerBase
{
    protected AbpBookStoreController()
    {
        LocalizationResource = typeof(AbpBookStoreResource);
    }
}
