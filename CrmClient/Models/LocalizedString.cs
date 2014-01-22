using CrmClient.Resources;

namespace CrmClient.Models
{
    class LocalizedString
    {
        private static AppResources _localizedResources = new AppResources();

        public AppResources LocalizedResources { get { return _localizedResources; } }
    }
}
