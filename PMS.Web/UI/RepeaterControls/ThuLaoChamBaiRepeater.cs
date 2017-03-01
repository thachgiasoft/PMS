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
    /// A designer class for a strongly typed repeater <c>ThuLaoChamBaiRepeater</c>
    /// </summary>
	public class ThuLaoChamBaiRepeaterDesigner : System.Web.UI.Design.ControlDesigner
	{
	    /// <summary>
        /// Initializes a new instance of the <see cref="T:ThuLaoChamBaiRepeaterDesigner"/> class.
        /// </summary>
		public ThuLaoChamBaiRepeaterDesigner()
		{
		}

        /// <summary>
        /// Initializes the control designer and loads the specified component.
        /// </summary>
        /// <param name="component">The control being designed.</param>
		public override void Initialize(IComponent component)
		{
			if (!(component is ThuLaoChamBaiRepeater))
			{ 
				throw new ArgumentException("Component is not a ThuLaoChamBaiRepeater."); 
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
			ThuLaoChamBaiRepeater z = (ThuLaoChamBaiRepeater)Component;
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
    /// A strongly typed repeater control for the <see cref="ThuLaoChamBaiRepeater"/> Type.
    /// </summary>
	[Designer(typeof(ThuLaoChamBaiRepeaterDesigner))]
	[ParseChildren(true)]
	[ToolboxData("<{0}:ThuLaoChamBaiRepeater runat=\"server\"></{0}:ThuLaoChamBaiRepeater>")]
	public class ThuLaoChamBaiRepeater : CompositeDataBoundControl, System.Web.UI.INamingContainer
	{
	    /// <summary>
        /// Initializes a new instance of the <see cref="T:ThuLaoChamBaiRepeater"/> class.
        /// </summary>
		public ThuLaoChamBaiRepeater()
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
		[TemplateContainer(typeof(ThuLaoChamBaiItem))]
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
		[TemplateContainer(typeof(ThuLaoChamBaiItem))]
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
        [TemplateContainer(typeof(ThuLaoChamBaiItem))]
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
		[TemplateContainer(typeof(ThuLaoChamBaiItem))]
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
		[TemplateContainer(typeof(ThuLaoChamBaiItem))]
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
						PMS.Entities.ThuLaoChamBai entity = o as PMS.Entities.ThuLaoChamBai;
						ThuLaoChamBaiItem container = new ThuLaoChamBaiItem(entity);
	
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
	public class ThuLaoChamBaiItem : System.Web.UI.Control, System.Web.UI.INamingContainer
	{
		private PMS.Entities.ThuLaoChamBai _entity;

        /// <summary>
        /// Initializes a new instance of the <see cref="T:ThuLaoChamBaiItem"/> class.
        /// </summary>
		public ThuLaoChamBaiItem()
			: base()
		{ }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:ThuLaoChamBaiItem"/> class.
        /// </summary>
		public ThuLaoChamBaiItem(PMS.Entities.ThuLaoChamBai entity)
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
        /// Gets the MaGiangVienQuanLy
        /// </summary>
        /// <value>The MaGiangVienQuanLy.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String MaGiangVienQuanLy
		{
			get { return _entity.MaGiangVienQuanLy; }
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
        /// Gets the MaHocPhan
        /// </summary>
        /// <value>The MaHocPhan.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String MaHocPhan
		{
			get { return _entity.MaHocPhan; }
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
        /// Gets the LanThi
        /// </summary>
        /// <value>The LanThi.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String LanThi
		{
			get { return _entity.LanThi; }
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
        /// Gets the SoBaiGiuaKy
        /// </summary>
        /// <value>The SoBaiGiuaKy.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Int32? SoBaiGiuaKy
		{
			get { return _entity.SoBaiGiuaKy; }
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
        /// Gets the SoBaiCuoiKy
        /// </summary>
        /// <value>The SoBaiCuoiKy.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Int32? SoBaiCuoiKy
		{
			get { return _entity.SoBaiCuoiKy; }
		}
        /// <summary>
        /// Gets the DonGiaGiuaKy
        /// </summary>
        /// <value>The DonGiaGiuaKy.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Decimal? DonGiaGiuaKy
		{
			get { return _entity.DonGiaGiuaKy; }
		}
        /// <summary>
        /// Gets the DonGiaQuaTrinh
        /// </summary>
        /// <value>The DonGiaQuaTrinh.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Decimal? DonGiaQuaTrinh
		{
			get { return _entity.DonGiaQuaTrinh; }
		}
        /// <summary>
        /// Gets the DonGiaCuoiKy
        /// </summary>
        /// <value>The DonGiaCuoiKy.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Decimal? DonGiaCuoiKy
		{
			get { return _entity.DonGiaCuoiKy; }
		}
        /// <summary>
        /// Gets the TienGiuaKy
        /// </summary>
        /// <value>The TienGiuaKy.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Decimal? TienGiuaKy
		{
			get { return _entity.TienGiuaKy; }
		}
        /// <summary>
        /// Gets the TienQuaTrinh
        /// </summary>
        /// <value>The TienQuaTrinh.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Decimal? TienQuaTrinh
		{
			get { return _entity.TienQuaTrinh; }
		}
        /// <summary>
        /// Gets the TienCuoiKy
        /// </summary>
        /// <value>The TienCuoiKy.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Decimal? TienCuoiKy
		{
			get { return _entity.TienCuoiKy; }
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
        /// Gets the Thue
        /// </summary>
        /// <value>The Thue.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Decimal? Thue
		{
			get { return _entity.Thue; }
		}
        /// <summary>
        /// Gets the ThucLanh
        /// </summary>
        /// <value>The ThucLanh.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Decimal? ThucLanh
		{
			get { return _entity.ThucLanh; }
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
        /// Gets the DotChiTra
        /// </summary>
        /// <value>The DotChiTra.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String DotChiTra
		{
			get { return _entity.DotChiTra; }
		}
        /// <summary>
        /// Gets the IsSync
        /// </summary>
        /// <value>The IsSync.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Boolean? IsSync
		{
			get { return _entity.IsSync; }
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
        /// Gets the MaBacDaoTao
        /// </summary>
        /// <value>The MaBacDaoTao.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String MaBacDaoTao
		{
			get { return _entity.MaBacDaoTao; }
		}
        /// <summary>
        /// Gets the MucChi
        /// </summary>
        /// <value>The MucChi.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String MucChi
		{
			get { return _entity.MucChi; }
		}
        /// <summary>
        /// Gets the MaHinhThucThi
        /// </summary>
        /// <value>The MaHinhThucThi.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String MaHinhThucThi
		{
			get { return _entity.MaHinhThucThi; }
		}

        /// <summary>
        /// Gets a <see cref="T:PMS.Entities.ThuLaoChamBai"></see> object
        /// </summary>
        /// <value></value>
        [System.ComponentModel.Bindable(true)]
        public PMS.Entities.ThuLaoChamBai Entity
        {
            get { return _entity; }
        }
	}
}
