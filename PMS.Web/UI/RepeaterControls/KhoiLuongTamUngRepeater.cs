﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Web.UI;
using System.ComponentModel;
using System.Web.UI.Design.WebControls;
using System.Web.UI.Design;
using System.Web.UI.WebControls;

namespace PMS.Web.UI
{
    /// <summary>
    /// A designer class for a strongly typed repeater <c>KhoiLuongTamUngRepeater</c>
    /// </summary>
	public class KhoiLuongTamUngRepeaterDesigner : System.Web.UI.Design.ControlDesigner
	{
	    /// <summary>
        /// Initializes a new instance of the <see cref="T:KhoiLuongTamUngRepeaterDesigner"/> class.
        /// </summary>
		public KhoiLuongTamUngRepeaterDesigner()
		{
		}

        /// <summary>
        /// Initializes the control designer and loads the specified component.
        /// </summary>
        /// <param name="component">The control being designed.</param>
		public override void Initialize(IComponent component)
		{
			if (!(component is KhoiLuongTamUngRepeater))
			{ 
				throw new ArgumentException("Component is not a KhoiLuongTamUngRepeater."); 
			} 
			base.Initialize(component); 
			base.SetViewFlags(ViewFlags.TemplateEditing, true); 
		}


		/// <summary>
		/// Generate HTML for the designer
		/// </summary>
		/// <returns>a string of design time HTML</returns>
		public override string GetDesignTimeHtml()
		{

			// Get the instance this designer applies to
			//
			KhoiLuongTamUngRepeater z = (KhoiLuongTamUngRepeater)Component;
			z.DataBind();

			return base.GetDesignTimeHtml();

			//return z.RenderAtDesignTime();

			//	ControlCollection c = z.Controls;
			//Totem z = (Totem) Component;
			//Totem z = (Totem) Component;
			//return ("<div style='border: 1px gray dotted; background-color: lightgray'><b>TagStat :</b> zae |  qsdds</div>");

		}
	}

    /// <summary>
    /// A strongly typed repeater control for the <see cref="KhoiLuongTamUngRepeater"/> Type.
    /// </summary>
	[Designer(typeof(KhoiLuongTamUngRepeaterDesigner))]
	[ParseChildren(true)]
	[ToolboxData("<{0}:KhoiLuongTamUngRepeater runat=\"server\"></{0}:KhoiLuongTamUngRepeater>")]
	public class KhoiLuongTamUngRepeater : CompositeDataBoundControl, System.Web.UI.INamingContainer
	{
	    /// <summary>
        /// Initializes a new instance of the <see cref="T:KhoiLuongTamUngRepeater"/> class.
        /// </summary>
		public KhoiLuongTamUngRepeater()
		{
		}

		/// <summary>
        /// Gets a <see cref="T:System.Web.UI.ControlCollection"></see> object that represents the child controls for a specified server control in the UI hierarchy.
        /// </summary>
        /// <value></value>
        /// <returns>The collection of child controls for the specified server control.</returns>
		public override ControlCollection Controls
		{
			get
			{
				this.EnsureChildControls();
				return base.Controls;
			}
		}

		private ITemplate m_headerTemplate;
		/// <summary>
        /// Gets or sets the header template.
        /// </summary>
        /// <value>The header template.</value>
		[Browsable(false)]
		[TemplateContainer(typeof(KhoiLuongTamUngItem))]
		[PersistenceMode(PersistenceMode.InnerDefaultProperty)]
		public ITemplate HeaderTemplate
		{
			get { return m_headerTemplate; }
			set { m_headerTemplate = value; }
		}

		private ITemplate m_itemTemplate;
		/// <summary>
        /// Gets or sets the item template.
        /// </summary>
        /// <value>The item template.</value>
		[Browsable(false)]
		[TemplateContainer(typeof(KhoiLuongTamUngItem))]
		[PersistenceMode(PersistenceMode.InnerDefaultProperty)]
		public ITemplate ItemTemplate
		{
			get { return m_itemTemplate; }
			set { m_itemTemplate = value; }
		}

		private ITemplate m_seperatorTemplate;
        /// <summary>
        /// Gets or sets the Seperator Template
        /// </summary>
        [Browsable(false)]
        [TemplateContainer(typeof(KhoiLuongTamUngItem))]
        [PersistenceMode(PersistenceMode.InnerDefaultProperty)]
        public ITemplate SeperatorTemplate
        {
            get { return m_seperatorTemplate; }
            set { m_seperatorTemplate = value; }
        }
			
		private ITemplate m_altenateItemTemplate;
        /// <summary>
        /// Gets or sets the alternating item template.
        /// </summary>
        /// <value>The alternating item template.</value>
		[Browsable(false)]
		[TemplateContainer(typeof(KhoiLuongTamUngItem))]
		[PersistenceMode(PersistenceMode.InnerDefaultProperty)]
		public ITemplate AlternatingItemTemplate
		{
			get { return m_altenateItemTemplate; }
			set { m_altenateItemTemplate = value; }
		}

		private ITemplate m_footerTemplate;
        /// <summary>
        /// Gets or sets the footer template.
        /// </summary>
        /// <value>The footer template.</value>
		[Browsable(false)]
		[TemplateContainer(typeof(KhoiLuongTamUngItem))]
		[PersistenceMode(PersistenceMode.InnerDefaultProperty)]
		public ITemplate FooterTemplate
		{
			get { return m_footerTemplate; }
			set { m_footerTemplate = value; }
		}

//      /// <summary>
//      /// Called by the ASP.NET page framework to notify server controls that use composition-based implementation to create any child controls they contain in preparation for posting back or rendering.
//      /// </summary>
//		protected override void CreateChildControls()
//      {
//         if (ChildControlsCreated)
//         {
//            return;
//         }

//         Controls.Clear();

//         //Instantiate the Header template (if exists)
//         if (m_headerTemplate != null)
//         {
//            Control headerItem = new Control();
//            m_headerTemplate.InstantiateIn(headerItem);
//            Controls.Add(headerItem);
//         }

//         //Instantiate the Footer template (if exists)
//         if (m_footerTemplate != null)
//         {
//            Control footerItem = new Control();
//            m_footerTemplate.InstantiateIn(footerItem);
//            Controls.Add(footerItem);
//         }
//
//         ChildControlsCreated = true;
//      }
	
		/// <summary>
        /// Overridden and Empty so that span tags are not written
        /// </summary>
        /// <param name="writer"></param>
        public override void RenderBeginTag(HtmlTextWriter writer)
        {
            
        }

        /// <summary>
        /// Overridden and Empty so that span tags are not written
        /// </summary>
        /// <param name="writer"></param>
        public override void RenderEndTag(HtmlTextWriter writer)
        {
                
        }		
		
		/// <summary>
      	/// Called by the ASP.NET page framework to notify server controls that use composition-based implementation to create any child controls they contain in preparation for posting back or rendering.
      	/// </summary>
		protected override int CreateChildControls(System.Collections.IEnumerable dataSource, bool dataBinding)
      	{
         int pos = 0;

         if (dataBinding)
         {
            //Instantiate the Header template (if exists)
            if (m_headerTemplate != null)
            {
                Control headerItem = new Control();
                m_headerTemplate.InstantiateIn(headerItem);
                Controls.Add(headerItem);
            }
			if (dataSource != null)
			{
				foreach (object o in dataSource)
				{
						PMS.Entities.KhoiLuongTamUng entity = o as PMS.Entities.KhoiLuongTamUng;
						KhoiLuongTamUngItem container = new KhoiLuongTamUngItem(entity);
	
						if (m_itemTemplate != null && (pos % 2) == 0)
						{
							m_itemTemplate.InstantiateIn(container);
							
							if (m_seperatorTemplate != null)
							{
								m_seperatorTemplate.InstantiateIn(container);
							}
						}
						else
						{
							if (m_altenateItemTemplate != null)
							{
								m_altenateItemTemplate.InstantiateIn(container);
								
								if (m_seperatorTemplate != null)
								{
									m_seperatorTemplate.InstantiateIn(container);
								}
								
							}
							else if (m_itemTemplate != null)
							{
								m_itemTemplate.InstantiateIn(container);
								
								if (m_seperatorTemplate != null)
								{
									m_seperatorTemplate.InstantiateIn(container);
								}
							}
							else
							{
								// no template !!!
							}
						}
						Controls.Add(container);
						
						container.DataBind();
						
						pos++;
				}
			}
            //Instantiate the Footer template (if exists)
            if (m_footerTemplate != null)
            {
                Control footerItem = new Control();
                m_footerTemplate.InstantiateIn(footerItem);
                Controls.Add(footerItem);
            }

		}
			
			return pos;
		}

        /// <summary>
        /// Raises the <see cref="E:System.Web.UI.Control.PreRender"></see> event.
        /// </summary>
        /// <param name="e">An <see cref="T:System.EventArgs"></see> object that contains the event data.</param>
		protected override void OnPreRender(EventArgs e)
		{
			base.DataBind();
		}

		#region Design time
        /// <summary>
        /// Renders at design time.
        /// </summary>
        /// <returns>a  string of the Designed HTML</returns>
		internal string RenderAtDesignTime()
		{			
			return "Designer currently not implemented"; 
		}

		#endregion
	}

    /// <summary>
    /// A wrapper type for the entity
    /// </summary>
	[System.ComponentModel.ToolboxItem(false)]
	public class KhoiLuongTamUngItem : System.Web.UI.Control, System.Web.UI.INamingContainer
	{
		private PMS.Entities.KhoiLuongTamUng _entity;

        /// <summary>
        /// Initializes a new instance of the <see cref="T:KhoiLuongTamUngItem"/> class.
        /// </summary>
		public KhoiLuongTamUngItem()
			: base()
		{ }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:KhoiLuongTamUngItem"/> class.
        /// </summary>
		public KhoiLuongTamUngItem(PMS.Entities.KhoiLuongTamUng entity)
			: base()
		{
			_entity = entity;
		}
		
        /// <summary>
        /// Gets the MaKhoiLuong
        /// </summary>
        /// <value>The MaKhoiLuong.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Int32 MaKhoiLuong
		{
			get { return _entity.MaKhoiLuong; }
		}
        /// <summary>
        /// Gets the MaLichHoc
        /// </summary>
        /// <value>The MaLichHoc.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Int32? MaLichHoc
		{
			get { return _entity.MaLichHoc; }
		}
        /// <summary>
        /// Gets the MaQuanLyGv
        /// </summary>
        /// <value>The MaQuanLyGv.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String MaQuanLyGv
		{
			get { return _entity.MaQuanLyGv; }
		}
        /// <summary>
        /// Gets the MaLopHocPhan
        /// </summary>
        /// <value>The MaLopHocPhan.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String MaLopHocPhan
		{
			get { return _entity.MaLopHocPhan; }
		}
        /// <summary>
        /// Gets the NamHoc
        /// </summary>
        /// <value>The NamHoc.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String NamHoc
		{
			get { return _entity.NamHoc; }
		}
        /// <summary>
        /// Gets the HocKy
        /// </summary>
        /// <value>The HocKy.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String HocKy
		{
			get { return _entity.HocKy; }
		}
        /// <summary>
        /// Gets the MaMonHoc
        /// </summary>
        /// <value>The MaMonHoc.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String MaMonHoc
		{
			get { return _entity.MaMonHoc; }
		}
        /// <summary>
        /// Gets the TenMonHoc
        /// </summary>
        /// <value>The TenMonHoc.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String TenMonHoc
		{
			get { return _entity.TenMonHoc; }
		}
        /// <summary>
        /// Gets the Nhom
        /// </summary>
        /// <value>The Nhom.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String Nhom
		{
			get { return _entity.Nhom; }
		}
        /// <summary>
        /// Gets the SoTinChi
        /// </summary>
        /// <value>The SoTinChi.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Decimal? SoTinChi
		{
			get { return _entity.SoTinChi; }
		}
        /// <summary>
        /// Gets the SoLuong
        /// </summary>
        /// <value>The SoLuong.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Int32? SoLuong
		{
			get { return _entity.SoLuong; }
		}
        /// <summary>
        /// Gets the MaLoaiHocPhan
        /// </summary>
        /// <value>The MaLoaiHocPhan.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Byte? MaLoaiHocPhan
		{
			get { return _entity.MaLoaiHocPhan; }
		}
        /// <summary>
        /// Gets the LoaiHocPhan
        /// </summary>
        /// <value>The LoaiHocPhan.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String LoaiHocPhan
		{
			get { return _entity.LoaiHocPhan; }
		}
        /// <summary>
        /// Gets the MaBuoiHoc
        /// </summary>
        /// <value>The MaBuoiHoc.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Int32? MaBuoiHoc
		{
			get { return _entity.MaBuoiHoc; }
		}
        /// <summary>
        /// Gets the MaLop
        /// </summary>
        /// <value>The MaLop.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String MaLop
		{
			get { return _entity.MaLop; }
		}
        /// <summary>
        /// Gets the TietBatDau
        /// </summary>
        /// <value>The TietBatDau.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Int32? TietBatDau
		{
			get { return _entity.TietBatDau; }
		}
        /// <summary>
        /// Gets the SoTiet
        /// </summary>
        /// <value>The SoTiet.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Decimal? SoTiet
		{
			get { return _entity.SoTiet; }
		}
        /// <summary>
        /// Gets the TinhTrang
        /// </summary>
        /// <value>The TinhTrang.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Int32? TinhTrang
		{
			get { return _entity.TinhTrang; }
		}
        /// <summary>
        /// Gets the NgayDay
        /// </summary>
        /// <value>The NgayDay.</value>
		[System.ComponentModel.Bindable(true)]
		public System.DateTime? NgayDay
		{
			get { return _entity.NgayDay; }
		}
        /// <summary>
        /// Gets the MaBacDaoTao
        /// </summary>
        /// <value>The MaBacDaoTao.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String MaBacDaoTao
		{
			get { return _entity.MaBacDaoTao; }
		}
        /// <summary>
        /// Gets the MaKhoa
        /// </summary>
        /// <value>The MaKhoa.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String MaKhoa
		{
			get { return _entity.MaKhoa; }
		}
        /// <summary>
        /// Gets the MaNhomMonHoc
        /// </summary>
        /// <value>The MaNhomMonHoc.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String MaNhomMonHoc
		{
			get { return _entity.MaNhomMonHoc; }
		}
        /// <summary>
        /// Gets the MaPhongHoc
        /// </summary>
        /// <value>The MaPhongHoc.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String MaPhongHoc
		{
			get { return _entity.MaPhongHoc; }
		}
        /// <summary>
        /// Gets the MaKhoaHoc
        /// </summary>
        /// <value>The MaKhoaHoc.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String MaKhoaHoc
		{
			get { return _entity.MaKhoaHoc; }
		}
        /// <summary>
        /// Gets the LoaiHocKy
        /// </summary>
        /// <value>The LoaiHocKy.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Byte? LoaiHocKy
		{
			get { return _entity.LoaiHocKy; }
		}
        /// <summary>
        /// Gets the NamThu
        /// </summary>
        /// <value>The NamThu.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String NamThu
		{
			get { return _entity.NamThu; }
		}
        /// <summary>
        /// Gets the MaHocHam
        /// </summary>
        /// <value>The MaHocHam.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Int32? MaHocHam
		{
			get { return _entity.MaHocHam; }
		}
        /// <summary>
        /// Gets the MaHocVi
        /// </summary>
        /// <value>The MaHocVi.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Int32? MaHocVi
		{
			get { return _entity.MaHocVi; }
		}
        /// <summary>
        /// Gets the MaLoaiGiangVien
        /// </summary>
        /// <value>The MaLoaiGiangVien.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Int32? MaLoaiGiangVien
		{
			get { return _entity.MaLoaiGiangVien; }
		}
        /// <summary>
        /// Gets the MaChucVu
        /// </summary>
        /// <value>The MaChucVu.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Int32? MaChucVu
		{
			get { return _entity.MaChucVu; }
		}
        /// <summary>
        /// Gets the MaHinhThucDaoTao
        /// </summary>
        /// <value>The MaHinhThucDaoTao.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String MaHinhThucDaoTao
		{
			get { return _entity.MaHinhThucDaoTao; }
		}
        /// <summary>
        /// Gets the GhiChu
        /// </summary>
        /// <value>The GhiChu.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String GhiChu
		{
			get { return _entity.GhiChu; }
		}
        /// <summary>
        /// Gets the LopHocPhanChuyenNganh
        /// </summary>
        /// <value>The LopHocPhanChuyenNganh.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Boolean? LopHocPhanChuyenNganh
		{
			get { return _entity.LopHocPhanChuyenNganh; }
		}
        /// <summary>
        /// Gets the DotImport
        /// </summary>
        /// <value>The DotImport.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String DotImport
		{
			get { return _entity.DotImport; }
		}
        /// <summary>
        /// Gets the DaoTaoTinChi
        /// </summary>
        /// <value>The DaoTaoTinChi.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Boolean? DaoTaoTinChi
		{
			get { return _entity.DaoTaoTinChi; }
		}
        /// <summary>
        /// Gets the NgonNguGiangDay
        /// </summary>
        /// <value>The NgonNguGiangDay.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String NgonNguGiangDay
		{
			get { return _entity.NgonNguGiangDay; }
		}

        /// <summary>
        /// Gets a <see cref="T:PMS.Entities.KhoiLuongTamUng"></see> object
        /// </summary>
        /// <value></value>
        [System.ComponentModel.Bindable(true)]
        public PMS.Entities.KhoiLuongTamUng Entity
        {
            get { return _entity; }
        }
	}
}