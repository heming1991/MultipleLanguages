using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace ConfigurationSettings
{
    /// <summary>
    /// Configuration data for LogonStyle
    /// </summary>
    public class LogonStyleConfiguration : ConfigurationElement
    {
        private const string autoLogin = "AutoLogin";
        private const string allowChangeUser = "AllowChangeUser";
        private const string bannerImageLocation = "BannerImageLocation";
        private const string autoFillUserName = "AutoFillUserName";

        /// <summary>
        /// The Xml configuration Key.
        /// </summary>
        public const string XmlConfigKey = "LogonStyle";

        /// <summary>
        /// 
        /// </summary>
        /// <remarks></remarks>
        [ConfigurationProperty(autoLogin, IsRequired = false, DefaultValue = false)]
        public bool AutoLogin
        {
            get { return (bool)base[autoLogin]; }
            set { base[autoLogin] = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks></remarks>
        [ConfigurationProperty(allowChangeUser, IsRequired = false, DefaultValue = true)]
        public bool AllowChangeUser
        {
            get { return (bool)base[allowChangeUser]; }
            set { base[allowChangeUser] = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks></remarks>
        [ConfigurationProperty(bannerImageLocation, IsRequired = false, DefaultValue = "")]
        public string BannerImageLocation
        {
            get { return (string)base[bannerImageLocation]; }
            set { base[bannerImageLocation] = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks></remarks>
        [ConfigurationProperty(autoFillUserName, IsRequired = false, DefaultValue = "false")]
        public bool AutoFillUserName
        {
            get { return (bool)base[autoFillUserName]; }
            set { base[autoFillUserName] = value; }
        }
    }
}
