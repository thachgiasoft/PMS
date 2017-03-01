using System;
using System.Collections.Generic;
using System.Text;

namespace PMS.Core.Manager
{
    [Serializable]
    public class ControlLayout
    {
        public string ControlID { get; set; }
        public byte[] Layout { get; set; }

        private ControlLayout() { }

        public ControlLayout(string Id)
        {
            ControlID = Id;
        }
    }
}