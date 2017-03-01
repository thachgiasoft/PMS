using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Reflection;

namespace PMS.Core.Manager
{
    public class PluginServices
    {
        public PluginServices() { AppPlugins = new Plugins(); }

        /// <summary>
        /// A Collection of all Plugins Found and Loaded by the FindPlugins() Method
        /// </summary>
        public Plugins AppPlugins { get; set; }

        /// <summary>
        /// Searches the Application's Startup Directory for Plugins
        /// </summary>
        public void FindPlugins()
        {
            FindPlugins(AppDomain.CurrentDomain.BaseDirectory + "Plugins");
        }
        /// <summary>
        /// Searches the passed Path for Plugins
        /// </summary>
        /// <param name="Path">Directory to search for Plugins in</param>
        public void FindPlugins(string Path)
        {
            //First empty the collection, we're reloading them all
            AppPlugins.Clear();
            //Initialize current plugin project
            AddProjectPlugin();
            //Go through all the files in the plugin directory
            if (Directory.Exists(AppDomain.CurrentDomain.BaseDirectory + "Plugins"))
            {
                foreach (string f in Directory.GetFiles(Path))
                {
                    FileInfo file = new FileInfo(f);
                    //Preliminary check, must be .dll
                    if (file.Extension.Equals(".dll"))
                    {
                        //Add the 'plugin'
                        AddPlugin(f);
                    }
                }
            }
        }

        /// <summary>
        /// Add current plugin
        /// </summary>
        private void AddProjectPlugin()
        {
            //Create a new assembly from the plugin file we're adding..
            Assembly asm = Assembly.GetExecutingAssembly();
            //Next we'll loop through all the Types found in the assembly
            foreach (Type pluginType in asm.GetTypes())
            {
                if (pluginType.IsPublic) //Only look at public types
                {
                    if (!pluginType.IsAbstract)  //Only look at non-abstract types
                    {
                        Plugin pw = new Plugin() { AssemblyPath = asm.Location, FullName = pluginType.FullName, Name = pluginType.Name, RuntimeVersion = asm.ImageRuntimeVersion };
                        AppPlugins.Add(pw);
                    }
                }
            }
        }

        /// <summary>
        /// Add plugin load from assembly file
        /// </summary>
        /// <param name="fileName"></param>
        private void AddPlugin(string fileName)
        {
            //Create a new assembly from the plugin file we're adding..
            Assembly asm = Assembly.LoadFrom(fileName);
            //Next we'll loop through all the Types found in the assembly
            foreach (Type pluginType in asm.GetTypes())
            {
                if (pluginType.IsPublic) //Only look at public types
                {
                    if (!pluginType.IsAbstract)  //Only look at non-abstract types
                    {
                        Plugin pw = new Plugin() { AssemblyPath = asm.Location, FullName = pluginType.FullName, Name = pluginType.Name, RuntimeVersion = asm.ImageRuntimeVersion };
                        AppPlugins.Add(pw);
                    }
                }
            }
        }

        /// <summary>
        /// Unloads and Clear all AvailablePlugins
        /// </summary>
        public void ClearPlugins()
        {
            //Finally, clear our collection of available plugins
            AppPlugins.Clear();
        }
    }
}