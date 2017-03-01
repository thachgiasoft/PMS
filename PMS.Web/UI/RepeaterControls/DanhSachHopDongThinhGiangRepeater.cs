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
    /// A designer class for a strongly typed repeater <c>DanhSachHopDongThinhGiangRepeater</c>
    /// </summary>
	public class DanhSachHopDongThinhGiangRepeaterDesigner : System.Web.UI.Design.ControlDesigner
	{
	    /// <summary>
        /// Initializes a new instance of the <see cref="T:DanhSachHopDongThinhGiangRepeaterDesigner"/> class.
        /// </summary>
		public DanhSachHopDongThinhGiangRepeaterDesigner()
		{
		}

        /// <summary>
        /// Initializes the control designer and loads the specified component.
        /// </summary>
        /// <param name="component">The control being designed.</param>
		public override void Initialize(IComponent component)
		{
			if (!(component is DanhSachHopDongThinhGiangRepeater))
			{ 
				throw new ArgumentException("Component is not a DanhSachHopDongThinhGiangRepeater."); 
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
			DanhSachHopDongThinhGiangRepeater z = (DanhSachHopDongThinhGiangRepeater)Component;
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
    /// A strongly typed repeater control for the <see cref="DanhSachHopDongThinhGiangRepeater"/> Type.
    /// </summary>
	[Designer(typeof(DanhSachHopDongThinhGiangRepeaterDesigner))]
	[ParseChildren(true)]
	[ToolboxData("<{0}:DanhSachHopDongThinhGiangRepeater runat=\"server\"></{0}:DanhSachHopDongThinhGiangRepeater>")]
	public class DanhSachHopDongThinhGiangRepeater : CompositeDataBoundControl, System.Web.UI.INamingContainer
	{
	    /// <summary>
        /// Initializes a new instance of the <see cref="T:DanhSachHopDongThinhGiangRepeater"/> class.
        /// </summary>
		public DanhSachHopDongThinhGiangRepeater()
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
		[TemplateContainer(typeof(DanhSachHopDongThinhGiangItem))]
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
		[TemplateContainer(typeof(DanhSachHopDongThinhGiangItem))]
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
        [TemplateContainer(typeof(DanhSachHopDongThinhGiangItem))]
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
		[TemplateContainer(typeof(DanhSachHopDongThinhGiangItem))]
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
		[TemplateContainer(typeof(DanhSachHopDongThinhGiangItem))]
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
						PMS.Entities.DanhSachHopDongThinhGiang entity = o as PMS.Entities.DanhSachHopDongThinhGiang;
						DanhSachHopDongThinhGiangItem container = new DanhSachHopDongThinhGiangItem(entity);
	
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
	public class DanhSachHopDongThinhGiangItem : System.Web.UI.Control, System.Web.UI.INamingContainer
	{
		private PMS.Entities.DanhSachHopDongThinhGiang _entity;

        /// <summary>
        /// Initializes a new instance of the <see cref="T:DanhSachHopDongThinhGiangItem"/> class.
        /// </summary>
		public DanhSachHopDongThinhGiangItem()
			: base()
		{ }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:DanhSachHopDongThinhGiangItem"/> class.
        /// </summary>
		public DanhSachHopDongThinhGiangItem(PMS.Entities.DanhSachHopDongThinhGiang entity)
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
        /// Gets the MaGiangVien
        /// </summary>
        /// <value>The MaGiangVien.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Int32? MaGiangVien
		{
			get { return _entity.MaGiangVien; }
		}
        /// <summary>
        /// Gets the HoTen
        /// </summary>
        /// <value>The HoTen.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String HoTen
		{
			get { return _entity.HoTen; }
		}
        /// <summary>
        /// Gets the NgaySinh
        /// </summary>
        /// <value>The NgaySinh.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String NgaySinh
		{
			get { return _entity.NgaySinh; }
		}
        /// <summary>
        /// Gets the SoCmnd
        /// </summary>
        /// <value>The SoCmnd.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String SoCmnd
		{
			get { return _entity.SoCmnd; }
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
        /// Gets the ChuyenNganh
        /// </summary>
        /// <value>The ChuyenNganh.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String ChuyenNganh
		{
			get { return _entity.ChuyenNganh; }
		}
        /// <summary>
        /// Gets the MaSoThue
        /// </summary>
        /// <value>The MaSoThue.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String MaSoThue
		{
			get { return _entity.MaSoThue; }
		}
        /// <summary>
        /// Gets the CoQuanCongTac
        /// </summary>
        /// <value>The CoQuanCongTac.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String CoQuanCongTac
		{
			get { return _entity.CoQuanCongTac; }
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
        /// Gets the MaLopHocPhan
        /// </summary>
        /// <value>The MaLopHocPhan.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String MaLopHocPhan
		{
			get { return _entity.MaLopHocPhan; }
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
        /// Gets the SoHopDong
        /// </summary>
        /// <value>The SoHopDong.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String SoHopDong
		{
			get { return _entity.SoHopDong; }
		}
        /// <summary>
        /// Gets the MaDonVi
        /// </summary>
        /// <value>The MaDonVi.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String MaDonVi
		{
			get { return _entity.MaDonVi; }
		}
        /// <summary>
        /// Gets the NgayBatDau
        /// </summary>
        /// <value>The NgayBatDau.</value>
		[System.ComponentModel.Bindable(true)]
		public System.DateTime? NgayBatDau
		{
			get { return _entity.NgayBatDau; }
		}
        /// <summary>
        /// Gets the NgayKetThuc
        /// </summary>
        /// <value>The NgayKetThuc.</value>
		[System.ComponentModel.Bindable(true)]
		public System.DateTime? NgayKetThuc
		{
			get { return _entity.NgayKetThuc; }
		}
        /// <summary>
        /// Gets the SoTietLyThuyet
        /// </summary>
        /// <value>The SoTietLyThuyet.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Decimal? SoTietLyThuyet
		{
			get { return _entity.SoTietLyThuyet; }
		}
        /// <summary>
        /// Gets the SoTietThucHanh
        /// </summary>
        /// <value>The SoTietThucHanh.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Decimal? SoTietThucHanh
		{
			get { return _entity.SoTietThucHanh; }
		}
        /// <summary>
        /// Gets the HeSoQuyDoiThucHanh
        /// </summary>
        /// <value>The HeSoQuyDoiThucHanh.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Decimal? HeSoQuyDoiThucHanh
		{
			get { return _entity.HeSoQuyDoiThucHanh; }
		}
        /// <summary>
        /// Gets the SoNhomThucHanh
        /// </summary>
        /// <value>The SoNhomThucHanh.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Int32? SoNhomThucHanh
		{
			get { return _entity.SoNhomThucHanh; }
		}
        /// <summary>
        /// Gets the TongSoTiet
        /// </summary>
        /// <value>The TongSoTiet.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Decimal? TongSoTiet
		{
			get { return _entity.TongSoTiet; }
		}
        /// <summary>
        /// Gets the SoTietLyThuyetTrenTuan
        /// </summary>
        /// <value>The SoTietLyThuyetTrenTuan.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Decimal? SoTietLyThuyetTrenTuan
		{
			get { return _entity.SoTietLyThuyetTrenTuan; }
		}
        /// <summary>
        /// Gets the SoTietThucHanhTrenTuan
        /// </summary>
        /// <value>The SoTietThucHanhTrenTuan.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Decimal? SoTietThucHanhTrenTuan
		{
			get { return _entity.SoTietThucHanhTrenTuan; }
		}
        /// <summary>
        /// Gets the TongSoTietTrenTuan
        /// </summary>
        /// <value>The TongSoTietTrenTuan.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Decimal? TongSoTietTrenTuan
		{
			get { return _entity.TongSoTietTrenTuan; }
		}
        /// <summary>
        /// Gets the HeSoLopDong
        /// </summary>
        /// <value>The HeSoLopDong.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Decimal? HeSoLopDong
		{
			get { return _entity.HeSoLopDong; }
		}
        /// <summary>
        /// Gets the SiSo
        /// </summary>
        /// <value>The SiSo.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Int32? SiSo
		{
			get { return _entity.SiSo; }
		}
        /// <summary>
        /// Gets the TrangThaiHoSo
        /// </summary>
        /// <value>The TrangThaiHoSo.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String TrangThaiHoSo
		{
			get { return _entity.TrangThaiHoSo; }
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
        /// Gets the DonViTienTe
        /// </summary>
        /// <value>The DonViTienTe.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String DonViTienTe
		{
			get { return _entity.DonViTienTe; }
		}
        /// <summary>
        /// Gets the TongGiaTriHopDong
        /// </summary>
        /// <value>The TongGiaTriHopDong.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Decimal? TongGiaTriHopDong
		{
			get { return _entity.TongGiaTriHopDong; }
		}
        /// <summary>
        /// Gets the GiaTriHopDongConLai
        /// </summary>
        /// <value>The GiaTriHopDongConLai.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Decimal? GiaTriHopDongConLai
		{
			get { return _entity.GiaTriHopDongConLai; }
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
        /// Gets the GhiChu
        /// </summary>
        /// <value>The GhiChu.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String GhiChu
		{
			get { return _entity.GhiChu; }
		}
        /// <summary>
        /// Gets the DaXacNhan
        /// </summary>
        /// <value>The DaXacNhan.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Boolean? DaXacNhan
		{
			get { return _entity.DaXacNhan; }
		}
        /// <summary>
        /// Gets the IsLock
        /// </summary>
        /// <value>The IsLock.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Boolean? IsLock
		{
			get { return _entity.IsLock; }
		}
        /// <summary>
        /// Gets the NgayCapNhat
        /// </summary>
        /// <value>The NgayCapNhat.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String NgayCapNhat
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
        /// Gets a <see cref="T:PMS.Entities.DanhSachHopDongThinhGiang"></see> object
        /// </summary>
        /// <value></value>
        [System.ComponentModel.Bindable(true)]
        public PMS.Entities.DanhSachHopDongThinhGiang Entity
        {
            get { return _entity; }
        }
	}
}
