using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace ConfigurationSettings
{
    /// <summary>
    /// Configuration data for AuthenticationProvider
    /// </summary>
    public class AuthenticationProviderConfiguration : ConfigurationElement
    {
        private const string authenticationProviderType = "AuthenticationProviderType";
        private const string authenticationProviderAssembly = "AuthenticationProviderAssembly";

        /// <summary>
        /// The Xml configuration Key.
        /// </summary>
        public const string XmlConfigKey = "AuthenticationProvider";

        /// <summary>
        /// 
        /// </summary>
        /// <remarks></remarks>
        [ConfigurationProperty(authenticationProviderType, IsRequired = true, DefaultValue = "")]
        public string AuthenticationProviderType
        {
            get { return (string)base[authenticationProviderType]; }
            set { base[authenticationProviderType] = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks></remarks>
        [ConfigurationProperty(authenticationProviderAssembly, IsRequired = true, DefaultValue = "")]
        public string AuthenticationProviderAssembly
        {
            get { return (string)base[authenticationProviderAssembly]; }
            set { base[authenticationProviderAssembly] = value; }
        }
    }
}
