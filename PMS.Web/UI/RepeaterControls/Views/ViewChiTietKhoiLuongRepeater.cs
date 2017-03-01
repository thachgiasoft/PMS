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
    /// A designer class for a strongly typed repeater <c>ViewChiTietKhoiLuongRepeater</c>
    /// </summary>
	public class ViewChiTietKhoiLuongRepeaterDesigner : System.Web.UI.Design.ControlDesigner
	{
	    /// <summary>
        /// Initializes a new instance of the <see cref="T:ViewChiTietKhoiLuongRepeaterDesigner"/> class.
        /// </summary>
		public ViewChiTietKhoiLuongRepeaterDesigner()
		{
		}

        /// <summary>
        /// Initializes the control designer and loads the specified component.
        /// </summary>
        /// <param name="component">The control being designed.</param>
		public override void Initialize(IComponent component)
		{
			if (!(component is ViewChiTietKhoiLuongRepeater))
			{ 
				throw new ArgumentException("Component is not a ViewChiTietKhoiLuongRepeater."); 
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
			ViewChiTietKhoiLuongRepeater z = (ViewChiTietKhoiLuongRepeater)Component;
			z.DataBind();

			return base.GetDesignTimeHtml();
		}
	}

    /// <summary>
    /// A strongly typed repeater control for the <see cref="ViewChiTietKhoiLuongRepeater"/> Type.
    /// </summary>
	[Designer(typeof(ViewChiTietKhoiLuongRepeaterDesigner))]
	[ParseChildren(true)]
	[ToolboxData("<{0}:ViewChiTietKhoiLuongRepeater runat=\"server\"></{0}:ViewChiTietKhoiLuongRepeater>")]
	public class ViewChiTietKhoiLuongRepeater : CompositeDataBoundControl, System.Web.UI.INamingContainer
	{
	    /// <summary>
        /// Initializes a new instance of the <see cref="T:ViewChiTietKhoiLuongRepeater"/> class.
        /// </summary>
		public ViewChiTietKhoiLuongRepeater()
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
		[TemplateContainer(typeof(ViewChiTietKhoiLuongItem))]
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
		[TemplateContainer(typeof(ViewChiTietKhoiLuongItem))]
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
        [TemplateContainer(typeof(ViewChiTietKhoiLuongItem))]
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
		[TemplateContainer(typeof(ViewChiTietKhoiLuongItem))]
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
		[TemplateContainer(typeof(ViewChiTietKhoiLuongItem))]
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
						PMS.Entities.ViewChiTietKhoiLuong entity = o as PMS.Entities.ViewChiTietKhoiLuong;
						ViewChiTietKhoiLuongItem container = new ViewChiTietKhoiLuongItem(entity);
	
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
	public class ViewChiTietKhoiLuongItem : System.Web.UI.Control, System.Web.UI.INamingContainer
	{
		private PMS.Entities.ViewChiTietKhoiLuong _entity;

        /// <summary>
        /// Initializes a new instance of the <see cref="T:ViewChiTietKhoiLuongItem"/> class.
        /// </summary>
		public ViewChiTietKhoiLuongItem()
			: base()
		{ }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:ViewChiTietKhoiLuongItem"/> class.
        /// </summary>
		public ViewChiTietKhoiLuongItem(PMS.Entities.ViewChiTietKhoiLuong entity)
			: base()
		{
			_entity = entity;
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
        /// Gets the HoTen
        /// </summary>
        /// <value>The HoTen.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String HoTen
		{
			get { return _entity.HoTen; }
		}
        /// <summary>
        /// Gets the MaKhoa
        /// </summary>
        /// <value>The MaKhoa.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String MaKhoa
		{
			get { return _entity.MaKhoa; }
		}
        /// <summary>
        /// Gets the MaBoMon
        /// </summary>
        /// <value>The MaBoMon.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String MaBoMon
		{
			get { return _entity.MaBoMon; }
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
        /// Gets the MaLop
        /// </summary>
        /// <value>The MaLop.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String MaLop
		{
			get { return _entity.MaLop; }
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
		public System.Decimal? TrongGio
		{
			get { return _entity.TrongGio; }
		}
        /// <summary>
        /// Gets the ChatLuongCao
        /// </summary>
        /// <value>The ChatLuongCao.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Decimal? ChatLuongCao
		{
			get { return _entity.ChatLuongCao; }
		}
        /// <summary>
        /// Gets the NgoaiGio
        /// </summary>
        /// <value>The NgoaiGio.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Decimal? NgoaiGio
		{
			get { return _entity.NgoaiGio; }
		}
        /// <summary>
        /// Gets the HeSoThanhPhan
        /// </summary>
        /// <value>The HeSoThanhPhan.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Decimal? HeSoThanhPhan
		{
			get { return _entity.HeSoThanhPhan; }
		}
        /// <summary>
        /// Gets the HeSoLopDong
        /// </summary>
        /// <value>The HeSoLopDong.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Decimal? HeSoLopDong
		{
			get { return _entity.HeSoLopDong; }
		}
        /// <summary>
        /// Gets the DonGia
        /// </summary>
        /// <value>The DonGia.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Decimal? DonGia
		{
			get { return _entity.DonGia; }
		}
        /// <summary>
        /// Gets the TietQuyDoi
        /// </summary>
        /// <value>The TietQuyDoi.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Decimal? TietQuyDoi
		{
			get { return _entity.TietQuyDoi; }
		}
        /// <summary>
        /// Gets the MaLoaiKhoiLuong
        /// </summary>
        /// <value>The MaLoaiKhoiLuong.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String MaLoaiKhoiLuong
		{
			get { return _entity.MaLoaiKhoiLuong; }
		}
        /// <summary>
        /// Gets the TenLoaiKhoiLuong
        /// </summary>
        /// <value>The TenLoaiKhoiLuong.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String TenLoaiKhoiLuong
		{
			get { return _entity.TenLoaiKhoiLuong; }
		}
        /// <summary>
        /// Gets the PhanLoai
        /// </summary>
        /// <value>The PhanLoai.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String PhanLoai
		{
			get { return _entity.PhanLoai; }
		}
        /// <summary>
        /// Gets the NghiaVu
        /// </summary>
        /// <value>The NghiaVu.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Boolean? NghiaVu
		{
			get { return _entity.NghiaVu; }
		}
        /// <summary>
        /// Gets the NguongTiet
        /// </summary>
        /// <value>The NguongTiet.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Int32? NguongTiet
		{
			get { return _entity.NguongTiet; }
		}
        /// <summary>
        /// Gets the TietNghiaVu
        /// </summary>
        /// <value>The TietNghiaVu.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Decimal? TietNghiaVu
		{
			get { return _entity.TietNghiaVu; }
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

	}
}