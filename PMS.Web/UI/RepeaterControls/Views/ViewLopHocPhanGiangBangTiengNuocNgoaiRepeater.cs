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
    /// A designer class for a strongly typed repeater <c>ViewLopHocPhanGiangBangTiengNuocNgoaiRepeater</c>
    /// </summary>
	public class ViewLopHocPhanGiangBangTiengNuocNgoaiRepeaterDesigner : System.Web.UI.Design.ControlDesigner
	{
	    /// <summary>
        /// Initializes a new instance of the <see cref="T:ViewLopHocPhanGiangBangTiengNuocNgoaiRepeaterDesigner"/> class.
        /// </summary>
		public ViewLopHocPhanGiangBangTiengNuocNgoaiRepeaterDesigner()
		{
		}

        /// <summary>
        /// Initializes the control designer and loads the specified component.
        /// </summary>
        /// <param name="component">The control being designed.</param>
		public override void Initialize(IComponent component)
		{
			if (!(component is ViewLopHocPhanGiangBangTiengNuocNgoaiRepeater))
			{ 
				throw new ArgumentException("Component is not a ViewLopHocPhanGiangBangTiengNuocNgoaiRepeater."); 
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
			ViewLopHocPhanGiangBangTiengNuocNgoaiRepeater z = (ViewLopHocPhanGiangBangTiengNuocNgoaiRepeater)Component;
			z.DataBind();

			return base.GetDesignTimeHtml();
		}
	}

    /// <summary>
    /// A strongly typed repeater control for the <see cref="ViewLopHocPhanGiangBangTiengNuocNgoaiRepeater"/> Type.
    /// </summary>
	[Designer(typeof(ViewLopHocPhanGiangBangTiengNuocNgoaiRepeaterDesigner))]
	[ParseChildren(true)]
	[ToolboxData("<{0}:ViewLopHocPhanGiangBangTiengNuocNgoaiRepeater runat=\"server\"></{0}:ViewLopHocPhanGiangBangTiengNuocNgoaiRepeater>")]
	public class ViewLopHocPhanGiangBangTiengNuocNgoaiRepeater : CompositeDataBoundControl, System.Web.UI.INamingContainer
	{
	    /// <summary>
        /// Initializes a new instance of the <see cref="T:ViewLopHocPhanGiangBangTiengNuocNgoaiRepeater"/> class.
        /// </summary>
		public ViewLopHocPhanGiangBangTiengNuocNgoaiRepeater()
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
		[TemplateContainer(typeof(ViewLopHocPhanGiangBangTiengNuocNgoaiItem))]
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
		[TemplateContainer(typeof(ViewLopHocPhanGiangBangTiengNuocNgoaiItem))]
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
        [TemplateContainer(typeof(ViewLopHocPhanGiangBangTiengNuocNgoaiItem))]
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
		[TemplateContainer(typeof(ViewLopHocPhanGiangBangTiengNuocNgoaiItem))]
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
		[TemplateContainer(typeof(ViewLopHocPhanGiangBangTiengNuocNgoaiItem))]
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
						PMS.Entities.ViewLopHocPhanGiangBangTiengNuocNgoai entity = o as PMS.Entities.ViewLopHocPhanGiangBangTiengNuocNgoai;
						ViewLopHocPhanGiangBangTiengNuocNgoaiItem container = new ViewLopHocPhanGiangBangTiengNuocNgoaiItem(entity);
	
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
	public class ViewLopHocPhanGiangBangTiengNuocNgoaiItem : System.Web.UI.Control, System.Web.UI.INamingContainer
	{
		private PMS.Entities.ViewLopHocPhanGiangBangTiengNuocNgoai _entity;

        /// <summary>
        /// Initializes a new instance of the <see cref="T:ViewLopHocPhanGiangBangTiengNuocNgoaiItem"/> class.
        /// </summary>
		public ViewLopHocPhanGiangBangTiengNuocNgoaiItem()
			: base()
		{ }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:ViewLopHocPhanGiangBangTiengNuocNgoaiItem"/> class.
        /// </summary>
		public ViewLopHocPhanGiangBangTiengNuocNgoaiItem(PMS.Entities.ViewLopHocPhanGiangBangTiengNuocNgoai entity)
			: base()
		{
			_entity = entity;
		}
		
        /// <summary>
        /// Gets the ScheduleStudyUnitId
        /// </summary>
        /// <value>The ScheduleStudyUnitId.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String ScheduleStudyUnitId
		{
			get { return _entity.ScheduleStudyUnitId; }
		}
        /// <summary>
        /// Gets the StudyUnitId
        /// </summary>
        /// <value>The StudyUnitId.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String StudyUnitId
		{
			get { return _entity.StudyUnitId; }
		}
        /// <summary>
        /// Gets the CurriculumId
        /// </summary>
        /// <value>The CurriculumId.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String CurriculumId
		{
			get { return _entity.CurriculumId; }
		}
        /// <summary>
        /// Gets the CurriculumName
        /// </summary>
        /// <value>The CurriculumName.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String CurriculumName
		{
			get { return _entity.CurriculumName; }
		}
        /// <summary>
        /// Gets the ListOfClassStudentId
        /// </summary>
        /// <value>The ListOfClassStudentId.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String ListOfClassStudentId
		{
			get { return _entity.ListOfClassStudentId; }
		}
        /// <summary>
        /// Gets the ListOfProfessorId
        /// </summary>
        /// <value>The ListOfProfessorId.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String ListOfProfessorId
		{
			get { return _entity.ListOfProfessorId; }
		}
        /// <summary>
        /// Gets the ListOfProfessorFirstName
        /// </summary>
        /// <value>The ListOfProfessorFirstName.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String ListOfProfessorFirstName
		{
			get { return _entity.ListOfProfessorFirstName; }
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
        /// Gets the TermId
        /// </summary>
        /// <value>The TermId.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String TermId
		{
			get { return _entity.TermId; }
		}
        /// <summary>
        /// Gets the Chon
        /// </summary>
        /// <value>The Chon.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Boolean? Chon
		{
			get { return _entity.Chon; }
		}

	}
}
