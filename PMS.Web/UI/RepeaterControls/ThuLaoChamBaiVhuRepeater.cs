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
    /// A designer class for a strongly typed repeater <c>ThuLaoChamBaiVhuRepeater</c>
    /// </summary>
	public class ThuLaoChamBaiVhuRepeaterDesigner : System.Web.UI.Design.ControlDesigner
	{
	    /// <summary>
        /// Initializes a new instance of the <see cref="T:ThuLaoChamBaiVhuRepeaterDesigner"/> class.
        /// </summary>
		public ThuLaoChamBaiVhuRepeaterDesigner()
		{
		}

        /// <summary>
        /// Initializes the control designer and loads the specified component.
        /// </summary>
        /// <param name="component">The control being designed.</param>
		public override void Initialize(IComponent component)
		{
			if (!(component is ThuLaoChamBaiVhuRepeater))
			{ 
				throw new ArgumentException("Component is not a ThuLaoChamBaiVhuRepeater."); 
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
			ThuLaoChamBaiVhuRepeater z = (ThuLaoChamBaiVhuRepeater)Component;
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
    /// A strongly typed repeater control for the <see cref="ThuLaoChamBaiVhuRepeater"/> Type.
    /// </summary>
	[Designer(typeof(ThuLaoChamBaiVhuRepeaterDesigner))]
	[ParseChildren(true)]
	[ToolboxData("<{0}:ThuLaoChamBaiVhuRepeater runat=\"server\"></{0}:ThuLaoChamBaiVhuRepeater>")]
	public class ThuLaoChamBaiVhuRepeater : CompositeDataBoundControl, System.Web.UI.INamingContainer
	{
	    /// <summary>
        /// Initializes a new instance of the <see cref="T:ThuLaoChamBaiVhuRepeater"/> class.
        /// </summary>
		public ThuLaoChamBaiVhuRepeater()
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
		[TemplateContainer(typeof(ThuLaoChamBaiVhuItem))]
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
		[TemplateContainer(typeof(ThuLaoChamBaiVhuItem))]
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
        [TemplateContainer(typeof(ThuLaoChamBaiVhuItem))]
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
		[TemplateContainer(typeof(ThuLaoChamBaiVhuItem))]
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
		[TemplateContainer(typeof(ThuLaoChamBaiVhuItem))]
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
						PMS.Entities.ThuLaoChamBaiVhu entity = o as PMS.Entities.ThuLaoChamBaiVhu;
						ThuLaoChamBaiVhuItem container = new ThuLaoChamBaiVhuItem(entity);
	
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
	public class ThuLaoChamBaiVhuItem : System.Web.UI.Control, System.Web.UI.INamingContainer
	{
		private PMS.Entities.ThuLaoChamBaiVhu _entity;

        /// <summary>
        /// Initializes a new instance of the <see cref="T:ThuLaoChamBaiVhuItem"/> class.
        /// </summary>
		public ThuLaoChamBaiVhuItem()
			: base()
		{ }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:ThuLaoChamBaiVhuItem"/> class.
        /// </summary>
		public ThuLaoChamBaiVhuItem(PMS.Entities.ThuLaoChamBaiVhu entity)
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
        /// Gets the KyThi
        /// </summary>
        /// <value>The KyThi.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String KyThi
		{
			get { return _entity.KyThi; }
		}
        /// <summary>
        /// Gets the LanThi
        /// </summary>
        /// <value>The LanThi.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String LanThi
		{
			get { return _entity.LanThi; }
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
        /// Gets the KhoaNganh
        /// </summary>
        /// <value>The KhoaNganh.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String KhoaNganh
		{
			get { return _entity.KhoaNganh; }
		}
        /// <summary>
        /// Gets the Nganh
        /// </summary>
        /// <value>The Nganh.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String Nganh
		{
			get { return _entity.Nganh; }
		}
        /// <summary>
        /// Gets the MaHocPhan
        /// </summary>
        /// <value>The MaHocPhan.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String MaHocPhan
		{
			get { return _entity.MaHocPhan; }
		}
        /// <summary>
        /// Gets the TenHocPhan
        /// </summary>
        /// <value>The TenHocPhan.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String TenHocPhan
		{
			get { return _entity.TenHocPhan; }
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
		public System.Int32? SoTinChi
		{
			get { return _entity.SoTinChi; }
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
        /// Gets the LopSinhVien
        /// </summary>
        /// <value>The LopSinhVien.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String LopSinhVien
		{
			get { return _entity.LopSinhVien; }
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
        /// Gets the ThoiGianThi
        /// </summary>
        /// <value>The ThoiGianThi.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String ThoiGianThi
		{
			get { return _entity.ThoiGianThi; }
		}
        /// <summary>
        /// Gets the DinhMucChamGiuaKy
        /// </summary>
        /// <value>The DinhMucChamGiuaKy.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Decimal? DinhMucChamGiuaKy
		{
			get { return _entity.DinhMucChamGiuaKy; }
		}
        /// <summary>
        /// Gets the ThuLaoChamGiuaKy
        /// </summary>
        /// <value>The ThuLaoChamGiuaKy.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Decimal? ThuLaoChamGiuaKy
		{
			get { return _entity.ThuLaoChamGiuaKy; }
		}
        /// <summary>
        /// Gets the DinhMucChamCuoiKy
        /// </summary>
        /// <value>The DinhMucChamCuoiKy.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Decimal? DinhMucChamCuoiKy
		{
			get { return _entity.DinhMucChamCuoiKy; }
		}
        /// <summary>
        /// Gets the ThuLaoChamCuoiKy
        /// </summary>
        /// <value>The ThuLaoChamCuoiKy.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Decimal? ThuLaoChamCuoiKy
		{
			get { return _entity.ThuLaoChamCuoiKy; }
		}
        /// <summary>
        /// Gets the ThanhTienLan1
        /// </summary>
        /// <value>The ThanhTienLan1.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Decimal? ThanhTienLan1
		{
			get { return _entity.ThanhTienLan1; }
		}
        /// <summary>
        /// Gets the ThanhTienLan2
        /// </summary>
        /// <value>The ThanhTienLan2.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Decimal? ThanhTienLan2
		{
			get { return _entity.ThanhTienLan2; }
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
        /// Gets the HinhThucThi
        /// </summary>
        /// <value>The HinhThucThi.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String HinhThucThi
		{
			get { return _entity.HinhThucThi; }
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
        /// Gets the SoTietQuyDoi
        /// </summary>
        /// <value>The SoTietQuyDoi.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Decimal? SoTietQuyDoi
		{
			get { return _entity.SoTietQuyDoi; }
		}
        /// <summary>
        /// Gets the Chot
        /// </summary>
        /// <value>The Chot.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Boolean? Chot
		{
			get { return _entity.Chot; }
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
        /// Gets the SoBaiLan2
        /// </summary>
        /// <value>The SoBaiLan2.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Int32? SoBaiLan2
		{
			get { return _entity.SoBaiLan2; }
		}

        /// <summary>
        /// Gets a <see cref="T:PMS.Entities.ThuLaoChamBaiVhu"></see> object
        /// </summary>
        /// <value></value>
        [System.ComponentModel.Bindable(true)]
        public PMS.Entities.ThuLaoChamBaiVhu Entity
        {
            get { return _entity; }
        }
	}
}