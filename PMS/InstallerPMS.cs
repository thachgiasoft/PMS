using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration.Install;
using System.Configuration;


namespace PMS
{
    [RunInstaller(true)]
    public partial class InstallerPMS : System.Configuration.Install.Installer
    {
        public InstallerPMS()
        {
            InitializeComponent();
        }

        public override void Install(IDictionary stateSaver)
        {
            base.Install(stateSaver);

            //Opens the specified client configuration file as a Configuration object 
            Configuration config = ConfigurationManager.OpenExeConfiguration(
                //Gets the source directory of the installation from the default 
                //context parameters 
                Context.Parameters["assemblypath"]);

            // Get the connectionStrings section. 
            ConfigurationSection section = config.GetSection("connectionStrings");

            //Ensures that the section is not already protected 
            if (!section.SectionInformation.IsProtected)
            {
                //Uses the Windows Data Protection API (DPAPI) to encrypt the 
                //configuration section using a machine-specific secret key 
                section.SectionInformation.ProtectSection("DataProtectionConfigurationProvider");
                config.Save();
            }
        }
    }
}
