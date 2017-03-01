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
    /// A designer class for a strongly typed repeater <c>VLopHocPhanKhongPhanCongRepeater</c>
    /// </summary>
	public class VLopHocPhanKhongPhanCongRepeaterDesigner : System.Web.UI.Design.ControlDesigner
	{
	    /// <summary>
        /// Initializes a new instance of the <see cref="T:VLopHocPhanKhongPhanCongRepeaterDesigner"/> class.
        /// </summary>
		public VLopHocPhanKhongPhanCongRepeaterDesigner()
		{
		}

        /// <summary>
        /// Initializes the control designer and loads the specified component.
        /// </summary>
        /// <param name="component">The control being designed.</param>
		public override void Initialize(IComponent component)
		{
			if (!(component is VLopHocPhanKhongPhanCongRepeater))
			{ 
				throw new ArgumentException("Component is not a VLopHocPhanKhongPhanCongRepeater."); 
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
			VLopHocPhanKhongPhanCongRepeater z = (VLopHocPhanKhongPhanCongRepeater)Component;
			z.DataBind();

			return base.GetDesignTimeHtml();
		}
	}

    /// <summary>
    /// A strongly typed repeater control for the <see cref="VLopHocPhanKhongPhanCongRepeater"/> Type.
    /// </summary>
	[Designer(typeof(VLopHocPhanKhongPhanCongRepeaterDesigner))]
	[ParseChildren(true)]
	[ToolboxData("<{0}:VLopHocPhanKhongPhanCongRepeater runat=\"server\"></{0}:VLopHocPhanKhongPhanCongRepeater>")]
	public class VLopHocPhanKhongPhanCongRepeater : CompositeDataBoundControl, System.Web.UI.INamingContainer
	{
	    /// <summary>
        /// Initializes a new instance of the <see cref="T:VLopHocPhanKhongPhanCongRepeater"/> class.
        /// </summary>
		public VLopHocPhanKhongPhanCongRepeater()
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
		[TemplateContainer(typeof(VLopHocPhanKhongPhanCongItem))]
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
		[TemplateContainer(typeof(VLopHocPhanKhongPhanCongItem))]
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
        [TemplateContainer(typeof(VLopHocPhanKhongPhanCongItem))]
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
		[TemplateContainer(typeof(VLopHocPhanKhongPhanCongItem))]
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
		[TemplateContainer(typeof(VLopHocPhanKhongPhanCongItem))]
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
						PMS.Entities.VLopHocPhanKhongPhanCong entity = o as PMS.Entities.VLopHocPhanKhongPhanCong;
						VLopHocPhanKhongPhanCongItem container = new VLopHocPhanKhongPhanCongItem(entity);
	
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
	public class VLopHocPhanKhongPhanCongItem : System.Web.UI.Control, System.Web.UI.INamingContainer
	{
		private PMS.Entities.VLopHocPhanKhongPhanCong _entity;

        /// <summary>
        /// Initializes a new instance of the <see cref="T:VLopHocPhanKhongPhanCongItem"/> class.
        /// </summary>
		public VLopHocPhanKhongPhanCongItem()
			: base()
		{ }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:VLopHocPhanKhongPhanCongItem"/> class.
        /// </summary>
		public VLopHocPhanKhongPhanCongItem(PMS.Entities.VLopHocPhanKhongPhanCong entity)
			: base()
		{
			_entity = entity;
		}
		
        /// <summary>
        /// Gets the MaLoaiGiangVien
        /// </summary>
        /// <value>The MaLoaiGiangVien.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Int32? MaLoaiGiangVien
		{
			get { return _entity.MaLoaiGiangVien; }
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
        /// Gets the HoTen
        /// </summary>
        /// <value>The HoTen.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String HoTen
		{
			get { return _entity.HoTen; }
		}
        /// <summary>
        /// Gets the ChucDanh
        /// </summary>
        /// <value>The ChucDanh.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String ChucDanh
		{
			get { return _entity.ChucDanh; }
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
        /// Gets the MaNhom
        /// </summary>
        /// <value>The MaNhom.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String MaNhom
		{
			get { return _entity.MaNhom; }
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
        /// Gets the SoTinChi
        /// </summary>
        /// <value>The SoTinChi.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Decimal SoTinChi
		{
			get { return _entity.SoTinChi; }
		}
        /// <summary>
        /// Gets the SiSoLop
        /// </summary>
        /// <value>The SiSoLop.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Int32? SiSoLop
		{
			get { return _entity.SiSoLop; }
		}
        /// <summary>
        /// Gets the TrongGio
        /// </summary>
        /// <value>The TrongGio.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Int32? TrongGio
		{
			get { return _entity.TrongGio; }
		}
        /// <summary>
        /// Gets the NgoaiGio
        /// </summary>
        /// <value>The NgoaiGio.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Int32? NgoaiGio
		{
			get { return _entity.NgoaiGio; }
		}
        /// <summary>
        /// Gets the GiangHe
        /// </summary>
        /// <value>The GiangHe.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Int32? GiangHe
		{
			get { return _entity.GiangHe; }
		}
        /// <summary>
        /// Gets the HeSoCoSo
        /// </summary>
        /// <value>The HeSoCoSo.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Decimal? HeSoCoSo
		{
			get { return _entity.HeSoCoSo; }
		}
        /// <summary>
        /// Gets the NgayBatDau
        /// </summary>
        /// <value>The NgayBatDau.</value>
		[System.ComponentModel.Bindable(true)]
		public System.DateTime? NgayBatDau
		{
			get { return _entity.NgayBatDau; }
		}
        /// <summary>
        /// Gets the NgayKetThuc
        /// </summary>
        /// <value>The NgayKetThuc.</value>
		[System.ComponentModel.Bindable(true)]
		public System.DateTime? NgayKetThuc
		{
			get { return _entity.NgayKetThuc; }
		}
        /// <summary>
        /// Gets the ThoiGianGiang
        /// </summary>
        /// <value>The ThoiGianGiang.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String ThoiGianGiang
		{
			get { return _entity.ThoiGianGiang; }
		}
        /// <summary>
        /// Gets the MaDiaDiem
        /// </summary>
        /// <value>The MaDiaDiem.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String MaDiaDiem
		{
			get { return _entity.MaDiaDiem; }
		}
        /// <summary>
        /// Gets the MaBacLoaiHinh
        /// </summary>
        /// <value>The MaBacLoaiHinh.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String MaBacLoaiHinh
		{
			get { return _entity.MaBacLoaiHinh; }
		}

	}
}
