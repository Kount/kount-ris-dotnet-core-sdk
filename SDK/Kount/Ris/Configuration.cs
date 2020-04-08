using Microsoft.Extensions.Configuration;
using System.Configuration;
using System.IO;

namespace Kount.Ris
{
    /// <summary>
    /// Containing configuration values
    /// </summary>
    public class Configuration
    {
        /// <summary>
        /// Gets configuration values from app settings.
        /// </summary>
        /// <returns>Configuration class with raw values.</returns>
        public static Configuration FromAppSettings()
        {
            var builder = new ConfigurationBuilder()
              .SetBasePath(Directory.GetCurrentDirectory())
              .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

            IConfigurationRoot configuration = builder.Build();

            return new Configuration()
            {

                MerchantId = configuration.GetConnectionString("Ris.MerchantId"),
                URL = configuration.GetConnectionString("Ris.Url"),
                ConfigKey = configuration.GetConnectionString("Ris.Config.Key"),
                ConnectTimeout = configuration.GetConnectionString("Ris.Connect.Timeout"),
                Version = configuration.GetConnectionString("Ris.Version"),
                ApiKey = configuration.GetConnectionString("Ris.API.Key"),
                CertificateFile = configuration.GetConnectionString("Ris.CertificateFile"),
                PrivateKeyPassword = configuration.GetConnectionString("Ris.PrivateKeyPassword"),


            };
        }

        /// <summary>
        /// Six digit identifier issued by Kount.
        /// </summary>
        public string MerchantId { get; set; }

        /// <summary>
        /// HTTPS URL path to the company's servers provided in boarding documentation from Kount.
        /// </summary>
        public string URL { get; set; }

        /// <summary>
        /// Config Key used in hashing method.
        /// </summary>
        public string ConfigKey { get; set; }

        /// <summary>
        /// RIS connect timeout value measured in milliseconds.
        /// </summary>
        public string ConnectTimeout { get; set; }

        /// <summary>
        /// RIS version
        /// </summary>
        public string Version { get; set; }

        /// <summary>
        /// API Key value from API Key page within Agent Web Console.
        /// </summary>
        public string ApiKey { get; set; }

        /// <summary>
        /// Full path of the certificate pk12 or pfx file.
        /// </summary>
        public string CertificateFile { get; set; }

        /// <summary>
        /// Password used to export the certificate
        /// </summary>
        public string PrivateKeyPassword { get; set; }
    }
}