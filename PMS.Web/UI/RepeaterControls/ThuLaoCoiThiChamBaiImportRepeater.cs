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
    /// A designer class for a strongly typed repeater <c>ThuLaoCoiThiChamBaiImportRepeater</c>
    /// </summary>
	public class ThuLaoCoiThiChamBaiImportRepeaterDesigner : System.Web.UI.Design.ControlDesigner
	{
	    /// <summary>
        /// Initializes a new instance of the <see cref="T:ThuLaoCoiThiChamBaiImportRepeaterDesigner"/> class.
        /// </summary>
		public ThuLaoCoiThiChamBaiImportRepeaterDesigner()
		{
		}

        /// <summary>
        /// Initializes the control designer and loads the specified component.
        /// </summary>
        /// <param name="component">The control being designed.</param>
		public override void Initialize(IComponent component)
		{
			if (!(component is ThuLaoCoiThiChamBaiImportRepeater))
			{ 
				throw new ArgumentException("Component is not a ThuLaoCoiThiChamBaiImportRepeater."); 
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
			ThuLaoCoiThiChamBaiImportRepeater z = (ThuLaoCoiThiChamBaiImportRepeater)Component;
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
    /// A strongly typed repeater control for the <see cref="ThuLaoCoiThiChamBaiImportRepeater"/> Type.
    /// </summary>
	[Designer(typeof(ThuLaoCoiThiChamBaiImportRepeaterDesigner))]
	[ParseChildren(true)]
	[ToolboxData("<{0}:ThuLaoCoiThiChamBaiImportRepeater runat=\"server\"></{0}:ThuLaoCoiThiChamBaiImportRepeater>")]
	public class ThuLaoCoiThiChamBaiImportRepeater : CompositeDataBoundControl, System.Web.UI.INamingContainer
	{
	    /// <summary>
        /// Initializes a new instance of the <see cref="T:ThuLaoCoiThiChamBaiImportRepeater"/> class.
        /// </summary>
		public ThuLaoCoiThiChamBaiImportRepeater()
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
		[TemplateContainer(typeof(ThuLaoCoiThiChamBaiImportItem))]
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
		[TemplateContainer(typeof(ThuLaoCoiThiChamBaiImportItem))]
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
        [TemplateContainer(typeof(ThuLaoCoiThiChamBaiImportItem))]
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
		[TemplateContainer(typeof(ThuLaoCoiThiChamBaiImportItem))]
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
		[TemplateContainer(typeof(ThuLaoCoiThiChamBaiImportItem))]
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
						PMS.Entities.ThuLaoCoiThiChamBaiImport entity = o as PMS.Entities.ThuLaoCoiThiChamBaiImport;
						ThuLaoCoiThiChamBaiImportItem container = new ThuLaoCoiThiChamBaiImportItem(entity);
	
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
	public class ThuLaoCoiThiChamBaiImportItem : System.Web.UI.Control, System.Web.UI.INamingContainer
	{
		private PMS.Entities.ThuLaoCoiThiChamBaiImport _entity;

        /// <summary>
        /// Initializes a new instance of the <see cref="T:ThuLaoCoiThiChamBaiImportItem"/> class.
        /// </summary>
		public ThuLaoCoiThiChamBaiImportItem()
			: base()
		{ }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:ThuLaoCoiThiChamBaiImportItem"/> class.
        /// </summary>
		public ThuLaoCoiThiChamBaiImportItem(PMS.Entities.ThuLaoCoiThiChamBaiImport entity)
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
        /// Gets the DotChiTra
        /// </summary>
        /// <value>The DotChiTra.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String DotChiTra
		{
			get { return _entity.DotChiTra; }
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
        /// Gets the HoTen
        /// </summary>
        /// <value>The HoTen.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String HoTen
		{
			get { return _entity.HoTen; }
		}
        /// <summary>
        /// Gets the NoiDungChi
        /// </summary>
        /// <value>The NoiDungChi.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String NoiDungChi
		{
			get { return _entity.NoiDungChi; }
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
        /// Gets the TenMonHoc
        /// </summary>
        /// <value>The TenMonHoc.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String TenMonHoc
		{
			get { return _entity.TenMonHoc; }
		}
        /// <summary>
        /// Gets the MaLop
        /// </summary>
        /// <value>The MaLop.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String MaLop
		{
			get { return _entity.MaLop; }
		}
        /// <summary>
        /// Gets the SoBaiQuaTrinh
        /// </summary>
        /// <value>The SoBaiQuaTrinh.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Int32? SoBaiQuaTrinh
		{
			get { return _entity.SoBaiQuaTrinh; }
		}
        /// <summary>
        /// Gets the SoBaiGiuaKy
        /// </summary>
        /// <value>The SoBaiGiuaKy.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Int32? SoBaiGiuaKy
		{
			get { return _entity.SoBaiGiuaKy; }
		}
        /// <summary>
        /// Gets the SoBaiCuoiKy
        /// </summary>
        /// <value>The SoBaiCuoiKy.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Int32? SoBaiCuoiKy
		{
			get { return _entity.SoBaiCuoiKy; }
		}
        /// <summary>
        /// Gets the DonGiaQuaTrinh
        /// </summary>
        /// <value>The DonGiaQuaTrinh.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Int32? DonGiaQuaTrinh
		{
			get { return _entity.DonGiaQuaTrinh; }
		}
        /// <summary>
        /// Gets the DonGiaGiuaKy
        /// </summary>
        /// <value>The DonGiaGiuaKy.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Int32? DonGiaGiuaKy
		{
			get { return _entity.DonGiaGiuaKy; }
		}
        /// <summary>
        /// Gets the DonGiaCuoiKy
        /// </summary>
        /// <value>The DonGiaCuoiKy.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Int32? DonGiaCuoiKy
		{
			get { return _entity.DonGiaCuoiKy; }
		}
        /// <summary>
        /// Gets the ThanhTien
        /// </summary>
        /// <value>The ThanhTien.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Int32? ThanhTien
		{
			get { return _entity.ThanhTien; }
		}
        /// <summary>
        /// Gets the SoTienCoiThi
        /// </summary>
        /// <value>The SoTienCoiThi.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Int32? SoTienCoiThi
		{
			get { return _entity.SoTienCoiThi; }
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
        /// Gets the BacDaoTao
        /// </summary>
        /// <value>The BacDaoTao.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String BacDaoTao
		{
			get { return _entity.BacDaoTao; }
		}
        /// <summary>
        /// Gets the GioCoiThi
        /// </summary>
        /// <value>The GioCoiThi.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Decimal? GioCoiThi
		{
			get { return _entity.GioCoiThi; }
		}
        /// <summary>
        /// Gets the GioChamThi
        /// </summary>
        /// <value>The GioChamThi.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Decimal? GioChamThi
		{
			get { return _entity.GioChamThi; }
		}
        /// <summary>
        /// Gets the GioRaDe
        /// </summary>
        /// <value>The GioRaDe.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Decimal? GioRaDe
		{
			get { return _entity.GioRaDe; }
		}
        /// <summary>
        /// Gets the GioToChucThi
        /// </summary>
        /// <value>The GioToChucThi.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Decimal? GioToChucThi
		{
			get { return _entity.GioToChucThi; }
		}
        /// <summary>
        /// Gets the GioNhapDiem
        /// </summary>
        /// <value>The GioNhapDiem.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Decimal? GioNhapDiem
		{
			get { return _entity.GioNhapDiem; }
		}
        /// <summary>
        /// Gets the TongCong
        /// </summary>
        /// <value>The TongCong.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Decimal? TongCong
		{
			get { return _entity.TongCong; }
		}
        /// <summary>
        /// Gets the LoaiHinHdaoTao
        /// </summary>
        /// <value>The LoaiHinHdaoTao.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String LoaiHinHdaoTao
		{
			get { return _entity.LoaiHinHdaoTao; }
		}

        /// <summary>
        /// Gets a <see cref="T:PMS.Entities.ThuLaoCoiThiChamBaiImport"></see> object
        /// </summary>
        /// <value></value>
        [System.ComponentModel.Bindable(true)]
        public PMS.Entities.ThuLaoCoiThiChamBaiImport Entity
        {
            get { return _entity; }
        }
	}
}
