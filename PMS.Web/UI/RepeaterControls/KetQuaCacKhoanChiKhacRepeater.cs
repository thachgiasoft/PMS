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
    /// A designer class for a strongly typed repeater <c>KetQuaCacKhoanChiKhacRepeater</c>
    /// </summary>
	public class KetQuaCacKhoanChiKhacRepeaterDesigner : System.Web.UI.Design.ControlDesigner
	{
	    /// <summary>
        /// Initializes a new instance of the <see cref="T:KetQuaCacKhoanChiKhacRepeaterDesigner"/> class.
        /// </summary>
		public KetQuaCacKhoanChiKhacRepeaterDesigner()
		{
		}

        /// <summary>
        /// Initializes the control designer and loads the specified component.
        /// </summary>
        /// <param name="component">The control being designed.</param>
		public override void Initialize(IComponent component)
		{
			if (!(component is KetQuaCacKhoanChiKhacRepeater))
			{ 
				throw new ArgumentException("Component is not a KetQuaCacKhoanChiKhacRepeater."); 
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
			KetQuaCacKhoanChiKhacRepeater z = (KetQuaCacKhoanChiKhacRepeater)Component;
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
    /// A strongly typed repeater control for the <see cref="KetQuaCacKhoanChiKhacRepeater"/> Type.
    /// </summary>
	[Designer(typeof(KetQuaCacKhoanChiKhacRepeaterDesigner))]
	[ParseChildren(true)]
	[ToolboxData("<{0}:KetQuaCacKhoanChiKhacRepeater runat=\"server\"></{0}:KetQuaCacKhoanChiKhacRepeater>")]
	public class KetQuaCacKhoanChiKhacRepeater : CompositeDataBoundControl, System.Web.UI.INamingContainer
	{
	    /// <summary>
        /// Initializes a new instance of the <see cref="T:KetQuaCacKhoanChiKhacRepeater"/> class.
        /// </summary>
		public KetQuaCacKhoanChiKhacRepeater()
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
		[TemplateContainer(typeof(KetQuaCacKhoanChiKhacItem))]
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
		[TemplateContainer(typeof(KetQuaCacKhoanChiKhacItem))]
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
        [TemplateContainer(typeof(KetQuaCacKhoanChiKhacItem))]
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
		[TemplateContainer(typeof(KetQuaCacKhoanChiKhacItem))]
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
		[TemplateContainer(typeof(KetQuaCacKhoanChiKhacItem))]
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
						PMS.Entities.KetQuaCacKhoanChiKhac entity = o as PMS.Entities.KetQuaCacKhoanChiKhac;
						KetQuaCacKhoanChiKhacItem container = new KetQuaCacKhoanChiKhacItem(entity);
	
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
	public class KetQuaCacKhoanChiKhacItem : System.Web.UI.Control, System.Web.UI.INamingContainer
	{
		private PMS.Entities.KetQuaCacKhoanChiKhac _entity;

        /// <summary>
        /// Initializes a new instance of the <see cref="T:KetQuaCacKhoanChiKhacItem"/> class.
        /// </summary>
		public KetQuaCacKhoanChiKhacItem()
			: base()
		{ }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:KetQuaCacKhoanChiKhacItem"/> class.
        /// </summary>
		public KetQuaCacKhoanChiKhacItem(PMS.Entities.KetQuaCacKhoanChiKhac entity)
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
        /// Gets the MaGiangVienQuanLy
        /// </summary>
        /// <value>The MaGiangVienQuanLy.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String MaGiangVienQuanLy
		{
			get { return _entity.MaGiangVienQuanLy; }
		}
        /// <summary>
        /// Gets the Lop
        /// </summary>
        /// <value>The Lop.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String Lop
		{
			get { return _entity.Lop; }
		}
        /// <summary>
        /// Gets the MaSo
        /// </summary>
        /// <value>The MaSo.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String MaSo
		{
			get { return _entity.MaSo; }
		}
        /// <summary>
        /// Gets the Ngay
        /// </summary>
        /// <value>The Ngay.</value>
		[System.ComponentModel.Bindable(true)]
		public System.DateTime? Ngay
		{
			get { return _entity.Ngay; }
		}
        /// <summary>
        /// Gets the NoiDung
        /// </summary>
        /// <value>The NoiDung.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String NoiDung
		{
			get { return _entity.NoiDung; }
		}
        /// <summary>
        /// Gets the HeSo
        /// </summary>
        /// <value>The HeSo.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Decimal? HeSo
		{
			get { return _entity.HeSo; }
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
        /// Gets the TienMotTiet
        /// </summary>
        /// <value>The TienMotTiet.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Decimal? TienMotTiet
		{
			get { return _entity.TienMotTiet; }
		}
        /// <summary>
        /// Gets the ThanhTien
        /// </summary>
        /// <value>The ThanhTien.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Decimal? ThanhTien
		{
			get { return _entity.ThanhTien; }
		}
        /// <summary>
        /// Gets the PhiCongTac
        /// </summary>
        /// <value>The PhiCongTac.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Decimal? PhiCongTac
		{
			get { return _entity.PhiCongTac; }
		}
        /// <summary>
        /// Gets the TienGiangNgoaiGio
        /// </summary>
        /// <value>The TienGiangNgoaiGio.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Decimal? TienGiangNgoaiGio
		{
			get { return _entity.TienGiangNgoaiGio; }
		}
        /// <summary>
        /// Gets the TongThanhTien
        /// </summary>
        /// <value>The TongThanhTien.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Decimal? TongThanhTien
		{
			get { return _entity.TongThanhTien; }
		}

        /// <summary>
        /// Gets a <see cref="T:PMS.Entities.KetQuaCacKhoanChiKhac"></see> object
        /// </summary>
        /// <value></value>
        [System.ComponentModel.Bindable(true)]
        public PMS.Entities.KetQuaCacKhoanChiKhac Entity
        {
            get { return _entity; }
        }
	}
}
