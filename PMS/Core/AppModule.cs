using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace PMS.Core
{
    public class Permission {
        public bool Delete { get; set; }
        public bool Save { get; set; }
    }

    /// <summary>
    /// AppModule
    /// </summary>
    public class AppModule
    {
        public int Id { get; set; }
        public string ModuleId { get; set; }
        public string Caption { get; set; }
        public string Type { get; set; }//Mdi, Popup
        public string MethodName { get; set; }
        public string Parameter { get; set; }
        public Hashtable Authorization { get; set; }
        public PMS.Entities.ChucNang Module { get; set; }
        //public Permission ModulePermission { get; set; }

        /// <summary>
        /// Check invoke method.
        /// </summary>
        public bool IsMethodInvoke
        {
            get
            {
                return !string.IsNullOrEmpty(MethodName);
            }
        }

        /// <summary>
        /// Check parameter.
        /// </summary>
        public bool IsParameter
        {
            get
            {
                return !string.IsNullOrEmpty(Parameter);
            }
        }
    }
}