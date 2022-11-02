using MySqlConnector;
using System.Configuration;

namespace CryptoWatcherLib.DataAccess.AppConfig
{
    public sealed class AppConfigAccess : IAppConfigAccess
    {
        public string GetDbConnectionString()
        {
            return new MySqlConnectionStringBuilder
            {
                Server = GetValueFromKey("dBServer"),
                Database = GetValueFromKey("dBDatabase"),
                UserID = GetValueFromKey("dBUserID"),
                Password = GetValueFromKey("dBPassword")
            }.ConnectionString;
        }

        public string GetCryptoCurrencyApiKey()
        {
            return GetValueFromKey("cryptoCurrencyApiKey");
        }
        /// <summary>
        /// The function returns the stored value in the app config from the given key.
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        private string GetValueFromKey(string key)
        {
            try
            {
                return ConfigurationManager.AppSettings[key];
            }
            catch (Exception e)
            {
                throw new Exception($"Error while trying to read the folling appconfig Key: {key} | Errormessage: {e.Message} | InnerException: {e.InnerException} | Stacktrace: {e.StackTrace}");
            }
        }

        public void UpdateAppConfigKey(string key, string value)
        {
            try
            {
                var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                var settings = configFile.AppSettings.Settings;
                if (settings[key] == null)
                {
                    settings.Add(key, value);
                }
                else
                {
                    settings[key].Value = value;
                }
                configFile.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection(configFile.AppSettings.SectionInformation.Name);
            }
            catch (ConfigurationErrorsException ex)
            {
                throw new ConfigurationErrorsException($"Error writing to the app config | {ex.Message}");
            }
        }


    }
}
