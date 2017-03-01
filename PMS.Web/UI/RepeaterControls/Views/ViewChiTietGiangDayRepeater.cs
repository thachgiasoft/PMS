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
    /// A designer class for a strongly typed repeater <c>ViewChiTietGiangDayRepeater</c>
    /// </summary>
	public class ViewChiTietGiangDayRepeaterDesigner : System.Web.UI.Design.ControlDesigner
	{
	    /// <summary>
        /// Initializes a new instance of the <see cref="T:ViewChiTietGiangDayRepeaterDesigner"/> class.
        /// </summary>
		public ViewChiTietGiangDayRepeaterDesigner()
		{
		}

        /// <summary>
        /// Initializes the control designer and loads the specified component.
        /// </summary>
        /// <param name="component">The control being designed.</param>
		public override void Initialize(IComponent component)
		{
			if (!(component is ViewChiTietGiangDayRepeater))
			{ 
				throw new ArgumentException("Component is not a ViewChiTietGiangDayRepeater."); 
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
			ViewChiTietGiangDayRepeater z = (ViewChiTietGiangDayRepeater)Component;
			z.DataBind();

			return base.GetDesignTimeHtml();
		}
	}

    /// <summary>
    /// A strongly typed repeater control for the <see cref="ViewChiTietGiangDayRepeater"/> Type.
    /// </summary>
	[Designer(typeof(ViewChiTietGiangDayRepeaterDesigner))]
	[ParseChildren(true)]
	[ToolboxData("<{0}:ViewChiTietGiangDayRepeater runat=\"server\"></{0}:ViewChiTietGiangDayRepeater>")]
	public class ViewChiTietGiangDayRepeater : CompositeDataBoundControl, System.Web.UI.INamingContainer
	{
	    /// <summary>
        /// Initializes a new instance of the <see cref="T:ViewChiTietGiangDayRepeater"/> class.
        /// </summary>
		public ViewChiTietGiangDayRepeater()
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
		[TemplateContainer(typeof(ViewChiTietGiangDayItem))]
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
		[TemplateContainer(typeof(ViewChiTietGiangDayItem))]
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
        [TemplateContainer(typeof(ViewChiTietGiangDayItem))]
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
		[TemplateContainer(typeof(ViewChiTietGiangDayItem))]
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
		[TemplateContainer(typeof(ViewChiTietGiangDayItem))]
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
						PMS.Entities.ViewChiTietGiangDay entity = o as PMS.Entities.ViewChiTietGiangDay;
						ViewChiTietGiangDayItem container = new ViewChiTietGiangDayItem(entity);
	
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
	public class ViewChiTietGiangDayItem : System.Web.UI.Control, System.Web.UI.INamingContainer
	{
		private PMS.Entities.ViewChiTietGiangDay _entity;

        /// <summary>
        /// Initializes a new instance of the <see cref="T:ViewChiTietGiangDayItem"/> class.
        /// </summary>
		public ViewChiTietGiangDayItem()
			: base()
		{ }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:ViewChiTietGiangDayItem"/> class.
        /// </summary>
		public ViewChiTietGiangDayItem(PMS.Entities.ViewChiTietGiangDay entity)
			: base()
		{
			_entity = entity;
		}
		
        /// <summary>
        /// Gets the MaLichHoc
        /// </summary>
        /// <value>The MaLichHoc.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Int32 MaLichHoc
		{
			get { return _entity.MaLichHoc; }
		}
        /// <summary>
        /// Gets the MaGiangVien
        /// </summary>
        /// <value>The MaGiangVien.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String MaGiangVien
		{
			get { return _entity.MaGiangVien; }
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
        /// Gets the Nam
        /// </summary>
        /// <value>The Nam.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Int32? Nam
		{
			get { return _entity.Nam; }
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
        /// Gets the MaPhong
        /// </summary>
        /// <value>The MaPhong.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String MaPhong
		{
			get { return _entity.MaPhong; }
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
        /// Gets the MaBuoiHoc
        /// </summary>
        /// <value>The MaBuoiHoc.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Int32? MaBuoiHoc
		{
			get { return _entity.MaBuoiHoc; }
		}
        /// <summary>
        /// Gets the MaKhoaHoc
        /// </summary>
        /// <value>The MaKhoaHoc.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String MaKhoaHoc
		{
			get { return _entity.MaKhoaHoc; }
		}
        /// <summary>
        /// Gets the TietBatDau
        /// </summary>
        /// <value>The TietBatDau.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Int32? TietBatDau
		{
			get { return _entity.TietBatDau; }
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
        /// Gets the SoTiet
        /// </summary>
        /// <value>The SoTiet.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Int32? SoTiet
		{
			get { return _entity.SoTiet; }
		}
        /// <summary>
        /// Gets the TinhTrang
        /// </summary>
        /// <value>The TinhTrang.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Int32 TinhTrang
		{
			get { return _entity.TinhTrang; }
		}

	}
}
