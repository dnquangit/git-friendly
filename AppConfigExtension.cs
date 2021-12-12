using System.Configuration;
using System.Reflection;

namespace GitApp
{
    public static class AppConfigExtension
    {
        public static void UpdateSetting(string key, string value)
        {
            Configuration configuration = ConfigurationManager.
                OpenExeConfiguration(Assembly.GetExecutingAssembly().Location);
            configuration.AppSettings.Settings[key].Value = value;
            configuration.Save();

            ConfigurationManager.RefreshSection("appSettings");
        }
    }
}
