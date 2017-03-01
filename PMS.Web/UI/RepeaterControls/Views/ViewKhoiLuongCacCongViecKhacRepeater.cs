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
    /// A designer class for a strongly typed repeater <c>ViewKhoiLuongCacCongViecKhacRepeater</c>
    /// </summary>
	public class ViewKhoiLuongCacCongViecKhacRepeaterDesigner : System.Web.UI.Design.ControlDesigner
	{
	    /// <summary>
        /// Initializes a new instance of the <see cref="T:ViewKhoiLuongCacCongViecKhacRepeaterDesigner"/> class.
        /// </summary>
		public ViewKhoiLuongCacCongViecKhacRepeaterDesigner()
		{
		}

        /// <summary>
        /// Initializes the control designer and loads the specified component.
        /// </summary>
        /// <param name="component">The control being designed.</param>
		public override void Initialize(IComponent component)
		{
			if (!(component is ViewKhoiLuongCacCongViecKhacRepeater))
			{ 
				throw new ArgumentException("Component is not a ViewKhoiLuongCacCongViecKhacRepeater."); 
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
			ViewKhoiLuongCacCongViecKhacRepeater z = (ViewKhoiLuongCacCongViecKhacRepeater)Component;
			z.DataBind();

			return base.GetDesignTimeHtml();
		}
	}

    /// <summary>
    /// A strongly typed repeater control for the <see cref="ViewKhoiLuongCacCongViecKhacRepeater"/> Type.
    /// </summary>
	[Designer(typeof(ViewKhoiLuongCacCongViecKhacRepeaterDesigner))]
	[ParseChildren(true)]
	[ToolboxData("<{0}:ViewKhoiLuongCacCongViecKhacRepeater runat=\"server\"></{0}:ViewKhoiLuongCacCongViecKhacRepeater>")]
	public class ViewKhoiLuongCacCongViecKhacRepeater : CompositeDataBoundControl, System.Web.UI.INamingContainer
	{
	    /// <summary>
        /// Initializes a new instance of the <see cref="T:ViewKhoiLuongCacCongViecKhacRepeater"/> class.
        /// </summary>
		public ViewKhoiLuongCacCongViecKhacRepeater()
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
		[TemplateContainer(typeof(ViewKhoiLuongCacCongViecKhacItem))]
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
		[TemplateContainer(typeof(ViewKhoiLuongCacCongViecKhacItem))]
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
        [TemplateContainer(typeof(ViewKhoiLuongCacCongViecKhacItem))]
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
		[TemplateContainer(typeof(ViewKhoiLuongCacCongViecKhacItem))]
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
		[TemplateContainer(typeof(ViewKhoiLuongCacCongViecKhacItem))]
		[PersistenceMode(PersistenceMode.InnerDefaultProperty)]
		public ITemplate FooterTemplate
		{
			get { return m_footerTemplate; }
			set { m_footerTemplate = value; }
		}
		
		
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

//      /// <summary>
//      /// Called by the ASP.NET page framework to notify server controls that use composition-based implementation to create any child controls they contain in preparation for posting back or rendering.
//      /// </summary>
//		protected override void CreateChildControls()
//		{
//			if (ChildControlsCreated)
//			{
//				return;
//			}
//			Controls.Clear();
//
//			if (m_headerTemplate != null)
//			{
//				Control headerItem = new Control();
//				m_headerTemplate.InstantiateIn(headerItem);
//				Controls.Add(headerItem);
//			}
//
//			
//			if (m_footerTemplate != null)
//			{
//				Control footerItem = new Control();
//				m_footerTemplate.InstantiateIn(footerItem);
//				Controls.Add(footerItem);
//			}
//			ChildControlsCreated = true;
//		}
		
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
						PMS.Entities.ViewKhoiLuongCacCongViecKhac entity = o as PMS.Entities.ViewKhoiLuongCacCongViecKhac;
						ViewKhoiLuongCacCongViecKhacItem container = new ViewKhoiLuongCacCongViecKhacItem(entity);
	
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
	public class ViewKhoiLuongCacCongViecKhacItem : System.Web.UI.Control, System.Web.UI.INamingContainer
	{
		private PMS.Entities.ViewKhoiLuongCacCongViecKhac _entity;

        /// <summary>
        /// Initializes a new instance of the <see cref="T:ViewKhoiLuongCacCongViecKhacItem"/> class.
        /// </summary>
		public ViewKhoiLuongCacCongViecKhacItem()
			: base()
		{ }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:ViewKhoiLuongCacCongViecKhacItem"/> class.
        /// </summary>
		public ViewKhoiLuongCacCongViecKhacItem(PMS.Entities.ViewKhoiLuongCacCongViecKhac entity)
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
        /// Gets the MaGiangVienQuanLy
        /// </summary>
        /// <value>The MaGiangVienQuanLy.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String MaGiangVienQuanLy
		{
			get { return _entity.MaGiangVienQuanLy; }
		}
        /// <summary>
        /// Gets the Ho
        /// </summary>
        /// <value>The Ho.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String Ho
		{
			get { return _entity.Ho; }
		}
        /// <summary>
        /// Gets the Ten
        /// </summary>
        /// <value>The Ten.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String Ten
		{
			get { return _entity.Ten; }
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
        /// Gets the MaLoaiCongViec
        /// </summary>
        /// <value>The MaLoaiCongViec.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Int32 MaLoaiCongViec
		{
			get { return _entity.MaLoaiCongViec; }
		}
        /// <summary>
        /// Gets the MaCongViec
        /// </summary>
        /// <value>The MaCongViec.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String MaCongViec
		{
			get { return _entity.MaCongViec; }
		}
        /// <summary>
        /// Gets the TenCongViec
        /// </summary>
        /// <value>The TenCongViec.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String TenCongViec
		{
			get { return _entity.TenCongViec; }
		}
        /// <summary>
        /// Gets the MaDonViTinh
        /// </summary>
        /// <value>The MaDonViTinh.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Int32? MaDonViTinh
		{
			get { return _entity.MaDonViTinh; }
		}
        /// <summary>
        /// Gets the TenDonViTinh
        /// </summary>
        /// <value>The TenDonViTinh.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String TenDonViTinh
		{
			get { return _entity.TenDonViTinh; }
		}
        /// <summary>
        /// Gets the SoLuong
        /// </summary>
        /// <value>The SoLuong.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Decimal? SoLuong
		{
			get { return _entity.SoLuong; }
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
        /// Gets the MaNhom
        /// </summary>
        /// <value>The MaNhom.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String MaNhom
		{
			get { return _entity.MaNhom; }
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
        /// Gets the HeSoQuyDoi
        /// </summary>
        /// <value>The HeSoQuyDoi.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Decimal? HeSoQuyDoi
		{
			get { return _entity.HeSoQuyDoi; }
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
        /// Gets the Chot
        /// </summary>
        /// <value>The Chot.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Boolean? Chot
		{
			get { return _entity.Chot; }
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
        /// Gets the MaLoaiKhoiLuong
        /// </summary>
        /// <value>The MaLoaiKhoiLuong.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String MaLoaiKhoiLuong
		{
			get { return _entity.MaLoaiKhoiLuong; }
		}
        /// <summary>
        /// Gets the HeSoChucDanhKhoiLuongKhac
        /// </summary>
        /// <value>The HeSoChucDanhKhoiLuongKhac.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Decimal? HeSoChucDanhKhoiLuongKhac
		{
			get { return _entity.HeSoChucDanhKhoiLuongKhac; }
		}
        /// <summary>
        /// Gets the DotThanhToan
        /// </summary>
        /// <value>The DotThanhToan.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String DotThanhToan
		{
			get { return _entity.DotThanhToan; }
		}
        /// <summary>
        /// Gets the HeSoNhan
        /// </summary>
        /// <value>The HeSoNhan.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Int32? HeSoNhan
		{
			get { return _entity.HeSoNhan; }
		}
        /// <summary>
        /// Gets the GioChuanCongThemTrenMotTiet
        /// </summary>
        /// <value>The GioChuanCongThemTrenMotTiet.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Decimal? GioChuanCongThemTrenMotTiet
		{
			get { return _entity.GioChuanCongThemTrenMotTiet; }
		}

	}
}
