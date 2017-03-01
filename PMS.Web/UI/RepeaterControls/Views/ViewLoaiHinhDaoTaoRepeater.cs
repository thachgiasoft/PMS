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
    /// A designer class for a strongly typed repeater <c>ViewLoaiHinhDaoTaoRepeater</c>
    /// </summary>
	public class ViewLoaiHinhDaoTaoRepeaterDesigner : System.Web.UI.Design.ControlDesigner
	{
	    /// <summary>
        /// Initializes a new instance of the <see cref="T:ViewLoaiHinhDaoTaoRepeaterDesigner"/> class.
        /// </summary>
		public ViewLoaiHinhDaoTaoRepeaterDesigner()
		{
		}

        /// <summary>
        /// Initializes the control designer and loads the specified component.
        /// </summary>
        /// <param name="component">The control being designed.</param>
		public override void Initialize(IComponent component)
		{
			if (!(component is ViewLoaiHinhDaoTaoRepeater))
			{ 
				throw new ArgumentException("Component is not a ViewLoaiHinhDaoTaoRepeater."); 
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
			ViewLoaiHinhDaoTaoRepeater z = (ViewLoaiHinhDaoTaoRepeater)Component;
			z.DataBind();

			return base.GetDesignTimeHtml();
		}
	}

    /// <summary>
    /// A strongly typed repeater control for the <see cref="ViewLoaiHinhDaoTaoRepeater"/> Type.
    /// </summary>
	[Designer(typeof(ViewLoaiHinhDaoTaoRepeaterDesigner))]
	[ParseChildren(true)]
	[ToolboxData("<{0}:ViewLoaiHinhDaoTaoRepeater runat=\"server\"></{0}:ViewLoaiHinhDaoTaoRepeater>")]
	public class ViewLoaiHinhDaoTaoRepeater : CompositeDataBoundControl, System.Web.UI.INamingContainer
	{
	    /// <summary>
        /// Initializes a new instance of the <see cref="T:ViewLoaiHinhDaoTaoRepeater"/> class.
        /// </summary>
		public ViewLoaiHinhDaoTaoRepeater()
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
		[TemplateContainer(typeof(ViewLoaiHinhDaoTaoItem))]
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
		[TemplateContainer(typeof(ViewLoaiHinhDaoTaoItem))]
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
        [TemplateContainer(typeof(ViewLoaiHinhDaoTaoItem))]
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
		[TemplateContainer(typeof(ViewLoaiHinhDaoTaoItem))]
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
		[TemplateContainer(typeof(ViewLoaiHinhDaoTaoItem))]
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
						PMS.Entities.ViewLoaiHinhDaoTao entity = o as PMS.Entities.ViewLoaiHinhDaoTao;
						ViewLoaiHinhDaoTaoItem container = new ViewLoaiHinhDaoTaoItem(entity);
	
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
	public class ViewLoaiHinhDaoTaoItem : System.Web.UI.Control, System.Web.UI.INamingContainer
	{
		private PMS.Entities.ViewLoaiHinhDaoTao _entity;

        /// <summary>
        /// Initializes a new instance of the <see cref="T:ViewLoaiHinhDaoTaoItem"/> class.
        /// </summary>
		public ViewLoaiHinhDaoTaoItem()
			: base()
		{ }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:ViewLoaiHinhDaoTaoItem"/> class.
        /// </summary>
		public ViewLoaiHinhDaoTaoItem(PMS.Entities.ViewLoaiHinhDaoTao entity)
			: base()
		{
			_entity = entity;
		}
		
        /// <summary>
        /// Gets the MaLoaiHinh
        /// </summary>
        /// <value>The MaLoaiHinh.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String MaLoaiHinh
		{
			get { return _entity.MaLoaiHinh; }
		}
        /// <summary>
        /// Gets the TenLoaiHinh
        /// </summary>
        /// <value>The TenLoaiHinh.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String TenLoaiHinh
		{
			get { return _entity.TenLoaiHinh; }
		}
        /// <summary>
        /// Gets the Level
        /// </summary>
        /// <value>The Level.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Byte? Level
		{
			get { return _entity.Level; }
		}
        /// <summary>
        /// Gets the StudyUnitCode
        /// </summary>
        /// <value>The StudyUnitCode.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String StudyUnitCode
		{
			get { return _entity.StudyUnitCode; }
		}
        /// <summary>
        /// Gets the Locked
        /// </summary>
        /// <value>The Locked.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Boolean? Locked
		{
			get { return _entity.Locked; }
		}
        /// <summary>
        /// Gets the Abbreviation
        /// </summary>
        /// <value>The Abbreviation.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String Abbreviation
		{
			get { return _entity.Abbreviation; }
		}
        /// <summary>
        /// Gets the PrintAbbreviation
        /// </summary>
        /// <value>The PrintAbbreviation.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String PrintAbbreviation
		{
			get { return _entity.PrintAbbreviation; }
		}
        /// <summary>
        /// Gets the StudyTypeEngName
        /// </summary>
        /// <value>The StudyTypeEngName.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String StudyTypeEngName
		{
			get { return _entity.StudyTypeEngName; }
		}

	}
}
