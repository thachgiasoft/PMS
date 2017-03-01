//NETTIERS - This is a copy of the source code for EntLib 5.  This fixes a bug for webapps.
//http://entlib.codeplex.com/workitem/26760?projectname=entlib

//===============================================================================
// Microsoft patterns & practices Enterprise Library
// Core
//===============================================================================
// Copyright © Microsoft Corporation.  All rights reserved.
// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY
// OF ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT
// LIMITED TO THE IMPLIED WARRANTIES OF MERCHANTABILITY AND
// FITNESS FOR A PARTICULAR PURPOSE.
//===============================================================================

using System;
using System.ComponentModel;
using System.Configuration;
using System.IO;
using Microsoft.Practices.EnterpriseLibrary.Common.Configuration;
using Microsoft.Practices.EnterpriseLibrary.Common.Configuration.Design;
using Microsoft.Practices.EnterpriseLibrary.Common.Configuration.Design.Validation;
using Microsoft.Practices.EnterpriseLibrary.Common.Properties;

namespace PMS.Data
{
    /// <summary>
    /// Represents the configuration settings that describe a <see cref="FileConfigurationSource"/>.
    /// </summary>
    [Browsable(true)]
    [EnvironmentalOverrides(false)]
    public class FileConfigurationSourceElement : Microsoft.Practices.EnterpriseLibrary.Common.Configuration.FileConfigurationSourceElement
    {
        /// <summary>
        /// Returns a new <see cref="FileConfigurationSource"/> configured with the receiver's settings.
        /// </summary>
        /// <returns>A new configuration source.</returns>
        public override IConfigurationSource CreateSource()
        {
            IConfigurationSource createdObject = new PMS.Data.FileConfigurationSource(FilePath);

            return createdObject;
        }
    }
}
