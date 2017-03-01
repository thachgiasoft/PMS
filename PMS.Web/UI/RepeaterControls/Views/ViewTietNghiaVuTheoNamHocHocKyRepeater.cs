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
    /// A designer class for a strongly typed repeater <c>ViewTietNghiaVuTheoNamHocHocKyRepeater</c>
    /// </summary>
	public class ViewTietNghiaVuTheoNamHocHocKyRepeaterDesigner : System.Web.UI.Design.ControlDesigner
	{
	    /// <summary>
        /// Initializes a new instance of the <see cref="T:ViewTietNghiaVuTheoNamHocHocKyRepeaterDesigner"/> class.
        /// </summary>
		public ViewTietNghiaVuTheoNamHocHocKyRepeaterDesigner()
		{
		}

        /// <summary>
        /// Initializes the control designer and loads the specified component.
        /// </summary>
        /// <param name="component">The control being designed.</param>
		public override void Initialize(IComponent component)
		{
			if (!(component is ViewTietNghiaVuTheoNamHocHocKyRepeater))
			{ 
				throw new ArgumentException("Component is not a ViewTietNghiaVuTheoNamHocHocKyRepeater."); 
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
			ViewTietNghiaVuTheoNamHocHocKyRepeater z = (ViewTietNghiaVuTheoNamHocHocKyRepeater)Component;
			z.DataBind();

			return base.GetDesignTimeHtml();
		}
	}

    /// <summary>
    /// A strongly typed repeater control for the <see cref="ViewTietNghiaVuTheoNamHocHocKyRepeater"/> Type.
    /// </summary>
	[Designer(typeof(ViewTietNghiaVuTheoNamHocHocKyRepeaterDesigner))]
	[ParseChildren(true)]
	[ToolboxData("<{0}:ViewTietNghiaVuTheoNamHocHocKyRepeater runat=\"server\"></{0}:ViewTietNghiaVuTheoNamHocHocKyRepeater>")]
	public class ViewTietNghiaVuTheoNamHocHocKyRepeater : CompositeDataBoundControl, System.Web.UI.INamingContainer
	{
	    /// <summary>
        /// Initializes a new instance of the <see cref="T:ViewTietNghiaVuTheoNamHocHocKyRepeater"/> class.
        /// </summary>
		public ViewTietNghiaVuTheoNamHocHocKyRepeater()
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
		[TemplateContainer(typeof(ViewTietNghiaVuTheoNamHocHocKyItem))]
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
		[TemplateContainer(typeof(ViewTietNghiaVuTheoNamHocHocKyItem))]
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
        [TemplateContainer(typeof(ViewTietNghiaVuTheoNamHocHocKyItem))]
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
		[TemplateContainer(typeof(ViewTietNghiaVuTheoNamHocHocKyItem))]
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
		[TemplateContainer(typeof(ViewTietNghiaVuTheoNamHocHocKyItem))]
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
						PMS.Entities.ViewTietNghiaVuTheoNamHocHocKy entity = o as PMS.Entities.ViewTietNghiaVuTheoNamHocHocKy;
						ViewTietNghiaVuTheoNamHocHocKyItem container = new ViewTietNghiaVuTheoNamHocHocKyItem(entity);
	
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
	public class ViewTietNghiaVuTheoNamHocHocKyItem : System.Web.UI.Control, System.Web.UI.INamingContainer
	{
		private PMS.Entities.ViewTietNghiaVuTheoNamHocHocKy _entity;

        /// <summary>
        /// Initializes a new instance of the <see cref="T:ViewTietNghiaVuTheoNamHocHocKyItem"/> class.
        /// </summary>
		public ViewTietNghiaVuTheoNamHocHocKyItem()
			: base()
		{ }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:ViewTietNghiaVuTheoNamHocHocKyItem"/> class.
        /// </summary>
		public ViewTietNghiaVuTheoNamHocHocKyItem(PMS.Entities.ViewTietNghiaVuTheoNamHocHocKy entity)
			: base()
		{
			_entity = entity;
		}
		
        /// <summary>
        /// Gets the MaGiangVien
        /// </summary>
        /// <value>The MaGiangVien.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Int32? MaGiangVien
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
        /// Gets the HoTen
        /// </summary>
        /// <value>The HoTen.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String HoTen
		{
			get { return _entity.HoTen; }
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
        /// Gets the TenHocHam
        /// </summary>
        /// <value>The TenHocHam.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String TenHocHam
		{
			get { return _entity.TenHocHam; }
		}
        /// <summary>
        /// Gets the TenHocVi
        /// </summary>
        /// <value>The TenHocVi.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String TenHocVi
		{
			get { return _entity.TenHocVi; }
		}
        /// <summary>
        /// Gets the MaChucVu
        /// </summary>
        /// <value>The MaChucVu.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Int32? MaChucVu
		{
			get { return _entity.MaChucVu; }
		}
        /// <summary>
        /// Gets the TenChucVu
        /// </summary>
        /// <value>The TenChucVu.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String TenChucVu
		{
			get { return _entity.TenChucVu; }
		}
        /// <summary>
        /// Gets the SoTietNghiaVu
        /// </summary>
        /// <value>The SoTietNghiaVu.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Decimal? SoTietNghiaVu
		{
			get { return _entity.SoTietNghiaVu; }
		}
        /// <summary>
        /// Gets the PhanTramGiamTru
        /// </summary>
        /// <value>The PhanTramGiamTru.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Decimal? PhanTramGiamTru
		{
			get { return _entity.PhanTramGiamTru; }
		}
        /// <summary>
        /// Gets the TietNghiaVuSauGiamTru
        /// </summary>
        /// <value>The TietNghiaVuSauGiamTru.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Decimal? TietNghiaVuSauGiamTru
		{
			get { return _entity.TietNghiaVuSauGiamTru; }
		}
        /// <summary>
        /// Gets the TietGioiHan
        /// </summary>
        /// <value>The TietGioiHan.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Decimal? TietGioiHan
		{
			get { return _entity.TietGioiHan; }
		}
        /// <summary>
        /// Gets the GhiChu
        /// </summary>
        /// <value>The GhiChu.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Boolean? GhiChu
		{
			get { return _entity.GhiChu; }
		}
        /// <summary>
        /// Gets the GhiChu2
        /// </summary>
        /// <value>The GhiChu2.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String GhiChu2
		{
			get { return _entity.GhiChu2; }
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
        /// Gets the MaGiamTruKhac
        /// </summary>
        /// <value>The MaGiamTruKhac.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Int32? MaGiamTruKhac
		{
			get { return _entity.MaGiamTruKhac; }
		}
        /// <summary>
        /// Gets the SoTietGiamTruKhac
        /// </summary>
        /// <value>The SoTietGiamTruKhac.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Decimal? SoTietGiamTruKhac
		{
			get { return _entity.SoTietGiamTruKhac; }
		}
        /// <summary>
        /// Gets the TietNghiaVuCongTacKhac
        /// </summary>
        /// <value>The TietNghiaVuCongTacKhac.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Decimal? TietNghiaVuCongTacKhac
		{
			get { return _entity.TietNghiaVuCongTacKhac; }
		}
        /// <summary>
        /// Gets the TietNghiaVuCongTacKhacSauGiamTru
        /// </summary>
        /// <value>The TietNghiaVuCongTacKhacSauGiamTru.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Decimal? TietNghiaVuCongTacKhacSauGiamTru
		{
			get { return _entity.TietNghiaVuCongTacKhacSauGiamTru; }
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
        /// Gets the TenNgach
        /// </summary>
        /// <value>The TenNgach.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String TenNgach
		{
			get { return _entity.TenNgach; }
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
        /// Gets the PhanTramDuocGiam
        /// </summary>
        /// <value>The PhanTramDuocGiam.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Decimal? PhanTramDuocGiam
		{
			get { return _entity.PhanTramDuocGiam; }
		}
        /// <summary>
        /// Gets the CongPhanTramGiam
        /// </summary>
        /// <value>The CongPhanTramGiam.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Decimal? CongPhanTramGiam
		{
			get { return _entity.CongPhanTramGiam; }
		}

	}
}
