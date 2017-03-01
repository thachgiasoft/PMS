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
	/// Represents the DataRepository.ThuMoiGiangHopDongThinhGiangProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(ThuMoiGiangHopDongThinhGiangDataSourceDesigner))]
	public class ThuMoiGiangHopDongThinhGiangDataSource : ProviderDataSource<ThuMoiGiangHopDongThinhGiang, ThuMoiGiangHopDongThinhGiangKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ThuMoiGiangHopDongThinhGiangDataSource class.
		/// </summary>
		public ThuMoiGiangHopDongThinhGiangDataSource() : base(new ThuMoiGiangHopDongThinhGiangService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the ThuMoiGiangHopDongThinhGiangDataSourceView used by the ThuMoiGiangHopDongThinhGiangDataSource.
		/// </summary>
		protected ThuMoiGiangHopDongThinhGiangDataSourceView ThuMoiGiangHopDongThinhGiangView
		{
			get { return ( View as ThuMoiGiangHopDongThinhGiangDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the ThuMoiGiangHopDongThinhGiangDataSource control invokes to retrieve data.
		/// </summary>
		public ThuMoiGiangHopDongThinhGiangSelectMethod SelectMethod
		{
			get
			{
				ThuMoiGiangHopDongThinhGiangSelectMethod selectMethod = ThuMoiGiangHopDongThinhGiangSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (ThuMoiGiangHopDongThinhGiangSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the ThuMoiGiangHopDongThinhGiangDataSourceView class that is to be
		/// used by the ThuMoiGiangHopDongThinhGiangDataSource.
		/// </summary>
		/// <returns>An instance of the ThuMoiGiangHopDongThinhGiangDataSourceView class.</returns>
		protected override BaseDataSourceView<ThuMoiGiangHopDongThinhGiang, ThuMoiGiangHopDongThinhGiangKey> GetNewDataSourceView()
		{
			return new ThuMoiGiangHopDongThinhGiangDataSourceView(this, DefaultViewName);
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
	/// Supports the ThuMoiGiangHopDongThinhGiangDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class ThuMoiGiangHopDongThinhGiangDataSourceView : ProviderDataSourceView<ThuMoiGiangHopDongThinhGiang, ThuMoiGiangHopDongThinhGiangKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ThuMoiGiangHopDongThinhGiangDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the ThuMoiGiangHopDongThinhGiangDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public ThuMoiGiangHopDongThinhGiangDataSourceView(ThuMoiGiangHopDongThinhGiangDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal ThuMoiGiangHopDongThinhGiangDataSource ThuMoiGiangHopDongThinhGiangOwner
		{
			get { return Owner as ThuMoiGiangHopDongThinhGiangDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal ThuMoiGiangHopDongThinhGiangSelectMethod SelectMethod
		{
			get { return ThuMoiGiangHopDongThinhGiangOwner.SelectMethod; }
			set { ThuMoiGiangHopDongThinhGiangOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal ThuMoiGiangHopDongThinhGiangService ThuMoiGiangHopDongThinhGiangProvider
		{
			get { return Provider as ThuMoiGiangHopDongThinhGiangService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<ThuMoiGiangHopDongThinhGiang> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<ThuMoiGiangHopDongThinhGiang> results = null;
			ThuMoiGiangHopDongThinhGiang item;
			count = 0;
			
			System.String _maGiangVien;
			System.String _maLopHocPhan;
			System.String _maLopSinhVien;

			switch ( SelectMethod )
			{
				case ThuMoiGiangHopDongThinhGiangSelectMethod.Get:
					ThuMoiGiangHopDongThinhGiangKey entityKey  = new ThuMoiGiangHopDongThinhGiangKey();
					entityKey.Load(values);
					item = ThuMoiGiangHopDongThinhGiangProvider.Get(entityKey);
					results = new TList<ThuMoiGiangHopDongThinhGiang>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case ThuMoiGiangHopDongThinhGiangSelectMethod.GetAll:
                    results = ThuMoiGiangHopDongThinhGiangProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case ThuMoiGiangHopDongThinhGiangSelectMethod.GetPaged:
					results = ThuMoiGiangHopDongThinhGiangProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case ThuMoiGiangHopDongThinhGiangSelectMethod.Find:
					if ( FilterParameters != null )
						results = ThuMoiGiangHopDongThinhGiangProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = ThuMoiGiangHopDongThinhGiangProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case ThuMoiGiangHopDongThinhGiangSelectMethod.GetByMaGiangVienMaLopHocPhanMaLopSinhVien:
					_maGiangVien = ( values["MaGiangVien"] != null ) ? (System.String) EntityUtil.ChangeType(values["MaGiangVien"], typeof(System.String)) : string.Empty;
					_maLopHocPhan = ( values["MaLopHocPhan"] != null ) ? (System.String) EntityUtil.ChangeType(values["MaLopHocPhan"], typeof(System.String)) : string.Empty;
					_maLopSinhVien = ( values["MaLopSinhVien"] != null ) ? (System.String) EntityUtil.ChangeType(values["MaLopSinhVien"], typeof(System.String)) : string.Empty;
					item = ThuMoiGiangHopDongThinhGiangProvider.GetByMaGiangVienMaLopHocPhanMaLopSinhVien(_maGiangVien, _maLopHocPhan, _maLopSinhVien);
					results = new TList<ThuMoiGiangHopDongThinhGiang>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				// IX
				// FK
				// M:M
				// Custom
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
			if ( SelectMethod == ThuMoiGiangHopDongThinhGiangSelectMethod.Get || SelectMethod == ThuMoiGiangHopDongThinhGiangSelectMethod.GetByMaGiangVienMaLopHocPhanMaLopSinhVien )
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
				ThuMoiGiangHopDongThinhGiang entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					ThuMoiGiangHopDongThinhGiangProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<ThuMoiGiangHopDongThinhGiang> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			ThuMoiGiangHopDongThinhGiangProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region ThuMoiGiangHopDongThinhGiangDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the ThuMoiGiangHopDongThinhGiangDataSource class.
	/// </summary>
	public class ThuMoiGiangHopDongThinhGiangDataSourceDesigner : ProviderDataSourceDesigner<ThuMoiGiangHopDongThinhGiang, ThuMoiGiangHopDongThinhGiangKey>
	{
		/// <summary>
		/// Initializes a new instance of the ThuMoiGiangHopDongThinhGiangDataSourceDesigner class.
		/// </summary>
		public ThuMoiGiangHopDongThinhGiangDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public ThuMoiGiangHopDongThinhGiangSelectMethod SelectMethod
		{
			get { return ((ThuMoiGiangHopDongThinhGiangDataSource) DataSource).SelectMethod; }
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
				actions.Add(new ThuMoiGiangHopDongThinhGiangDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region ThuMoiGiangHopDongThinhGiangDataSourceActionList

	/// <summary>
	/// Supports the ThuMoiGiangHopDongThinhGiangDataSourceDesigner class.
	/// </summary>
	internal class ThuMoiGiangHopDongThinhGiangDataSourceActionList : DesignerActionList
	{
		private ThuMoiGiangHopDongThinhGiangDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the ThuMoiGiangHopDongThinhGiangDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public ThuMoiGiangHopDongThinhGiangDataSourceActionList(ThuMoiGiangHopDongThinhGiangDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public ThuMoiGiangHopDongThinhGiangSelectMethod SelectMethod
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

	#endregion ThuMoiGiangHopDongThinhGiangDataSourceActionList
	
	#endregion ThuMoiGiangHopDongThinhGiangDataSourceDesigner
	
	#region ThuMoiGiangHopDongThinhGiangSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the ThuMoiGiangHopDongThinhGiangDataSource.SelectMethod property.
	/// </summary>
	public enum ThuMoiGiangHopDongThinhGiangSelectMethod
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
		/// Represents the GetByMaGiangVienMaLopHocPhanMaLopSinhVien method.
		/// </summary>
		GetByMaGiangVienMaLopHocPhanMaLopSinhVien
	}
	
	#endregion ThuMoiGiangHopDongThinhGiangSelectMethod

	#region ThuMoiGiangHopDongThinhGiangFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ThuMoiGiangHopDongThinhGiang"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ThuMoiGiangHopDongThinhGiangFilter : SqlFilter<ThuMoiGiangHopDongThinhGiangColumn>
	{
	}
	
	#endregion ThuMoiGiangHopDongThinhGiangFilter

	#region ThuMoiGiangHopDongThinhGiangExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ThuMoiGiangHopDongThinhGiang"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ThuMoiGiangHopDongThinhGiangExpressionBuilder : SqlExpressionBuilder<ThuMoiGiangHopDongThinhGiangColumn>
	{
	}
	
	#endregion ThuMoiGiangHopDongThinhGiangExpressionBuilder	

	#region ThuMoiGiangHopDongThinhGiangProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;ThuMoiGiangHopDongThinhGiangChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="ThuMoiGiangHopDongThinhGiang"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ThuMoiGiangHopDongThinhGiangProperty : ChildEntityProperty<ThuMoiGiangHopDongThinhGiangChildEntityTypes>
	{
	}
	
	#endregion ThuMoiGiangHopDongThinhGiangProperty
}

