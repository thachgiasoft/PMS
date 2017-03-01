using System;
using System.Collections.Generic;
using System.Text;

namespace PMS.Core.Manager
{
    public class Plugin
    {
        public string Name { get; set; }
        public string FullName { get; set; }
        public string RuntimeVersion { get; set; }
        public string AssemblyPath { get; set; }
    }
}
