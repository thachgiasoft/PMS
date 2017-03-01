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
	/// Represents the DataRepository.TrinhDoSuPhamProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(TrinhDoSuPhamDataSourceDesigner))]
	public class TrinhDoSuPhamDataSource : ProviderDataSource<TrinhDoSuPham, TrinhDoSuPhamKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the TrinhDoSuPhamDataSource class.
		/// </summary>
		public TrinhDoSuPhamDataSource() : base(new TrinhDoSuPhamService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the TrinhDoSuPhamDataSourceView used by the TrinhDoSuPhamDataSource.
		/// </summary>
		protected TrinhDoSuPhamDataSourceView TrinhDoSuPhamView
		{
			get { return ( View as TrinhDoSuPhamDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the TrinhDoSuPhamDataSource control invokes to retrieve data.
		/// </summary>
		public TrinhDoSuPhamSelectMethod SelectMethod
		{
			get
			{
				TrinhDoSuPhamSelectMethod selectMethod = TrinhDoSuPhamSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (TrinhDoSuPhamSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the TrinhDoSuPhamDataSourceView class that is to be
		/// used by the TrinhDoSuPhamDataSource.
		/// </summary>
		/// <returns>An instance of the TrinhDoSuPhamDataSourceView class.</returns>
		protected override BaseDataSourceView<TrinhDoSuPham, TrinhDoSuPhamKey> GetNewDataSourceView()
		{
			return new TrinhDoSuPhamDataSourceView(this, DefaultViewName);
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
	/// Supports the TrinhDoSuPhamDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class TrinhDoSuPhamDataSourceView : ProviderDataSourceView<TrinhDoSuPham, TrinhDoSuPhamKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the TrinhDoSuPhamDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the TrinhDoSuPhamDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public TrinhDoSuPhamDataSourceView(TrinhDoSuPhamDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal TrinhDoSuPhamDataSource TrinhDoSuPhamOwner
		{
			get { return Owner as TrinhDoSuPhamDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal TrinhDoSuPhamSelectMethod SelectMethod
		{
			get { return TrinhDoSuPhamOwner.SelectMethod; }
			set { TrinhDoSuPhamOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal TrinhDoSuPhamService TrinhDoSuPhamProvider
		{
			get { return Provider as TrinhDoSuPhamService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<TrinhDoSuPham> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<TrinhDoSuPham> results = null;
			TrinhDoSuPham item;
			count = 0;
			
			System.Int32 _maTrinhDoSuPham;

			switch ( SelectMethod )
			{
				case TrinhDoSuPhamSelectMethod.Get:
					TrinhDoSuPhamKey entityKey  = new TrinhDoSuPhamKey();
					entityKey.Load(values);
					item = TrinhDoSuPhamProvider.Get(entityKey);
					results = new TList<TrinhDoSuPham>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case TrinhDoSuPhamSelectMethod.GetAll:
                    results = TrinhDoSuPhamProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case TrinhDoSuPhamSelectMethod.GetPaged:
					results = TrinhDoSuPhamProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case TrinhDoSuPhamSelectMethod.Find:
					if ( FilterParameters != null )
						results = TrinhDoSuPhamProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = TrinhDoSuPhamProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case TrinhDoSuPhamSelectMethod.GetByMaTrinhDoSuPham:
					_maTrinhDoSuPham = ( values["MaTrinhDoSuPham"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["MaTrinhDoSuPham"], typeof(System.Int32)) : (int)0;
					item = TrinhDoSuPhamProvider.GetByMaTrinhDoSuPham(_maTrinhDoSuPham);
					results = new TList<TrinhDoSuPham>();
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
			if ( SelectMethod == TrinhDoSuPhamSelectMethod.Get || SelectMethod == TrinhDoSuPhamSelectMethod.GetByMaTrinhDoSuPham )
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
				TrinhDoSuPham entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					TrinhDoSuPhamProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<TrinhDoSuPham> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			TrinhDoSuPhamProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region TrinhDoSuPhamDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the TrinhDoSuPhamDataSource class.
	/// </summary>
	public class TrinhDoSuPhamDataSourceDesigner : ProviderDataSourceDesigner<TrinhDoSuPham, TrinhDoSuPhamKey>
	{
		/// <summary>
		/// Initializes a new instance of the TrinhDoSuPhamDataSourceDesigner class.
		/// </summary>
		public TrinhDoSuPhamDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public TrinhDoSuPhamSelectMethod SelectMethod
		{
			get { return ((TrinhDoSuPhamDataSource) DataSource).SelectMethod; }
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
				actions.Add(new TrinhDoSuPhamDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region TrinhDoSuPhamDataSourceActionList

	/// <summary>
	/// Supports the TrinhDoSuPhamDataSourceDesigner class.
	/// </summary>
	internal class TrinhDoSuPhamDataSourceActionList : DesignerActionList
	{
		private TrinhDoSuPhamDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the TrinhDoSuPhamDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public TrinhDoSuPhamDataSourceActionList(TrinhDoSuPhamDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public TrinhDoSuPhamSelectMethod SelectMethod
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

	#endregion TrinhDoSuPhamDataSourceActionList
	
	#endregion TrinhDoSuPhamDataSourceDesigner
	
	#region TrinhDoSuPhamSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the TrinhDoSuPhamDataSource.SelectMethod property.
	/// </summary>
	public enum TrinhDoSuPhamSelectMethod
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
		/// Represents the GetByMaTrinhDoSuPham method.
		/// </summary>
		GetByMaTrinhDoSuPham
	}
	
	#endregion TrinhDoSuPhamSelectMethod

	#region TrinhDoSuPhamFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="TrinhDoSuPham"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class TrinhDoSuPhamFilter : SqlFilter<TrinhDoSuPhamColumn>
	{
	}
	
	#endregion TrinhDoSuPhamFilter

	#region TrinhDoSuPhamExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="TrinhDoSuPham"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class TrinhDoSuPhamExpressionBuilder : SqlExpressionBuilder<TrinhDoSuPhamColumn>
	{
	}
	
	#endregion TrinhDoSuPhamExpressionBuilder	

	#region TrinhDoSuPhamProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;TrinhDoSuPhamChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="TrinhDoSuPham"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class TrinhDoSuPhamProperty : ChildEntityProperty<TrinhDoSuPhamChildEntityTypes>
	{
	}
	
	#endregion TrinhDoSuPhamProperty
}

