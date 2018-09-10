using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;

namespace ConfigurationSettings
{
    public class StartUpFunctionsConfiguration : ConfigurationElement
    {
        public const string XmlConfigKey = "StartUpFunctions";

        private const string functionNames = "FunctionNames";

        [ConfigurationProperty(functionNames, IsRequired = false, DefaultValue = "")]
        public string FunctionNames
        {
            get { return (string)base[functionNames]; }
            set { base[functionNames] = value; }
        }
    }
}
