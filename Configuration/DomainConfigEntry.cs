using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace ConfigurationSettings
{    
    /// <summary>
    /// Configuration data for Domain options
    /// </summary>
    public class DomainConfigEntry : ConfigurationElement
    {
        private const string name = "Name";

        /// <summary>
        /// the domain name
        /// </summary>
        /// <remarks></remarks>
        [ConfigurationProperty(name, IsRequired = true)]
        public string Name
        {
            get { return (string)base[name]; }
            set { base[name] = value; }
        }
    }
}
