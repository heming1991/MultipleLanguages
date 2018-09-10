using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Diagnostics;

namespace ConfigurationSettings
{
    /// <summary>
    /// ConfigurationCollection for DomainConfigEntry
    /// </summary>
    [ConfigurationCollection(typeof(DomainConfigEntry),
        CollectionType = ConfigurationElementCollectionType.AddRemoveClearMap)]
    public class DomainConfigEntryCollection : ConfigurationElementCollection
    {
        private const string defaultDomain = "Default";

        /// <summary>
        /// The Xml configuration Key.
        /// </summary>
        public const string XmlConfigKey = "Domains";

        #region Indexers
        /// <summary>
        /// set or get DomainConfigEntry in indexers
        /// </summary>
        /// <param name="index">index number in indexers</param>
        /// <returns></returns>
        public DomainConfigEntry this[int index]
        {
            get
            {
                return (DomainConfigEntry)base.BaseGet(index);
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
        /// Get DomainConfigEntry from indexers by name
        /// </summary>
        /// <param name="name">name of the target menu of this entry</param>
        /// <returns>return DomainConfigEntry</returns>
        new public DomainConfigEntry this[string name]
        {
            get { return (DomainConfigEntry)base.BaseGet(name); }
        }
        #endregion

        #region Methods
        /// <summary>
        /// Add DomainConfigEntry element to the ConfigurationElementCollection
        /// </summary>
        /// <param name="item">the DomainConfigEntry to be added</param>
        public void Add(DomainConfigEntry item)
        {
            base.BaseAdd(item);
        }

        /// <summary>
        /// remove DomainConfigEntry element to the ConfigurationElementCollection
        /// </summary>
        /// <param name="name">name of the target menu of this entry</param>
        public void Remove(string name)
        {
            base.BaseRemove(name);
        }

        /// <summary>
        /// remove DomainConfigEntry from indexers
        /// </summary>
        /// <param name="item">the DomainConfigEntry to be removed</param>
        public void Remove(DomainConfigEntry item)
        {
            base.BaseRemove(GetElementKey(item));
        }

        /// <summary>
        /// clear the indexer, remove all DomainConfigEntry
        /// </summary>
        public void Clear()
        {
            base.BaseClear();
        }

        /// <summary>
        /// remove DomainConfigEntry element from indexer
        /// </summary>
        /// <param name="index">index in the ConfigurationElementCollection</param>
        public void RemoveAt(int index)
        {
            base.BaseRemoveAt(index);
        }

        /// <summary>
        /// Gets the key for the DomainConfigEntry at the specified index location
        /// </summary>
        /// <param name="index"></param>
        /// <returns>return the name of DomainConfigEntry</returns>
        public string GetKey(int index)
        {
            return (string)base.BaseGetKey(index);
        }
        #endregion

        #region Overrides
        /// <summary>
        /// create new element of DomainConfigEntry
        /// </summary>
        /// <returns></returns>
        protected override ConfigurationElement CreateNewElement()
        {
            return new DomainConfigEntry();
        }

        /// <summary>
        /// get the name of DomainConfigEntry
        /// </summary>
        /// <param name="element"></param>
        /// <returns></returns>
        protected override object GetElementKey(ConfigurationElement element)
        {
            var entry = element as DomainConfigEntry;
            Debug.Assert(entry != null);

            if (entry != null)
                return entry.Name;
            else
                return null;
        }
        #endregion

        [ConfigurationProperty(defaultDomain, IsRequired = false, DefaultValue = "")]
        public string Default
        {
            get { return (string)base[defaultDomain]; }
            set { base[defaultDomain] = value; }
        }
    }
}
