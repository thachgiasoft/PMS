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
    /// A designer class for a strongly typed repeater <c>ThuLaoRaDeThiVhuexRepeater</c>
    /// </summary>
	public class ThuLaoRaDeThiVhuexRepeaterDesigner : System.Web.UI.Design.ControlDesigner
	{
	    /// <summary>
        /// Initializes a new instance of the <see cref="T:ThuLaoRaDeThiVhuexRepeaterDesigner"/> class.
        /// </summary>
		public ThuLaoRaDeThiVhuexRepeaterDesigner()
		{
		}

        /// <summary>
        /// Initializes the control designer and loads the specified component.
        /// </summary>
        /// <param name="component">The control being designed.</param>
		public override void Initialize(IComponent component)
		{
			if (!(component is ThuLaoRaDeThiVhuexRepeater))
			{ 
				throw new ArgumentException("Component is not a ThuLaoRaDeThiVhuexRepeater."); 
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
			ThuLaoRaDeThiVhuexRepeater z = (ThuLaoRaDeThiVhuexRepeater)Component;
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
    /// A strongly typed repeater control for the <see cref="ThuLaoRaDeThiVhuexRepeater"/> Type.
    /// </summary>
	[Designer(typeof(ThuLaoRaDeThiVhuexRepeaterDesigner))]
	[ParseChildren(true)]
	[ToolboxData("<{0}:ThuLaoRaDeThiVhuexRepeater runat=\"server\"></{0}:ThuLaoRaDeThiVhuexRepeater>")]
	public class ThuLaoRaDeThiVhuexRepeater : CompositeDataBoundControl, System.Web.UI.INamingContainer
	{
	    /// <summary>
        /// Initializes a new instance of the <see cref="T:ThuLaoRaDeThiVhuexRepeater"/> class.
        /// </summary>
		public ThuLaoRaDeThiVhuexRepeater()
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
		[TemplateContainer(typeof(ThuLaoRaDeThiVhuexItem))]
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
		[TemplateContainer(typeof(ThuLaoRaDeThiVhuexItem))]
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
        [TemplateContainer(typeof(ThuLaoRaDeThiVhuexItem))]
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
		[TemplateContainer(typeof(ThuLaoRaDeThiVhuexItem))]
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
		[TemplateContainer(typeof(ThuLaoRaDeThiVhuexItem))]
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
						PMS.Entities.ThuLaoRaDeThiVhuex entity = o as PMS.Entities.ThuLaoRaDeThiVhuex;
						ThuLaoRaDeThiVhuexItem container = new ThuLaoRaDeThiVhuexItem(entity);
	
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
	public class ThuLaoRaDeThiVhuexItem : System.Web.UI.Control, System.Web.UI.INamingContainer
	{
		private PMS.Entities.ThuLaoRaDeThiVhuex _entity;

        /// <summary>
        /// Initializes a new instance of the <see cref="T:ThuLaoRaDeThiVhuexItem"/> class.
        /// </summary>
		public ThuLaoRaDeThiVhuexItem()
			: base()
		{ }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:ThuLaoRaDeThiVhuexItem"/> class.
        /// </summary>
		public ThuLaoRaDeThiVhuexItem(PMS.Entities.ThuLaoRaDeThiVhuex entity)
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
        /// Gets the KyThi
        /// </summary>
        /// <value>The KyThi.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String KyThi
		{
			get { return _entity.KyThi; }
		}
        /// <summary>
        /// Gets the LanThi
        /// </summary>
        /// <value>The LanThi.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Int32? LanThi
		{
			get { return _entity.LanThi; }
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
        /// Gets the MaGv
        /// </summary>
        /// <value>The MaGv.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String MaGv
		{
			get { return _entity.MaGv; }
		}
        /// <summary>
        /// Gets the DotThi
        /// </summary>
        /// <value>The DotThi.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String DotThi
		{
			get { return _entity.DotThi; }
		}
        /// <summary>
        /// Gets the TracNghiemDuoi50
        /// </summary>
        /// <value>The TracNghiemDuoi50.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Decimal? TracNghiemDuoi50
		{
			get { return _entity.TracNghiemDuoi50; }
		}
        /// <summary>
        /// Gets the TracNghiemTren50
        /// </summary>
        /// <value>The TracNghiemTren50.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Decimal? TracNghiemTren50
		{
			get { return _entity.TracNghiemTren50; }
		}
        /// <summary>
        /// Gets the TuLuan
        /// </summary>
        /// <value>The TuLuan.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Decimal? TuLuan
		{
			get { return _entity.TuLuan; }
		}
        /// <summary>
        /// Gets the TongHop
        /// </summary>
        /// <value>The TongHop.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Decimal? TongHop
		{
			get { return _entity.TongHop; }
		}
        /// <summary>
        /// Gets the VanDap
        /// </summary>
        /// <value>The VanDap.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Decimal? VanDap
		{
			get { return _entity.VanDap; }
		}
        /// <summary>
        /// Gets the ThucHanh
        /// </summary>
        /// <value>The ThucHanh.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Decimal? ThucHanh
		{
			get { return _entity.ThucHanh; }
		}
        /// <summary>
        /// Gets the TieuLuan
        /// </summary>
        /// <value>The TieuLuan.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Decimal? TieuLuan
		{
			get { return _entity.TieuLuan; }
		}
        /// <summary>
        /// Gets the GioChuan
        /// </summary>
        /// <value>The GioChuan.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Decimal? GioChuan
		{
			get { return _entity.GioChuan; }
		}
        /// <summary>
        /// Gets the UpdateDate
        /// </summary>
        /// <value>The UpdateDate.</value>
		[System.ComponentModel.Bindable(true)]
		public System.DateTime? UpdateDate
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
        /// Gets a <see cref="T:PMS.Entities.ThuLaoRaDeThiVhuex"></see> object
        /// </summary>
        /// <value></value>
        [System.ComponentModel.Bindable(true)]
        public PMS.Entities.ThuLaoRaDeThiVhuex Entity
        {
            get { return _entity; }
        }
	}
}
