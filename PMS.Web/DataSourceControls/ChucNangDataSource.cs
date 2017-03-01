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
	/// Represents the DataRepository.ChucNangProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(ChucNangDataSourceDesigner))]
	public class ChucNangDataSource : ProviderDataSource<ChucNang, ChucNangKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ChucNangDataSource class.
		/// </summary>
		public ChucNangDataSource() : base(new ChucNangService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the ChucNangDataSourceView used by the ChucNangDataSource.
		/// </summary>
		protected ChucNangDataSourceView ChucNangView
		{
			get { return ( View as ChucNangDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the ChucNangDataSource control invokes to retrieve data.
		/// </summary>
		public ChucNangSelectMethod SelectMethod
		{
			get
			{
				ChucNangSelectMethod selectMethod = ChucNangSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (ChucNangSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the ChucNangDataSourceView class that is to be
		/// used by the ChucNangDataSource.
		/// </summary>
		/// <returns>An instance of the ChucNangDataSourceView class.</returns>
		protected override BaseDataSourceView<ChucNang, ChucNangKey> GetNewDataSourceView()
		{
			return new ChucNangDataSourceView(this, DefaultViewName);
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
	/// Supports the ChucNangDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class ChucNangDataSourceView : ProviderDataSourceView<ChucNang, ChucNangKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ChucNangDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the ChucNangDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public ChucNangDataSourceView(ChucNangDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal ChucNangDataSource ChucNangOwner
		{
			get { return Owner as ChucNangDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal ChucNangSelectMethod SelectMethod
		{
			get { return ChucNangOwner.SelectMethod; }
			set { ChucNangOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal ChucNangService ChucNangProvider
		{
			get { return Provider as ChucNangService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<ChucNang> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<ChucNang> results = null;
			ChucNang item;
			count = 0;
			
			System.Int32 _id;
			System.Int32? _parentId_nullable;
			System.Int32 _maNhomQuyen;
			System.Int32 sp29_ParentId;
			System.Boolean sp29_TrangThai;
			System.Boolean sp32_TrangThai;
			System.Int32 sp28_ParentId;
			System.String sp28_PhanLoai;
			System.Boolean sp28_TrangThai;
			System.Int32 sp24_Id;
			System.Boolean sp24_TrangThai;
			System.Int32 sp26_MaNhomQuyen;
			System.String sp26_PhanLoai;
			System.Boolean sp26_TrangThai;
			System.String sp31_TenForm;
			System.Boolean sp31_TrangThai;
			System.String sp30_PhanLoai;
			System.Boolean sp30_TrangThai;
			System.Int32 sp25_MaNhomQuyen;
			System.Int32 sp25_ParentId;
			System.String sp25_PhanLoai;
			System.Boolean sp25_TrangThai;
			System.Boolean sp33_TrangThai;
			System.String sp33_MaNhomQuyen;

			switch ( SelectMethod )
			{
				case ChucNangSelectMethod.Get:
					ChucNangKey entityKey  = new ChucNangKey();
					entityKey.Load(values);
					item = ChucNangProvider.Get(entityKey);
					results = new TList<ChucNang>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case ChucNangSelectMethod.GetAll:
                    results = ChucNangProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case ChucNangSelectMethod.GetPaged:
					results = ChucNangProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case ChucNangSelectMethod.Find:
					if ( FilterParameters != null )
						results = ChucNangProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = ChucNangProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case ChucNangSelectMethod.GetById:
					_id = ( values["Id"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["Id"], typeof(System.Int32)) : (int)0;
					item = ChucNangProvider.GetById(_id);
					results = new TList<ChucNang>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				// IX
				// FK
				case ChucNangSelectMethod.GetByParentId:
					_parentId_nullable = (System.Int32?) EntityUtil.ChangeType(values["ParentId"], typeof(System.Int32?));
					results = ChucNangProvider.GetByParentId(_parentId_nullable, this.StartIndex, this.PageSize, out count);
					break;
				// M:M
				case ChucNangSelectMethod.GetByMaNhomQuyenFromNhomChucNang:
					_maNhomQuyen = ( values["MaNhomQuyen"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["MaNhomQuyen"], typeof(System.Int32)) : (int)0;
					results = ChucNangProvider.GetByMaNhomQuyenFromNhomChucNang(_maNhomQuyen, this.StartIndex, this.PageSize, out count);
					break;
				// Custom
				case ChucNangSelectMethod.GetByParentIDTrangThai:
					sp29_ParentId = (System.Int32) EntityUtil.ChangeType(values["ParentId"], typeof(System.Int32));
					sp29_TrangThai = (System.Boolean) EntityUtil.ChangeType(values["TrangThai"], typeof(System.Boolean));
					results = ChucNangProvider.GetByParentIDTrangThai(sp29_ParentId, sp29_TrangThai, StartIndex, PageSize);
					break;
				case ChucNangSelectMethod.GetByTrangThai:
					sp32_TrangThai = (System.Boolean) EntityUtil.ChangeType(values["TrangThai"], typeof(System.Boolean));
					results = ChucNangProvider.GetByTrangThai(sp32_TrangThai, StartIndex, PageSize);
					break;
				case ChucNangSelectMethod.GetByParentIDPhanLoaiTrangThai:
					sp28_ParentId = (System.Int32) EntityUtil.ChangeType(values["ParentId"], typeof(System.Int32));
					sp28_PhanLoai = (System.String) EntityUtil.ChangeType(values["PhanLoai"], typeof(System.String));
					sp28_TrangThai = (System.Boolean) EntityUtil.ChangeType(values["TrangThai"], typeof(System.Boolean));
					results = ChucNangProvider.GetByParentIDPhanLoaiTrangThai(sp28_ParentId, sp28_PhanLoai, sp28_TrangThai, StartIndex, PageSize);
					break;
				case ChucNangSelectMethod.GetByIDTrangThai:
					sp24_Id = (System.Int32) EntityUtil.ChangeType(values["Id"], typeof(System.Int32));
					sp24_TrangThai = (System.Boolean) EntityUtil.ChangeType(values["TrangThai"], typeof(System.Boolean));
					results = ChucNangProvider.GetByIDTrangThai(sp24_Id, sp24_TrangThai, StartIndex, PageSize);
					break;
				case ChucNangSelectMethod.GetByMaNhomQuyenPhanLoaiTrangThai:
					sp26_MaNhomQuyen = (System.Int32) EntityUtil.ChangeType(values["MaNhomQuyen"], typeof(System.Int32));
					sp26_PhanLoai = (System.String) EntityUtil.ChangeType(values["PhanLoai"], typeof(System.String));
					sp26_TrangThai = (System.Boolean) EntityUtil.ChangeType(values["TrangThai"], typeof(System.Boolean));
					results = ChucNangProvider.GetByMaNhomQuyenPhanLoaiTrangThai(sp26_MaNhomQuyen, sp26_PhanLoai, sp26_TrangThai, StartIndex, PageSize);
					break;
				case ChucNangSelectMethod.GetByTenFormTrangThai:
					sp31_TenForm = (System.String) EntityUtil.ChangeType(values["TenForm"], typeof(System.String));
					sp31_TrangThai = (System.Boolean) EntityUtil.ChangeType(values["TrangThai"], typeof(System.Boolean));
					results = ChucNangProvider.GetByTenFormTrangThai(sp31_TenForm, sp31_TrangThai, StartIndex, PageSize);
					break;
				case ChucNangSelectMethod.GetByPhanLoaiTrangThai:
					sp30_PhanLoai = (System.String) EntityUtil.ChangeType(values["PhanLoai"], typeof(System.String));
					sp30_TrangThai = (System.Boolean) EntityUtil.ChangeType(values["TrangThai"], typeof(System.Boolean));
					results = ChucNangProvider.GetByPhanLoaiTrangThai(sp30_PhanLoai, sp30_TrangThai, StartIndex, PageSize);
					break;
				case ChucNangSelectMethod.GetByMaNhomQuyenParentIDPhanLoaiTrangThai:
					sp25_MaNhomQuyen = (System.Int32) EntityUtil.ChangeType(values["MaNhomQuyen"], typeof(System.Int32));
					sp25_ParentId = (System.Int32) EntityUtil.ChangeType(values["ParentId"], typeof(System.Int32));
					sp25_PhanLoai = (System.String) EntityUtil.ChangeType(values["PhanLoai"], typeof(System.String));
					sp25_TrangThai = (System.Boolean) EntityUtil.ChangeType(values["TrangThai"], typeof(System.Boolean));
					results = ChucNangProvider.GetByMaNhomQuyenParentIDPhanLoaiTrangThai(sp25_MaNhomQuyen, sp25_ParentId, sp25_PhanLoai, sp25_TrangThai, StartIndex, PageSize);
					break;
				case ChucNangSelectMethod.GetByTrangThaiNhomQuyen:
					sp33_TrangThai = (System.Boolean) EntityUtil.ChangeType(values["TrangThai"], typeof(System.Boolean));
					sp33_MaNhomQuyen = (System.String) EntityUtil.ChangeType(values["MaNhomQuyen"], typeof(System.String));
					results = ChucNangProvider.GetByTrangThaiNhomQuyen(sp33_TrangThai, sp33_MaNhomQuyen, StartIndex, PageSize);
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
			if ( SelectMethod == ChucNangSelectMethod.Get || SelectMethod == ChucNangSelectMethod.GetById )
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
				ChucNang entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					ChucNangProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<ChucNang> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			ChucNangProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region ChucNangDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the ChucNangDataSource class.
	/// </summary>
	public class ChucNangDataSourceDesigner : ProviderDataSourceDesigner<ChucNang, ChucNangKey>
	{
		/// <summary>
		/// Initializes a new instance of the ChucNangDataSourceDesigner class.
		/// </summary>
		public ChucNangDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public ChucNangSelectMethod SelectMethod
		{
			get { return ((ChucNangDataSource) DataSource).SelectMethod; }
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
				actions.Add(new ChucNangDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region ChucNangDataSourceActionList

	/// <summary>
	/// Supports the ChucNangDataSourceDesigner class.
	/// </summary>
	internal class ChucNangDataSourceActionList : DesignerActionList
	{
		private ChucNangDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the ChucNangDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public ChucNangDataSourceActionList(ChucNangDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public ChucNangSelectMethod SelectMethod
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

	#endregion ChucNangDataSourceActionList
	
	#endregion ChucNangDataSourceDesigner
	
	#region ChucNangSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the ChucNangDataSource.SelectMethod property.
	/// </summary>
	public enum ChucNangSelectMethod
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
		/// Represents the GetById method.
		/// </summary>
		GetById,
		/// <summary>
		/// Represents the GetByParentId method.
		/// </summary>
		GetByParentId,
		/// <summary>
		/// Represents the GetByMaNhomQuyenFromNhomChucNang method.
		/// </summary>
		GetByMaNhomQuyenFromNhomChucNang,
		/// <summary>
		/// Represents the GetByParentIDTrangThai method.
		/// </summary>
		GetByParentIDTrangThai,
		/// <summary>
		/// Represents the GetByTrangThai method.
		/// </summary>
		GetByTrangThai,
		/// <summary>
		/// Represents the GetByParentIDPhanLoaiTrangThai method.
		/// </summary>
		GetByParentIDPhanLoaiTrangThai,
		/// <summary>
		/// Represents the GetByIDTrangThai method.
		/// </summary>
		GetByIDTrangThai,
		/// <summary>
		/// Represents the GetByMaNhomQuyenPhanLoaiTrangThai method.
		/// </summary>
		GetByMaNhomQuyenPhanLoaiTrangThai,
		/// <summary>
		/// Represents the GetByTenFormTrangThai method.
		/// </summary>
		GetByTenFormTrangThai,
		/// <summary>
		/// Represents the GetByPhanLoaiTrangThai method.
		/// </summary>
		GetByPhanLoaiTrangThai,
		/// <summary>
		/// Represents the GetByMaNhomQuyenParentIDPhanLoaiTrangThai method.
		/// </summary>
		GetByMaNhomQuyenParentIDPhanLoaiTrangThai,
		/// <summary>
		/// Represents the GetByTrangThaiNhomQuyen method.
		/// </summary>
		GetByTrangThaiNhomQuyen
	}
	
	#endregion ChucNangSelectMethod

	#region ChucNangFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ChucNang"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ChucNangFilter : SqlFilter<ChucNangColumn>
	{
	}
	
	#endregion ChucNangFilter

	#region ChucNangExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ChucNang"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ChucNangExpressionBuilder : SqlExpressionBuilder<ChucNangColumn>
	{
	}
	
	#endregion ChucNangExpressionBuilder	

	#region ChucNangProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;ChucNangChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="ChucNang"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ChucNangProperty : ChildEntityProperty<ChucNangChildEntityTypes>
	{
	}
	
	#endregion ChucNangProperty
}

