#region Using Directives
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Web.UI;
using System.Web.UI.Design;

using PMS.Entities;
using PMS.Data;
using PMS.Data.Bases;
using PMS.Services;
#endregion

namespace PMS.Web.Data
{
	/// <summary>
	/// Represents the DataRepository.GiangVienProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(GiangVienDataSourceDesigner))]
	public class GiangVienDataSource : ProviderDataSource<GiangVien, GiangVienKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GiangVienDataSource class.
		/// </summary>
		public GiangVienDataSource() : base(new GiangVienService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the GiangVienDataSourceView used by the GiangVienDataSource.
		/// </summary>
		protected GiangVienDataSourceView GiangVienView
		{
			get { return ( View as GiangVienDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the GiangVienDataSource control invokes to retrieve data.
		/// </summary>
		public GiangVienSelectMethod SelectMethod
		{
			get
			{
				GiangVienSelectMethod selectMethod = GiangVienSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (GiangVienSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the GiangVienDataSourceView class that is to be
		/// used by the GiangVienDataSource.
		/// </summary>
		/// <returns>An instance of the GiangVienDataSourceView class.</returns>
		protected override BaseDataSourceView<GiangVien, GiangVienKey> GetNewDataSourceView()
		{
			return new GiangVienDataSourceView(this, DefaultViewName);
		}
		
		/// <summary>
        /// Creates a cache hashing key based on the startIndex, pageSize and the SelectMethod being used.
        /// </summary>
        /// <param name="startIndex">The current start row index.</param>
        /// <param name="pageSize">The current page size.</param>
        /// <returns>A string that can be used as a key for caching purposes.</returns>
		protected override string CacheHashKey(int startIndex, int pageSize)
        {
			return String.Format("{0}:{1}:{2}", SelectMethod, startIndex, pageSize);
        }
		
		#endregion Methods
	}
	
	/// <summary>
	/// Supports the GiangVienDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class GiangVienDataSourceView : ProviderDataSourceView<GiangVien, GiangVienKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GiangVienDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the GiangVienDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public GiangVienDataSourceView(GiangVienDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal GiangVienDataSource GiangVienOwner
		{
			get { return Owner as GiangVienDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal GiangVienSelectMethod SelectMethod
		{
			get { return GiangVienOwner.SelectMethod; }
			set { GiangVienOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal GiangVienService GiangVienProvider
		{
			get { return Provider as GiangVienService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<GiangVien> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<GiangVien> results = null;
			GiangVien item;
			count = 0;
			
			System.String _maQuanLy;
			System.Int32 _maGiangVien;
			System.Int32? _maHocHam_nullable;
			System.Int32? _maHocVi_nullable;
			System.Int32? _maLoaiGiangVien_nullable;
			System.Int32? _maLoaiNhanVien_nullable;
			System.Int32? _maNgachCongChuc_nullable;
			System.Int32? _maNguoiLap_nullable;
			System.Int32? _maTinhTrang_nullable;
			System.Int32? _maTrinhDoChinhTri_nullable;
			System.Int32? _maTrinhDoNgoaiNgu_nullable;
			System.Int32? _maTrinhDoQuanLyNhaNuoc_nullable;
			System.Int32? _maTrinhDoSuPham_nullable;
			System.Int32? _maTrinhDoTinHoc_nullable;
			System.Int32 _maHoSo;
			System.String sp2239_MaDonVi;
			System.Int32 sp2239_MaTinhTrang;
			System.String sp2228_NhomQuyen;
			System.String sp2225_MaDonVi;
			System.String sp2237_MaDonVi;
			System.Int32 sp2237_MaHocHam;
			System.Int32 sp2237_MaHocVi;
			System.String sp2238_MaDonVi;
			System.Int32 sp2238_MaHocHam;
			System.Int32 sp2238_MaHocVi;
			System.String sp2238_MaTinhTrang;

			switch ( SelectMethod )
			{
				case GiangVienSelectMethod.Get:
					GiangVienKey entityKey  = new GiangVienKey();
					entityKey.Load(values);
					item = GiangVienProvider.Get(entityKey);
					results = new TList<GiangVien>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case GiangVienSelectMethod.GetAll:
                    results = GiangVienProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case GiangVienSelectMethod.GetPaged:
					results = GiangVienProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case GiangVienSelectMethod.Find:
					if ( FilterParameters != null )
						results = GiangVienProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = GiangVienProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case GiangVienSelectMethod.GetByMaGiangVien:
					_maGiangVien = ( values["MaGiangVien"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["MaGiangVien"], typeof(System.Int32)) : (int)0;
					item = GiangVienProvider.GetByMaGiangVien(_maGiangVien);
					results = new TList<GiangVien>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				// IX
				case GiangVienSelectMethod.GetByMaQuanLy:
					_maQuanLy = ( values["MaQuanLy"] != null ) ? (System.String) EntityUtil.ChangeType(values["MaQuanLy"], typeof(System.String)) : string.Empty;
					results = GiangVienProvider.GetByMaQuanLy(_maQuanLy, this.StartIndex, this.PageSize, out count);
					break;
				// FK
				case GiangVienSelectMethod.GetByMaHocHam:
					_maHocHam_nullable = (System.Int32?) EntityUtil.ChangeType(values["MaHocHam"], typeof(System.Int32?));
					results = GiangVienProvider.GetByMaHocHam(_maHocHam_nullable, this.StartIndex, this.PageSize, out count);
					break;
				case GiangVienSelectMethod.GetByMaHocVi:
					_maHocVi_nullable = (System.Int32?) EntityUtil.ChangeType(values["MaHocVi"], typeof(System.Int32?));
					results = GiangVienProvider.GetByMaHocVi(_maHocVi_nullable, this.StartIndex, this.PageSize, out count);
					break;
				case GiangVienSelectMethod.GetByMaLoaiGiangVien:
					_maLoaiGiangVien_nullable = (System.Int32?) EntityUtil.ChangeType(values["MaLoaiGiangVien"], typeof(System.Int32?));
					results = GiangVienProvider.GetByMaLoaiGiangVien(_maLoaiGiangVien_nullable, this.StartIndex, this.PageSize, out count);
					break;
				case GiangVienSelectMethod.GetByMaLoaiNhanVien:
					_maLoaiNhanVien_nullable = (System.Int32?) EntityUtil.ChangeType(values["MaLoaiNhanVien"], typeof(System.Int32?));
					results = GiangVienProvider.GetByMaLoaiNhanVien(_maLoaiNhanVien_nullable, this.StartIndex, this.PageSize, out count);
					break;
				case GiangVienSelectMethod.GetByMaNgachCongChuc:
					_maNgachCongChuc_nullable = (System.Int32?) EntityUtil.ChangeType(values["MaNgachCongChuc"], typeof(System.Int32?));
					results = GiangVienProvider.GetByMaNgachCongChuc(_maNgachCongChuc_nullable, this.StartIndex, this.PageSize, out count);
					break;
				case GiangVienSelectMethod.GetByMaNguoiLap:
					_maNguoiLap_nullable = (System.Int32?) EntityUtil.ChangeType(values["MaNguoiLap"], typeof(System.Int32?));
					results = GiangVienProvider.GetByMaNguoiLap(_maNguoiLap_nullable, this.StartIndex, this.PageSize, out count);
					break;
				case GiangVienSelectMethod.GetByMaTinhTrang:
					_maTinhTrang_nullable = (System.Int32?) EntityUtil.ChangeType(values["MaTinhTrang"], typeof(System.Int32?));
					results = GiangVienProvider.GetByMaTinhTrang(_maTinhTrang_nullable, this.StartIndex, this.PageSize, out count);
					break;
				case GiangVienSelectMethod.GetByMaTrinhDoChinhTri:
					_maTrinhDoChinhTri_nullable = (System.Int32?) EntityUtil.ChangeType(values["MaTrinhDoChinhTri"], typeof(System.Int32?));
					results = GiangVienProvider.GetByMaTrinhDoChinhTri(_maTrinhDoChinhTri_nullable, this.StartIndex, this.PageSize, out count);
					break;
				case GiangVienSelectMethod.GetByMaTrinhDoNgoaiNgu:
					_maTrinhDoNgoaiNgu_nullable = (System.Int32?) EntityUtil.ChangeType(values["MaTrinhDoNgoaiNgu"], typeof(System.Int32?));
					results = GiangVienProvider.GetByMaTrinhDoNgoaiNgu(_maTrinhDoNgoaiNgu_nullable, this.StartIndex, this.PageSize, out count);
					break;
				case GiangVienSelectMethod.GetByMaTrinhDoQuanLyNhaNuoc:
					_maTrinhDoQuanLyNhaNuoc_nullable = (System.Int32?) EntityUtil.ChangeType(values["MaTrinhDoQuanLyNhaNuoc"], typeof(System.Int32?));
					results = GiangVienProvider.GetByMaTrinhDoQuanLyNhaNuoc(_maTrinhDoQuanLyNhaNuoc_nullable, this.StartIndex, this.PageSize, out count);
					break;
				case GiangVienSelectMethod.GetByMaTrinhDoSuPham:
					_maTrinhDoSuPham_nullable = (System.Int32?) EntityUtil.ChangeType(values["MaTrinhDoSuPham"], typeof(System.Int32?));
					results = GiangVienProvider.GetByMaTrinhDoSuPham(_maTrinhDoSuPham_nullable, this.StartIndex, this.PageSize, out count);
					break;
				case GiangVienSelectMethod.GetByMaTrinhDoTinHoc:
					_maTrinhDoTinHoc_nullable = (System.Int32?) EntityUtil.ChangeType(values["MaTrinhDoTinHoc"], typeof(System.Int32?));
					results = GiangVienProvider.GetByMaTrinhDoTinHoc(_maTrinhDoTinHoc_nullable, this.StartIndex, this.PageSize, out count);
					break;
				// M:M
				case GiangVienSelectMethod.GetByMaHoSoFromGiangVienHoSo:
					_maHoSo = ( values["MaHoSo"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["MaHoSo"], typeof(System.Int32)) : (int)0;
					results = GiangVienProvider.GetByMaHoSoFromGiangVienHoSo(_maHoSo, this.StartIndex, this.PageSize, out count);
					break;
				// Custom
				case GiangVienSelectMethod.GetMaDonViMaTinhTrang:
					sp2239_MaDonVi = (System.String) EntityUtil.ChangeType(values["MaDonVi"], typeof(System.String));
					sp2239_MaTinhTrang = (System.Int32) EntityUtil.ChangeType(values["MaTinhTrang"], typeof(System.Int32));
					results = GiangVienProvider.GetMaDonViMaTinhTrang(sp2239_MaDonVi, sp2239_MaTinhTrang, StartIndex, PageSize);
					break;
				case GiangVienSelectMethod.GetByNhomQuyen:
					sp2228_NhomQuyen = (System.String) EntityUtil.ChangeType(values["NhomQuyen"], typeof(System.String));
					results = GiangVienProvider.GetByNhomQuyen(sp2228_NhomQuyen, StartIndex, PageSize);
					break;
				case GiangVienSelectMethod.GetByMaDonVi:
					sp2225_MaDonVi = (System.String) EntityUtil.ChangeType(values["MaDonVi"], typeof(System.String));
					results = GiangVienProvider.GetByMaDonVi(sp2225_MaDonVi, StartIndex, PageSize);
					break;
				case GiangVienSelectMethod.GetMaDonViMaHocHamMaHocVi:
					sp2237_MaDonVi = (System.String) EntityUtil.ChangeType(values["MaDonVi"], typeof(System.String));
					sp2237_MaHocHam = (System.Int32) EntityUtil.ChangeType(values["MaHocHam"], typeof(System.Int32));
					sp2237_MaHocVi = (System.Int32) EntityUtil.ChangeType(values["MaHocVi"], typeof(System.Int32));
					results = GiangVienProvider.GetMaDonViMaHocHamMaHocVi(sp2237_MaDonVi, sp2237_MaHocHam, sp2237_MaHocVi, StartIndex, PageSize);
					break;
				case GiangVienSelectMethod.GetMaDonViMaHocHamMaHocViMaTinhTrang:
					sp2238_MaDonVi = (System.String) EntityUtil.ChangeType(values["MaDonVi"], typeof(System.String));
					sp2238_MaHocHam = (System.Int32) EntityUtil.ChangeType(values["MaHocHam"], typeof(System.Int32));
					sp2238_MaHocVi = (System.Int32) EntityUtil.ChangeType(values["MaHocVi"], typeof(System.Int32));
					sp2238_MaTinhTrang = (System.String) EntityUtil.ChangeType(values["MaTinhTrang"], typeof(System.String));
					results = GiangVienProvider.GetMaDonViMaHocHamMaHocViMaTinhTrang(sp2238_MaDonVi, sp2238_MaHocHam, sp2238_MaHocVi, sp2238_MaTinhTrang, StartIndex, PageSize);
					break;
				default:
					break;
			}

			if ( results != null && count < 1 )
			{
				count = results.Count;

				if ( !String.IsNullOrEmpty(CustomMethodRecordCountParamName) )
				{
					object objCustomCount = EntityUtil.ChangeType(customOutput[CustomMethodRecordCountParamName], typeof(Int32));
					
					if ( objCustomCount != null )
					{
						count = (int) objCustomCount;
					}
				}
			}
			
			return results;
		}
		
		/// <summary>
		/// Gets the values of any supplied parameters for internal caching.
		/// </summary>
		/// <param name="values">An IDictionary object of name/value pairs.</param>
		protected override void GetSelectParameters(IDictionary values)
		{
			if ( SelectMethod == GiangVienSelectMethod.Get || SelectMethod == GiangVienSelectMethod.GetByMaGiangVien )
			{
				EntityId = GetEntityKey(values);
			}
		}

		/// <summary>
		/// Performs a DeepLoad operation for the current entity if it has
		/// not already been performed.
		/// </summary>
		internal override void DeepLoad()
		{
			if ( !IsDeepLoaded )
			{
				GiangVien entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					GiangVienProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
					// set loaded flag
					IsDeepLoaded = true;
				}
			}
		}

		/// <summary>
		/// Performs a DeepLoad operation on the specified entity collection.
		/// </summary>
		/// <param name="entityList"></param>
		/// <param name="properties"></param>
		internal override void DeepLoad(TList<GiangVien> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			GiangVienProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region GiangVienDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the GiangVienDataSource class.
	/// </summary>
	public class GiangVienDataSourceDesigner : ProviderDataSourceDesigner<GiangVien, GiangVienKey>
	{
		/// <summary>
		/// Initializes a new instance of the GiangVienDataSourceDesigner class.
		/// </summary>
		public GiangVienDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public GiangVienSelectMethod SelectMethod
		{
			get { return ((GiangVienDataSource) DataSource).SelectMethod; }
			set { SetPropertyValue("SelectMethod", value); }
		}

		/// <summary>Gets the designer action list collection for this designer.</summary>
		/// <returns>The <see cref="T:System.ComponentModel.Design.DesignerActionListCollection"/>
		/// associated with this designer.</returns>
		public override DesignerActionListCollection ActionLists
		{
			get
			{
				DesignerActionListCollection actions = new DesignerActionListCollection();
				actions.Add(new GiangVienDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region GiangVienDataSourceActionList

	/// <summary>
	/// Supports the GiangVienDataSourceDesigner class.
	/// </summary>
	internal class GiangVienDataSourceActionList : DesignerActionList
	{
		private GiangVienDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the GiangVienDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public GiangVienDataSourceActionList(GiangVienDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public GiangVienSelectMethod SelectMethod
		{
			get { return _designer.SelectMethod; }
			set { _designer.SelectMethod = value; }
		}

		/// <summary>
		/// Returns the collection of <see cref="T:System.ComponentModel.Design.DesignerActionItem"/>
		/// objects contained in the list.
		/// </summary>
		/// <returns>A <see cref="T:System.ComponentModel.Design.DesignerActionItem"/>
		/// array that contains the items in this list.</returns>
		public override DesignerActionItemCollection GetSortedActionItems()
		{
			DesignerActionItemCollection items = new DesignerActionItemCollection();
			items.Add(new DesignerActionPropertyItem("SelectMethod", "Select Method", "Methods"));
			return items;
		}
	}

	#endregion GiangVienDataSourceActionList
	
	#endregion GiangVienDataSourceDesigner
	
	#region GiangVienSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the GiangVienDataSource.SelectMethod property.
	/// </summary>
	public enum GiangVienSelectMethod
	{
		/// <summary>
		/// Represents the Get method.
		/// </summary>
		Get,
		/// <summary>
		/// Represents the GetAll method.
		/// </summary>
		GetAll,
		/// <summary>
		/// Represents the GetPaged method.
		/// </summary>
		GetPaged,
		/// <summary>
		/// Represents the Find method.
		/// </summary>
		Find,
		/// <summary>
		/// Represents the GetByMaQuanLy method.
		/// </summary>
		GetByMaQuanLy,
		/// <summary>
		/// Represents the GetByMaGiangVien method.
		/// </summary>
		GetByMaGiangVien,
		/// <summary>
		/// Represents the GetByMaHocHam method.
		/// </summary>
		GetByMaHocHam,
		/// <summary>
		/// Represents the GetByMaHocVi method.
		/// </summary>
		GetByMaHocVi,
		/// <summary>
		/// Represents the GetByMaLoaiGiangVien method.
		/// </summary>
		GetByMaLoaiGiangVien,
		/// <summary>
		/// Represents the GetByMaLoaiNhanVien method.
		/// </summary>
		GetByMaLoaiNhanVien,
		/// <summary>
		/// Represents the GetByMaNgachCongChuc method.
		/// </summary>
		GetByMaNgachCongChuc,
		/// <summary>
		/// Represents the GetByMaNguoiLap method.
		/// </summary>
		GetByMaNguoiLap,
		/// <summary>
		/// Represents the GetByMaTinhTrang method.
		/// </summary>
		GetByMaTinhTrang,
		/// <summary>
		/// Represents the GetByMaTrinhDoChinhTri method.
		/// </summary>
		GetByMaTrinhDoChinhTri,
		/// <summary>
		/// Represents the GetByMaTrinhDoNgoaiNgu method.
		/// </summary>
		GetByMaTrinhDoNgoaiNgu,
		/// <summary>
		/// Represents the GetByMaTrinhDoQuanLyNhaNuoc method.
		/// </summary>
		GetByMaTrinhDoQuanLyNhaNuoc,
		/// <summary>
		/// Represents the GetByMaTrinhDoSuPham method.
		/// </summary>
		GetByMaTrinhDoSuPham,
		/// <summary>
		/// Represents the GetByMaTrinhDoTinHoc method.
		/// </summary>
		GetByMaTrinhDoTinHoc,
		/// <summary>
		/// Represents the GetByMaHoSoFromGiangVienHoSo method.
		/// </summary>
		GetByMaHoSoFromGiangVienHoSo,
		/// <summary>
		/// Represents the GetMaDonViMaTinhTrang method.
		/// </summary>
		GetMaDonViMaTinhTrang,
		/// <summary>
		/// Represents the GetByNhomQuyen method.
		/// </summary>
		GetByNhomQuyen,
		/// <summary>
		/// Represents the GetByMaDonVi method.
		/// </summary>
		GetByMaDonVi,
		/// <summary>
		/// Represents the GetMaDonViMaHocHamMaHocVi method.
		/// </summary>
		GetMaDonViMaHocHamMaHocVi,
		/// <summary>
		/// Represents the GetMaDonViMaHocHamMaHocViMaTinhTrang method.
		/// </summary>
		GetMaDonViMaHocHamMaHocViMaTinhTrang
	}
	
	#endregion GiangVienSelectMethod

	#region GiangVienFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GiangVien"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GiangVienFilter : SqlFilter<GiangVienColumn>
	{
	}
	
	#endregion GiangVienFilter

	#region GiangVienExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GiangVien"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GiangVienExpressionBuilder : SqlExpressionBuilder<GiangVienColumn>
	{
	}
	
	#endregion GiangVienExpressionBuilder	

	#region GiangVienProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;GiangVienChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="GiangVien"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GiangVienProperty : ChildEntityProperty<GiangVienChildEntityTypes>
	{
	}
	
	#endregion GiangVienProperty
}

