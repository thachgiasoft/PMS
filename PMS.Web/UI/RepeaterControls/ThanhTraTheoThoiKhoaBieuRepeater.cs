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
    /// A designer class for a strongly typed repeater <c>ThanhTraTheoThoiKhoaBieuRepeater</c>
    /// </summary>
	public class ThanhTraTheoThoiKhoaBieuRepeaterDesigner : System.Web.UI.Design.ControlDesigner
	{
	    /// <summary>
        /// Initializes a new instance of the <see cref="T:ThanhTraTheoThoiKhoaBieuRepeaterDesigner"/> class.
        /// </summary>
		public ThanhTraTheoThoiKhoaBieuRepeaterDesigner()
		{
		}

        /// <summary>
        /// Initializes the control designer and loads the specified component.
        /// </summary>
        /// <param name="component">The control being designed.</param>
		public override void Initialize(IComponent component)
		{
			if (!(component is ThanhTraTheoThoiKhoaBieuRepeater))
			{ 
				throw new ArgumentException("Component is not a ThanhTraTheoThoiKhoaBieuRepeater."); 
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
			ThanhTraTheoThoiKhoaBieuRepeater z = (ThanhTraTheoThoiKhoaBieuRepeater)Component;
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
    /// A strongly typed repeater control for the <see cref="ThanhTraTheoThoiKhoaBieuRepeater"/> Type.
    /// </summary>
	[Designer(typeof(ThanhTraTheoThoiKhoaBieuRepeaterDesigner))]
	[ParseChildren(true)]
	[ToolboxData("<{0}:ThanhTraTheoThoiKhoaBieuRepeater runat=\"server\"></{0}:ThanhTraTheoThoiKhoaBieuRepeater>")]
	public class ThanhTraTheoThoiKhoaBieuRepeater : CompositeDataBoundControl, System.Web.UI.INamingContainer
	{
	    /// <summary>
        /// Initializes a new instance of the <see cref="T:ThanhTraTheoThoiKhoaBieuRepeater"/> class.
        /// </summary>
		public ThanhTraTheoThoiKhoaBieuRepeater()
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
		[TemplateContainer(typeof(ThanhTraTheoThoiKhoaBieuItem))]
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
		[TemplateContainer(typeof(ThanhTraTheoThoiKhoaBieuItem))]
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
        [TemplateContainer(typeof(ThanhTraTheoThoiKhoaBieuItem))]
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
		[TemplateContainer(typeof(ThanhTraTheoThoiKhoaBieuItem))]
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
		[TemplateContainer(typeof(ThanhTraTheoThoiKhoaBieuItem))]
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
						PMS.Entities.ThanhTraTheoThoiKhoaBieu entity = o as PMS.Entities.ThanhTraTheoThoiKhoaBieu;
						ThanhTraTheoThoiKhoaBieuItem container = new ThanhTraTheoThoiKhoaBieuItem(entity);
	
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
	public class ThanhTraTheoThoiKhoaBieuItem : System.Web.UI.Control, System.Web.UI.INamingContainer
	{
		private PMS.Entities.ThanhTraTheoThoiKhoaBieu _entity;

        /// <summary>
        /// Initializes a new instance of the <see cref="T:ThanhTraTheoThoiKhoaBieuItem"/> class.
        /// </summary>
		public ThanhTraTheoThoiKhoaBieuItem()
			: base()
		{ }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:ThanhTraTheoThoiKhoaBieuItem"/> class.
        /// </summary>
		public ThanhTraTheoThoiKhoaBieuItem(PMS.Entities.ThanhTraTheoThoiKhoaBieu entity)
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
        /// Gets the SiSo
        /// </summary>
        /// <value>The SiSo.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Int32? SiSo
		{
			get { return _entity.SiSo; }
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
        /// Gets the SoTietGhiNhan
        /// </summary>
        /// <value>The SoTietGhiNhan.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Int32? SoTietGhiNhan
		{
			get { return _entity.SoTietGhiNhan; }
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
        /// Gets the Ngay
        /// </summary>
        /// <value>The Ngay.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String Ngay
		{
			get { return _entity.Ngay; }
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
        /// Gets the Phong
        /// </summary>
        /// <value>The Phong.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String Phong
		{
			get { return _entity.Phong; }
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
        /// Gets the SoTietQuyDoi
        /// </summary>
        /// <value>The SoTietQuyDoi.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Decimal? SoTietQuyDoi
		{
			get { return _entity.SoTietQuyDoi; }
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
        /// Gets the ThanhLy
        /// </summary>
        /// <value>The ThanhLy.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String ThanhLy
		{
			get { return _entity.ThanhLy; }
		}

        /// <summary>
        /// Gets a <see cref="T:PMS.Entities.ThanhTraTheoThoiKhoaBieu"></see> object
        /// </summary>
        /// <value></value>
        [System.ComponentModel.Bindable(true)]
        public PMS.Entities.ThanhTraTheoThoiKhoaBieu Entity
        {
            get { return _entity; }
        }
	}
}
