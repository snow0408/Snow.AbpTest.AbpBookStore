using Snow.AbpBookStore.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Snow.AbpBookStore.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class AbpBookStorePageModel : AbpPageModel
{
    protected AbpBookStorePageModel()
    {
        LocalizationResourceType = typeof(AbpBookStoreResource);
    }
}
