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
	/// Represents the DataRepository.TaiKhoanProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(TaiKhoanDataSourceDesigner))]
	public class TaiKhoanDataSource : ProviderDataSource<TaiKhoan, TaiKhoanKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the TaiKhoanDataSource class.
		/// </summary>
		public TaiKhoanDataSource() : base(new TaiKhoanService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the TaiKhoanDataSourceView used by the TaiKhoanDataSource.
		/// </summary>
		protected TaiKhoanDataSourceView TaiKhoanView
		{
			get { return ( View as TaiKhoanDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the TaiKhoanDataSource control invokes to retrieve data.
		/// </summary>
		public TaiKhoanSelectMethod SelectMethod
		{
			get
			{
				TaiKhoanSelectMethod selectMethod = TaiKhoanSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (TaiKhoanSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the TaiKhoanDataSourceView class that is to be
		/// used by the TaiKhoanDataSource.
		/// </summary>
		/// <returns>An instance of the TaiKhoanDataSourceView class.</returns>
		protected override BaseDataSourceView<TaiKhoan, TaiKhoanKey> GetNewDataSourceView()
		{
			return new TaiKhoanDataSourceView(this, DefaultViewName);
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
	/// Supports the TaiKhoanDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class TaiKhoanDataSourceView : ProviderDataSourceView<TaiKhoan, TaiKhoanKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the TaiKhoanDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the TaiKhoanDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public TaiKhoanDataSourceView(TaiKhoanDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal TaiKhoanDataSource TaiKhoanOwner
		{
			get { return Owner as TaiKhoanDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal TaiKhoanSelectMethod SelectMethod
		{
			get { return TaiKhoanOwner.SelectMethod; }
			set { TaiKhoanOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal TaiKhoanService TaiKhoanProvider
		{
			get { return Provider as TaiKhoanService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<TaiKhoan> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<TaiKhoan> results = null;
			TaiKhoan item;
			count = 0;
			
			System.String _tenDangNhap_nullable;
			System.Int32 _maTaiKhoan;
			System.Int32? _maNhomQuyen_nullable;
			System.Int32 _parentId;
			System.Int32 _userId;
			System.String sp2841_TenDangNhap;
			System.String sp2841_MatKhau;
			System.Int32 sp2840_MaNhomQuyen;

			switch ( SelectMethod )
			{
				case TaiKhoanSelectMethod.Get:
					TaiKhoanKey entityKey  = new TaiKhoanKey();
					entityKey.Load(values);
					item = TaiKhoanProvider.Get(entityKey);
					results = new TList<TaiKhoan>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case TaiKhoanSelectMethod.GetAll:
                    results = TaiKhoanProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case TaiKhoanSelectMethod.GetPaged:
					results = TaiKhoanProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case TaiKhoanSelectMethod.Find:
					if ( FilterParameters != null )
						results = TaiKhoanProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = TaiKhoanProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case TaiKhoanSelectMethod.GetByMaTaiKhoan:
					_maTaiKhoan = ( values["MaTaiKhoan"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["MaTaiKhoan"], typeof(System.Int32)) : (int)0;
					item = TaiKhoanProvider.GetByMaTaiKhoan(_maTaiKhoan);
					results = new TList<TaiKhoan>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				// IX
				case TaiKhoanSelectMethod.GetByTenDangNhap:
					_tenDangNhap_nullable = (System.String) EntityUtil.ChangeType(values["TenDangNhap"], typeof(System.String));
					item = TaiKhoanProvider.GetByTenDangNhap(_tenDangNhap_nullable);
					results = new TList<TaiKhoan>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				// FK
				case TaiKhoanSelectMethod.GetByMaNhomQuyen:
					_maNhomQuyen_nullable = (System.Int32?) EntityUtil.ChangeType(values["MaNhomQuyen"], typeof(System.Int32?));
					results = TaiKhoanProvider.GetByMaNhomQuyen(_maNhomQuyen_nullable, this.StartIndex, this.PageSize, out count);
					break;
				// M:M
				case TaiKhoanSelectMethod.GetByParentIdFromHeThong:
					_parentId = ( values["ParentId"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["ParentId"], typeof(System.Int32)) : (int)0;
					results = TaiKhoanProvider.GetByParentIdFromHeThong(_parentId, this.StartIndex, this.PageSize, out count);
					break;
				case TaiKhoanSelectMethod.GetByUserIdFromHeThong:
					_userId = ( values["UserId"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["UserId"], typeof(System.Int32)) : (int)0;
					results = TaiKhoanProvider.GetByUserIdFromHeThong(_userId, this.StartIndex, this.PageSize, out count);
					break;
				// Custom
				case TaiKhoanSelectMethod.GetByTenDangNhapMatKhau:
					sp2841_TenDangNhap = (System.String) EntityUtil.ChangeType(values["TenDangNhap"], typeof(System.String));
					sp2841_MatKhau = (System.String) EntityUtil.ChangeType(values["MatKhau"], typeof(System.String));
					results = TaiKhoanProvider.GetByTenDangNhapMatKhau(sp2841_TenDangNhap, sp2841_MatKhau, StartIndex, PageSize);
					break;
				case TaiKhoanSelectMethod.GetByNhomQuyenQL:
					sp2840_MaNhomQuyen = (System.Int32) EntityUtil.ChangeType(values["MaNhomQuyen"], typeof(System.Int32));
					results = TaiKhoanProvider.GetByNhomQuyenQL(sp2840_MaNhomQuyen, StartIndex, PageSize);
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
			if ( SelectMethod == TaiKhoanSelectMethod.Get || SelectMethod == TaiKhoanSelectMethod.GetByMaTaiKhoan )
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
				TaiKhoan entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					TaiKhoanProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<TaiKhoan> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			TaiKhoanProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region TaiKhoanDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the TaiKhoanDataSource class.
	/// </summary>
	public class TaiKhoanDataSourceDesigner : ProviderDataSourceDesigner<TaiKhoan, TaiKhoanKey>
	{
		/// <summary>
		/// Initializes a new instance of the TaiKhoanDataSourceDesigner class.
		/// </summary>
		public TaiKhoanDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public TaiKhoanSelectMethod SelectMethod
		{
			get { return ((TaiKhoanDataSource) DataSource).SelectMethod; }
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
				actions.Add(new TaiKhoanDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region TaiKhoanDataSourceActionList

	/// <summary>
	/// Supports the TaiKhoanDataSourceDesigner class.
	/// </summary>
	internal class TaiKhoanDataSourceActionList : DesignerActionList
	{
		private TaiKhoanDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the TaiKhoanDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public TaiKhoanDataSourceActionList(TaiKhoanDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public TaiKhoanSelectMethod SelectMethod
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

	#endregion TaiKhoanDataSourceActionList
	
	#endregion TaiKhoanDataSourceDesigner
	
	#region TaiKhoanSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the TaiKhoanDataSource.SelectMethod property.
	/// </summary>
	public enum TaiKhoanSelectMethod
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
		/// Represents the GetByTenDangNhap method.
		/// </summary>
		GetByTenDangNhap,
		/// <summary>
		/// Represents the GetByMaTaiKhoan method.
		/// </summary>
		GetByMaTaiKhoan,
		/// <summary>
		/// Represents the GetByMaNhomQuyen method.
		/// </summary>
		GetByMaNhomQuyen,
		/// <summary>
		/// Represents the GetByParentIdFromHeThong method.
		/// </summary>
		GetByParentIdFromHeThong,
		/// <summary>
		/// Represents the GetByUserIdFromHeThong method.
		/// </summary>
		GetByUserIdFromHeThong,
		/// <summary>
		/// Represents the GetByTenDangNhapMatKhau method.
		/// </summary>
		GetByTenDangNhapMatKhau,
		/// <summary>
		/// Represents the GetByNhomQuyenQL method.
		/// </summary>
		GetByNhomQuyenQL
	}
	
	#endregion TaiKhoanSelectMethod

	#region TaiKhoanFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="TaiKhoan"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class TaiKhoanFilter : SqlFilter<TaiKhoanColumn>
	{
	}
	
	#endregion TaiKhoanFilter

	#region TaiKhoanExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="TaiKhoan"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class TaiKhoanExpressionBuilder : SqlExpressionBuilder<TaiKhoanColumn>
	{
	}
	
	#endregion TaiKhoanExpressionBuilder	

	#region TaiKhoanProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;TaiKhoanChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="TaiKhoan"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class TaiKhoanProperty : ChildEntityProperty<TaiKhoanChildEntityTypes>
	{
	}
	
	#endregion TaiKhoanProperty
}

