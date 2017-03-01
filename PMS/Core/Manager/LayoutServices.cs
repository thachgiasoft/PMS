using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;

namespace PMS.Core.Manager
{
    public class LayoutServices
    {
        /// <summary>
        /// Get method layout control.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="methodName"></param>
        /// <returns></returns>
        private static MethodInfo GetLayoutMethod(Type type, string methodName)
        {
            MethodInfo mi = type.GetMethod(methodName, BindingFlags.Instance | BindingFlags.Public, null, new Type[] { typeof(Stream) }, null);
            if (mi == null)
                throw new ArgumentException("The specified control can't save layout");
            return mi;
        }

        /// <summary>
        /// Save layout control return object ControlLayout.
        /// </summary>
        /// <param name="ctl"></param>
        /// <returns></returns>
        private static ControlLayout SaveLayout(object ctl)
        {
            ControlLayout c = new ControlLayout(ctl.GetType().Name);
            using (MemoryStream stream = new MemoryStream())
            {
                try
                {
                    MethodInfo mi = GetLayoutMethod(ctl.GetType(), "SaveLayoutToStream");
                    if (mi != null)
                    {
                        mi.Invoke(ctl, new object[] { stream });
                        c.Layout = stream.ToArray();
                    }
                    return c;
                }
                finally { stream.Close(); }
            }
        }

        /// <summary>
        /// Restore layout control.
        /// </summary>
        /// <param name="ctl"></param>
        /// <param name="layout"></param>
        private static void RestoreLayout(object ctl, ControlLayout layout)
        {
            if (layout.Layout != null)
            {
                using (MemoryStream stream = new MemoryStream(layout.Layout))
                {
                    try
                    {
                        MethodInfo mi = GetLayoutMethod(ctl.GetType(), "RestoreLayoutFromStream");
                        mi.Invoke(ctl, new object[] { stream });
                    }
                    finally { stream.Close(); }
                }
            }
        }

        /// <summary>
        /// Load layout.
        /// </summary>
        /// <param name="ctl"></param>
        /// <param name="data"></param>
        public static void LoadLayoutControl(object[] ctl, byte[] data)
        {
            Hashtable h = Converter.ByteArrayToObject(data) as Hashtable;
            if (h != null)
            {
                foreach (object c in ctl)
                {
                    if (h.ContainsKey(c.GetType().Name))
                        RestoreLayout(c, (ControlLayout)h[c.GetType().Name]);
                }
            }
        }

        /// <summary>
        /// Save layout.
        /// </summary>
        /// <param name="ctl"></param>
        /// <returns></returns>
        public static Hashtable SaveLayoutControl(object[] ctl)
        {
            Hashtable h = new Hashtable();
            foreach (object c in ctl)
                h.Add(c.GetType().Name, SaveLayout(c));
            return h;
        }
    }
}