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
    /// A designer class for a strongly typed repeater <c>CongThucRepeater</c>
    /// </summary>
	public class CongThucRepeaterDesigner : System.Web.UI.Design.ControlDesigner
	{
	    /// <summary>
        /// Initializes a new instance of the <see cref="T:CongThucRepeaterDesigner"/> class.
        /// </summary>
		public CongThucRepeaterDesigner()
		{
		}

        /// <summary>
        /// Initializes the control designer and loads the specified component.
        /// </summary>
        /// <param name="component">The control being designed.</param>
		public override void Initialize(IComponent component)
		{
			if (!(component is CongThucRepeater))
			{ 
				throw new ArgumentException("Component is not a CongThucRepeater."); 
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
			CongThucRepeater z = (CongThucRepeater)Component;
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
    /// A strongly typed repeater control for the <see cref="CongThucRepeater"/> Type.
    /// </summary>
	[Designer(typeof(CongThucRepeaterDesigner))]
	[ParseChildren(true)]
	[ToolboxData("<{0}:CongThucRepeater runat=\"server\"></{0}:CongThucRepeater>")]
	public class CongThucRepeater : CompositeDataBoundControl, System.Web.UI.INamingContainer
	{
	    /// <summary>
        /// Initializes a new instance of the <see cref="T:CongThucRepeater"/> class.
        /// </summary>
		public CongThucRepeater()
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
		[TemplateContainer(typeof(CongThucItem))]
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
		[TemplateContainer(typeof(CongThucItem))]
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
        [TemplateContainer(typeof(CongThucItem))]
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
		[TemplateContainer(typeof(CongThucItem))]
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
		[TemplateContainer(typeof(CongThucItem))]
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
						PMS.Entities.CongThuc entity = o as PMS.Entities.CongThuc;
						CongThucItem container = new CongThucItem(entity);
	
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
	public class CongThucItem : System.Web.UI.Control, System.Web.UI.INamingContainer
	{
		private PMS.Entities.CongThuc _entity;

        /// <summary>
        /// Initializes a new instance of the <see cref="T:CongThucItem"/> class.
        /// </summary>
		public CongThucItem()
			: base()
		{ }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:CongThucItem"/> class.
        /// </summary>
		public CongThucItem(PMS.Entities.CongThuc entity)
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
        /// Gets the YearStudy
        /// </summary>
        /// <value>The YearStudy.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String YearStudy
		{
			get { return _entity.YearStudy; }
		}
        /// <summary>
        /// Gets the Name
        /// </summary>
        /// <value>The Name.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String Name
		{
			get { return _entity.Name; }
		}
        /// <summary>
        /// Gets the Col01
        /// </summary>
        /// <value>The Col01.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Decimal? Col01
		{
			get { return _entity.Col01; }
		}
        /// <summary>
        /// Gets the Col02
        /// </summary>
        /// <value>The Col02.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Decimal? Col02
		{
			get { return _entity.Col02; }
		}
        /// <summary>
        /// Gets the Col03
        /// </summary>
        /// <value>The Col03.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Decimal? Col03
		{
			get { return _entity.Col03; }
		}
        /// <summary>
        /// Gets the Col04
        /// </summary>
        /// <value>The Col04.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Decimal? Col04
		{
			get { return _entity.Col04; }
		}
        /// <summary>
        /// Gets the Col05
        /// </summary>
        /// <value>The Col05.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Decimal? Col05
		{
			get { return _entity.Col05; }
		}
        /// <summary>
        /// Gets the Col06
        /// </summary>
        /// <value>The Col06.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Decimal? Col06
		{
			get { return _entity.Col06; }
		}
        /// <summary>
        /// Gets the Col07
        /// </summary>
        /// <value>The Col07.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Decimal? Col07
		{
			get { return _entity.Col07; }
		}
        /// <summary>
        /// Gets the Col08
        /// </summary>
        /// <value>The Col08.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Decimal? Col08
		{
			get { return _entity.Col08; }
		}
        /// <summary>
        /// Gets the UpdateDate
        /// </summary>
        /// <value>The UpdateDate.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String UpdateDate
		{
			get { return _entity.UpdateDate; }
		}
        /// <summary>
        /// Gets the UpdateStaff
        /// </summary>
        /// <value>The UpdateStaff.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String UpdateStaff
		{
			get { return _entity.UpdateStaff; }
		}

        /// <summary>
        /// Gets a <see cref="T:PMS.Entities.CongThuc"></see> object
        /// </summary>
        /// <value></value>
        [System.ComponentModel.Bindable(true)]
        public PMS.Entities.CongThuc Entity
        {
            get { return _entity; }
        }
	}
}
