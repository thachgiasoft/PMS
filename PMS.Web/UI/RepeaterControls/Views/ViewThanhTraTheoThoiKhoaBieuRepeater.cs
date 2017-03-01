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
    /// A designer class for a strongly typed repeater <c>ViewThanhTraTheoThoiKhoaBieuRepeater</c>
    /// </summary>
	public class ViewThanhTraTheoThoiKhoaBieuRepeaterDesigner : System.Web.UI.Design.ControlDesigner
	{
	    /// <summary>
        /// Initializes a new instance of the <see cref="T:ViewThanhTraTheoThoiKhoaBieuRepeaterDesigner"/> class.
        /// </summary>
		public ViewThanhTraTheoThoiKhoaBieuRepeaterDesigner()
		{
		}

        /// <summary>
        /// Initializes the control designer and loads the specified component.
        /// </summary>
        /// <param name="component">The control being designed.</param>
		public override void Initialize(IComponent component)
		{
			if (!(component is ViewThanhTraTheoThoiKhoaBieuRepeater))
			{ 
				throw new ArgumentException("Component is not a ViewThanhTraTheoThoiKhoaBieuRepeater."); 
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
			ViewThanhTraTheoThoiKhoaBieuRepeater z = (ViewThanhTraTheoThoiKhoaBieuRepeater)Component;
			z.DataBind();

			return base.GetDesignTimeHtml();
		}
	}

    /// <summary>
    /// A strongly typed repeater control for the <see cref="ViewThanhTraTheoThoiKhoaBieuRepeater"/> Type.
    /// </summary>
	[Designer(typeof(ViewThanhTraTheoThoiKhoaBieuRepeaterDesigner))]
	[ParseChildren(true)]
	[ToolboxData("<{0}:ViewThanhTraTheoThoiKhoaBieuRepeater runat=\"server\"></{0}:ViewThanhTraTheoThoiKhoaBieuRepeater>")]
	public class ViewThanhTraTheoThoiKhoaBieuRepeater : CompositeDataBoundControl, System.Web.UI.INamingContainer
	{
	    /// <summary>
        /// Initializes a new instance of the <see cref="T:ViewThanhTraTheoThoiKhoaBieuRepeater"/> class.
        /// </summary>
		public ViewThanhTraTheoThoiKhoaBieuRepeater()
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
		[TemplateContainer(typeof(ViewThanhTraTheoThoiKhoaBieuItem))]
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
		[TemplateContainer(typeof(ViewThanhTraTheoThoiKhoaBieuItem))]
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
        [TemplateContainer(typeof(ViewThanhTraTheoThoiKhoaBieuItem))]
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
		[TemplateContainer(typeof(ViewThanhTraTheoThoiKhoaBieuItem))]
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
		[TemplateContainer(typeof(ViewThanhTraTheoThoiKhoaBieuItem))]
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
						PMS.Entities.ViewThanhTraTheoThoiKhoaBieu entity = o as PMS.Entities.ViewThanhTraTheoThoiKhoaBieu;
						ViewThanhTraTheoThoiKhoaBieuItem container = new ViewThanhTraTheoThoiKhoaBieuItem(entity);
	
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
	public class ViewThanhTraTheoThoiKhoaBieuItem : System.Web.UI.Control, System.Web.UI.INamingContainer
	{
		private PMS.Entities.ViewThanhTraTheoThoiKhoaBieu _entity;

        /// <summary>
        /// Initializes a new instance of the <see cref="T:ViewThanhTraTheoThoiKhoaBieuItem"/> class.
        /// </summary>
		public ViewThanhTraTheoThoiKhoaBieuItem()
			: base()
		{ }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:ViewThanhTraTheoThoiKhoaBieuItem"/> class.
        /// </summary>
		public ViewThanhTraTheoThoiKhoaBieuItem(PMS.Entities.ViewThanhTraTheoThoiKhoaBieu entity)
			: base()
		{
			_entity = entity;
		}
		
        /// <summary>
        /// Gets the MaLichHoc
        /// </summary>
        /// <value>The MaLichHoc.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Int32 MaLichHoc
		{
			get { return _entity.MaLichHoc; }
		}
        /// <summary>
        /// Gets the MaGocLopHocPhan
        /// </summary>
        /// <value>The MaGocLopHocPhan.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String MaGocLopHocPhan
		{
			get { return _entity.MaGocLopHocPhan; }
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
        /// Gets the MaHocPhan
        /// </summary>
        /// <value>The MaHocPhan.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String MaHocPhan
		{
			get { return _entity.MaHocPhan; }
		}
        /// <summary>
        /// Gets the TenHocPhan
        /// </summary>
        /// <value>The TenHocPhan.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String TenHocPhan
		{
			get { return _entity.TenHocPhan; }
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
        /// Gets the MaLop
        /// </summary>
        /// <value>The MaLop.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String MaLop
		{
			get { return _entity.MaLop; }
		}
        /// <summary>
        /// Gets the Ngay
        /// </summary>
        /// <value>The Ngay.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String Ngay
		{
			get { return _entity.Ngay; }
		}
        /// <summary>
        /// Gets the Thu
        /// </summary>
        /// <value>The Thu.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String Thu
		{
			get { return _entity.Thu; }
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
		public System.Int32? SoTiet
		{
			get { return _entity.SoTiet; }
		}
        /// <summary>
        /// Gets the Phong
        /// </summary>
        /// <value>The Phong.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String Phong
		{
			get { return _entity.Phong; }
		}
        /// <summary>
        /// Gets the Khoa
        /// </summary>
        /// <value>The Khoa.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String Khoa
		{
			get { return _entity.Khoa; }
		}
        /// <summary>
        /// Gets the MaCanBoGiangDay
        /// </summary>
        /// <value>The MaCanBoGiangDay.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String MaCanBoGiangDay
		{
			get { return _entity.MaCanBoGiangDay; }
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
        /// Gets the TienDo
        /// </summary>
        /// <value>The TienDo.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String TienDo
		{
			get { return _entity.TienDo; }
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
        /// Gets the MaViPham
        /// </summary>
        /// <value>The MaViPham.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String MaViPham
		{
			get { return _entity.MaViPham; }
		}
        /// <summary>
        /// Gets the NoiDungViPham
        /// </summary>
        /// <value>The NoiDungViPham.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String NoiDungViPham
		{
			get { return _entity.NoiDungViPham; }
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
        /// Gets the TenHinhThucViPham
        /// </summary>
        /// <value>The TenHinhThucViPham.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String TenHinhThucViPham
		{
			get { return _entity.TenHinhThucViPham; }
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
        /// Gets the SoTietGhiNhan
        /// </summary>
        /// <value>The SoTietGhiNhan.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Int32? SoTietGhiNhan
		{
			get { return _entity.SoTietGhiNhan; }
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
        /// Gets the TrangThai
        /// </summary>
        /// <value>The TrangThai.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Boolean? TrangThai
		{
			get { return _entity.TrangThai; }
		}

	}
}
