using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace ConfigurationSettings
{
    /// <summary>
    /// 
    /// </summary>
    public class StartUpConfigSection : System.Configuration.ConfigurationSection
    {
        /// <summary>
        /// The Xml configuration key for use case catalog.
        /// </summary>
        public const string XmlConfigKey = "StartUpConfiguration";

        /// <summary>
        /// Gets the collection of <see cref="LogonStyleConfiguration"/> items from the configuration file.
        /// </summary>
        //[ConfigurationProperty(LogonStyleConfiguration.XmlConfigKey)]
        //public LogonStyleConfiguration LogonStyle
        //{
        //    get
        //    {
        //        return (LogonStyleConfiguration)base[LogonStyleConfiguration.XmlConfigKey];
        //    }
        //}

        /// <summary>
        /// Gets the collection of <see cref="AuthenticationProviderConfiguration"/> items from the configuration file.
        /// </summary>
        //[ConfigurationProperty(AuthenticationProviderConfiguration.XmlConfigKey)]
        //public AuthenticationProviderConfiguration AuthenticationProvider
        //{
        //    get
        //    {
        //        return (AuthenticationProviderConfiguration)base[AuthenticationProviderConfiguration.XmlConfigKey];
        //    }
        //}

        /// <summary>
        /// Gets the collection of <see cref="LanguageConfigEntry"/> items from the configuration file.
        /// </summary>
        [ConfigurationProperty(LanguageConfigEntryCollection.XmlConfigKey)]
        public LanguageConfigEntryCollection LanguageConfigure
        {
            get
            {
                return (LanguageConfigEntryCollection)base[LanguageConfigEntryCollection.XmlConfigKey];
            }
        }

        /// <summary>
        /// Gets the collection of <see cref="DomainConfigEntry"/> items from the configuration file.
        /// </summary>
        //[ConfigurationProperty(DomainConfigEntryCollection.XmlConfigKey)]
        //public DomainConfigEntryCollection DomainConfigure
        //{
        //    get
        //    {
        //        return (DomainConfigEntryCollection)base[DomainConfigEntryCollection.XmlConfigKey];
        //    }
        //}

        //[ConfigurationProperty(StartUpFunctionsConfiguration.XmlConfigKey)]
        //public StartUpFunctionsConfiguration StartUpFunctionsConfigure
        //{
        //    get
        //    {
        //        return (StartUpFunctionsConfiguration)base[StartUpFunctionsConfiguration.XmlConfigKey];
        //    }
        //}
    }
}
