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
    /// A designer class for a strongly typed repeater <c>ChiTienThuLaoGiangDayRepeater</c>
    /// </summary>
	public class ChiTienThuLaoGiangDayRepeaterDesigner : System.Web.UI.Design.ControlDesigner
	{
	    /// <summary>
        /// Initializes a new instance of the <see cref="T:ChiTienThuLaoGiangDayRepeaterDesigner"/> class.
        /// </summary>
		public ChiTienThuLaoGiangDayRepeaterDesigner()
		{
		}

        /// <summary>
        /// Initializes the control designer and loads the specified component.
        /// </summary>
        /// <param name="component">The control being designed.</param>
		public override void Initialize(IComponent component)
		{
			if (!(component is ChiTienThuLaoGiangDayRepeater))
			{ 
				throw new ArgumentException("Component is not a ChiTienThuLaoGiangDayRepeater."); 
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
			ChiTienThuLaoGiangDayRepeater z = (ChiTienThuLaoGiangDayRepeater)Component;
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
    /// A strongly typed repeater control for the <see cref="ChiTienThuLaoGiangDayRepeater"/> Type.
    /// </summary>
	[Designer(typeof(ChiTienThuLaoGiangDayRepeaterDesigner))]
	[ParseChildren(true)]
	[ToolboxData("<{0}:ChiTienThuLaoGiangDayRepeater runat=\"server\"></{0}:ChiTienThuLaoGiangDayRepeater>")]
	public class ChiTienThuLaoGiangDayRepeater : CompositeDataBoundControl, System.Web.UI.INamingContainer
	{
	    /// <summary>
        /// Initializes a new instance of the <see cref="T:ChiTienThuLaoGiangDayRepeater"/> class.
        /// </summary>
		public ChiTienThuLaoGiangDayRepeater()
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
		[TemplateContainer(typeof(ChiTienThuLaoGiangDayItem))]
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
		[TemplateContainer(typeof(ChiTienThuLaoGiangDayItem))]
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
        [TemplateContainer(typeof(ChiTienThuLaoGiangDayItem))]
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
		[TemplateContainer(typeof(ChiTienThuLaoGiangDayItem))]
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
		[TemplateContainer(typeof(ChiTienThuLaoGiangDayItem))]
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
						PMS.Entities.ChiTienThuLaoGiangDay entity = o as PMS.Entities.ChiTienThuLaoGiangDay;
						ChiTienThuLaoGiangDayItem container = new ChiTienThuLaoGiangDayItem(entity);
	
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
	public class ChiTienThuLaoGiangDayItem : System.Web.UI.Control, System.Web.UI.INamingContainer
	{
		private PMS.Entities.ChiTienThuLaoGiangDay _entity;

        /// <summary>
        /// Initializes a new instance of the <see cref="T:ChiTienThuLaoGiangDayItem"/> class.
        /// </summary>
		public ChiTienThuLaoGiangDayItem()
			: base()
		{ }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:ChiTienThuLaoGiangDayItem"/> class.
        /// </summary>
		public ChiTienThuLaoGiangDayItem(PMS.Entities.ChiTienThuLaoGiangDay entity)
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
        /// Gets the MaCanBoGiangDay
        /// </summary>
        /// <value>The MaCanBoGiangDay.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String MaCanBoGiangDay
		{
			get { return _entity.MaCanBoGiangDay; }
		}
        /// <summary>
        /// Gets the Oid
        /// </summary>
        /// <value>The Oid.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Guid? Oid
		{
			get { return _entity.Oid; }
		}
        /// <summary>
        /// Gets the LaGiangVienThinhGiang
        /// </summary>
        /// <value>The LaGiangVienThinhGiang.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Boolean? LaGiangVienThinhGiang
		{
			get { return _entity.LaGiangVienThinhGiang; }
		}
        /// <summary>
        /// Gets the TongTien
        /// </summary>
        /// <value>The TongTien.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Decimal? TongTien
		{
			get { return _entity.TongTien; }
		}
        /// <summary>
        /// Gets the SoChungTuHrm
        /// </summary>
        /// <value>The SoChungTuHrm.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String SoChungTuHrm
		{
			get { return _entity.SoChungTuHrm; }
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
        /// Gets the NgayLayDuLieu
        /// </summary>
        /// <value>The NgayLayDuLieu.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String NgayLayDuLieu
		{
			get { return _entity.NgayLayDuLieu; }
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
        /// Gets the TongSoTietQuyDoi
        /// </summary>
        /// <value>The TongSoTietQuyDoi.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Decimal? TongSoTietQuyDoi
		{
			get { return _entity.TongSoTietQuyDoi; }
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
        /// Gets the MaLopSinhVien
        /// </summary>
        /// <value>The MaLopSinhVien.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String MaLopSinhVien
		{
			get { return _entity.MaLopSinhVien; }
		}
        /// <summary>
        /// Gets the LopClc
        /// </summary>
        /// <value>The LopClc.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Boolean? LopClc
		{
			get { return _entity.LopClc; }
		}

        /// <summary>
        /// Gets a <see cref="T:PMS.Entities.ChiTienThuLaoGiangDay"></see> object
        /// </summary>
        /// <value></value>
        [System.ComponentModel.Bindable(true)]
        public PMS.Entities.ChiTienThuLaoGiangDay Entity
        {
            get { return _entity; }
        }
	}
}
