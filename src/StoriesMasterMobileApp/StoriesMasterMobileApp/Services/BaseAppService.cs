using CrossCutting.Disposable;

namespace StoriesMasterMobileApp.Services
{
    public class BaseAppService : DisposableObject
    {
        protected override void ReleaseResources()
        {
        }
    }
}
