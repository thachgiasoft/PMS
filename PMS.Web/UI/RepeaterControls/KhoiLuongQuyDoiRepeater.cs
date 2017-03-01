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
    /// A designer class for a strongly typed repeater <c>KhoiLuongQuyDoiRepeater</c>
    /// </summary>
	public class KhoiLuongQuyDoiRepeaterDesigner : System.Web.UI.Design.ControlDesigner
	{
	    /// <summary>
        /// Initializes a new instance of the <see cref="T:KhoiLuongQuyDoiRepeaterDesigner"/> class.
        /// </summary>
		public KhoiLuongQuyDoiRepeaterDesigner()
		{
		}

        /// <summary>
        /// Initializes the control designer and loads the specified component.
        /// </summary>
        /// <param name="component">The control being designed.</param>
		public override void Initialize(IComponent component)
		{
			if (!(component is KhoiLuongQuyDoiRepeater))
			{ 
				throw new ArgumentException("Component is not a KhoiLuongQuyDoiRepeater."); 
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
			KhoiLuongQuyDoiRepeater z = (KhoiLuongQuyDoiRepeater)Component;
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
    /// A strongly typed repeater control for the <see cref="KhoiLuongQuyDoiRepeater"/> Type.
    /// </summary>
	[Designer(typeof(KhoiLuongQuyDoiRepeaterDesigner))]
	[ParseChildren(true)]
	[ToolboxData("<{0}:KhoiLuongQuyDoiRepeater runat=\"server\"></{0}:KhoiLuongQuyDoiRepeater>")]
	public class KhoiLuongQuyDoiRepeater : CompositeDataBoundControl, System.Web.UI.INamingContainer
	{
	    /// <summary>
        /// Initializes a new instance of the <see cref="T:KhoiLuongQuyDoiRepeater"/> class.
        /// </summary>
		public KhoiLuongQuyDoiRepeater()
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
		[TemplateContainer(typeof(KhoiLuongQuyDoiItem))]
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
		[TemplateContainer(typeof(KhoiLuongQuyDoiItem))]
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
        [TemplateContainer(typeof(KhoiLuongQuyDoiItem))]
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
		[TemplateContainer(typeof(KhoiLuongQuyDoiItem))]
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
		[TemplateContainer(typeof(KhoiLuongQuyDoiItem))]
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
						PMS.Entities.KhoiLuongQuyDoi entity = o as PMS.Entities.KhoiLuongQuyDoi;
						KhoiLuongQuyDoiItem container = new KhoiLuongQuyDoiItem(entity);
	
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
	public class KhoiLuongQuyDoiItem : System.Web.UI.Control, System.Web.UI.INamingContainer
	{
		private PMS.Entities.KhoiLuongQuyDoi _entity;

        /// <summary>
        /// Initializes a new instance of the <see cref="T:KhoiLuongQuyDoiItem"/> class.
        /// </summary>
		public KhoiLuongQuyDoiItem()
			: base()
		{ }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:KhoiLuongQuyDoiItem"/> class.
        /// </summary>
		public KhoiLuongQuyDoiItem(PMS.Entities.KhoiLuongQuyDoi entity)
			: base()
		{
			_entity = entity;
		}
		
        /// <summary>
        /// Gets the MaKhoiLuongQuyDoi
        /// </summary>
        /// <value>The MaKhoiLuongQuyDoi.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Int32 MaKhoiLuongQuyDoi
		{
			get { return _entity.MaKhoiLuongQuyDoi; }
		}
        /// <summary>
        /// Gets the MaKhoiLuongGiangDay
        /// </summary>
        /// <value>The MaKhoiLuongGiangDay.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Int32? MaKhoiLuongGiangDay
		{
			get { return _entity.MaKhoiLuongGiangDay; }
		}
        /// <summary>
        /// Gets the MaGiangVien
        /// </summary>
        /// <value>The MaGiangVien.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String MaGiangVien
		{
			get { return _entity.MaGiangVien; }
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
        /// Gets the MaKhoaHoc
        /// </summary>
        /// <value>The MaKhoaHoc.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String MaKhoaHoc
		{
			get { return _entity.MaKhoaHoc; }
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
        /// Gets the HeSoCongViec
        /// </summary>
        /// <value>The HeSoCongViec.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Decimal? HeSoCongViec
		{
			get { return _entity.HeSoCongViec; }
		}
        /// <summary>
        /// Gets the HeSoBacDaoTao
        /// </summary>
        /// <value>The HeSoBacDaoTao.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Decimal? HeSoBacDaoTao
		{
			get { return _entity.HeSoBacDaoTao; }
		}
        /// <summary>
        /// Gets the HeSoNgonNgu
        /// </summary>
        /// <value>The HeSoNgonNgu.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Decimal? HeSoNgonNgu
		{
			get { return _entity.HeSoNgonNgu; }
		}
        /// <summary>
        /// Gets the HeSoChucDanhChuyenMon
        /// </summary>
        /// <value>The HeSoChucDanhChuyenMon.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Decimal? HeSoChucDanhChuyenMon
		{
			get { return _entity.HeSoChucDanhChuyenMon; }
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
        /// Gets the HeSoCoSo
        /// </summary>
        /// <value>The HeSoCoSo.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Decimal? HeSoCoSo
		{
			get { return _entity.HeSoCoSo; }
		}
        /// <summary>
        /// Gets the SoTietThucTeQuyDoi
        /// </summary>
        /// <value>The SoTietThucTeQuyDoi.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Decimal? SoTietThucTeQuyDoi
		{
			get { return _entity.SoTietThucTeQuyDoi; }
		}
        /// <summary>
        /// Gets the TietQuyDoi
        /// </summary>
        /// <value>The TietQuyDoi.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Decimal? TietQuyDoi
		{
			get { return _entity.TietQuyDoi; }
		}
        /// <summary>
        /// Gets the HeSoQuyDoiThucHanhSangLyThuyet
        /// </summary>
        /// <value>The HeSoQuyDoiThucHanhSangLyThuyet.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Decimal? HeSoQuyDoiThucHanhSangLyThuyet
		{
			get { return _entity.HeSoQuyDoiThucHanhSangLyThuyet; }
		}
        /// <summary>
        /// Gets the HeSoNgoaiGio
        /// </summary>
        /// <value>The HeSoNgoaiGio.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Decimal? HeSoNgoaiGio
		{
			get { return _entity.HeSoNgoaiGio; }
		}
        /// <summary>
        /// Gets the LoaiLop
        /// </summary>
        /// <value>The LoaiLop.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String LoaiLop
		{
			get { return _entity.LoaiLop; }
		}
        /// <summary>
        /// Gets the HeSoClcCntn
        /// </summary>
        /// <value>The HeSoClcCntn.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Decimal? HeSoClcCntn
		{
			get { return _entity.HeSoClcCntn; }
		}
        /// <summary>
        /// Gets the HeSoThinhGiangMonChuyenNganh
        /// </summary>
        /// <value>The HeSoThinhGiangMonChuyenNganh.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Decimal? HeSoThinhGiangMonChuyenNganh
		{
			get { return _entity.HeSoThinhGiangMonChuyenNganh; }
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
        /// Gets the HeSoTroCapGiangDay
        /// </summary>
        /// <value>The HeSoTroCapGiangDay.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Decimal? HeSoTroCapGiangDay
		{
			get { return _entity.HeSoTroCapGiangDay; }
		}
        /// <summary>
        /// Gets the HeSoTroCap
        /// </summary>
        /// <value>The HeSoTroCap.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Decimal? HeSoTroCap
		{
			get { return _entity.HeSoTroCap; }
		}
        /// <summary>
        /// Gets the HeSoLuong
        /// </summary>
        /// <value>The HeSoLuong.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Decimal? HeSoLuong
		{
			get { return _entity.HeSoLuong; }
		}
        /// <summary>
        /// Gets the HeSoMonMoi
        /// </summary>
        /// <value>The HeSoMonMoi.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Decimal? HeSoMonMoi
		{
			get { return _entity.HeSoMonMoi; }
		}
        /// <summary>
        /// Gets the HeSoNienCheTinChi
        /// </summary>
        /// <value>The HeSoNienCheTinChi.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Decimal? HeSoNienCheTinChi
		{
			get { return _entity.HeSoNienCheTinChi; }
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
        /// Gets the MucThanhToan
        /// </summary>
        /// <value>The MucThanhToan.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Decimal? MucThanhToan
		{
			get { return _entity.MucThanhToan; }
		}
        /// <summary>
        /// Gets the HeSoKhoiNganh
        /// </summary>
        /// <value>The HeSoKhoiNganh.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Decimal? HeSoKhoiNganh
		{
			get { return _entity.HeSoKhoiNganh; }
		}
        /// <summary>
        /// Gets the MaKhoaCuaMonHoc
        /// </summary>
        /// <value>The MaKhoaCuaMonHoc.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String MaKhoaCuaMonHoc
		{
			get { return _entity.MaKhoaCuaMonHoc; }
		}

        /// <summary>
        /// Gets a <see cref="T:PMS.Entities.KhoiLuongQuyDoi"></see> object
        /// </summary>
        /// <value></value>
        [System.ComponentModel.Bindable(true)]
        public PMS.Entities.KhoiLuongQuyDoi Entity
        {
            get { return _entity; }
        }
	}
}
