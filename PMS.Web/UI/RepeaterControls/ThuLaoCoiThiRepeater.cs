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
    /// A designer class for a strongly typed repeater <c>ThuLaoCoiThiRepeater</c>
    /// </summary>
	public class ThuLaoCoiThiRepeaterDesigner : System.Web.UI.Design.ControlDesigner
	{
	    /// <summary>
        /// Initializes a new instance of the <see cref="T:ThuLaoCoiThiRepeaterDesigner"/> class.
        /// </summary>
		public ThuLaoCoiThiRepeaterDesigner()
		{
		}

        /// <summary>
        /// Initializes the control designer and loads the specified component.
        /// </summary>
        /// <param name="component">The control being designed.</param>
		public override void Initialize(IComponent component)
		{
			if (!(component is ThuLaoCoiThiRepeater))
			{ 
				throw new ArgumentException("Component is not a ThuLaoCoiThiRepeater."); 
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
			ThuLaoCoiThiRepeater z = (ThuLaoCoiThiRepeater)Component;
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
    /// A strongly typed repeater control for the <see cref="ThuLaoCoiThiRepeater"/> Type.
    /// </summary>
	[Designer(typeof(ThuLaoCoiThiRepeaterDesigner))]
	[ParseChildren(true)]
	[ToolboxData("<{0}:ThuLaoCoiThiRepeater runat=\"server\"></{0}:ThuLaoCoiThiRepeater>")]
	public class ThuLaoCoiThiRepeater : CompositeDataBoundControl, System.Web.UI.INamingContainer
	{
	    /// <summary>
        /// Initializes a new instance of the <see cref="T:ThuLaoCoiThiRepeater"/> class.
        /// </summary>
		public ThuLaoCoiThiRepeater()
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
		[TemplateContainer(typeof(ThuLaoCoiThiItem))]
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
		[TemplateContainer(typeof(ThuLaoCoiThiItem))]
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
        [TemplateContainer(typeof(ThuLaoCoiThiItem))]
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
		[TemplateContainer(typeof(ThuLaoCoiThiItem))]
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
		[TemplateContainer(typeof(ThuLaoCoiThiItem))]
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
						PMS.Entities.ThuLaoCoiThi entity = o as PMS.Entities.ThuLaoCoiThi;
						ThuLaoCoiThiItem container = new ThuLaoCoiThiItem(entity);
	
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
	public class ThuLaoCoiThiItem : System.Web.UI.Control, System.Web.UI.INamingContainer
	{
		private PMS.Entities.ThuLaoCoiThi _entity;

        /// <summary>
        /// Initializes a new instance of the <see cref="T:ThuLaoCoiThiItem"/> class.
        /// </summary>
		public ThuLaoCoiThiItem()
			: base()
		{ }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:ThuLaoCoiThiItem"/> class.
        /// </summary>
		public ThuLaoCoiThiItem(PMS.Entities.ThuLaoCoiThi entity)
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
		public System.String LanThi
		{
			get { return _entity.LanThi; }
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
        /// Gets the Ca
        /// </summary>
        /// <value>The Ca.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String Ca
		{
			get { return _entity.Ca; }
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
        /// Gets the SoTien
        /// </summary>
        /// <value>The SoTien.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Decimal? SoTien
		{
			get { return _entity.SoTien; }
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
        /// Gets the NoiDung
        /// </summary>
        /// <value>The NoiDung.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String NoiDung
		{
			get { return _entity.NoiDung; }
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
        /// Gets the MaHocPhan
        /// </summary>
        /// <value>The MaHocPhan.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String MaHocPhan
		{
			get { return _entity.MaHocPhan; }
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
        /// Gets the NgayCapNhat
        /// </summary>
        /// <value>The NgayCapNhat.</value>
		[System.ComponentModel.Bindable(true)]
		public System.DateTime? NgayCapNhat
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
        /// Gets the DotChiTra
        /// </summary>
        /// <value>The DotChiTra.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String DotChiTra
		{
			get { return _entity.DotChiTra; }
		}
        /// <summary>
        /// Gets the MaCoSo
        /// </summary>
        /// <value>The MaCoSo.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String MaCoSo
		{
			get { return _entity.MaCoSo; }
		}
        /// <summary>
        /// Gets the TietbatDau
        /// </summary>
        /// <value>The TietbatDau.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Int32? TietbatDau
		{
			get { return _entity.TietbatDau; }
		}
        /// <summary>
        /// Gets the ThoiGianLamBai
        /// </summary>
        /// <value>The ThoiGianLamBai.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Int32? ThoiGianLamBai
		{
			get { return _entity.ThoiGianLamBai; }
		}
        /// <summary>
        /// Gets the GioCoiThi
        /// </summary>
        /// <value>The GioCoiThi.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String GioCoiThi
		{
			get { return _entity.GioCoiThi; }
		}
        /// <summary>
        /// Gets the SoLuongSinhVien
        /// </summary>
        /// <value>The SoLuongSinhVien.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Int32? SoLuongSinhVien
		{
			get { return _entity.SoLuongSinhVien; }
		}
        /// <summary>
        /// Gets the IsSync
        /// </summary>
        /// <value>The IsSync.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Boolean? IsSync
		{
			get { return _entity.IsSync; }
		}
        /// <summary>
        /// Gets the Chot
        /// </summary>
        /// <value>The Chot.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Boolean? Chot
		{
			get { return _entity.Chot; }
		}

        /// <summary>
        /// Gets a <see cref="T:PMS.Entities.ThuLaoCoiThi"></see> object
        /// </summary>
        /// <value></value>
        [System.ComponentModel.Bindable(true)]
        public PMS.Entities.ThuLaoCoiThi Entity
        {
            get { return _entity; }
        }
	}
}
