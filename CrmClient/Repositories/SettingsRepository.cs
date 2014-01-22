using CrmClient.Models;
using System.IO.IsolatedStorage;

namespace CrmClient.Repositories
{
    class SettingsRepository
    {

        public Settings GetSettings()
        {
            Settings settings;
            if (IsolatedStorageSettings.ApplicationSettings.TryGetValue("Settings", out settings))
            {
                return settings;
            }
            return new Settings();
        }

        public void SaveSettings(Settings settings)
        {
            IsolatedStorageSettings.ApplicationSettings["Settings"] = settings;
        }
    }
}
