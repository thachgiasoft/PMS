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
    /// A designer class for a strongly typed repeater <c>DinhMucGioChuanRepeater</c>
    /// </summary>
	public class DinhMucGioChuanRepeaterDesigner : System.Web.UI.Design.ControlDesigner
	{
	    /// <summary>
        /// Initializes a new instance of the <see cref="T:DinhMucGioChuanRepeaterDesigner"/> class.
        /// </summary>
		public DinhMucGioChuanRepeaterDesigner()
		{
		}

        /// <summary>
        /// Initializes the control designer and loads the specified component.
        /// </summary>
        /// <param name="component">The control being designed.</param>
		public override void Initialize(IComponent component)
		{
			if (!(component is DinhMucGioChuanRepeater))
			{ 
				throw new ArgumentException("Component is not a DinhMucGioChuanRepeater."); 
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
			DinhMucGioChuanRepeater z = (DinhMucGioChuanRepeater)Component;
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
    /// A strongly typed repeater control for the <see cref="DinhMucGioChuanRepeater"/> Type.
    /// </summary>
	[Designer(typeof(DinhMucGioChuanRepeaterDesigner))]
	[ParseChildren(true)]
	[ToolboxData("<{0}:DinhMucGioChuanRepeater runat=\"server\"></{0}:DinhMucGioChuanRepeater>")]
	public class DinhMucGioChuanRepeater : CompositeDataBoundControl, System.Web.UI.INamingContainer
	{
	    /// <summary>
        /// Initializes a new instance of the <see cref="T:DinhMucGioChuanRepeater"/> class.
        /// </summary>
		public DinhMucGioChuanRepeater()
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
		[TemplateContainer(typeof(DinhMucGioChuanItem))]
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
		[TemplateContainer(typeof(DinhMucGioChuanItem))]
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
        [TemplateContainer(typeof(DinhMucGioChuanItem))]
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
		[TemplateContainer(typeof(DinhMucGioChuanItem))]
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
		[TemplateContainer(typeof(DinhMucGioChuanItem))]
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
						PMS.Entities.DinhMucGioChuan entity = o as PMS.Entities.DinhMucGioChuan;
						DinhMucGioChuanItem container = new DinhMucGioChuanItem(entity);
	
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
	public class DinhMucGioChuanItem : System.Web.UI.Control, System.Web.UI.INamingContainer
	{
		private PMS.Entities.DinhMucGioChuan _entity;

        /// <summary>
        /// Initializes a new instance of the <see cref="T:DinhMucGioChuanItem"/> class.
        /// </summary>
		public DinhMucGioChuanItem()
			: base()
		{ }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:DinhMucGioChuanItem"/> class.
        /// </summary>
		public DinhMucGioChuanItem(PMS.Entities.DinhMucGioChuan entity)
			: base()
		{
			_entity = entity;
		}
		
        /// <summary>
        /// Gets the MaDinhMuc
        /// </summary>
        /// <value>The MaDinhMuc.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Int32 MaDinhMuc
		{
			get { return _entity.MaDinhMuc; }
		}
        /// <summary>
        /// Gets the Stt
        /// </summary>
        /// <value>The Stt.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Int32? Stt
		{
			get { return _entity.Stt; }
		}
        /// <summary>
        /// Gets the MaHocHam
        /// </summary>
        /// <value>The MaHocHam.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Int32? MaHocHam
		{
			get { return _entity.MaHocHam; }
		}
        /// <summary>
        /// Gets the MaHocVi
        /// </summary>
        /// <value>The MaHocVi.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Int32? MaHocVi
		{
			get { return _entity.MaHocVi; }
		}
        /// <summary>
        /// Gets the DinhMucMonHoc
        /// </summary>
        /// <value>The DinhMucMonHoc.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Int32? DinhMucMonHoc
		{
			get { return _entity.DinhMucMonHoc; }
		}
        /// <summary>
        /// Gets the DinhMucMonGdtcQp
        /// </summary>
        /// <value>The DinhMucMonGdtcQp.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Int32? DinhMucMonGdtcQp
		{
			get { return _entity.DinhMucMonGdtcQp; }
		}
        /// <summary>
        /// Gets the DinhMucNckh
        /// </summary>
        /// <value>The DinhMucNckh.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Int32? DinhMucNckh
		{
			get { return _entity.DinhMucNckh; }
		}
        /// <summary>
        /// Gets the HeSoLuongTangThem
        /// </summary>
        /// <value>The HeSoLuongTangThem.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Decimal? HeSoLuongTangThem
		{
			get { return _entity.HeSoLuongTangThem; }
		}
        /// <summary>
        /// Gets the MaBacLuong
        /// </summary>
        /// <value>The MaBacLuong.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String MaBacLuong
		{
			get { return _entity.MaBacLuong; }
		}
        /// <summary>
        /// Gets the DinhMucHoatDongChuyenMonKhac
        /// </summary>
        /// <value>The DinhMucHoatDongChuyenMonKhac.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Int32? DinhMucHoatDongChuyenMonKhac
		{
			get { return _entity.DinhMucHoatDongChuyenMonKhac; }
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
        /// Gets the TongDinhMuc
        /// </summary>
        /// <value>The TongDinhMuc.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Int32? TongDinhMuc
		{
			get { return _entity.TongDinhMuc; }
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
        /// Gets the PhanLoaiGiangVien
        /// </summary>
        /// <value>The PhanLoaiGiangVien.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String PhanLoaiGiangVien
		{
			get { return _entity.PhanLoaiGiangVien; }
		}
        /// <summary>
        /// Gets the TuHeSoLuong
        /// </summary>
        /// <value>The TuHeSoLuong.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Decimal? TuHeSoLuong
		{
			get { return _entity.TuHeSoLuong; }
		}
        /// <summary>
        /// Gets the DenHeSoLuong
        /// </summary>
        /// <value>The DenHeSoLuong.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Decimal? DenHeSoLuong
		{
			get { return _entity.DenHeSoLuong; }
		}

        /// <summary>
        /// Gets a <see cref="T:PMS.Entities.DinhMucGioChuan"></see> object
        /// </summary>
        /// <value></value>
        [System.ComponentModel.Bindable(true)]
        public PMS.Entities.DinhMucGioChuan Entity
        {
            get { return _entity; }
        }
	}
}
