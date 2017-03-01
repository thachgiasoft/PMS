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
    /// A designer class for a strongly typed repeater <c>BangPhuTroiGioDayGiangVienRepeater</c>
    /// </summary>
	public class BangPhuTroiGioDayGiangVienRepeaterDesigner : System.Web.UI.Design.ControlDesigner
	{
	    /// <summary>
        /// Initializes a new instance of the <see cref="T:BangPhuTroiGioDayGiangVienRepeaterDesigner"/> class.
        /// </summary>
		public BangPhuTroiGioDayGiangVienRepeaterDesigner()
		{
		}

        /// <summary>
        /// Initializes the control designer and loads the specified component.
        /// </summary>
        /// <param name="component">The control being designed.</param>
		public override void Initialize(IComponent component)
		{
			if (!(component is BangPhuTroiGioDayGiangVienRepeater))
			{ 
				throw new ArgumentException("Component is not a BangPhuTroiGioDayGiangVienRepeater."); 
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
			BangPhuTroiGioDayGiangVienRepeater z = (BangPhuTroiGioDayGiangVienRepeater)Component;
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
    /// A strongly typed repeater control for the <see cref="BangPhuTroiGioDayGiangVienRepeater"/> Type.
    /// </summary>
	[Designer(typeof(BangPhuTroiGioDayGiangVienRepeaterDesigner))]
	[ParseChildren(true)]
	[ToolboxData("<{0}:BangPhuTroiGioDayGiangVienRepeater runat=\"server\"></{0}:BangPhuTroiGioDayGiangVienRepeater>")]
	public class BangPhuTroiGioDayGiangVienRepeater : CompositeDataBoundControl, System.Web.UI.INamingContainer
	{
	    /// <summary>
        /// Initializes a new instance of the <see cref="T:BangPhuTroiGioDayGiangVienRepeater"/> class.
        /// </summary>
		public BangPhuTroiGioDayGiangVienRepeater()
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
		[TemplateContainer(typeof(BangPhuTroiGioDayGiangVienItem))]
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
		[TemplateContainer(typeof(BangPhuTroiGioDayGiangVienItem))]
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
        [TemplateContainer(typeof(BangPhuTroiGioDayGiangVienItem))]
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
		[TemplateContainer(typeof(BangPhuTroiGioDayGiangVienItem))]
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
		[TemplateContainer(typeof(BangPhuTroiGioDayGiangVienItem))]
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
						PMS.Entities.BangPhuTroiGioDayGiangVien entity = o as PMS.Entities.BangPhuTroiGioDayGiangVien;
						BangPhuTroiGioDayGiangVienItem container = new BangPhuTroiGioDayGiangVienItem(entity);
	
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
	public class BangPhuTroiGioDayGiangVienItem : System.Web.UI.Control, System.Web.UI.INamingContainer
	{
		private PMS.Entities.BangPhuTroiGioDayGiangVien _entity;

        /// <summary>
        /// Initializes a new instance of the <see cref="T:BangPhuTroiGioDayGiangVienItem"/> class.
        /// </summary>
		public BangPhuTroiGioDayGiangVienItem()
			: base()
		{ }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:BangPhuTroiGioDayGiangVienItem"/> class.
        /// </summary>
		public BangPhuTroiGioDayGiangVienItem(PMS.Entities.BangPhuTroiGioDayGiangVien entity)
			: base()
		{
			_entity = entity;
		}
		
        /// <summary>
        /// Gets the MaGiangVien
        /// </summary>
        /// <value>The MaGiangVien.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Int32 MaGiangVien
		{
			get { return _entity.MaGiangVien; }
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
        /// Gets the Ho
        /// </summary>
        /// <value>The Ho.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String Ho
		{
			get { return _entity.Ho; }
		}
        /// <summary>
        /// Gets the Ten
        /// </summary>
        /// <value>The Ten.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String Ten
		{
			get { return _entity.Ten; }
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
        /// Gets the MaDonVi
        /// </summary>
        /// <value>The MaDonVi.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String MaDonVi
		{
			get { return _entity.MaDonVi; }
		}
        /// <summary>
        /// Gets the TenDonVi
        /// </summary>
        /// <value>The TenDonVi.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String TenDonVi
		{
			get { return _entity.TenDonVi; }
		}
        /// <summary>
        /// Gets the MaLoaiGiangVien
        /// </summary>
        /// <value>The MaLoaiGiangVien.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Int32 MaLoaiGiangVien
		{
			get { return _entity.MaLoaiGiangVien; }
		}
        /// <summary>
        /// Gets the TenLoaiGiangVien
        /// </summary>
        /// <value>The TenLoaiGiangVien.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String TenLoaiGiangVien
		{
			get { return _entity.TenLoaiGiangVien; }
		}
        /// <summary>
        /// Gets the TcThucDay
        /// </summary>
        /// <value>The TcThucDay.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Decimal? TcThucDay
		{
			get { return _entity.TcThucDay; }
		}
        /// <summary>
        /// Gets the TietQd
        /// </summary>
        /// <value>The TietQd.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Decimal? TietQd
		{
			get { return _entity.TietQd; }
		}
        /// <summary>
        /// Gets the NhiemVuGd
        /// </summary>
        /// <value>The NhiemVuGd.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Int32? NhiemVuGd
		{
			get { return _entity.NhiemVuGd; }
		}
        /// <summary>
        /// Gets the NhiemVuNckh
        /// </summary>
        /// <value>The NhiemVuNckh.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Int32? NhiemVuNckh
		{
			get { return _entity.NhiemVuNckh; }
		}
        /// <summary>
        /// Gets the PhanCongCn
        /// </summary>
        /// <value>The PhanCongCn.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Int32? PhanCongCn
		{
			get { return _entity.PhanCongCn; }
		}
        /// <summary>
        /// Gets the CongTrinhCd
        /// </summary>
        /// <value>The CongTrinhCd.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Int32? CongTrinhCd
		{
			get { return _entity.CongTrinhCd; }
		}
        /// <summary>
        /// Gets the CongTrinhTc
        /// </summary>
        /// <value>The CongTrinhTc.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Int32? CongTrinhTc
		{
			get { return _entity.CongTrinhTc; }
		}

        /// <summary>
        /// Gets a <see cref="T:PMS.Entities.BangPhuTroiGioDayGiangVien"></see> object
        /// </summary>
        /// <value></value>
        [System.ComponentModel.Bindable(true)]
        public PMS.Entities.BangPhuTroiGioDayGiangVien Entity
        {
            get { return _entity; }
        }
	}
}
