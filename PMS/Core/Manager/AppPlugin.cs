using System;
using System.Collections.Generic;
using System.Text;

namespace PMS.Core.Manager
{
    public class AppPlugin
    {
        private static PluginServices service;

        /// <summary>
        /// Constructor
        /// </summary>
        static AppPlugin() { service = new PluginServices(); }

        /// <summary>
        /// Init Plugin
        /// </summary>
        public static void InitPlugin()
        {
            service.FindPlugins();
        }

        /// <summary>
        /// Clear all plugins
        /// </summary>
        public static void ClearPlugins()
        {
            service.ClearPlugins();
        }

        /// <summary>
        /// Return Plugins
        /// </summary>
        public static Plugins Plugins
        {
            get { return service.AppPlugins; }
        }
    }
}
