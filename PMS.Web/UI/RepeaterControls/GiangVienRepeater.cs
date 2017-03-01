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
    /// A designer class for a strongly typed repeater <c>GiangVienRepeater</c>
    /// </summary>
	public class GiangVienRepeaterDesigner : System.Web.UI.Design.ControlDesigner
	{
	    /// <summary>
        /// Initializes a new instance of the <see cref="T:GiangVienRepeaterDesigner"/> class.
        /// </summary>
		public GiangVienRepeaterDesigner()
		{
		}

        /// <summary>
        /// Initializes the control designer and loads the specified component.
        /// </summary>
        /// <param name="component">The control being designed.</param>
		public override void Initialize(IComponent component)
		{
			if (!(component is GiangVienRepeater))
			{ 
				throw new ArgumentException("Component is not a GiangVienRepeater."); 
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
			GiangVienRepeater z = (GiangVienRepeater)Component;
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
    /// A strongly typed repeater control for the <see cref="GiangVienRepeater"/> Type.
    /// </summary>
	[Designer(typeof(GiangVienRepeaterDesigner))]
	[ParseChildren(true)]
	[ToolboxData("<{0}:GiangVienRepeater runat=\"server\"></{0}:GiangVienRepeater>")]
	public class GiangVienRepeater : CompositeDataBoundControl, System.Web.UI.INamingContainer
	{
	    /// <summary>
        /// Initializes a new instance of the <see cref="T:GiangVienRepeater"/> class.
        /// </summary>
		public GiangVienRepeater()
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
		[TemplateContainer(typeof(GiangVienItem))]
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
		[TemplateContainer(typeof(GiangVienItem))]
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
        [TemplateContainer(typeof(GiangVienItem))]
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
		[TemplateContainer(typeof(GiangVienItem))]
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
		[TemplateContainer(typeof(GiangVienItem))]
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
						PMS.Entities.GiangVien entity = o as PMS.Entities.GiangVien;
						GiangVienItem container = new GiangVienItem(entity);
	
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
	public class GiangVienItem : System.Web.UI.Control, System.Web.UI.INamingContainer
	{
		private PMS.Entities.GiangVien _entity;

        /// <summary>
        /// Initializes a new instance of the <see cref="T:GiangVienItem"/> class.
        /// </summary>
		public GiangVienItem()
			: base()
		{ }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:GiangVienItem"/> class.
        /// </summary>
		public GiangVienItem(PMS.Entities.GiangVien entity)
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
        /// Gets the MaDanToc
        /// </summary>
        /// <value>The MaDanToc.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String MaDanToc
		{
			get { return _entity.MaDanToc; }
		}
        /// <summary>
        /// Gets the MaTonGiao
        /// </summary>
        /// <value>The MaTonGiao.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String MaTonGiao
		{
			get { return _entity.MaTonGiao; }
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
        /// Gets the MaNguoiLap
        /// </summary>
        /// <value>The MaNguoiLap.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Int32? MaNguoiLap
		{
			get { return _entity.MaNguoiLap; }
		}
        /// <summary>
        /// Gets the MatKhau
        /// </summary>
        /// <value>The MatKhau.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String MatKhau
		{
			get { return _entity.MatKhau; }
		}
        /// <summary>
        /// Gets the MaTinhTrang
        /// </summary>
        /// <value>The MaTinhTrang.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Int32? MaTinhTrang
		{
			get { return _entity.MaTinhTrang; }
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
        /// Gets the TenDem
        /// </summary>
        /// <value>The TenDem.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String TenDem
		{
			get { return _entity.TenDem; }
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
        /// Gets the NgaySinh
        /// </summary>
        /// <value>The NgaySinh.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String NgaySinh
		{
			get { return _entity.NgaySinh; }
		}
        /// <summary>
        /// Gets the GioiTinh
        /// </summary>
        /// <value>The GioiTinh.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Boolean? GioiTinh
		{
			get { return _entity.GioiTinh; }
		}
        /// <summary>
        /// Gets the NoiSinh
        /// </summary>
        /// <value>The NoiSinh.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String NoiSinh
		{
			get { return _entity.NoiSinh; }
		}
        /// <summary>
        /// Gets the Cmnd
        /// </summary>
        /// <value>The Cmnd.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String Cmnd
		{
			get { return _entity.Cmnd; }
		}
        /// <summary>
        /// Gets the NgayCap
        /// </summary>
        /// <value>The NgayCap.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String NgayCap
		{
			get { return _entity.NgayCap; }
		}
        /// <summary>
        /// Gets the NoiCap
        /// </summary>
        /// <value>The NoiCap.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String NoiCap
		{
			get { return _entity.NoiCap; }
		}
        /// <summary>
        /// Gets the DoanDang
        /// </summary>
        /// <value>The DoanDang.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Boolean? DoanDang
		{
			get { return _entity.DoanDang; }
		}
        /// <summary>
        /// Gets the NgayVaoDoanDang
        /// </summary>
        /// <value>The NgayVaoDoanDang.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String NgayVaoDoanDang
		{
			get { return _entity.NgayVaoDoanDang; }
		}
        /// <summary>
        /// Gets the NgayKyHopDong
        /// </summary>
        /// <value>The NgayKyHopDong.</value>
		[System.ComponentModel.Bindable(true)]
		public System.DateTime? NgayKyHopDong
		{
			get { return _entity.NgayKyHopDong; }
		}
        /// <summary>
        /// Gets the NgayKetThucHopDong
        /// </summary>
        /// <value>The NgayKetThucHopDong.</value>
		[System.ComponentModel.Bindable(true)]
		public System.DateTime? NgayKetThucHopDong
		{
			get { return _entity.NgayKetThucHopDong; }
		}
        /// <summary>
        /// Gets the HinhAnh
        /// </summary>
        /// <value>The HinhAnh.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Byte[] HinhAnh
		{
			get { return _entity.HinhAnh; }
		}
        /// <summary>
        /// Gets the DiaChi
        /// </summary>
        /// <value>The DiaChi.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String DiaChi
		{
			get { return _entity.DiaChi; }
		}
        /// <summary>
        /// Gets the ThuongTru
        /// </summary>
        /// <value>The ThuongTru.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String ThuongTru
		{
			get { return _entity.ThuongTru; }
		}
        /// <summary>
        /// Gets the NoiLamViec
        /// </summary>
        /// <value>The NoiLamViec.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String NoiLamViec
		{
			get { return _entity.NoiLamViec; }
		}
        /// <summary>
        /// Gets the Email
        /// </summary>
        /// <value>The Email.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String Email
		{
			get { return _entity.Email; }
		}
        /// <summary>
        /// Gets the DienThoai
        /// </summary>
        /// <value>The DienThoai.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String DienThoai
		{
			get { return _entity.DienThoai; }
		}
        /// <summary>
        /// Gets the SoDiDong
        /// </summary>
        /// <value>The SoDiDong.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String SoDiDong
		{
			get { return _entity.SoDiDong; }
		}
        /// <summary>
        /// Gets the SoTaiKhoan
        /// </summary>
        /// <value>The SoTaiKhoan.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String SoTaiKhoan
		{
			get { return _entity.SoTaiKhoan; }
		}
        /// <summary>
        /// Gets the TenNganHang
        /// </summary>
        /// <value>The TenNganHang.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String TenNganHang
		{
			get { return _entity.TenNganHang; }
		}
        /// <summary>
        /// Gets the MaSoThue
        /// </summary>
        /// <value>The MaSoThue.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String MaSoThue
		{
			get { return _entity.MaSoThue; }
		}
        /// <summary>
        /// Gets the ChiNhanh
        /// </summary>
        /// <value>The ChiNhanh.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String ChiNhanh
		{
			get { return _entity.ChiNhanh; }
		}
        /// <summary>
        /// Gets the SoSoBaoHiem
        /// </summary>
        /// <value>The SoSoBaoHiem.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String SoSoBaoHiem
		{
			get { return _entity.SoSoBaoHiem; }
		}
        /// <summary>
        /// Gets the ThoiGianBatDau
        /// </summary>
        /// <value>The ThoiGianBatDau.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String ThoiGianBatDau
		{
			get { return _entity.ThoiGianBatDau; }
		}
        /// <summary>
        /// Gets the BacLuong
        /// </summary>
        /// <value>The BacLuong.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Decimal? BacLuong
		{
			get { return _entity.BacLuong; }
		}
        /// <summary>
        /// Gets the NgayHuongLuong
        /// </summary>
        /// <value>The NgayHuongLuong.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String NgayHuongLuong
		{
			get { return _entity.NgayHuongLuong; }
		}
        /// <summary>
        /// Gets the NamLamViec
        /// </summary>
        /// <value>The NamLamViec.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String NamLamViec
		{
			get { return _entity.NamLamViec; }
		}
        /// <summary>
        /// Gets the ChuyenNganh
        /// </summary>
        /// <value>The ChuyenNganh.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String ChuyenNganh
		{
			get { return _entity.ChuyenNganh; }
		}
        /// <summary>
        /// Gets the MaHeSoThuLao
        /// </summary>
        /// <value>The MaHeSoThuLao.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String MaHeSoThuLao
		{
			get { return _entity.MaHeSoThuLao; }
		}
        /// <summary>
        /// Gets the Ngach
        /// </summary>
        /// <value>The Ngach.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String Ngach
		{
			get { return _entity.Ngach; }
		}
        /// <summary>
        /// Gets the SoHieuCongChuc
        /// </summary>
        /// <value>The SoHieuCongChuc.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String SoHieuCongChuc
		{
			get { return _entity.SoHieuCongChuc; }
		}
        /// <summary>
        /// Gets the Hrmid
        /// </summary>
        /// <value>The Hrmid.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Guid? Hrmid
		{
			get { return _entity.Hrmid; }
		}
        /// <summary>
        /// Gets the NoiCapBang
        /// </summary>
        /// <value>The NoiCapBang.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String NoiCapBang
		{
			get { return _entity.NoiCapBang; }
		}
        /// <summary>
        /// Gets the KhoaTaiKhoan
        /// </summary>
        /// <value>The KhoaTaiKhoan.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Boolean? KhoaTaiKhoan
		{
			get { return _entity.KhoaTaiKhoan; }
		}
        /// <summary>
        /// Gets the MaLoaiNhanVien
        /// </summary>
        /// <value>The MaLoaiNhanVien.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Int32? MaLoaiNhanVien
		{
			get { return _entity.MaLoaiNhanVien; }
		}
        /// <summary>
        /// Gets the MaNgachCongChuc
        /// </summary>
        /// <value>The MaNgachCongChuc.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Int32? MaNgachCongChuc
		{
			get { return _entity.MaNgachCongChuc; }
		}
        /// <summary>
        /// Gets the MaTrinhDoChinhTri
        /// </summary>
        /// <value>The MaTrinhDoChinhTri.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Int32? MaTrinhDoChinhTri
		{
			get { return _entity.MaTrinhDoChinhTri; }
		}
        /// <summary>
        /// Gets the MaTrinhDoSuPham
        /// </summary>
        /// <value>The MaTrinhDoSuPham.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Int32? MaTrinhDoSuPham
		{
			get { return _entity.MaTrinhDoSuPham; }
		}
        /// <summary>
        /// Gets the MaTrinhDoNgoaiNgu
        /// </summary>
        /// <value>The MaTrinhDoNgoaiNgu.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Int32? MaTrinhDoNgoaiNgu
		{
			get { return _entity.MaTrinhDoNgoaiNgu; }
		}
        /// <summary>
        /// Gets the MaTrinhDoTinHoc
        /// </summary>
        /// <value>The MaTrinhDoTinHoc.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Int32? MaTrinhDoTinHoc
		{
			get { return _entity.MaTrinhDoTinHoc; }
		}
        /// <summary>
        /// Gets the MaTrinhDoQuanLyNhaNuoc
        /// </summary>
        /// <value>The MaTrinhDoQuanLyNhaNuoc.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Int32? MaTrinhDoQuanLyNhaNuoc
		{
			get { return _entity.MaTrinhDoQuanLyNhaNuoc; }
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
        /// Gets the NgayCapNhat
        /// </summary>
        /// <value>The NgayCapNhat.</value>
		[System.ComponentModel.Bindable(true)]
		public System.DateTime? NgayCapNhat
		{
			get { return _entity.NgayCapNhat; }
		}
        /// <summary>
        /// Gets the KhoiKienThucGiangDay
        /// </summary>
        /// <value>The KhoiKienThucGiangDay.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String KhoiKienThucGiangDay
		{
			get { return _entity.KhoiKienThucGiangDay; }
		}
        /// <summary>
        /// Gets the NganhDaoTao
        /// </summary>
        /// <value>The NganhDaoTao.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String NganhDaoTao
		{
			get { return _entity.NganhDaoTao; }
		}
        /// <summary>
        /// Gets the DonViGiangDay
        /// </summary>
        /// <value>The DonViGiangDay.</value>
		[System.ComponentModel.Bindable(true)]
		public System.String DonViGiangDay
		{
			get { return _entity.DonViGiangDay; }
		}
        /// <summary>
        /// Gets the IdHoSo
        /// </summary>
        /// <value>The IdHoSo.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Int32? IdHoSo
		{
			get { return _entity.IdHoSo; }
		}
        /// <summary>
        /// Gets the MaQuocTich
        /// </summary>
        /// <value>The MaQuocTich.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Int32? MaQuocTich
		{
			get { return _entity.MaQuocTich; }
		}
        /// <summary>
        /// Gets the DaXoaHrm
        /// </summary>
        /// <value>The DaXoaHrm.</value>
		[System.ComponentModel.Bindable(true)]
		public System.Boolean? DaXoaHrm
		{
			get { return _entity.DaXoaHrm; }
		}

        /// <summary>
        /// Gets a <see cref="T:PMS.Entities.GiangVien"></see> object
        /// </summary>
        /// <value></value>
        [System.ComponentModel.Bindable(true)]
        public PMS.Entities.GiangVien Entity
        {
            get { return _entity; }
        }
	}
}
