using System;

namespace DevExpress.Common.ToolTip
{
    public static class AppToolTip
    {
        /// <summary>
        /// Set tooltip for control
        /// </summary>
        /// <param name="tip"></param>
        /// <param name="control"></param>
        /// <param name="title"></param>
        /// <param name="contents"></param>
        /// <param name="footer"></param>
        /// <param name="html"></param>
        public static void SetToolTip(DevExpress.Utils.ToolTipController tip, System.Windows.Forms.Control control, string title, string contents, string footer, bool html)
        {
            DevExpress.Utils.SuperToolTip superToolTip = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipItem toolTipItem = new DevExpress.Utils.ToolTipItem { Text = contents, Image = DevExpress.Common.Properties.Resources.note };
            superToolTip.Items.AddTitle(title);
            superToolTip.Items.Add(toolTipItem);
            superToolTip.Items.AddSeparator();
            superToolTip.Items.AddTitle(footer);
            tip.AllowHtmlText = html;
            if (control is DevExpress.XtraEditors.TextEdit)
            {
                ((DevExpress.XtraEditors.TextEdit)control).SuperTip = superToolTip;
                tip.SetSuperTip((DevExpress.XtraEditors.TextEdit)control, superToolTip);
            }
            else
                if (control is DevExpress.XtraEditors.CheckEdit)
                {
                    ((DevExpress.XtraEditors.CheckEdit)control).SuperTip = superToolTip;
                    tip.SetSuperTip((DevExpress.XtraEditors.CheckEdit)control, superToolTip);
                }
                else
                    if (control is DevExpress.XtraEditors.ComboBoxEdit)
                    {
                        ((DevExpress.XtraEditors.ComboBoxEdit)control).SuperTip = superToolTip;
                        tip.SetSuperTip((DevExpress.XtraEditors.ComboBoxEdit)control, superToolTip);
                    }
                    else
                        if (control is DevExpress.XtraEditors.SimpleButton)
                        {
                            ((DevExpress.XtraEditors.SimpleButton)control).SuperTip = superToolTip;
                            tip.SetSuperTip((DevExpress.XtraEditors.SimpleButton)control, superToolTip);
                        }
                        else
                            if (control is DevExpress.XtraEditors.SpinEdit)
                            {
                                ((DevExpress.XtraEditors.SpinEdit)control).SuperTip = superToolTip;
                                tip.SetSuperTip((DevExpress.XtraEditors.SpinEdit)control, superToolTip);
                            }
                            else
                                if (control is DevExpress.XtraEditors.CheckedListBoxControl)
                                {
                                    ((DevExpress.XtraEditors.CheckedListBoxControl)control).SuperTip = superToolTip;
                                    tip.SetSuperTip((DevExpress.XtraEditors.CheckedListBoxControl)control, superToolTip);
                                }
        }
    }
}