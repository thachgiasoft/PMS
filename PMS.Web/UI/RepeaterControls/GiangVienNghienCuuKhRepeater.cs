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
    /// A designer class for a strongly typed repeater <c>GiangVienNghienCuuKhRepeater</c>
    /// </summary>
	public class GiangVienNghienCuuKhRepeaterDesigner : System.Web.UI.Design.ControlDesigner
	{
	    /// <summary>
        /// Initializes a new instance of the <see cref="T:GiangVienNghienCuuKhRepeaterDesigner"/> class.
        /// </summary>
		public GiangVienNghienCuuKhRepeaterDesigner()
		{
		}

        /// <summary>
        /// Initializes the control designer and loads the specified component.
        /// </summary>
        /// <param name="component">The control being designed.</param>
		public override void Initialize(IComponent component)
		{
			if (!(component is GiangVienNghienCuuKhRepeater))
			{ 
				throw new ArgumentException("Component is not a GiangVienNghienCuuKhRepeater."); 
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
			GiangVienNghienCuuKhRepeater z = (GiangVienNghienCuuKhRepeater)Component;
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
    /// A strongly typed repeater control for the <see cref="GiangVienNghienCuuKhRepeater"/> Type.
    /// </summary>
	[Designer(typeof(GiangVienNghienCuuKhRepeaterDesigner))]
	[ParseChildren(true)]
	[ToolboxData("<{0}:GiangVienNghienCuuKhRepeater runat=\"server\"></{0}:GiangVienNghienCuuKhRepeater>")]
	public class GiangVienNghienCuuKhRepeater : CompositeDataBoundControl, System.Web.UI.INamingContainer
	{
	    /// <summary>
        /// Initializes a new instance of the <see cref="T:GiangVienNghienCuuKhRepeater"/> class.
        /// </summary>
		public GiangVienNghienCuuKhRepeater()
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
		[TemplateContainer(typeof(GiangVienNghienCuuKhItem))]
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
		[TemplateContainer(typeof(GiangVienNghienCuuKhItem))]
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
        [TemplateContainer(typeof(GiangVienNghienCuuKhItem))]
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
		[TemplateContainer(typeof(GiangVienNghienCuuKhItem))]
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
		[TemplateContainer(typeof(GiangVienNghienCuuKhItem))]
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
						PMS.Entities.GiangVienNghienCuuKh entity = o as PMS.Entities.GiangVienNghienCuuKh;
						GiangVienNghienCuuKhItem container = new GiangVienNghienCuuKhItem(entity);
	
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
	public class GiangVienNghienCuuKhItem : System.Web.UI.Control, System.Web.UI.INamingContainer
	{
		private PMS.Entities.GiangVienNghienCuuKh _entity;

        /// <summary>
        /// Initializes a new instance of the <see cref="T:GiangVienNghienCuuKhItem"/> class.
        /// </summary>
		public GiangVienNghienCuuKhItem()
			: base()
		{ }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:GiangVienNghienCuuKhItem"/> class.
        /// </summary>
		public GiangVienNghienCuuKhItem(PMS.Entities.GiangVienNghienCuuKh entity)
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
        /// Gets the MaNckh
        /// </summary>
        /// <value>The MaNckh.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Int32? MaNckh
		{
			get { return _entity.MaNckh; }
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
        /// Gets the NgayHieuLuc
        /// </summary>
        /// <value>The NgayHieuLuc.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String NgayHieuLuc
		{
			get { return _entity.NgayHieuLuc; }
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
        /// Gets the NgayHetHieuLuc
        /// </summary>
        /// <value>The NgayHetHieuLuc.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String NgayHetHieuLuc
		{
			get { return _entity.NgayHetHieuLuc; }
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
        /// Gets the TenNckh
        /// </summary>
        /// <value>The TenNckh.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String TenNckh
		{
			get { return _entity.TenNckh; }
		}
        /// <summary>
        /// Gets the GioGiangChuyenSangNckh
        /// </summary>
        /// <value>The GioGiangChuyenSangNckh.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Decimal? GioGiangChuyenSangNckh
		{
			get { return _entity.GioGiangChuyenSangNckh; }
		}
        /// <summary>
        /// Gets the NgayNhap
        /// </summary>
        /// <value>The NgayNhap.</value>
		[System.ComponentModel.Bindable(true)]
		public System.DateTime? NgayNhap
		{
			get { return _entity.NgayNhap; }
		}
        /// <summary>
        /// Gets the SoLuongThanhVien
        /// </summary>
        /// <value>The SoLuongThanhVien.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Int32? SoLuongThanhVien
		{
			get { return _entity.SoLuongThanhVien; }
		}
        /// <summary>
        /// Gets the MaVaiTro
        /// </summary>
        /// <value>The MaVaiTro.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Int32? MaVaiTro
		{
			get { return _entity.MaVaiTro; }
		}
        /// <summary>
        /// Gets the DuKien
        /// </summary>
        /// <value>The DuKien.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Boolean? DuKien
		{
			get { return _entity.DuKien; }
		}
        /// <summary>
        /// Gets the XacNhan
        /// </summary>
        /// <value>The XacNhan.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Boolean? XacNhan
		{
			get { return _entity.XacNhan; }
		}
        /// <summary>
        /// Gets the NgayXacNhan
        /// </summary>
        /// <value>The NgayXacNhan.</value>
		[System.ComponentModel.Bindable(true)]
		public System.DateTime? NgayXacNhan
		{
			get { return _entity.NgayXacNhan; }
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
        /// Gets the MucDoHoanThanh
        /// </summary>
        /// <value>The MucDoHoanThanh.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Int32? MucDoHoanThanh
		{
			get { return _entity.MucDoHoanThanh; }
		}

        /// <summary>
        /// Gets a <see cref="T:PMS.Entities.GiangVienNghienCuuKh"></see> object
        /// </summary>
        /// <value></value>
        [System.ComponentModel.Bindable(true)]
        public PMS.Entities.GiangVienNghienCuuKh Entity
        {
            get { return _entity; }
        }
	}
}
