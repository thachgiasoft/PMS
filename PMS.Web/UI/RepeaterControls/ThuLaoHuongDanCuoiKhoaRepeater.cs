using System;
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
    /// A designer class for a strongly typed repeater <c>ThuLaoHuongDanCuoiKhoaRepeater</c>
    /// </summary>
	public class ThuLaoHuongDanCuoiKhoaRepeaterDesigner : System.Web.UI.Design.ControlDesigner
	{
	    /// <summary>
        /// Initializes a new instance of the <see cref="T:ThuLaoHuongDanCuoiKhoaRepeaterDesigner"/> class.
        /// </summary>
		public ThuLaoHuongDanCuoiKhoaRepeaterDesigner()
		{
		}

        /// <summary>
        /// Initializes the control designer and loads the specified component.
        /// </summary>
        /// <param name="component">The control being designed.</param>
		public override void Initialize(IComponent component)
		{
			if (!(component is ThuLaoHuongDanCuoiKhoaRepeater))
			{ 
				throw new ArgumentException("Component is not a ThuLaoHuongDanCuoiKhoaRepeater."); 
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
			ThuLaoHuongDanCuoiKhoaRepeater z = (ThuLaoHuongDanCuoiKhoaRepeater)Component;
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
    /// A strongly typed repeater control for the <see cref="ThuLaoHuongDanCuoiKhoaRepeater"/> Type.
    /// </summary>
	[Designer(typeof(ThuLaoHuongDanCuoiKhoaRepeaterDesigner))]
	[ParseChildren(true)]
	[ToolboxData("<{0}:ThuLaoHuongDanCuoiKhoaRepeater runat=\"server\"></{0}:ThuLaoHuongDanCuoiKhoaRepeater>")]
	public class ThuLaoHuongDanCuoiKhoaRepeater : CompositeDataBoundControl, System.Web.UI.INamingContainer
	{
	    /// <summary>
        /// Initializes a new instance of the <see cref="T:ThuLaoHuongDanCuoiKhoaRepeater"/> class.
        /// </summary>
		public ThuLaoHuongDanCuoiKhoaRepeater()
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
		[TemplateContainer(typeof(ThuLaoHuongDanCuoiKhoaItem))]
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
		[TemplateContainer(typeof(ThuLaoHuongDanCuoiKhoaItem))]
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
        [TemplateContainer(typeof(ThuLaoHuongDanCuoiKhoaItem))]
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
		[TemplateContainer(typeof(ThuLaoHuongDanCuoiKhoaItem))]
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
		[TemplateContainer(typeof(ThuLaoHuongDanCuoiKhoaItem))]
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
						PMS.Entities.ThuLaoHuongDanCuoiKhoa entity = o as PMS.Entities.ThuLaoHuongDanCuoiKhoa;
						ThuLaoHuongDanCuoiKhoaItem container = new ThuLaoHuongDanCuoiKhoaItem(entity);
	
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
	public class ThuLaoHuongDanCuoiKhoaItem : System.Web.UI.Control, System.Web.UI.INamingContainer
	{
		private PMS.Entities.ThuLaoHuongDanCuoiKhoa _entity;

        /// <summary>
        /// Initializes a new instance of the <see cref="T:ThuLaoHuongDanCuoiKhoaItem"/> class.
        /// </summary>
		public ThuLaoHuongDanCuoiKhoaItem()
			: base()
		{ }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:ThuLaoHuongDanCuoiKhoaItem"/> class.
        /// </summary>
		public ThuLaoHuongDanCuoiKhoaItem(PMS.Entities.ThuLaoHuongDanCuoiKhoa entity)
			: base()
		{
			_entity = entity;
		}
		
        /// <summary>
        /// Gets the Id
        /// </summary>
        /// <value>The Id.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Int32 Id
		{
			get { return _entity.Id; }
		}
        /// <summary>
        /// Gets the MaGiangVienQuanLy
        /// </summary>
        /// <value>The MaGiangVienQuanLy.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String MaGiangVienQuanLy
		{
			get { return _entity.MaGiangVienQuanLy; }
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
        /// Gets the DotChiTra
        /// </summary>
        /// <value>The DotChiTra.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String DotChiTra
		{
			get { return _entity.DotChiTra; }
		}
        /// <summary>
        /// Gets the HuongDanVietBaoCaoTotNghiep
        /// </summary>
        /// <value>The HuongDanVietBaoCaoTotNghiep.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Int32? HuongDanVietBaoCaoTotNghiep
		{
			get { return _entity.HuongDanVietBaoCaoTotNghiep; }
		}
        /// <summary>
        /// Gets the HuongDanChuyenDeThucTapTotNghiep
        /// </summary>
        /// <value>The HuongDanChuyenDeThucTapTotNghiep.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Int32? HuongDanChuyenDeThucTapTotNghiep
		{
			get { return _entity.HuongDanChuyenDeThucTapTotNghiep; }
		}
        /// <summary>
        /// Gets the HuongDanKhoaLuanTotNghiep
        /// </summary>
        /// <value>The HuongDanKhoaLuanTotNghiep.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Int32? HuongDanKhoaLuanTotNghiep
		{
			get { return _entity.HuongDanKhoaLuanTotNghiep; }
		}
        /// <summary>
        /// Gets the PhanBienKhoaLuanTotNghiep
        /// </summary>
        /// <value>The PhanBienKhoaLuanTotNghiep.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Int32? PhanBienKhoaLuanTotNghiep
		{
			get { return _entity.PhanBienKhoaLuanTotNghiep; }
		}
        /// <summary>
        /// Gets the SoTietQuyDoi
        /// </summary>
        /// <value>The SoTietQuyDoi.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Decimal? SoTietQuyDoi
		{
			get { return _entity.SoTietQuyDoi; }
		}
        /// <summary>
        /// Gets the DonGia
        /// </summary>
        /// <value>The DonGia.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Decimal? DonGia
		{
			get { return _entity.DonGia; }
		}
        /// <summary>
        /// Gets the ThanhTienKhoaLuanChuyenDeTotNghiep
        /// </summary>
        /// <value>The ThanhTienKhoaLuanChuyenDeTotNghiep.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Decimal? ThanhTienKhoaLuanChuyenDeTotNghiep
		{
			get { return _entity.ThanhTienKhoaLuanChuyenDeTotNghiep; }
		}
        /// <summary>
        /// Gets the SoLuongThamGiaHoiDongTotNghiep
        /// </summary>
        /// <value>The SoLuongThamGiaHoiDongTotNghiep.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Int32? SoLuongThamGiaHoiDongTotNghiep
		{
			get { return _entity.SoLuongThamGiaHoiDongTotNghiep; }
		}
        /// <summary>
        /// Gets the ThanhTienThamGiaHoiDongTotNghiep
        /// </summary>
        /// <value>The ThanhTienThamGiaHoiDongTotNghiep.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Decimal? ThanhTienThamGiaHoiDongTotNghiep
		{
			get { return _entity.ThanhTienThamGiaHoiDongTotNghiep; }
		}
        /// <summary>
        /// Gets the SoTietNoGioChuan
        /// </summary>
        /// <value>The SoTietNoGioChuan.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Decimal? SoTietNoGioChuan
		{
			get { return _entity.SoTietNoGioChuan; }
		}
        /// <summary>
        /// Gets the ThanhTienNoGioChuan
        /// </summary>
        /// <value>The ThanhTienNoGioChuan.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Decimal? ThanhTienNoGioChuan
		{
			get { return _entity.ThanhTienNoGioChuan; }
		}
        /// <summary>
        /// Gets the Thue
        /// </summary>
        /// <value>The Thue.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Decimal? Thue
		{
			get { return _entity.Thue; }
		}
        /// <summary>
        /// Gets the ThucLanh
        /// </summary>
        /// <value>The ThucLanh.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Decimal? ThucLanh
		{
			get { return _entity.ThucLanh; }
		}
        /// <summary>
        /// Gets the NoiDung
        /// </summary>
        /// <value>The NoiDung.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String NoiDung
		{
			get { return _entity.NoiDung; }
		}
        /// <summary>
        /// Gets the NgayCapNhat
        /// </summary>
        /// <value>The NgayCapNhat.</value>
		[System.ComponentModel.Bindable(true)]
		public System.DateTime? NgayCapNhat
		{
			get { return _entity.NgayCapNhat; }
		}
        /// <summary>
        /// Gets the NguoiCapNhat
        /// </summary>
        /// <value>The NguoiCapNhat.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String NguoiCapNhat
		{
			get { return _entity.NguoiCapNhat; }
		}
        /// <summary>
        /// Gets the ChotKhoiLuong
        /// </summary>
        /// <value>The ChotKhoiLuong.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Int32? ChotKhoiLuong
		{
			get { return _entity.ChotKhoiLuong; }
		}

        /// <summary>
        /// Gets a <see cref="T:PMS.Entities.ThuLaoHuongDanCuoiKhoa"></see> object
        /// </summary>
        /// <value></value>
        [System.ComponentModel.Bindable(true)]
        public PMS.Entities.ThuLaoHuongDanCuoiKhoa Entity
        {
            get { return _entity; }
        }
	}
}
