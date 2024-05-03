using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace Snow.AbpBookStore.Web;

[Dependency(ReplaceServices = true)]
public class AbpBookStoreBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "AbpBookStore";
}
