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
    /// A designer class for a strongly typed repeater <c>ViewTinhKhoiLuongTungTuanRepeater</c>
    /// </summary>
	public class ViewTinhKhoiLuongTungTuanRepeaterDesigner : System.Web.UI.Design.ControlDesigner
	{
	    /// <summary>
        /// Initializes a new instance of the <see cref="T:ViewTinhKhoiLuongTungTuanRepeaterDesigner"/> class.
        /// </summary>
		public ViewTinhKhoiLuongTungTuanRepeaterDesigner()
		{
		}

        /// <summary>
        /// Initializes the control designer and loads the specified component.
        /// </summary>
        /// <param name="component">The control being designed.</param>
		public override void Initialize(IComponent component)
		{
			if (!(component is ViewTinhKhoiLuongTungTuanRepeater))
			{ 
				throw new ArgumentException("Component is not a ViewTinhKhoiLuongTungTuanRepeater."); 
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
			ViewTinhKhoiLuongTungTuanRepeater z = (ViewTinhKhoiLuongTungTuanRepeater)Component;
			z.DataBind();

			return base.GetDesignTimeHtml();
		}
	}

    /// <summary>
    /// A strongly typed repeater control for the <see cref="ViewTinhKhoiLuongTungTuanRepeater"/> Type.
    /// </summary>
	[Designer(typeof(ViewTinhKhoiLuongTungTuanRepeaterDesigner))]
	[ParseChildren(true)]
	[ToolboxData("<{0}:ViewTinhKhoiLuongTungTuanRepeater runat=\"server\"></{0}:ViewTinhKhoiLuongTungTuanRepeater>")]
	public class ViewTinhKhoiLuongTungTuanRepeater : CompositeDataBoundControl, System.Web.UI.INamingContainer
	{
	    /// <summary>
        /// Initializes a new instance of the <see cref="T:ViewTinhKhoiLuongTungTuanRepeater"/> class.
        /// </summary>
		public ViewTinhKhoiLuongTungTuanRepeater()
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
		[TemplateContainer(typeof(ViewTinhKhoiLuongTungTuanItem))]
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
		[TemplateContainer(typeof(ViewTinhKhoiLuongTungTuanItem))]
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
        [TemplateContainer(typeof(ViewTinhKhoiLuongTungTuanItem))]
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
		[TemplateContainer(typeof(ViewTinhKhoiLuongTungTuanItem))]
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
		[TemplateContainer(typeof(ViewTinhKhoiLuongTungTuanItem))]
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
						PMS.Entities.ViewTinhKhoiLuongTungTuan entity = o as PMS.Entities.ViewTinhKhoiLuongTungTuan;
						ViewTinhKhoiLuongTungTuanItem container = new ViewTinhKhoiLuongTungTuanItem(entity);
	
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
	public class ViewTinhKhoiLuongTungTuanItem : System.Web.UI.Control, System.Web.UI.INamingContainer
	{
		private PMS.Entities.ViewTinhKhoiLuongTungTuan _entity;

        /// <summary>
        /// Initializes a new instance of the <see cref="T:ViewTinhKhoiLuongTungTuanItem"/> class.
        /// </summary>
		public ViewTinhKhoiLuongTungTuanItem()
			: base()
		{ }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:ViewTinhKhoiLuongTungTuanItem"/> class.
        /// </summary>
		public ViewTinhKhoiLuongTungTuanItem(PMS.Entities.ViewTinhKhoiLuongTungTuan entity)
			: base()
		{
			_entity = entity;
		}
		
        /// <summary>
        /// Gets the MaKhoiLuong
        /// </summary>
        /// <value>The MaKhoiLuong.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Int32 MaKhoiLuong
		{
			get { return _entity.MaKhoiLuong; }
		}
        /// <summary>
        /// Gets the MaToaNha
        /// </summary>
        /// <value>The MaToaNha.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String MaToaNha
		{
			get { return _entity.MaToaNha; }
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
        /// Gets the MaLop
        /// </summary>
        /// <value>The MaLop.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String MaLop
		{
			get { return _entity.MaLop; }
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
        /// Gets the LoaiHocPhan
        /// </summary>
        /// <value>The LoaiHocPhan.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String LoaiHocPhan
		{
			get { return _entity.LoaiHocPhan; }
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
        /// Gets the MaMonHoc
        /// </summary>
        /// <value>The MaMonHoc.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String MaMonHoc
		{
			get { return _entity.MaMonHoc; }
		}
        /// <summary>
        /// Gets the DienGiai
        /// </summary>
        /// <value>The DienGiai.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String DienGiai
		{
			get { return _entity.DienGiai; }
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
        /// Gets the SoTinChi
        /// </summary>
        /// <value>The SoTinChi.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Decimal? SoTinChi
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
        /// Gets the SoNhom
        /// </summary>
        /// <value>The SoNhom.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Int32? SoNhom
		{
			get { return _entity.SoNhom; }
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
        /// Gets the TrongGio
        /// </summary>
        /// <value>The TrongGio.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Decimal? TrongGio
		{
			get { return _entity.TrongGio; }
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
        /// Gets the HeSoCoSo
        /// </summary>
        /// <value>The HeSoCoSo.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Decimal? HeSoCoSo
		{
			get { return _entity.HeSoCoSo; }
		}
        /// <summary>
        /// Gets the HeSoHocKy
        /// </summary>
        /// <value>The HeSoHocKy.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Decimal? HeSoHocKy
		{
			get { return _entity.HeSoHocKy; }
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
        /// Gets the HeSoTrongGio
        /// </summary>
        /// <value>The HeSoTrongGio.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Decimal? HeSoTrongGio
		{
			get { return _entity.HeSoTrongGio; }
		}
        /// <summary>
        /// Gets the HeSoNgoaiGio
        /// </summary>
        /// <value>The HeSoNgoaiGio.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Decimal? HeSoNgoaiGio
		{
			get { return _entity.HeSoNgoaiGio; }
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
        /// Gets the LoaiHocKy
        /// </summary>
        /// <value>The LoaiHocKy.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Int32? LoaiHocKy
		{
			get { return _entity.LoaiHocKy; }
		}
        /// <summary>
        /// Gets the ThoiKhoaBieu
        /// </summary>
        /// <value>The ThoiKhoaBieu.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String ThoiKhoaBieu
		{
			get { return _entity.ThoiKhoaBieu; }
		}
        /// <summary>
        /// Gets the NgayTao
        /// </summary>
        /// <value>The NgayTao.</value>
		[System.ComponentModel.Bindable(true)]
		public System.DateTime? NgayTao
		{
			get { return _entity.NgayTao; }
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
        /// Gets the Tuan
        /// </summary>
        /// <value>The Tuan.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Int32? Tuan
		{
			get { return _entity.Tuan; }
		}
        /// <summary>
        /// Gets the Nam
        /// </summary>
        /// <value>The Nam.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Int32? Nam
		{
			get { return _entity.Nam; }
		}
        /// <summary>
        /// Gets the NgayDay
        /// </summary>
        /// <value>The NgayDay.</value>
		[System.ComponentModel.Bindable(true)]
		public System.DateTime? NgayDay
		{
			get { return _entity.NgayDay; }
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
        /// Gets the TenLop
        /// </summary>
        /// <value>The TenLop.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String TenLop
		{
			get { return _entity.TenLop; }
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

	}
}
