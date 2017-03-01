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
    /// A designer class for a strongly typed repeater <c>ChucNangRepeater</c>
    /// </summary>
	public class ChucNangRepeaterDesigner : System.Web.UI.Design.ControlDesigner
	{
	    /// <summary>
        /// Initializes a new instance of the <see cref="T:ChucNangRepeaterDesigner"/> class.
        /// </summary>
		public ChucNangRepeaterDesigner()
		{
		}

        /// <summary>
        /// Initializes the control designer and loads the specified component.
        /// </summary>
        /// <param name="component">The control being designed.</param>
		public override void Initialize(IComponent component)
		{
			if (!(component is ChucNangRepeater))
			{ 
				throw new ArgumentException("Component is not a ChucNangRepeater."); 
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
			ChucNangRepeater z = (ChucNangRepeater)Component;
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
    /// A strongly typed repeater control for the <see cref="ChucNangRepeater"/> Type.
    /// </summary>
	[Designer(typeof(ChucNangRepeaterDesigner))]
	[ParseChildren(true)]
	[ToolboxData("<{0}:ChucNangRepeater runat=\"server\"></{0}:ChucNangRepeater>")]
	public class ChucNangRepeater : CompositeDataBoundControl, System.Web.UI.INamingContainer
	{
	    /// <summary>
        /// Initializes a new instance of the <see cref="T:ChucNangRepeater"/> class.
        /// </summary>
		public ChucNangRepeater()
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
		[TemplateContainer(typeof(ChucNangItem))]
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
		[TemplateContainer(typeof(ChucNangItem))]
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
        [TemplateContainer(typeof(ChucNangItem))]
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
		[TemplateContainer(typeof(ChucNangItem))]
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
		[TemplateContainer(typeof(ChucNangItem))]
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
						PMS.Entities.ChucNang entity = o as PMS.Entities.ChucNang;
						ChucNangItem container = new ChucNangItem(entity);
	
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
	public class ChucNangItem : System.Web.UI.Control, System.Web.UI.INamingContainer
	{
		private PMS.Entities.ChucNang _entity;

        /// <summary>
        /// Initializes a new instance of the <see cref="T:ChucNangItem"/> class.
        /// </summary>
		public ChucNangItem()
			: base()
		{ }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:ChucNangItem"/> class.
        /// </summary>
		public ChucNangItem(PMS.Entities.ChucNang entity)
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
        /// Gets the ParentId
        /// </summary>
        /// <value>The ParentId.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Int32? ParentId
		{
			get { return _entity.ParentId; }
		}
        /// <summary>
        /// Gets the PhanLoai
        /// </summary>
        /// <value>The PhanLoai.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String PhanLoai
		{
			get { return _entity.PhanLoai; }
		}
        /// <summary>
        /// Gets the Menu
        /// </summary>
        /// <value>The Menu.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Boolean? Menu
		{
			get { return _entity.Menu; }
		}
        /// <summary>
        /// Gets the BeginGroup
        /// </summary>
        /// <value>The BeginGroup.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Boolean? BeginGroup
		{
			get { return _entity.BeginGroup; }
		}
        /// <summary>
        /// Gets the RibbonStyle
        /// </summary>
        /// <value>The RibbonStyle.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Boolean? RibbonStyle
		{
			get { return _entity.RibbonStyle; }
		}
        /// <summary>
        /// Gets the DataLayout
        /// </summary>
        /// <value>The DataLayout.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Byte[] DataLayout
		{
			get { return _entity.DataLayout; }
		}
        /// <summary>
        /// Gets the TenChucNang
        /// </summary>
        /// <value>The TenChucNang.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String TenChucNang
		{
			get { return _entity.TenChucNang; }
		}
        /// <summary>
        /// Gets the TenForm
        /// </summary>
        /// <value>The TenForm.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String TenForm
		{
			get { return _entity.TenForm; }
		}
        /// <summary>
        /// Gets the HinhAnh
        /// </summary>
        /// <value>The HinhAnh.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Byte[] HinhAnh
		{
			get { return _entity.HinhAnh; }
		}
        /// <summary>
        /// Gets the ThuTu
        /// </summary>
        /// <value>The ThuTu.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Int32? ThuTu
		{
			get { return _entity.ThuTu; }
		}
        /// <summary>
        /// Gets the TenPhuongThuc
        /// </summary>
        /// <value>The TenPhuongThuc.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String TenPhuongThuc
		{
			get { return _entity.TenPhuongThuc; }
		}
        /// <summary>
        /// Gets the ThamSo
        /// </summary>
        /// <value>The ThamSo.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String ThamSo
		{
			get { return _entity.ThamSo; }
		}
        /// <summary>
        /// Gets the KieuForm
        /// </summary>
        /// <value>The KieuForm.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String KieuForm
		{
			get { return _entity.KieuForm; }
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
        /// Gets a <see cref="T:PMS.Entities.ChucNang"></see> object
        /// </summary>
        /// <value></value>
        [System.ComponentModel.Bindable(true)]
        public PMS.Entities.ChucNang Entity
        {
            get { return _entity; }
        }
	}
}
