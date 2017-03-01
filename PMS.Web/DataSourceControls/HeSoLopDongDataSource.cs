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
	/// Represents the DataRepository.HeSoLopDongProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(HeSoLopDongDataSourceDesigner))]
	public class HeSoLopDongDataSource : ProviderDataSource<HeSoLopDong, HeSoLopDongKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the HeSoLopDongDataSource class.
		/// </summary>
		public HeSoLopDongDataSource() : base(new HeSoLopDongService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the HeSoLopDongDataSourceView used by the HeSoLopDongDataSource.
		/// </summary>
		protected HeSoLopDongDataSourceView HeSoLopDongView
		{
			get { return ( View as HeSoLopDongDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the HeSoLopDongDataSource control invokes to retrieve data.
		/// </summary>
		public HeSoLopDongSelectMethod SelectMethod
		{
			get
			{
				HeSoLopDongSelectMethod selectMethod = HeSoLopDongSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (HeSoLopDongSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the HeSoLopDongDataSourceView class that is to be
		/// used by the HeSoLopDongDataSource.
		/// </summary>
		/// <returns>An instance of the HeSoLopDongDataSourceView class.</returns>
		protected override BaseDataSourceView<HeSoLopDong, HeSoLopDongKey> GetNewDataSourceView()
		{
			return new HeSoLopDongDataSourceView(this, DefaultViewName);
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
	/// Supports the HeSoLopDongDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class HeSoLopDongDataSourceView : ProviderDataSourceView<HeSoLopDong, HeSoLopDongKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the HeSoLopDongDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the HeSoLopDongDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public HeSoLopDongDataSourceView(HeSoLopDongDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal HeSoLopDongDataSource HeSoLopDongOwner
		{
			get { return Owner as HeSoLopDongDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal HeSoLopDongSelectMethod SelectMethod
		{
			get { return HeSoLopDongOwner.SelectMethod; }
			set { HeSoLopDongOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal HeSoLopDongService HeSoLopDongProvider
		{
			get { return Provider as HeSoLopDongService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<HeSoLopDong> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<HeSoLopDong> results = null;
			HeSoLopDong item;
			count = 0;
			
			System.Int32 _maHeSo;
			System.Int32 sp290_SiSo;
			System.String sp292_MaBacDaoTao;
			System.Int32 sp292_SiSo;
			System.String sp292_MaNhomMonHoc;
			System.String sp292_LoaiHocPhan;
			System.DateTime sp292_NgayDay;
			System.String sp286_NamHoc;
			System.String sp286_HocKy;
			System.String sp286_MaLoaiKhoiLuong;
			System.String sp287_NamHoc;
			System.String sp287_HocKy;
			System.String sp287_MaLoaiKhoiLuong;
			System.String sp283_NamHoc;
			System.String sp283_HocKy;
			System.Int32 sp291_SiSo;
			System.String sp291_BacDaoTao;
			System.String sp291_NhomMonHoc;
			System.Int32 sp293_SiSo;
			System.String sp293_MaNhomMonHoc;
			System.DateTime sp293_NgayDay;
			System.String sp282_MaLoaiKhoiLuong;

			switch ( SelectMethod )
			{
				case HeSoLopDongSelectMethod.Get:
					HeSoLopDongKey entityKey  = new HeSoLopDongKey();
					entityKey.Load(values);
					item = HeSoLopDongProvider.Get(entityKey);
					results = new TList<HeSoLopDong>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case HeSoLopDongSelectMethod.GetAll:
                    results = HeSoLopDongProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case HeSoLopDongSelectMethod.GetPaged:
					results = HeSoLopDongProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case HeSoLopDongSelectMethod.Find:
					if ( FilterParameters != null )
						results = HeSoLopDongProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = HeSoLopDongProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case HeSoLopDongSelectMethod.GetByMaHeSo:
					_maHeSo = ( values["MaHeSo"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["MaHeSo"], typeof(System.Int32)) : (int)0;
					item = HeSoLopDongProvider.GetByMaHeSo(_maHeSo);
					results = new TList<HeSoLopDong>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				// IX
				// FK
				// M:M
				// Custom
				case HeSoLopDongSelectMethod.GetBySiSo:
					sp290_SiSo = (System.Int32) EntityUtil.ChangeType(values["SiSo"], typeof(System.Int32));
					results = HeSoLopDongProvider.GetBySiSo(sp290_SiSo, StartIndex, PageSize);
					break;
				case HeSoLopDongSelectMethod.GetBySiSoNhomMonHocLoaiHocPhanBacDaoTaoNgayDay:
					sp292_MaBacDaoTao = (System.String) EntityUtil.ChangeType(values["MaBacDaoTao"], typeof(System.String));
					sp292_SiSo = (System.Int32) EntityUtil.ChangeType(values["SiSo"], typeof(System.Int32));
					sp292_MaNhomMonHoc = (System.String) EntityUtil.ChangeType(values["MaNhomMonHoc"], typeof(System.String));
					sp292_LoaiHocPhan = (System.String) EntityUtil.ChangeType(values["LoaiHocPhan"], typeof(System.String));
					sp292_NgayDay = (System.DateTime) EntityUtil.ChangeType(values["NgayDay"], typeof(System.DateTime));
					results = HeSoLopDongProvider.GetBySiSoNhomMonHocLoaiHocPhanBacDaoTaoNgayDay(sp292_MaBacDaoTao, sp292_SiSo, sp292_MaNhomMonHoc, sp292_LoaiHocPhan, sp292_NgayDay, StartIndex, PageSize);
					break;
				case HeSoLopDongSelectMethod.GetByNamHocHocKyLoaiKhoiLuong:
					sp286_NamHoc = (System.String) EntityUtil.ChangeType(values["NamHoc"], typeof(System.String));
					sp286_HocKy = (System.String) EntityUtil.ChangeType(values["HocKy"], typeof(System.String));
					sp286_MaLoaiKhoiLuong = (System.String) EntityUtil.ChangeType(values["MaLoaiKhoiLuong"], typeof(System.String));
					results = HeSoLopDongProvider.GetByNamHocHocKyLoaiKhoiLuong(sp286_NamHoc, sp286_HocKy, sp286_MaLoaiKhoiLuong, StartIndex, PageSize);
					break;
				case HeSoLopDongSelectMethod.GetByNamHocHocKyMaLoaiKhoiLuong:
					sp287_NamHoc = (System.String) EntityUtil.ChangeType(values["NamHoc"], typeof(System.String));
					sp287_HocKy = (System.String) EntityUtil.ChangeType(values["HocKy"], typeof(System.String));
					sp287_MaLoaiKhoiLuong = (System.String) EntityUtil.ChangeType(values["MaLoaiKhoiLuong"], typeof(System.String));
					results = HeSoLopDongProvider.GetByNamHocHocKyMaLoaiKhoiLuong(sp287_NamHoc, sp287_HocKy, sp287_MaLoaiKhoiLuong, StartIndex, PageSize);
					break;
				case HeSoLopDongSelectMethod.GetByNamHocHocKy:
					sp283_NamHoc = (System.String) EntityUtil.ChangeType(values["NamHoc"], typeof(System.String));
					sp283_HocKy = (System.String) EntityUtil.ChangeType(values["HocKy"], typeof(System.String));
					results = HeSoLopDongProvider.GetByNamHocHocKy(sp283_NamHoc, sp283_HocKy, StartIndex, PageSize);
					break;
				case HeSoLopDongSelectMethod.GetBySiSoBacDaoTaoNhomMonHoc:
					sp291_SiSo = (System.Int32) EntityUtil.ChangeType(values["SiSo"], typeof(System.Int32));
					sp291_BacDaoTao = (System.String) EntityUtil.ChangeType(values["BacDaoTao"], typeof(System.String));
					sp291_NhomMonHoc = (System.String) EntityUtil.ChangeType(values["NhomMonHoc"], typeof(System.String));
					results = HeSoLopDongProvider.GetBySiSoBacDaoTaoNhomMonHoc(sp291_SiSo, sp291_BacDaoTao, sp291_NhomMonHoc, StartIndex, PageSize);
					break;
				case HeSoLopDongSelectMethod.GetBySiSoNhomMonHocNgayDay:
					sp293_SiSo = (System.Int32) EntityUtil.ChangeType(values["SiSo"], typeof(System.Int32));
					sp293_MaNhomMonHoc = (System.String) EntityUtil.ChangeType(values["MaNhomMonHoc"], typeof(System.String));
					sp293_NgayDay = (System.DateTime) EntityUtil.ChangeType(values["NgayDay"], typeof(System.DateTime));
					results = HeSoLopDongProvider.GetBySiSoNhomMonHocNgayDay(sp293_SiSo, sp293_MaNhomMonHoc, sp293_NgayDay, StartIndex, PageSize);
					break;
				case HeSoLopDongSelectMethod.GetByMaLoaiKhoiLuong:
					sp282_MaLoaiKhoiLuong = (System.String) EntityUtil.ChangeType(values["MaLoaiKhoiLuong"], typeof(System.String));
					results = HeSoLopDongProvider.GetByMaLoaiKhoiLuong(sp282_MaLoaiKhoiLuong, StartIndex, PageSize);
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
			if ( SelectMethod == HeSoLopDongSelectMethod.Get || SelectMethod == HeSoLopDongSelectMethod.GetByMaHeSo )
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
				HeSoLopDong entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					HeSoLopDongProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<HeSoLopDong> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			HeSoLopDongProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region HeSoLopDongDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the HeSoLopDongDataSource class.
	/// </summary>
	public class HeSoLopDongDataSourceDesigner : ProviderDataSourceDesigner<HeSoLopDong, HeSoLopDongKey>
	{
		/// <summary>
		/// Initializes a new instance of the HeSoLopDongDataSourceDesigner class.
		/// </summary>
		public HeSoLopDongDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public HeSoLopDongSelectMethod SelectMethod
		{
			get { return ((HeSoLopDongDataSource) DataSource).SelectMethod; }
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
				actions.Add(new HeSoLopDongDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region HeSoLopDongDataSourceActionList

	/// <summary>
	/// Supports the HeSoLopDongDataSourceDesigner class.
	/// </summary>
	internal class HeSoLopDongDataSourceActionList : DesignerActionList
	{
		private HeSoLopDongDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the HeSoLopDongDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public HeSoLopDongDataSourceActionList(HeSoLopDongDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public HeSoLopDongSelectMethod SelectMethod
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

	#endregion HeSoLopDongDataSourceActionList
	
	#endregion HeSoLopDongDataSourceDesigner
	
	#region HeSoLopDongSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the HeSoLopDongDataSource.SelectMethod property.
	/// </summary>
	public enum HeSoLopDongSelectMethod
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
		/// Represents the GetByMaHeSo method.
		/// </summary>
		GetByMaHeSo,
		/// <summary>
		/// Represents the GetBySiSo method.
		/// </summary>
		GetBySiSo,
		/// <summary>
		/// Represents the GetBySiSoNhomMonHocLoaiHocPhanBacDaoTaoNgayDay method.
		/// </summary>
		GetBySiSoNhomMonHocLoaiHocPhanBacDaoTaoNgayDay,
		/// <summary>
		/// Represents the GetByNamHocHocKyLoaiKhoiLuong method.
		/// </summary>
		GetByNamHocHocKyLoaiKhoiLuong,
		/// <summary>
		/// Represents the GetByNamHocHocKyMaLoaiKhoiLuong method.
		/// </summary>
		GetByNamHocHocKyMaLoaiKhoiLuong,
		/// <summary>
		/// Represents the GetByNamHocHocKy method.
		/// </summary>
		GetByNamHocHocKy,
		/// <summary>
		/// Represents the GetBySiSoBacDaoTaoNhomMonHoc method.
		/// </summary>
		GetBySiSoBacDaoTaoNhomMonHoc,
		/// <summary>
		/// Represents the GetBySiSoNhomMonHocNgayDay method.
		/// </summary>
		GetBySiSoNhomMonHocNgayDay,
		/// <summary>
		/// Represents the GetByMaLoaiKhoiLuong method.
		/// </summary>
		GetByMaLoaiKhoiLuong
	}
	
	#endregion HeSoLopDongSelectMethod

	#region HeSoLopDongFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="HeSoLopDong"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class HeSoLopDongFilter : SqlFilter<HeSoLopDongColumn>
	{
	}
	
	#endregion HeSoLopDongFilter

	#region HeSoLopDongExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="HeSoLopDong"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class HeSoLopDongExpressionBuilder : SqlExpressionBuilder<HeSoLopDongColumn>
	{
	}
	
	#endregion HeSoLopDongExpressionBuilder	

	#region HeSoLopDongProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;HeSoLopDongChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="HeSoLopDong"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class HeSoLopDongProperty : ChildEntityProperty<HeSoLopDongChildEntityTypes>
	{
	}
	
	#endregion HeSoLopDongProperty
}

