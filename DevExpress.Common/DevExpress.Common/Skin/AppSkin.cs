using System;
using System.Collections.Generic;
using DevExpress.Skins;
using DevExpress.Common.Config;

namespace DevExpress.Common.Skin
{
    public static class AppSkin
    {
        /// <summary>
        /// Get list skins
        /// </summary>
        /// <returns></returns>
        public static List<string> GetSkins()
        {
            List<string> list = new List<string>();
            foreach (SkinContainer cnt in SkinManager.Default.Skins)
                list.Add(cnt.SkinName);
            return list;
        }

        /// <summary>
        /// Set skin for application
        /// </summary>
        public static void InitSkin()
        {
            List<string> list = GetSkins();
            if (list.Count > 0)
            {
                int skinID = AppConfig.SkinID;
                if (skinID < list.Count)
                    DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle(list[skinID].ToString());
                else
                    DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle("Black");
            }
        }
    }
}
