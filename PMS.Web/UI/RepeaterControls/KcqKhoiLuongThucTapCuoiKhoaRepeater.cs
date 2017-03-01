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
    /// A designer class for a strongly typed repeater <c>KcqKhoiLuongThucTapCuoiKhoaRepeater</c>
    /// </summary>
	public class KcqKhoiLuongThucTapCuoiKhoaRepeaterDesigner : System.Web.UI.Design.ControlDesigner
	{
	    /// <summary>
        /// Initializes a new instance of the <see cref="T:KcqKhoiLuongThucTapCuoiKhoaRepeaterDesigner"/> class.
        /// </summary>
		public KcqKhoiLuongThucTapCuoiKhoaRepeaterDesigner()
		{
		}

        /// <summary>
        /// Initializes the control designer and loads the specified component.
        /// </summary>
        /// <param name="component">The control being designed.</param>
		public override void Initialize(IComponent component)
		{
			if (!(component is KcqKhoiLuongThucTapCuoiKhoaRepeater))
			{ 
				throw new ArgumentException("Component is not a KcqKhoiLuongThucTapCuoiKhoaRepeater."); 
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
			KcqKhoiLuongThucTapCuoiKhoaRepeater z = (KcqKhoiLuongThucTapCuoiKhoaRepeater)Component;
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
    /// A strongly typed repeater control for the <see cref="KcqKhoiLuongThucTapCuoiKhoaRepeater"/> Type.
    /// </summary>
	[Designer(typeof(KcqKhoiLuongThucTapCuoiKhoaRepeaterDesigner))]
	[ParseChildren(true)]
	[ToolboxData("<{0}:KcqKhoiLuongThucTapCuoiKhoaRepeater runat=\"server\"></{0}:KcqKhoiLuongThucTapCuoiKhoaRepeater>")]
	public class KcqKhoiLuongThucTapCuoiKhoaRepeater : CompositeDataBoundControl, System.Web.UI.INamingContainer
	{
	    /// <summary>
        /// Initializes a new instance of the <see cref="T:KcqKhoiLuongThucTapCuoiKhoaRepeater"/> class.
        /// </summary>
		public KcqKhoiLuongThucTapCuoiKhoaRepeater()
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
		[TemplateContainer(typeof(KcqKhoiLuongThucTapCuoiKhoaItem))]
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
		[TemplateContainer(typeof(KcqKhoiLuongThucTapCuoiKhoaItem))]
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
        [TemplateContainer(typeof(KcqKhoiLuongThucTapCuoiKhoaItem))]
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
		[TemplateContainer(typeof(KcqKhoiLuongThucTapCuoiKhoaItem))]
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
		[TemplateContainer(typeof(KcqKhoiLuongThucTapCuoiKhoaItem))]
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
						PMS.Entities.KcqKhoiLuongThucTapCuoiKhoa entity = o as PMS.Entities.KcqKhoiLuongThucTapCuoiKhoa;
						KcqKhoiLuongThucTapCuoiKhoaItem container = new KcqKhoiLuongThucTapCuoiKhoaItem(entity);
	
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
	public class KcqKhoiLuongThucTapCuoiKhoaItem : System.Web.UI.Control, System.Web.UI.INamingContainer
	{
		private PMS.Entities.KcqKhoiLuongThucTapCuoiKhoa _entity;

        /// <summary>
        /// Initializes a new instance of the <see cref="T:KcqKhoiLuongThucTapCuoiKhoaItem"/> class.
        /// </summary>
		public KcqKhoiLuongThucTapCuoiKhoaItem()
			: base()
		{ }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:KcqKhoiLuongThucTapCuoiKhoaItem"/> class.
        /// </summary>
		public KcqKhoiLuongThucTapCuoiKhoaItem(PMS.Entities.KcqKhoiLuongThucTapCuoiKhoa entity)
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
        /// Gets the MaGiangVien
        /// </summary>
        /// <value>The MaGiangVien.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Int32? MaGiangVien
		{
			get { return _entity.MaGiangVien; }
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
        /// Gets the MaLopHocPhan
        /// </summary>
        /// <value>The MaLopHocPhan.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String MaLopHocPhan
		{
			get { return _entity.MaLopHocPhan; }
		}
        /// <summary>
        /// Gets the MaLoaiHocPhan
        /// </summary>
        /// <value>The MaLoaiHocPhan.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Int32? MaLoaiHocPhan
		{
			get { return _entity.MaLoaiHocPhan; }
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
        /// Gets the SiSo
        /// </summary>
        /// <value>The SiSo.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Int32? SiSo
		{
			get { return _entity.SiSo; }
		}
        /// <summary>
        /// Gets the SoTinChi
        /// </summary>
        /// <value>The SoTinChi.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Int32? SoTinChi
		{
			get { return _entity.SoTinChi; }
		}
        /// <summary>
        /// Gets the SoTuan
        /// </summary>
        /// <value>The SoTuan.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Int32? SoTuan
		{
			get { return _entity.SoTuan; }
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
        /// Gets the TietQuyDoi
        /// </summary>
        /// <value>The TietQuyDoi.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Decimal? TietQuyDoi
		{
			get { return _entity.TietQuyDoi; }
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
        /// Gets the MaDiaDiem
        /// </summary>
        /// <value>The MaDiaDiem.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Int32? MaDiaDiem
		{
			get { return _entity.MaDiaDiem; }
		}
        /// <summary>
        /// Gets the HeSoDiaDiem
        /// </summary>
        /// <value>The HeSoDiaDiem.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Decimal? HeSoDiaDiem
		{
			get { return _entity.HeSoDiaDiem; }
		}
        /// <summary>
        /// Gets the DonGiaDiaDiem
        /// </summary>
        /// <value>The DonGiaDiaDiem.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Decimal? DonGiaDiaDiem
		{
			get { return _entity.DonGiaDiaDiem; }
		}
        /// <summary>
        /// Gets the TienXeDiaDiem
        /// </summary>
        /// <value>The TienXeDiaDiem.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Decimal? TienXeDiaDiem
		{
			get { return _entity.TienXeDiaDiem; }
		}
        /// <summary>
        /// Gets the ThanhTienGiangDay
        /// </summary>
        /// <value>The ThanhTienGiangDay.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Decimal? ThanhTienGiangDay
		{
			get { return _entity.ThanhTienGiangDay; }
		}
        /// <summary>
        /// Gets the GhiChu
        /// </summary>
        /// <value>The GhiChu.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String GhiChu
		{
			get { return _entity.GhiChu; }
		}
        /// <summary>
        /// Gets the DotThanhToan
        /// </summary>
        /// <value>The DotThanhToan.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String DotThanhToan
		{
			get { return _entity.DotThanhToan; }
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
        /// Gets the HeSoQuyDoi
        /// </summary>
        /// <value>The HeSoQuyDoi.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Decimal? HeSoQuyDoi
		{
			get { return _entity.HeSoQuyDoi; }
		}
        /// <summary>
        /// Gets the Loai
        /// </summary>
        /// <value>The Loai.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String Loai
		{
			get { return _entity.Loai; }
		}

        /// <summary>
        /// Gets a <see cref="T:PMS.Entities.KcqKhoiLuongThucTapCuoiKhoa"></see> object
        /// </summary>
        /// <value></value>
        [System.ComponentModel.Bindable(true)]
        public PMS.Entities.KcqKhoiLuongThucTapCuoiKhoa Entity
        {
            get { return _entity; }
        }
	}
}
