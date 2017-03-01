using System;
using DevExpress.XtraEditors;
using DevExpress.XtraBars;
using System.Windows.Forms;
using DevExpress.XtraBars.Ribbon;
using DevExpress.Common.DataConvert;
using PMS.BLL;
using System.Collections.Generic;
using PMS.Entities;
using DevExpress.XtraTreeList;
using PMS.UI.Forms.HeThong;
using System.Reflection;
using System.Data;
using DevExpress.Utils;
using DevExpress.XtraNavBar;
using PMS.Services;
using System.Drawing;
using System.IO;
using PMS.Core.Manager;
using PMS.Services;

namespace PMS.Core
{
    public class AppSystem
    {
        /// <summary>
        /// Container for app.
        /// </summary>
        private GroupControl AppContainer { get; set; }

        /// <summary>
        /// Get all plugin.
        /// </summary>
        /// <returns></returns>
        public static List<AppForm> GetForms()
        {
            List<AppForm> listForm = new List<AppForm>();
            //Get Plugins.
            foreach (Plugin p in AppPlugin.Plugins)
                listForm.Add(new AppForm { ID = p.FullName, Name = p.Name });
            return listForm;
        }

        /// <summary>
        /// Get all field in plugin.
        /// </summary>
        /// <param name="fullName"></param>
        /// <returns></returns>
        public static List<string> GetFieldInfos(string fullName)
        {
            List<string> list = new List<string>();
            FieldInfo[] fieldInfos = null;
            Plugin plugin = AppPlugin.Plugins.Find(fullName);
            if (plugin != null)
            {
                Type t = Type.GetType(plugin.FullName);
                if (t != null)
                    fieldInfos = t.GetFields(BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance);
                else
                {
                    Type tf = Assembly.LoadFrom(plugin.AssemblyPath).GetType(plugin.FullName);
                    if (tf != null)
                        fieldInfos = tf.GetFields(BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance);
                }
                //Add item.
                foreach (FieldInfo f in fieldInfos)
                {
                    switch (f.FieldType.FullName)
                    {
                        case "DevExpress.XtraEditors.SimpleButton":
                            list.Add(f.Name);
                            break;
                        case "DevExpress.XtraBars.BarButtonItem":
                            list.Add(f.Name);
                            break;
                        case "System.Windows.Forms.Button":
                            list.Add(f.Name);
                            break;
                        default:
                            break;
                    }
                }
            }
            return list;
        }

        /// <summary>
        /// Get all field in plugin.
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public static List<string> GetFieldInfos(Type t)
        {
            List<string> list = new List<string>();
            FieldInfo[] fieldInfos = t.GetFields(BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance);
            //Add item.
            foreach (FieldInfo f in fieldInfos)
            {
                switch (f.FieldType.FullName)
                {
                    case "DevExpress.XtraEditors.SimpleButton":
                        list.Add(f.Name);
                        break;
                    case "DevExpress.XtraBars.BarButtonItem":
                        list.Add(f.Name);
                        break;
                    case "System.Windows.Forms.Button":
                        list.Add(f.Name);
                        break;
                    default:
                        break;
                }
            }
            return list;
        }

        /// <summary>
        /// Invoke method.
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="t"></param>
        /// <param name="module"></param>
        private static void InvokeMethod(object obj, Type t, AppModule module)
        {
            try
            {
                if (module.IsMethodInvoke)
                {
                    MethodInfo mi = FindMethod(t, module.MethodName, module.Parameter);
                    if (mi != null)
                    {
                        if (module.IsParameter)
                            mi.Invoke(obj, module.Parameter.Split(','));
                        else
                            mi.Invoke(obj, null);
                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Load item module.
        /// </summary>
        /// <param name="t"></param>
        /// <param name="e"></param>
        private static void LoadItemModule(Type t, ItemClickEventArgs e)
        {
            AppModule objModule = e.Item.Tag as AppModule;
            if (objModule != null)
            {
                foreach (Form fr in frmMain.Instance.xtraTabbedMdiManager.MdiParent.MdiChildren)
                {
                    if (fr.Name == string.Format("{0}{1}", t.Name, objModule.Id))
                    {
                        fr.Focus();
                        return;
                    }
                }
                //Create instance form
                switch (t.BaseType.Name)
                {
                    case "XtraForm":
                        XtraForm xfrm = Activator.CreateInstance(t) as XtraForm;
                        if (xfrm != null)
                        {
                            //Phan quyen theo phuong thuc
                            bool result = false;
                            DataServices.TaiKhoan.KiemTraPhanQuyenControl(UserInfo.UserID, xfrm.Name, ref result);
                            if (result)
                            {
                                MethodInfo mi = FindMethod(t, "KhongDuocPhepCapNhat", result.ToString());
                                if (mi != null)
                                    mi.Invoke(xfrm, new string[] { result.ToString() });
                            }

                            //
                            xfrm.Name += objModule.Id;
                            InvokeMethod(xfrm, t, objModule);
                            if (objModule.Type == "Popup")
                                xfrm.ShowDialog();
                            else
                            {
                                if (objModule.Module == null)
                                    objModule.Module = DataServices.ChucNang.GetById(objModule.Id);
                                xfrm.MdiParent = frmMain.Instance;
                                xfrm.Tag = objModule;
                                xfrm.Text = e.Item.Caption;
                                xfrm.Show();
                                xfrm.Focus();
                            }
                        }
                        break;
                    case "Form":
                        Form frm = Activator.CreateInstance(t) as Form;
                        if (frm != null)
                        {
                            frm.Name += objModule.Id;
                            InvokeMethod(frm, t, objModule);
                            if (objModule.Type == "Popup")
                                frm.ShowDialog();
                            else
                            {
                                if (objModule.Module == null)
                                    objModule.Module = DataServices.ChucNang.GetById(objModule.Id);
                                frm.MdiParent = frmMain.Instance;
                                frm.Tag = objModule;
                                frm.Text = e.Item.Caption;
                                frm.Show();
                                frm.Focus();
                            }
                        }
                        break;
                    case "Object":
                        Object obj = Activator.CreateInstance(t) as Object;
                        if (obj != null)
                            InvokeMethod(obj, t, objModule);
                        break;
                    default:
                        break;
                }
            }
        }

        /// <summary>
        /// Item Click.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private static void ItemClick(object sender, ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (e.Item.Tag == null)
                return;
            AppModule objModule = e.Item.Tag as AppModule;
            if (objModule != null)
            {
                Plugin plugin = AppPlugin.Plugins.Find(objModule.ModuleId);
                if (plugin != null)
                {
                    Type t = Type.GetType(plugin.FullName);
                    if (t != null)
                        LoadItemModule(t, e);
                    else
                    {
                        Type tf = Assembly.LoadFrom(plugin.AssemblyPath).GetType(plugin.FullName);
                        if (tf != null)
                            LoadItemModule(tf, e);
                    }
                }
            }
            Cursor.Current = Cursors.Default;
        }

        /// <summary>
        /// Nav item click.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NavItemClick(object sender, NavBarLinkEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            AppModule objModule = e.Link.Item.Tag as AppModule;
            if (objModule != null)
            {
                Plugin plugin = AppPlugin.Plugins.Find(objModule.ModuleId);
                if (plugin != null)
                {
                    Type t = Type.GetType(plugin.FullName);
                    if (t != null)
                        ModuleSelect(t, e);
                    else
                    {
                        Type tf = Assembly.LoadFrom(plugin.AssemblyPath).GetType(plugin.FullName);
                        if (tf != null)
                            ModuleSelect(tf, e);
                    }
                }
            }
            Cursor.Current = Cursors.Default;
        }


        /// <summary>
        /// Init System.
        /// </summary>
        public static void InitSystem()
        {
            //Init ComponentModel
            ((System.ComponentModel.ISupportInitialize)(frmMain.Instance.ribbon)).BeginInit();
            //Init Image
            frmMain.Instance.ribbon.LargeImages = frmMain.Instance.imageCollectionSystem;
            //Add page
            RibbonPage page = new RibbonPage("Hệ thống") { Name = "ribbonPageSystem" };
            frmMain.Instance.ribbon.Pages.Add(page);
            //Add Group
            RibbonPageGroup group = new RibbonPageGroup("Nhóm hệ thống") { Name = "ribbonPageGroupSystem", AllowTextClipping = false };
            page.Groups.Add(group);

            List<XtraForm> listForm = new List<XtraForm>();
            listForm.AddRange(new XtraForm[] { new frmChucNang(), new frmNhomQuyen(), new frmPhanQuyen() });

            int index = 0;
            foreach (XtraForm fr in listForm)
            {
                BarButtonItem item = new BarButtonItem { Caption = fr.Text, Name = string.Format("barButtonItem{0}", index), Tag = new AppModule() { ModuleId = fr.GetType().FullName }, Hint = fr.Text, Description = fr.Text, LargeImageIndex = index };
                item.ItemClick += ItemClick;
                group.ItemLinks.Add(item, true);
                index++;
            }
            ((System.ComponentModel.ISupportInitialize)(frmMain.Instance.ribbon)).EndInit();
        }

        /// <summary>
        /// Init Control.
        /// </summary>
        public static void InitControl()
        {
            int lIndex = 0, sIndex = 0;
            //Init ComponentModel
            ((System.ComponentModel.ISupportInitialize)(frmMain.Instance.ribbon)).BeginInit();
            //Init Image
            frmMain.Instance.ribbon.LargeImages = frmMain.Instance.LimageCollection;
            //Clear image collection
            frmMain.Instance.LimageCollection.Images.Clear();
            frmMain.Instance.SimageCollection.Images.Clear();
            //Init 
            using (DataTable dt = new DataTable())
            {
                dt.Load(DataServices.ChucNang.GetModulesByGroupID(UserInfo.GroupID));
                foreach (DataRow pModule in dt.Select(string.Format("PhanLoai='{0}' AND TrangThai={1}", "Tab", 1), "ThuTu ASC"))
                {
                    //Add Page
                    RibbonPage page = new RibbonPage(pModule["TenChucNang"].ToString()) { Name = string.Format("ribbonPage{0}", pModule["ID"]) };
                    frmMain.Instance.ribbon.Pages.Add(page);
                    //Add PageGroup
                    foreach (DataRow gModule in dt.Select(string.Format("PhanLoai='{0}' AND TrangThai={1} AND ParentID={2}", "Group", 1, pModule["ID"]), "ThuTu ASC"))
                    {
                        RibbonPageGroup group = new RibbonPageGroup(gModule["TenChucNang"].ToString()) { Name = string.Format("ribbonPageGroup{0}", gModule["ID"]), AllowTextClipping = false };
                        page.Groups.Add(group);
                        //Add Item
                        foreach (DataRow iModule in dt.Select(string.Format("PhanLoai='{0}' AND TrangThai={1} AND ParentID={2}", "Item", 1, gModule["ID"]), "ThuTu ASC"))
                        {
                            if ((bool)iModule["Menu"])
                            {
                                //Add main menu
                                BarSubItem mainMenu = new BarSubItem(frmMain.Instance.ribbon.Manager, iModule["TenChucNang"].ToString()) { Name = string.Format("barButtonItem{0}", iModule["ID"]), Tag = new AppModule() { Id = (int)iModule["ID"], ModuleId = iModule["TenForm"].ToString(), Caption = iModule["TenChucNang"].ToString(), Type = iModule["KieuForm"].ToString(), MethodName = iModule["TenPhuongThuc"].ToString(), Parameter = iModule["ThamSo"].ToString()}, Hint = iModule["TenChucNang"].ToString(), Description = iModule["TenChucNang"].ToString() };
                                frmMain.Instance.ribbon.Items.Add(mainMenu);
                                if (iModule["HinhAnh"] != DBNull.Value)
                                {
                                    if ((bool)iModule["RibbonStyle"])
                                        frmMain.Instance.SimageCollection.AddImage(AppImage.ByteArrayToImage((byte[])iModule["HinhAnh"]));
                                    else
                                        frmMain.Instance.LimageCollection.AddImage(AppImage.ByteArrayToImage((byte[])iModule["HinhAnh"]));
                                    if (frmMain.Instance.SimageCollection.Images.Count > 0 && (bool)iModule["RibbonStyle"])
                                    {
                                        mainMenu.ImageIndex = sIndex;
                                        sIndex++;
                                        mainMenu.RibbonStyle = RibbonItemStyles.SmallWithoutText | RibbonItemStyles.SmallWithText;
                                    }
                                    else
                                    {
                                        mainMenu.LargeImageIndex = lIndex;
                                        lIndex++;
                                        mainMenu.RibbonStyle = RibbonItemStyles.All;
                                    }
                                }
                                //Add item into menu
                                foreach (DataRow iMenu in dt.Select(string.Format("PhanLoai='{0}' AND TrangThai={1} AND ParentID={2}", "Item", 1, iModule["ID"]), "ThuTu ASC"))
                                {
                                    if ((bool)iMenu["Menu"])
                                    {
                                        //Add sub menu
                                        BarSubItem subMenu = new BarSubItem(frmMain.Instance.ribbon.Manager, iMenu["TenChucNang"].ToString()) { Name = string.Format("barButtonItem{0}", iMenu["ID"]), Tag = new AppModule() { Id = (int)iMenu["ID"], ModuleId = iMenu["TenForm"].ToString(), Caption = iMenu["TenChucNang"].ToString(), Type = iMenu["KieuForm"].ToString(), MethodName = iMenu["TenPhuongThuc"].ToString(), Parameter = iMenu["ThamSo"].ToString() }, Hint = iMenu["TenChucNang"].ToString(), Description = iMenu["TenChucNang"].ToString() };
                                        frmMain.Instance.ribbon.Items.Add(subMenu);
                                        foreach (DataRow sMenu in dt.Select(string.Format("PhanLoai='{0}' AND TrangThai={1} AND ParentID={2}", "Item", 1, iMenu["ID"]), "ThuTu ASC"))
                                        {
                                            //Add image
                                            if (sMenu["HinhAnh"] != DBNull.Value)
                                                frmMain.Instance.SimageCollection.AddImage(AppImage.ByteArrayToImage((byte[])sMenu["HinhAnh"]));
                                            BarButtonItem item = new BarButtonItem() { Caption = sMenu["TenChucNang"].ToString(), Name = string.Format("barButtonItem{0}", sMenu["ID"]), Tag = new AppModule() { Id = (int)sMenu["ID"], ModuleId = sMenu["TenForm"].ToString(), Caption = sMenu["TenChucNang"].ToString(), Type = sMenu["KieuForm"].ToString(), MethodName = sMenu["TenPhuongThuc"].ToString(), Parameter = sMenu["ThamSo"].ToString() }, Hint = sMenu["TenChucNang"].ToString(), Description = sMenu["TenChucNang"].ToString() };
                                            if (frmMain.Instance.SimageCollection.Images.Count > 0 && sMenu["HinhAnh"] != DBNull.Value)
                                            {
                                                item.ImageIndex = sIndex;
                                                sIndex++;
                                            }
                                            item.ItemClick += ItemClick;
                                            item.RibbonStyle = RibbonItemStyles.All;
                                            subMenu.LinksPersistInfo.Add(new LinkPersistInfo(item, (bool)sMenu["BeginGroup"]));
                                            frmMain.Instance.ribbon.Items.Add(item);
                                        }
                                        mainMenu.ItemLinks.Add(subMenu, (bool)iMenu["BeginGroup"]);
                                    }
                                    else
                                    {
                                        //Add image
                                        if (iMenu["HinhAnh"] != DBNull.Value)
                                            frmMain.Instance.SimageCollection.AddImage(AppImage.ByteArrayToImage((byte[])iMenu["HinhAnh"]));
                                        BarButtonItem item = new BarButtonItem() { Caption = iMenu["TenChucNang"].ToString(), Name = string.Format("barButtonItem{0}", iMenu["ID"]), Tag = new AppModule() { Id = (int)iMenu["ID"], ModuleId = iMenu["TenForm"].ToString(), Caption = iMenu["TenChucNang"].ToString(), Type = iMenu["KieuForm"].ToString(), MethodName = iMenu["TenPhuongThuc"].ToString(), Parameter = iMenu["ThamSo"].ToString() }, Hint = iMenu["TenChucNang"].ToString(), Description = iMenu["TenChucNang"].ToString() };
                                        item.ItemClick += ItemClick;
                                        item.RibbonStyle = RibbonItemStyles.All;
                                        if (frmMain.Instance.SimageCollection.Images.Count > 0 && iMenu["HinhAnh"] != DBNull.Value)
                                        {
                                            item.ImageIndex = sIndex;
                                            sIndex++;
                                        }
                                        mainMenu.LinksPersistInfo.Add(new LinkPersistInfo(item, (bool)iMenu["BeginGroup"]));
                                        frmMain.Instance.ribbon.Items.Add(item);
                                    }
                                }
                                group.ItemLinks.Add(mainMenu, true);
                            }
                            else
                            {
                                if (iModule["HinhAnh"] != DBNull.Value)
                                {
                                    if ((bool)iModule["RibbonStyle"])
                                        frmMain.Instance.SimageCollection.AddImage(AppImage.ByteArrayToImage((byte[])iModule["HinhAnh"]));
                                    else
                                        frmMain.Instance.LimageCollection.AddImage(AppImage.ByteArrayToImage((byte[])iModule["HinhAnh"]));
                                }
                                BarButtonItem item = new BarButtonItem(frmMain.Instance.ribbon.Manager, iModule["TenChucNang"].ToString()) { Name = string.Format("barButtonItem{0}", iModule["ID"]), Tag = new AppModule() { Id = (int)iModule["ID"], ModuleId = iModule["TenForm"].ToString(), Caption = iModule["TenChucNang"].ToString(), Type = iModule["KieuForm"].ToString(), MethodName = iModule["TenPhuongThuc"].ToString(), Parameter = iModule["ThamSo"].ToString() }, Hint = iModule["TenChucNang"].ToString(), Description = iModule["TenChucNang"].ToString() };
                                item.ItemClick += ItemClick;
                                if (iModule["HinhAnh"] != DBNull.Value)
                                {
                                    if (frmMain.Instance.SimageCollection.Images.Count > 0 && (bool)iModule["RibbonStyle"])
                                    {
                                        item.ImageIndex = sIndex;
                                        sIndex++;
                                        item.RibbonStyle = RibbonItemStyles.SmallWithoutText | RibbonItemStyles.SmallWithText;
                                        group.ItemLinks.Add(item, (bool)iModule["BeginGroup"]);
                                    }
                                    else
                                    {
                                        item.LargeImageIndex = lIndex;
                                        lIndex++;
                                        item.RibbonStyle = RibbonItemStyles.All;
                                        group.ItemLinks.Add(item, (bool)iModule["BeginGroup"]);
                                    }
                                }
                                else
                                {
                                    item.RibbonStyle = RibbonItemStyles.All;
                                    group.ItemLinks.Add(item, (bool)iModule["BeginGroup"]);
                                }
                                frmMain.Instance.ribbon.Items.Add(item);
                            }
                        }
                    }
                }
            }
            ((System.ComponentModel.ISupportInitialize)(frmMain.Instance.ribbon)).EndInit();
        }

        /// <summary>
        /// Load modules support treelist.
        /// </summary>
        /// <param name="frm"></param>
        /// <param name="treeList"></param>
        public static void LoadModules(XtraForm frm, TreeList treeList)
        {
            treeList.KeyFieldName = "Id";
            treeList.ParentFieldName = "ParentId";
            AppModule objModule = frm.Tag as AppModule;
            if (objModule != null)
            {
                foreach (ChucNang c in DataServices.ChucNang.GetByIDTrangThai(objModule.Id, true))
                {
                    TList<ChucNang> listModules = DataServices.ChucNang.GetByMaNhomQuyenParentIDPhanLoaiTrangThai(UserInfo.GroupID, c.Id, "Module", true);
                    if (listModules.Count > 0)
                    {
                        treeList.DataSource = listModules;
                        return;
                    }
                }
            }
        }

        /// <summary>
        /// Load modules support treelist.
        /// </summary>
        /// <param name="frm"></param>
        /// <param name="treeList"></param>
        /// <param name="imageList"></param>
        public static void LoadModules(XtraForm frm, TreeList treeList, ImageCollection imageList)
        {
            treeList.KeyFieldName = "Id";
            treeList.ParentFieldName = "ParentId";
            treeList.ImageIndexFieldName = "ThuTu";
            AppModule objModule = frm.Tag as AppModule;
            if (objModule != null)
            {
                foreach (ChucNang c in DataServices.ChucNang.GetByIDTrangThai(objModule.Id, true))
                {
                    TList<ChucNang> listModules = DataServices.ChucNang.GetByMaNhomQuyenParentIDPhanLoaiTrangThai(UserInfo.GroupID, c.Id, "Module", true);
                    if (listModules.Count > 0)
                    {
                        foreach (ChucNang m in listModules.Copy())
                        {
                            if (m.HinhAnh != null)
                                imageList.AddImage(AppImage.ByteArrayToImage(m.HinhAnh));
                            foreach (ChucNang obj in DataServices.ChucNang.GetByMaNhomQuyenParentIDPhanLoaiTrangThai(UserInfo.GroupID, m.Id, "Module", true))
                            {
                                if (obj.HinhAnh != null)
                                    imageList.AddImage(AppImage.ByteArrayToImage(obj.HinhAnh));
                                listModules.Add(obj);
                            }
                        }
                        treeList.DataSource = listModules;
                        return;
                    }
                }
            }
        }

        /// <summary>
        /// Load modules support navigation.
        /// </summary>
        /// <param name="frm"></param>
        /// <param name="navControl"></param>
        /// <param name="simageList"></param>
        /// <param name="limageList"></param>
        public void LoadModules(XtraForm frm, NavBarControl navControl, GroupControl pContainer, ImageCollection simageCollection)
        {
            AppContainer = pContainer;
            int sIndex = 0;
            AppModule objModule = frm.Tag as AppModule;
            if (objModule != null)
            {
                foreach (ChucNang c in DataServices.ChucNang.GetByIDTrangThai(objModule.Id, true))
                {
                    TList<ChucNang> listModules = DataServices.ChucNang.GetByMaNhomQuyenParentIDPhanLoaiTrangThai(UserInfo.GroupID, c.Id, "Module", true);
                    if (listModules.Count > 0)
                    {
                        foreach (ChucNang grp in listModules)
                        {
                            //Group
                            NavBarGroup group = new NavBarGroup(grp.TenChucNang) { Name = string.Format("navBarGroup{0}", grp.Id), GroupStyle = NavBarGroupStyle.Default };
                            if (grp.HinhAnh != null)
                            {
                                simageCollection.AddImage(AppImage.ByteArrayToImage(grp.HinhAnh));
                                group.SmallImageIndex = sIndex;
                                sIndex++;
                            }
                            //Item
                            foreach (ChucNang itm in DataServices.ChucNang.GetByMaNhomQuyenParentIDPhanLoaiTrangThai(UserInfo.GroupID, grp.Id, "Module", true))
                            {
                                NavBarItem item = new NavBarItem(itm.TenChucNang) { Caption = itm.TenChucNang, Hint = itm.TenChucNang, Name = string.Format("navBarItem{0}{1}", itm.Id, grp.Id), Tag = new AppModule() { Id = itm.Id, ModuleId = itm.TenForm, Caption = itm.TenChucNang, Type = itm.KieuForm, MethodName = itm.TenPhuongThuc, Parameter = itm.ThamSo } };
                                item.LinkClicked += NavItemClick;
                                if (itm.HinhAnh != null)
                                {
                                    simageCollection.AddImage(AppImage.ByteArrayToImage(itm.HinhAnh));
                                    item.SmallImageIndex = sIndex;
                                    sIndex++;
                                }
                                group.ItemLinks.Add(item);
                                navControl.Items.Add(item);
                            }
                            navControl.Groups.Add(group);
                        }
                        return;
                    }
                }
            }
        }

        /// <summary>
        /// Invoke method support treelist.
        /// </summary>
        /// <param name="t"></param>
        /// <param name="obj"></param>
        /// <param name="e"></param>
        private static void InvokeMethod(Type t, object obj, FocusedNodeChangedEventArgs e)
        {
            try
            {
                AppModule objModule = e.Node.Tag as AppModule;
                if (objModule != null)
                {
                    if (objModule.IsMethodInvoke)
                    {
                        MethodInfo mi = FindMethod(t, objModule.MethodName, objModule.Parameter);
                        if (mi != null)
                        {
                            if (objModule.IsParameter)
                                mi.Invoke(obj, objModule.Parameter.Split(','));
                            else
                                mi.Invoke(obj, null);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Find method in class.
        /// </summary>
        /// <param name="t"></param>
        /// <param name="name"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        private static MethodInfo FindMethod(Type t, string name, string parameter)
        {
            MethodInfo[] methods = t.GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly);
            foreach (MethodInfo m in methods)
            {
                if (m.Name == name)
                {
                    if (string.IsNullOrEmpty(parameter))
                        return m;
                    else
                    {
                        if (m.GetParameters().Length == parameter.Split(',').Length)
                            return m;
                    }
                }
            }
            return null;
        }


        /// <summary>
        /// Invoke method support navigation.
        /// </summary>
        /// <param name="t"></param>
        /// <param name="obj"></param>
        /// <param name="e"></param>
        private static void InvokeMethod(Type t, object obj, NavBarLinkEventArgs e)
        {
            try
            {
                AppModule objModule = e.Link.Item.Tag as AppModule;
                if (objModule != null)
                {
                    if (objModule.IsMethodInvoke)
                    {
                        MethodInfo mi = FindMethod(t, objModule.MethodName, objModule.Parameter);
                        if (mi != null)
                        {
                            if (objModule.IsParameter)
                                mi.Invoke(obj, objModule.Parameter.Split(','));
                            else
                                mi.Invoke(obj, null);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Module select support navigation.
        /// </summary>
        /// <param name="t"></param>
        /// <param name="pContainer"></param>
        /// <param name="e"></param>
        private void ModuleSelect(Type t, NavBarLinkEventArgs e)
        {
            try
            {
                AppModule objModule = e.Link.Item.Tag as AppModule;
                if (objModule != null)
                {
                    switch (t.BaseType.Name)
                    {
                        case "XtraForm":
                            Cursor.Current = Cursors.WaitCursor;
                            XtraForm xForm = Activator.CreateInstance(t) as XtraForm;
                            if (xForm != null)
                            {
                                foreach (Form fr in frmMain.Instance.xtraTabbedMdiManager.MdiParent.MdiChildren)
                                {
                                    if (fr.Name == string.Format("{0}{1}", t.Name, objModule.Id))
                                    {
                                        fr.Focus();
                                        return;
                                    }
                                }
                                xForm.Name += objModule.Id;
                                InvokeMethod(t, xForm, e);
                                if (objModule.Module == null)
                                    objModule.Module = DataServices.ChucNang.GetById(objModule.Id);
                                if (!string.IsNullOrEmpty(objModule.Type))
                                {
                                    if (objModule.Type == "Popup")
                                    {
                                        xForm.Tag = objModule;
                                        xForm.Text = e.Link.Caption;
                                        xForm.ShowDialog();
                                    }
                                    else
                                    {
                                        xForm.MdiParent = frmMain.Instance;
                                        xForm.Tag = objModule;
                                        xForm.Text = e.Link.Caption;
                                        xForm.Show();
                                        xForm.Focus();
                                    }
                                }
                                else
                                {
                                    xForm.MdiParent = frmMain.Instance;
                                    xForm.Tag = objModule;
                                    xForm.Text = e.Link.Caption;
                                    xForm.Show();
                                    xForm.Focus();
                                }
                            }
                            Cursor.Current = Cursors.Default;
                            break;
                        case "Form":
                            Cursor.Current = Cursors.WaitCursor;
                            Form form = Activator.CreateInstance(t) as Form;
                            if (form != null)
                            {
                                foreach (Form fr in frmMain.Instance.xtraTabbedMdiManager.MdiParent.MdiChildren)
                                {
                                    if (fr.Name == string.Format("{0}{1}", t.Name, objModule.Id))
                                    {
                                        fr.Focus();
                                        return;
                                    }
                                }
                                form.Name += objModule.Id;
                                InvokeMethod(t, form, e);
                                if (objModule.Module == null)
                                    objModule.Module = DataServices.ChucNang.GetById(objModule.Id);
                                if (!string.IsNullOrEmpty(objModule.Type))
                                {
                                    if (objModule.Type == "Popup")
                                    {
                                        form.Tag = objModule;
                                        form.Text = e.Link.Caption;
                                        form.ShowDialog();
                                    }
                                    else
                                    {
                                        form.MdiParent = frmMain.Instance;
                                        form.Tag = objModule;
                                        form.Text = e.Link.Caption;
                                        form.Show();
                                        form.Focus();
                                    }
                                }
                                else
                                {
                                    form.MdiParent = frmMain.Instance;
                                    form.Tag = objModule;
                                    form.Text = e.Link.Caption;
                                    form.Show();
                                    form.Focus();
                                }
                            }
                            Cursor.Current = Cursors.Default;
                            break;
                        case "XtraUserControl":
                            Cursor.Current = Cursors.WaitCursor;
                            if (AppContainer != null)
                            {
                                if (!AppContainer.Controls.ContainsKey(string.Format("{0}{1}", t.Name, objModule.Id)))
                                {
                                    XtraUserControl xc = Activator.CreateInstance(t) as XtraUserControl;
                                    if (xc != null)
                                    {
                                        //Phan quyen tung control
                                        bool result = false;
                                        DataServices.TaiKhoan.KiemTraPhanQuyenControl(UserInfo.UserID, xc.Name, ref result);
                                        if (result)
                                        {
                                            MethodInfo mi = FindMethod(t, "KhongDuocPhepCapNhat", result.ToString());
                                            if (mi != null)
                                                mi.Invoke(xc, new string[] { result.ToString() });
                                        }

                                        if (!AppContainer.Controls.Contains(xc))
                                        {
                                            if (objModule.Module == null)
                                                objModule.Module = DataServices.ChucNang.GetById(objModule.Id);
                                            xc.Name = string.Format("{0}{1}", t.Name, objModule.Id);
                                            xc.Dock = DockStyle.Fill;
                                            xc.Tag = objModule;
                                            AppContainer.Text = e.Link.Caption;
                                            InvokeMethod(t, xc, e);
                                            AppContainer.Controls.Add(xc);
                                            xc.BringToFront();
                                            xc.Focus();
                                        }
                                    }
                                }
                                else
                                {
                                    AppContainer.Text = e.Link.Caption;
                                    AppContainer.Controls[AppContainer.Controls.IndexOfKey(string.Format("{0}{1}", t.Name, objModule.Id))].BringToFront();
                                    AppContainer.Controls[AppContainer.Controls.IndexOfKey(string.Format("{0}{1}", t.Name, objModule.Id))].Focus();
                                }
                            }
                            Cursor.Current = Cursors.Default;
                            break;
                        case "UserControl":
                            Cursor.Current = Cursors.WaitCursor;
                            if (AppContainer != null)
                            {
                                if (!AppContainer.Controls.ContainsKey(string.Format("{0}{1}", t.Name, objModule.Id)))
                                {
                                    UserControl uc = Activator.CreateInstance(t) as UserControl;
                                    if (uc != null)
                                    {
                                        if (!AppContainer.Controls.Contains(uc))
                                        {
                                            if (objModule.Module == null)
                                                objModule.Module = DataServices.ChucNang.GetById(objModule.Id);
                                            uc.Name = string.Format("{0}{1}", t.Name, objModule.Id);
                                            uc.Dock = DockStyle.Fill;
                                            uc.Tag = objModule;
                                            AppContainer.Text = e.Link.Caption;
                                            InvokeMethod(t, uc, e);
                                            AppContainer.Controls.Add(uc);
                                            uc.BringToFront();
                                            uc.Focus();
                                        }
                                    }
                                }
                                else
                                {
                                    AppContainer.Text = e.Link.Caption;
                                    AppContainer.Controls[AppContainer.Controls.IndexOfKey(string.Format("{0}{1}", t.Name, objModule.Id))].BringToFront();
                                    AppContainer.Controls[AppContainer.Controls.IndexOfKey(string.Format("{0}{1}", t.Name, objModule.Id))].Focus();
                                }
                            }
                            Cursor.Current = Cursors.Default;
                            break;
                        case "Object":
                            Object obj = Activator.CreateInstance(t) as Object;
                            if (obj != null)
                                InvokeMethod(t, obj, e);
                            break;
                        default:
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message + "\n" + ex.StackTrace, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        /// <summary>
        /// Module select support treelist.
        /// </summary>
        /// <param name="t"></param>
        /// <param name="pContainer"></param>
        /// <param name="e"></param>
        private static void ModuleSelect(Type t, GroupControl pContainer, FocusedNodeChangedEventArgs e)
        {
            try
            {
                AppModule objModule = e.Node.Tag as AppModule;
                if (objModule == null)
                {
                    objModule = new AppModule() { Id = (int)e.Node.GetValue("Id"), ModuleId = e.Node.GetValue("TenForm").ToString() };
                    if (e.Node.GetValue("TenPhuongThuc") != null)
                        objModule.MethodName = e.Node.GetValue("TenPhuongThuc").ToString();
                    if (e.Node.GetValue("ThamSo") != null)
                        objModule.Parameter = e.Node.GetValue("ThamSo").ToString();
                    if (e.Node.GetValue("KieuForm") != null)
                        objModule.Type = e.Node.GetValue("KieuForm").ToString();
                    if (e.Node.GetValue("TenChucNang") != null)
                        objModule.Caption = e.Node.GetValue("TenChucNang").ToString();
                    e.Node.Tag = objModule;
                }

                switch (t.BaseType.Name)
                {
                    case "XtraForm":
                        Cursor.Current = Cursors.WaitCursor;
                        XtraForm xForm = Activator.CreateInstance(t) as XtraForm;
                        if (xForm != null)
                        {
                            foreach (Form fr in frmMain.Instance.xtraTabbedMdiManager.MdiParent.MdiChildren)
                            {
                                if (fr.Name == string.Format("{0}{1}", t.Name, objModule.Id))
                                {
                                    fr.Focus();
                                    return;
                                }
                            }
                            xForm.Name += objModule.Id;
                            InvokeMethod(t, xForm, e);
                            if (objModule.Module == null)
                                objModule.Module = DataServices.ChucNang.GetById(objModule.Id);
                            if (!string.IsNullOrEmpty(objModule.Type))
                            {
                                if (objModule.Type == "Popup")
                                {
                                    xForm.Tag = objModule;
                                    xForm.Text = objModule.Caption;
                                    xForm.ShowDialog();
                                }
                                else
                                {
                                    xForm.MdiParent = frmMain.Instance;
                                    xForm.Tag = objModule;
                                    xForm.Text = objModule.Caption;
                                    xForm.Show();
                                    xForm.Focus();
                                }
                            }
                            else
                            {
                                xForm.MdiParent = frmMain.Instance;
                                xForm.Tag = objModule;
                                xForm.Text = objModule.Caption;
                                xForm.Show();
                                xForm.Focus();
                            }
                        }
                        Cursor.Current = Cursors.Default;
                        break;
                    case "Form":
                        Cursor.Current = Cursors.WaitCursor;
                        Form form = Activator.CreateInstance(t) as Form;
                        if (form != null)
                        {
                            foreach (Form fr in frmMain.Instance.xtraTabbedMdiManager.MdiParent.MdiChildren)
                            {
                                if (fr.Name == string.Format("{0}{1}", t.Name, objModule.Id))
                                {
                                    fr.Focus();
                                    return;
                                }
                            }
                            form.Name += objModule.Id;
                            InvokeMethod(t, form, e);
                            if (objModule.Module == null)
                                objModule.Module = DataServices.ChucNang.GetById(objModule.Id);
                            if (!string.IsNullOrEmpty(objModule.Type))
                            {
                                if (objModule.Type == "Popup")
                                {
                                    form.Tag = objModule;
                                    form.Text = objModule.Caption;
                                    form.ShowDialog();
                                }
                                else
                                {
                                    form.MdiParent = frmMain.Instance;
                                    form.Tag = objModule;
                                    form.Text = objModule.Caption;
                                    form.Show();
                                    form.Focus();
                                }
                            }
                            else
                            {
                                form.MdiParent = frmMain.Instance;
                                form.Tag = objModule;
                                form.Text = objModule.Caption;
                                form.Show();
                                form.Focus();
                            }
                        }
                        Cursor.Current = Cursors.Default;
                        break;
                    case "XtraUserControl":
                        Cursor.Current = Cursors.WaitCursor;
                        if (!pContainer.Controls.ContainsKey(string.Format("{0}{1}", t.Name, objModule.Id)))
                        {
                            XtraUserControl xc = Activator.CreateInstance(t) as XtraUserControl;
                            if (xc != null)
                            {
                                if (!pContainer.Controls.Contains(xc))
                                {
                                    if (objModule.Module == null)
                                        objModule.Module = DataServices.ChucNang.GetById(objModule.Id);
                                    xc.Name = string.Format("{0}{1}", t.Name, objModule.Id);
                                    xc.Dock = DockStyle.Fill;
                                    xc.Tag = objModule;
                                    pContainer.Text = objModule.Caption;
                                    InvokeMethod(t, xc, e);
                                    pContainer.Controls.Add(xc);
                                    xc.BringToFront();
                                    xc.Focus();
                                }
                            }
                        }
                        else
                        {
                            pContainer.Text = objModule.Caption;
                            pContainer.Controls[pContainer.Controls.IndexOfKey(string.Format("{0}{1}", t.Name, objModule.Id))].BringToFront();
                            pContainer.Controls[pContainer.Controls.IndexOfKey(string.Format("{0}{1}", t.Name, objModule.Id))].Focus();
                        }
                        Cursor.Current = Cursors.Default;
                        break;
                    case "UserControl":
                        Cursor.Current = Cursors.WaitCursor;
                        if (!pContainer.Controls.ContainsKey(string.Format("{0}{1}", t.Name, objModule.Id)))
                        {
                            UserControl uc = Activator.CreateInstance(t) as UserControl;
                            if (uc != null)
                            {
                                if (!pContainer.Controls.Contains(uc))
                                {
                                    if (objModule.Module == null)
                                        objModule.Module = DataServices.ChucNang.GetById(objModule.Id);
                                    uc.Name = string.Format("{0}{1}", t.Name, objModule.Id);
                                    uc.Dock = DockStyle.Fill;
                                    uc.Tag = objModule;
                                    pContainer.Text = objModule.Caption;
                                    InvokeMethod(t, uc, e);
                                    pContainer.Controls.Add(uc);
                                    uc.BringToFront();
                                    uc.Focus();
                                }
                            }
                        }
                        else
                        {
                            pContainer.Text = objModule.Caption;
                            pContainer.Controls[pContainer.Controls.IndexOfKey(string.Format("{0}{1}", t.Name, objModule.Id))].BringToFront();
                            pContainer.Controls[pContainer.Controls.IndexOfKey(string.Format("{0}{1}", t.Name, objModule.Id))].Focus();
                        }
                        Cursor.Current = Cursors.Default;
                        break;
                    case "Object":
                        Object obj = Activator.CreateInstance(t) as Object;
                        if (obj != null)
                            InvokeMethod(t, obj, e);
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        /// <summary>
        /// Module focus support treelist.
        /// </summary>
        /// <param name="pContainer"></param>
        /// <param name="e"></param>
        public static void TreeListModulesFocused(GroupControl pContainer, FocusedNodeChangedEventArgs e)
        {
            if (e.Node != null)
            {
                if (e.Node.GetValue("TenForm") != null)
                {
                    Plugin plugin = AppPlugin.Plugins.Find(e.Node.GetValue("TenForm").ToString());
                    if (plugin != null)
                    {
                        Type t = Type.GetType(plugin.FullName);
                        if (t != null)
                            ModuleSelect(t, pContainer, e);
                        else
                        {
                            Type tf = Assembly.LoadFrom(plugin.AssemblyPath).GetType(plugin.FullName);
                            if (tf != null)
                                ModuleSelect(tf, pContainer, e);
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Get type of module
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static Type GetTypeModule(string name)
        {
            Plugin plugin = AppPlugin.Plugins.Find(name);
            if (plugin != null)
            {
                Type t = Type.GetType(plugin.FullName);
                if (t != null)
                    return t;
                else
                {
                    Type tf = Assembly.LoadFrom(plugin.AssemblyPath).GetType(plugin.FullName);
                    if (tf != null)
                        return tf;
                }
            }
            return null;
        }
    }
}