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
    /// A designer class for a strongly typed repeater <c>ViewThanhTraCoiThiRepeater</c>
    /// </summary>
	public class ViewThanhTraCoiThiRepeaterDesigner : System.Web.UI.Design.ControlDesigner
	{
	    /// <summary>
        /// Initializes a new instance of the <see cref="T:ViewThanhTraCoiThiRepeaterDesigner"/> class.
        /// </summary>
		public ViewThanhTraCoiThiRepeaterDesigner()
		{
		}

        /// <summary>
        /// Initializes the control designer and loads the specified component.
        /// </summary>
        /// <param name="component">The control being designed.</param>
		public override void Initialize(IComponent component)
		{
			if (!(component is ViewThanhTraCoiThiRepeater))
			{ 
				throw new ArgumentException("Component is not a ViewThanhTraCoiThiRepeater."); 
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
			ViewThanhTraCoiThiRepeater z = (ViewThanhTraCoiThiRepeater)Component;
			z.DataBind();

			return base.GetDesignTimeHtml();
		}
	}

    /// <summary>
    /// A strongly typed repeater control for the <see cref="ViewThanhTraCoiThiRepeater"/> Type.
    /// </summary>
	[Designer(typeof(ViewThanhTraCoiThiRepeaterDesigner))]
	[ParseChildren(true)]
	[ToolboxData("<{0}:ViewThanhTraCoiThiRepeater runat=\"server\"></{0}:ViewThanhTraCoiThiRepeater>")]
	public class ViewThanhTraCoiThiRepeater : CompositeDataBoundControl, System.Web.UI.INamingContainer
	{
	    /// <summary>
        /// Initializes a new instance of the <see cref="T:ViewThanhTraCoiThiRepeater"/> class.
        /// </summary>
		public ViewThanhTraCoiThiRepeater()
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
		[TemplateContainer(typeof(ViewThanhTraCoiThiItem))]
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
		[TemplateContainer(typeof(ViewThanhTraCoiThiItem))]
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
        [TemplateContainer(typeof(ViewThanhTraCoiThiItem))]
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
		[TemplateContainer(typeof(ViewThanhTraCoiThiItem))]
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
		[TemplateContainer(typeof(ViewThanhTraCoiThiItem))]
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
						PMS.Entities.ViewThanhTraCoiThi entity = o as PMS.Entities.ViewThanhTraCoiThi;
						ViewThanhTraCoiThiItem container = new ViewThanhTraCoiThiItem(entity);
	
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
	public class ViewThanhTraCoiThiItem : System.Web.UI.Control, System.Web.UI.INamingContainer
	{
		private PMS.Entities.ViewThanhTraCoiThi _entity;

        /// <summary>
        /// Initializes a new instance of the <see cref="T:ViewThanhTraCoiThiItem"/> class.
        /// </summary>
		public ViewThanhTraCoiThiItem()
			: base()
		{ }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:ViewThanhTraCoiThiItem"/> class.
        /// </summary>
		public ViewThanhTraCoiThiItem(PMS.Entities.ViewThanhTraCoiThi entity)
			: base()
		{
			_entity = entity;
		}
		
        /// <summary>
        /// Gets the Examination
        /// </summary>
        /// <value>The Examination.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Int32 Examination
		{
			get { return _entity.Examination; }
		}
        /// <summary>
        /// Gets the MaCanBoCoiThi
        /// </summary>
        /// <value>The MaCanBoCoiThi.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String MaCanBoCoiThi
		{
			get { return _entity.MaCanBoCoiThi; }
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
        /// Gets the NgayThi
        /// </summary>
        /// <value>The NgayThi.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String NgayThi
		{
			get { return _entity.NgayThi; }
		}
        /// <summary>
        /// Gets the ThoiGianBatDau
        /// </summary>
        /// <value>The ThoiGianBatDau.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String ThoiGianBatDau
		{
			get { return _entity.ThoiGianBatDau; }
		}
        /// <summary>
        /// Gets the MaPhong
        /// </summary>
        /// <value>The MaPhong.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String MaPhong
		{
			get { return _entity.MaPhong; }
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
        /// Gets the ThoiGianLamBai
        /// </summary>
        /// <value>The ThoiGianLamBai.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String ThoiGianLamBai
		{
			get { return _entity.ThoiGianLamBai; }
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
        /// Gets the MaLopSinhVien
        /// </summary>
        /// <value>The MaLopSinhVien.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String MaLopSinhVien
		{
			get { return _entity.MaLopSinhVien; }
		}
        /// <summary>
        /// Gets the SoLuongSinhVien
        /// </summary>
        /// <value>The SoLuongSinhVien.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Int32? SoLuongSinhVien
		{
			get { return _entity.SoLuongSinhVien; }
		}
        /// <summary>
        /// Gets the TenKhoaChuQuan
        /// </summary>
        /// <value>The TenKhoaChuQuan.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String TenKhoaChuQuan
		{
			get { return _entity.TenKhoaChuQuan; }
		}
        /// <summary>
        /// Gets the MaViPham
        /// </summary>
        /// <value>The MaViPham.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String MaViPham
		{
			get { return _entity.MaViPham; }
		}
        /// <summary>
        /// Gets the MaHinhThucViPhamHrm
        /// </summary>
        /// <value>The MaHinhThucViPhamHrm.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Guid? MaHinhThucViPhamHrm
		{
			get { return _entity.MaHinhThucViPhamHrm; }
		}
        /// <summary>
        /// Gets the SiSoThanhTra
        /// </summary>
        /// <value>The SiSoThanhTra.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Int32? SiSoThanhTra
		{
			get { return _entity.SiSoThanhTra; }
		}
        /// <summary>
        /// Gets the ThoiDiemGhiNhan
        /// </summary>
        /// <value>The ThoiDiemGhiNhan.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String ThoiDiemGhiNhan
		{
			get { return _entity.ThoiDiemGhiNhan; }
		}
        /// <summary>
        /// Gets the LyDo
        /// </summary>
        /// <value>The LyDo.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String LyDo
		{
			get { return _entity.LyDo; }
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
        /// Gets the MaLoaiHocPhan
        /// </summary>
        /// <value>The MaLoaiHocPhan.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Int32? MaLoaiHocPhan
		{
			get { return _entity.MaLoaiHocPhan; }
		}
        /// <summary>
        /// Gets the TuTietDenTiet
        /// </summary>
        /// <value>The TuTietDenTiet.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String TuTietDenTiet
		{
			get { return _entity.TuTietDenTiet; }
		}
        /// <summary>
        /// Gets the TrangThai
        /// </summary>
        /// <value>The TrangThai.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Boolean? TrangThai
		{
			get { return _entity.TrangThai; }
		}
        /// <summary>
        /// Gets the XacNhan
        /// </summary>
        /// <value>The XacNhan.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Boolean? XacNhan
		{
			get { return _entity.XacNhan; }
		}
        /// <summary>
        /// Gets the SoTiet
        /// </summary>
        /// <value>The SoTiet.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Int32 SoTiet
		{
			get { return _entity.SoTiet; }
		}
        /// <summary>
        /// Gets the Lt
        /// </summary>
        /// <value>The Lt.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Int32? Lt
		{
			get { return _entity.Lt; }
		}
        /// <summary>
        /// Gets the Th
        /// </summary>
        /// <value>The Th.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Int32? Th
		{
			get { return _entity.Th; }
		}

	}
}
