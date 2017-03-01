using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace PMS.Core.Manager
{
    public class Plugins : CollectionBase
    {
        /// <summary>
        /// Constructor Plugins
        /// </summary>
        /// <param name="capacity"></param>
        public Plugins() { }

        /// <summary>
        /// Constructor Plugins(int capacity)
        /// </summary>
        /// <param name="capacity"></param>
        protected Plugins(int capacity) : base(capacity) { }

        /// <summary>
        /// Add a Plugin to the collection of Plugins
        /// </summary>
        /// <param name="obj"></param>
        public void Add(Plugin obj)
        {
            List.Add(obj);
        }

        /// <summary>
        /// Remove a Plugin to the collection of Plugins
        /// </summary>
        /// <param name="obj"></param>
        public void Remove(Plugin obj)
        {
            List.Remove(obj);
        }

        /// <summary>
        /// Finds a plugin in the Plugins
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public Plugin Find(string value)
        {
            //Loop through all the plugins
            foreach (Plugin p in List)
            {
                if (p.FullName.Equals(value) || p.AssemblyPath.Equals(value))
                    return p;
            }
            return null;
        }
    }
}
