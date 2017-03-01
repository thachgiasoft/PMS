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
    /// A designer class for a strongly typed repeater <c>CauHinhChotGioRepeater</c>
    /// </summary>
	public class CauHinhChotGioRepeaterDesigner : System.Web.UI.Design.ControlDesigner
	{
	    /// <summary>
        /// Initializes a new instance of the <see cref="T:CauHinhChotGioRepeaterDesigner"/> class.
        /// </summary>
		public CauHinhChotGioRepeaterDesigner()
		{
		}

        /// <summary>
        /// Initializes the control designer and loads the specified component.
        /// </summary>
        /// <param name="component">The control being designed.</param>
		public override void Initialize(IComponent component)
		{
			if (!(component is CauHinhChotGioRepeater))
			{ 
				throw new ArgumentException("Component is not a CauHinhChotGioRepeater."); 
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
			CauHinhChotGioRepeater z = (CauHinhChotGioRepeater)Component;
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
    /// A strongly typed repeater control for the <see cref="CauHinhChotGioRepeater"/> Type.
    /// </summary>
	[Designer(typeof(CauHinhChotGioRepeaterDesigner))]
	[ParseChildren(true)]
	[ToolboxData("<{0}:CauHinhChotGioRepeater runat=\"server\"></{0}:CauHinhChotGioRepeater>")]
	public class CauHinhChotGioRepeater : CompositeDataBoundControl, System.Web.UI.INamingContainer
	{
	    /// <summary>
        /// Initializes a new instance of the <see cref="T:CauHinhChotGioRepeater"/> class.
        /// </summary>
		public CauHinhChotGioRepeater()
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
		[TemplateContainer(typeof(CauHinhChotGioItem))]
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
		[TemplateContainer(typeof(CauHinhChotGioItem))]
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
        [TemplateContainer(typeof(CauHinhChotGioItem))]
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
		[TemplateContainer(typeof(CauHinhChotGioItem))]
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
		[TemplateContainer(typeof(CauHinhChotGioItem))]
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
						PMS.Entities.CauHinhChotGio entity = o as PMS.Entities.CauHinhChotGio;
						CauHinhChotGioItem container = new CauHinhChotGioItem(entity);
	
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
	public class CauHinhChotGioItem : System.Web.UI.Control, System.Web.UI.INamingContainer
	{
		private PMS.Entities.CauHinhChotGio _entity;

        /// <summary>
        /// Initializes a new instance of the <see cref="T:CauHinhChotGioItem"/> class.
        /// </summary>
		public CauHinhChotGioItem()
			: base()
		{ }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:CauHinhChotGioItem"/> class.
        /// </summary>
		public CauHinhChotGioItem(PMS.Entities.CauHinhChotGio entity)
			: base()
		{
			_entity = entity;
		}
		
        /// <summary>
        /// Gets the MaCauHinhChotGio
        /// </summary>
        /// <value>The MaCauHinhChotGio.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Int32 MaCauHinhChotGio
		{
			get { return _entity.MaCauHinhChotGio; }
		}
        /// <summary>
        /// Gets the MaQuanLy
        /// </summary>
        /// <value>The MaQuanLy.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String MaQuanLy
		{
			get { return _entity.MaQuanLy; }
		}
        /// <summary>
        /// Gets the TenQuanLy
        /// </summary>
        /// <value>The TenQuanLy.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String TenQuanLy
		{
			get { return _entity.TenQuanLy; }
		}
        /// <summary>
        /// Gets the TuNgay
        /// </summary>
        /// <value>The TuNgay.</value>
		[System.ComponentModel.Bindable(true)]
		public System.DateTime? TuNgay
		{
			get { return _entity.TuNgay; }
		}
        /// <summary>
        /// Gets the DenNgay
        /// </summary>
        /// <value>The DenNgay.</value>
		[System.ComponentModel.Bindable(true)]
		public System.DateTime? DenNgay
		{
			get { return _entity.DenNgay; }
		}
        /// <summary>
        /// Gets the IsLocked
        /// </summary>
        /// <value>The IsLocked.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Boolean? IsLocked
		{
			get { return _entity.IsLocked; }
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
        /// Gets the PhanTramDonGia
        /// </summary>
        /// <value>The PhanTramDonGia.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Decimal? PhanTramDonGia
		{
			get { return _entity.PhanTramDonGia; }
		}
        /// <summary>
        /// Gets the PhanTramHeSoCongThem
        /// </summary>
        /// <value>The PhanTramHeSoCongThem.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Decimal? PhanTramHeSoCongThem
		{
			get { return _entity.PhanTramHeSoCongThem; }
		}
        /// <summary>
        /// Gets the CoTinhNckh
        /// </summary>
        /// <value>The CoTinhNckh.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Boolean? CoTinhNckh
		{
			get { return _entity.CoTinhNckh; }
		}
        /// <summary>
        /// Gets the TinhVaoCaNam
        /// </summary>
        /// <value>The TinhVaoCaNam.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Boolean? TinhVaoCaNam
		{
			get { return _entity.TinhVaoCaNam; }
		}

        /// <summary>
        /// Gets a <see cref="T:PMS.Entities.CauHinhChotGio"></see> object
        /// </summary>
        /// <value></value>
        [System.ComponentModel.Bindable(true)]
        public PMS.Entities.CauHinhChotGio Entity
        {
            get { return _entity; }
        }
	}
}
