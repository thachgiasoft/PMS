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
    /// A designer class for a strongly typed repeater <c>ViewTongHopQuyDoiRepeater</c>
    /// </summary>
	public class ViewTongHopQuyDoiRepeaterDesigner : System.Web.UI.Design.ControlDesigner
	{
	    /// <summary>
        /// Initializes a new instance of the <see cref="T:ViewTongHopQuyDoiRepeaterDesigner"/> class.
        /// </summary>
		public ViewTongHopQuyDoiRepeaterDesigner()
		{
		}

        /// <summary>
        /// Initializes the control designer and loads the specified component.
        /// </summary>
        /// <param name="component">The control being designed.</param>
		public override void Initialize(IComponent component)
		{
			if (!(component is ViewTongHopQuyDoiRepeater))
			{ 
				throw new ArgumentException("Component is not a ViewTongHopQuyDoiRepeater."); 
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
			ViewTongHopQuyDoiRepeater z = (ViewTongHopQuyDoiRepeater)Component;
			z.DataBind();

			return base.GetDesignTimeHtml();
		}
	}

    /// <summary>
    /// A strongly typed repeater control for the <see cref="ViewTongHopQuyDoiRepeater"/> Type.
    /// </summary>
	[Designer(typeof(ViewTongHopQuyDoiRepeaterDesigner))]
	[ParseChildren(true)]
	[ToolboxData("<{0}:ViewTongHopQuyDoiRepeater runat=\"server\"></{0}:ViewTongHopQuyDoiRepeater>")]
	public class ViewTongHopQuyDoiRepeater : CompositeDataBoundControl, System.Web.UI.INamingContainer
	{
	    /// <summary>
        /// Initializes a new instance of the <see cref="T:ViewTongHopQuyDoiRepeater"/> class.
        /// </summary>
		public ViewTongHopQuyDoiRepeater()
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
		[TemplateContainer(typeof(ViewTongHopQuyDoiItem))]
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
		[TemplateContainer(typeof(ViewTongHopQuyDoiItem))]
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
        [TemplateContainer(typeof(ViewTongHopQuyDoiItem))]
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
		[TemplateContainer(typeof(ViewTongHopQuyDoiItem))]
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
		[TemplateContainer(typeof(ViewTongHopQuyDoiItem))]
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
						PMS.Entities.ViewTongHopQuyDoi entity = o as PMS.Entities.ViewTongHopQuyDoi;
						ViewTongHopQuyDoiItem container = new ViewTongHopQuyDoiItem(entity);
	
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
	public class ViewTongHopQuyDoiItem : System.Web.UI.Control, System.Web.UI.INamingContainer
	{
		private PMS.Entities.ViewTongHopQuyDoi _entity;

        /// <summary>
        /// Initializes a new instance of the <see cref="T:ViewTongHopQuyDoiItem"/> class.
        /// </summary>
		public ViewTongHopQuyDoiItem()
			: base()
		{ }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:ViewTongHopQuyDoiItem"/> class.
        /// </summary>
		public ViewTongHopQuyDoiItem(PMS.Entities.ViewTongHopQuyDoi entity)
			: base()
		{
			_entity = entity;
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
        /// Gets the TenKhoa
        /// </summary>
        /// <value>The TenKhoa.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String TenKhoa
		{
			get { return _entity.TenKhoa; }
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
        /// Gets the SoTiet1
        /// </summary>
        /// <value>The SoTiet1.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Decimal? SoTiet1
		{
			get { return _entity.SoTiet1; }
		}
        /// <summary>
        /// Gets the TietDoAn1
        /// </summary>
        /// <value>The TietDoAn1.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Decimal? TietDoAn1
		{
			get { return _entity.TietDoAn1; }
		}
        /// <summary>
        /// Gets the SoTiet2
        /// </summary>
        /// <value>The SoTiet2.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Decimal? SoTiet2
		{
			get { return _entity.SoTiet2; }
		}
        /// <summary>
        /// Gets the TietDoAn2
        /// </summary>
        /// <value>The TietDoAn2.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Decimal? TietDoAn2
		{
			get { return _entity.TietDoAn2; }
		}
        /// <summary>
        /// Gets the TietLyThuyet
        /// </summary>
        /// <value>The TietLyThuyet.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Decimal? TietLyThuyet
		{
			get { return _entity.TietLyThuyet; }
		}
        /// <summary>
        /// Gets the TietThucHanh
        /// </summary>
        /// <value>The TietThucHanh.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Decimal? TietThucHanh
		{
			get { return _entity.TietThucHanh; }
		}
        /// <summary>
        /// Gets the TietThiNghiem
        /// </summary>
        /// <value>The TietThiNghiem.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Decimal? TietThiNghiem
		{
			get { return _entity.TietThiNghiem; }
		}
        /// <summary>
        /// Gets the TietThucTap
        /// </summary>
        /// <value>The TietThucTap.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Decimal? TietThucTap
		{
			get { return _entity.TietThucTap; }
		}
        /// <summary>
        /// Gets the TietDoAn
        /// </summary>
        /// <value>The TietDoAn.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Decimal? TietDoAn
		{
			get { return _entity.TietDoAn; }
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

	}
}