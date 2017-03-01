﻿using System;
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
    /// A designer class for a strongly typed repeater <c>ViewKetQuaCacKhoanChiKhacRepeater</c>
    /// </summary>
	public class ViewKetQuaCacKhoanChiKhacRepeaterDesigner : System.Web.UI.Design.ControlDesigner
	{
	    /// <summary>
        /// Initializes a new instance of the <see cref="T:ViewKetQuaCacKhoanChiKhacRepeaterDesigner"/> class.
        /// </summary>
		public ViewKetQuaCacKhoanChiKhacRepeaterDesigner()
		{
		}

        /// <summary>
        /// Initializes the control designer and loads the specified component.
        /// </summary>
        /// <param name="component">The control being designed.</param>
		public override void Initialize(IComponent component)
		{
			if (!(component is ViewKetQuaCacKhoanChiKhacRepeater))
			{ 
				throw new ArgumentException("Component is not a ViewKetQuaCacKhoanChiKhacRepeater."); 
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
			ViewKetQuaCacKhoanChiKhacRepeater z = (ViewKetQuaCacKhoanChiKhacRepeater)Component;
			z.DataBind();

			return base.GetDesignTimeHtml();
		}
	}

    /// <summary>
    /// A strongly typed repeater control for the <see cref="ViewKetQuaCacKhoanChiKhacRepeater"/> Type.
    /// </summary>
	[Designer(typeof(ViewKetQuaCacKhoanChiKhacRepeaterDesigner))]
	[ParseChildren(true)]
	[ToolboxData("<{0}:ViewKetQuaCacKhoanChiKhacRepeater runat=\"server\"></{0}:ViewKetQuaCacKhoanChiKhacRepeater>")]
	public class ViewKetQuaCacKhoanChiKhacRepeater : CompositeDataBoundControl, System.Web.UI.INamingContainer
	{
	    /// <summary>
        /// Initializes a new instance of the <see cref="T:ViewKetQuaCacKhoanChiKhacRepeater"/> class.
        /// </summary>
		public ViewKetQuaCacKhoanChiKhacRepeater()
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
		[TemplateContainer(typeof(ViewKetQuaCacKhoanChiKhacItem))]
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
		[TemplateContainer(typeof(ViewKetQuaCacKhoanChiKhacItem))]
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
        [TemplateContainer(typeof(ViewKetQuaCacKhoanChiKhacItem))]
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
		[TemplateContainer(typeof(ViewKetQuaCacKhoanChiKhacItem))]
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
		[TemplateContainer(typeof(ViewKetQuaCacKhoanChiKhacItem))]
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
						PMS.Entities.ViewKetQuaCacKhoanChiKhac entity = o as PMS.Entities.ViewKetQuaCacKhoanChiKhac;
						ViewKetQuaCacKhoanChiKhacItem container = new ViewKetQuaCacKhoanChiKhacItem(entity);
	
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
	public class ViewKetQuaCacKhoanChiKhacItem : System.Web.UI.Control, System.Web.UI.INamingContainer
	{
		private PMS.Entities.ViewKetQuaCacKhoanChiKhac _entity;

        /// <summary>
        /// Initializes a new instance of the <see cref="T:ViewKetQuaCacKhoanChiKhacItem"/> class.
        /// </summary>
		public ViewKetQuaCacKhoanChiKhacItem()
			: base()
		{ }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:ViewKetQuaCacKhoanChiKhacItem"/> class.
        /// </summary>
		public ViewKetQuaCacKhoanChiKhacItem(PMS.Entities.ViewKetQuaCacKhoanChiKhac entity)
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
        /// Gets the HoTen
        /// </summary>
        /// <value>The HoTen.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String HoTen
		{
			get { return _entity.HoTen; }
		}
        /// <summary>
        /// Gets the GioiTinh
        /// </summary>
        /// <value>The GioiTinh.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String GioiTinh
		{
			get { return _entity.GioiTinh; }
		}
        /// <summary>
        /// Gets the NgaySinh
        /// </summary>
        /// <value>The NgaySinh.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String NgaySinh
		{
			get { return _entity.NgaySinh; }
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
        /// Gets the MaLoaiGiangVien
        /// </summary>
        /// <value>The MaLoaiGiangVien.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Int32? MaLoaiGiangVien
		{
			get { return _entity.MaLoaiGiangVien; }
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
        /// Gets the TenLoaiGiangVien
        /// </summary>
        /// <value>The TenLoaiGiangVien.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String TenLoaiGiangVien
		{
			get { return _entity.TenLoaiGiangVien; }
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
        /// Gets the Id
        /// </summary>
        /// <value>The Id.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Int32 Id
		{
			get { return _entity.Id; }
		}

	}
}