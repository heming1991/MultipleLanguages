using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Diagnostics;

namespace ConfigurationSettings
{
    /// <summary>
    /// ConfigurationCollection for LanguageConfigEntry
    /// </summary>
    [ConfigurationCollection(typeof(LanguageConfigEntry),
        CollectionType = ConfigurationElementCollectionType.AddRemoveClearMap)]
    public class LanguageConfigEntryCollection : ConfigurationElementCollection
    {
        private const string autoSelect = "AutoSelect";
        private const string defaultLanguage = "Default";
        private const string displayNativeName = "DisplayNativeName";

        /// <summary>
        /// The Xml configuration Key.
        /// </summary>
        public const string XmlConfigKey = "Languages";

        #region Indexers
        /// <summary>
        /// set or get LanguageConfigEntry in indexers
        /// </summary>
        /// <param name="index">index number in indexers</param>
        /// <returns></returns>
        public LanguageConfigEntry this[int index]
        {
            get
            {
                return (LanguageConfigEntry)base.BaseGet(index);
            }
            set
            {
                if (base.BaseGet(index) != null)
                {
                    base.BaseRemoveAt(index);
                }
                base.BaseAdd(index, value);
            }
        }

        /// <summary>
        /// Get LanguageConfigEntry from indexers by name
        /// </summary>
        /// <param name="name">name of the target menu of this entry</param>
        /// <returns>return LanguageConfigEntry</returns>
        new public LanguageConfigEntry this[string name]
        {
            get { return (LanguageConfigEntry)base.BaseGet(name); }
        }
        #endregion

        #region Methods
        /// <summary>
        /// Add LanguageConfigEntry element to the ConfigurationElementCollection
        /// </summary>
        /// <param name="item">the LanguageConfigEntry to be added</param>
        public void Add(LanguageConfigEntry item)
        {
            base.BaseAdd(item);
        }

        /// <summary>
        /// remove MenuAdjustmentEntry element to the ConfigurationElementCollection
        /// </summary>
        /// <param name="name">name of the target menu of this entry</param>
        public void Remove(string name)
        {
            base.BaseRemove(name);
        }

        /// <summary>
        /// remove LanguageConfigEntry from indexers
        /// </summary>
        /// <param name="item">the LanguageConfigEntry to be removed</param>
        public void Remove(LanguageConfigEntry item)
        {
            base.BaseRemove(GetElementKey(item));
        }

        /// <summary>
        /// clear the indexer, remove all LanguageConfigEntry
        /// </summary>
        public void Clear()
        {
            base.BaseClear();
        }

        /// <summary>
        /// remove LanguageConfigEntry element from indexer
        /// </summary>
        /// <param name="index">index in the ConfigurationElementCollection</param>
        public void RemoveAt(int index)
        {
            base.BaseRemoveAt(index);
        }

        /// <summary>
        /// Gets the key for the LanguageConfigEntry at the specified index location
        /// </summary>
        /// <param name="index"></param>
        /// <returns>return the name of LanguageConfigEntry</returns>
        public string GetKey(int index)
        {
            return (string)base.BaseGetKey(index);
        }
        #endregion

        #region Overrides
        /// <summary>
        /// create new element of LanguageConfigEntry
        /// </summary>
        /// <returns></returns>
        protected override ConfigurationElement CreateNewElement()
        {
            return new LanguageConfigEntry();
        }

        /// <summary>
        /// get the name of LanguageConfigEntry
        /// </summary>
        /// <param name="element"></param>
        /// <returns></returns>
        protected override object GetElementKey(ConfigurationElement element)
        {
            var entry = element as LanguageConfigEntry;
            Debug.Assert(entry != null);

            if (entry != null)
                return entry.Name;
            else
                return null;
        }
        #endregion

        //[ConfigurationProperty(autoSelect, IsRequired = true, DefaultValue = true)]
        //public bool AutoSelect
        //{
        //    get { return (bool)base[autoSelect]; }
        //    set { base[autoSelect] = value; }
        //}

        [ConfigurationProperty(defaultLanguage, IsRequired = false, DefaultValue = "")]
        public string Default
        {
            get { return (string)base[defaultLanguage]; }
            set { base[defaultLanguage] = value; }
        }

        //[ConfigurationProperty(displayNativeName, IsRequired = false, DefaultValue = true)]
        //public bool DisplayNativeName
        //{
        //    get { return (bool)base[displayNativeName]; }
        //    set { base[displayNativeName] = value; }
        //}
    }
}
