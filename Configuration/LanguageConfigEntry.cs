using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace ConfigurationSettings
{    
    /// <summary>
    /// Configuration data for Languages
    /// </summary>
    public class LanguageConfigEntry : ConfigurationElement
    {
        private const string name = "Name";

        /// <summary>
        /// Gets and sets the name of the Language in the format "[languagecode2]-[country/regioncode2]", where
        /// [languagecode2] is a lowercase two-letter code derived from ISO 639-1 and
        /// [country/regioncode2] is an uppercase two-letter code derived from ISO 3166.
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
