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
    /// A designer class for a strongly typed repeater <c>DuTruGioGiangKhiCoLopHocPhanRepeater</c>
    /// </summary>
	public class DuTruGioGiangKhiCoLopHocPhanRepeaterDesigner : System.Web.UI.Design.ControlDesigner
	{
	    /// <summary>
        /// Initializes a new instance of the <see cref="T:DuTruGioGiangKhiCoLopHocPhanRepeaterDesigner"/> class.
        /// </summary>
		public DuTruGioGiangKhiCoLopHocPhanRepeaterDesigner()
		{
		}

        /// <summary>
        /// Initializes the control designer and loads the specified component.
        /// </summary>
        /// <param name="component">The control being designed.</param>
		public override void Initialize(IComponent component)
		{
			if (!(component is DuTruGioGiangKhiCoLopHocPhanRepeater))
			{ 
				throw new ArgumentException("Component is not a DuTruGioGiangKhiCoLopHocPhanRepeater."); 
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
			DuTruGioGiangKhiCoLopHocPhanRepeater z = (DuTruGioGiangKhiCoLopHocPhanRepeater)Component;
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
    /// A strongly typed repeater control for the <see cref="DuTruGioGiangKhiCoLopHocPhanRepeater"/> Type.
    /// </summary>
	[Designer(typeof(DuTruGioGiangKhiCoLopHocPhanRepeaterDesigner))]
	[ParseChildren(true)]
	[ToolboxData("<{0}:DuTruGioGiangKhiCoLopHocPhanRepeater runat=\"server\"></{0}:DuTruGioGiangKhiCoLopHocPhanRepeater>")]
	public class DuTruGioGiangKhiCoLopHocPhanRepeater : CompositeDataBoundControl, System.Web.UI.INamingContainer
	{
	    /// <summary>
        /// Initializes a new instance of the <see cref="T:DuTruGioGiangKhiCoLopHocPhanRepeater"/> class.
        /// </summary>
		public DuTruGioGiangKhiCoLopHocPhanRepeater()
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
		[TemplateContainer(typeof(DuTruGioGiangKhiCoLopHocPhanItem))]
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
		[TemplateContainer(typeof(DuTruGioGiangKhiCoLopHocPhanItem))]
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
        [TemplateContainer(typeof(DuTruGioGiangKhiCoLopHocPhanItem))]
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
		[TemplateContainer(typeof(DuTruGioGiangKhiCoLopHocPhanItem))]
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
		[TemplateContainer(typeof(DuTruGioGiangKhiCoLopHocPhanItem))]
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
						PMS.Entities.DuTruGioGiangKhiCoLopHocPhan entity = o as PMS.Entities.DuTruGioGiangKhiCoLopHocPhan;
						DuTruGioGiangKhiCoLopHocPhanItem container = new DuTruGioGiangKhiCoLopHocPhanItem(entity);
	
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
	public class DuTruGioGiangKhiCoLopHocPhanItem : System.Web.UI.Control, System.Web.UI.INamingContainer
	{
		private PMS.Entities.DuTruGioGiangKhiCoLopHocPhan _entity;

        /// <summary>
        /// Initializes a new instance of the <see cref="T:DuTruGioGiangKhiCoLopHocPhanItem"/> class.
        /// </summary>
		public DuTruGioGiangKhiCoLopHocPhanItem()
			: base()
		{ }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:DuTruGioGiangKhiCoLopHocPhanItem"/> class.
        /// </summary>
		public DuTruGioGiangKhiCoLopHocPhanItem(PMS.Entities.DuTruGioGiangKhiCoLopHocPhan entity)
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
        /// Gets the MaLopHocPhan
        /// </summary>
        /// <value>The MaLopHocPhan.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String MaLopHocPhan
		{
			get { return _entity.MaLopHocPhan; }
		}
        /// <summary>
        /// Gets the TenLopHocPhan
        /// </summary>
        /// <value>The TenLopHocPhan.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String TenLopHocPhan
		{
			get { return _entity.TenLopHocPhan; }
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
        /// Gets the SoTiet
        /// </summary>
        /// <value>The SoTiet.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Decimal? SoTiet
		{
			get { return _entity.SoTiet; }
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
        /// Gets the MaLoaiHocPhan
        /// </summary>
        /// <value>The MaLoaiHocPhan.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Int32? MaLoaiHocPhan
		{
			get { return _entity.MaLoaiHocPhan; }
		}
        /// <summary>
        /// Gets the TenLoaiHocPhan
        /// </summary>
        /// <value>The TenLoaiHocPhan.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String TenLoaiHocPhan
		{
			get { return _entity.TenLoaiHocPhan; }
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
        /// Gets the MaNhomMonHoc
        /// </summary>
        /// <value>The MaNhomMonHoc.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Int32? MaNhomMonHoc
		{
			get { return _entity.MaNhomMonHoc; }
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
        /// Gets the HeSoLopDong
        /// </summary>
        /// <value>The HeSoLopDong.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Decimal? HeSoLopDong
		{
			get { return _entity.HeSoLopDong; }
		}
        /// <summary>
        /// Gets the HeSoMonThucTap
        /// </summary>
        /// <value>The HeSoMonThucTap.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Decimal? HeSoMonThucTap
		{
			get { return _entity.HeSoMonThucTap; }
		}
        /// <summary>
        /// Gets the HeSoCoVanHocTap
        /// </summary>
        /// <value>The HeSoCoVanHocTap.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Decimal? HeSoCoVanHocTap
		{
			get { return _entity.HeSoCoVanHocTap; }
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
        /// Gets the MaDonVi
        /// </summary>
        /// <value>The MaDonVi.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String MaDonVi
		{
			get { return _entity.MaDonVi; }
		}

        /// <summary>
        /// Gets a <see cref="T:PMS.Entities.DuTruGioGiangKhiCoLopHocPhan"></see> object
        /// </summary>
        /// <value></value>
        [System.ComponentModel.Bindable(true)]
        public PMS.Entities.DuTruGioGiangKhiCoLopHocPhan Entity
        {
            get { return _entity; }
        }
	}
}
