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
	/// Represents the DataRepository.ThuLaoChamBaiVhuProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(ThuLaoChamBaiVhuDataSourceDesigner))]
	public class ThuLaoChamBaiVhuDataSource : ProviderDataSource<ThuLaoChamBaiVhu, ThuLaoChamBaiVhuKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ThuLaoChamBaiVhuDataSource class.
		/// </summary>
		public ThuLaoChamBaiVhuDataSource() : base(new ThuLaoChamBaiVhuService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the ThuLaoChamBaiVhuDataSourceView used by the ThuLaoChamBaiVhuDataSource.
		/// </summary>
		protected ThuLaoChamBaiVhuDataSourceView ThuLaoChamBaiVhuView
		{
			get { return ( View as ThuLaoChamBaiVhuDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the ThuLaoChamBaiVhuDataSource control invokes to retrieve data.
		/// </summary>
		public ThuLaoChamBaiVhuSelectMethod SelectMethod
		{
			get
			{
				ThuLaoChamBaiVhuSelectMethod selectMethod = ThuLaoChamBaiVhuSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (ThuLaoChamBaiVhuSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the ThuLaoChamBaiVhuDataSourceView class that is to be
		/// used by the ThuLaoChamBaiVhuDataSource.
		/// </summary>
		/// <returns>An instance of the ThuLaoChamBaiVhuDataSourceView class.</returns>
		protected override BaseDataSourceView<ThuLaoChamBaiVhu, ThuLaoChamBaiVhuKey> GetNewDataSourceView()
		{
			return new ThuLaoChamBaiVhuDataSourceView(this, DefaultViewName);
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
	/// Supports the ThuLaoChamBaiVhuDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class ThuLaoChamBaiVhuDataSourceView : ProviderDataSourceView<ThuLaoChamBaiVhu, ThuLaoChamBaiVhuKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ThuLaoChamBaiVhuDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the ThuLaoChamBaiVhuDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public ThuLaoChamBaiVhuDataSourceView(ThuLaoChamBaiVhuDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal ThuLaoChamBaiVhuDataSource ThuLaoChamBaiVhuOwner
		{
			get { return Owner as ThuLaoChamBaiVhuDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal ThuLaoChamBaiVhuSelectMethod SelectMethod
		{
			get { return ThuLaoChamBaiVhuOwner.SelectMethod; }
			set { ThuLaoChamBaiVhuOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal ThuLaoChamBaiVhuService ThuLaoChamBaiVhuProvider
		{
			get { return Provider as ThuLaoChamBaiVhuService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<ThuLaoChamBaiVhu> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<ThuLaoChamBaiVhu> results = null;
			ThuLaoChamBaiVhu item;
			count = 0;
			
			System.Int32 _id;

			switch ( SelectMethod )
			{
				case ThuLaoChamBaiVhuSelectMethod.Get:
					ThuLaoChamBaiVhuKey entityKey  = new ThuLaoChamBaiVhuKey();
					entityKey.Load(values);
					item = ThuLaoChamBaiVhuProvider.Get(entityKey);
					results = new TList<ThuLaoChamBaiVhu>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case ThuLaoChamBaiVhuSelectMethod.GetAll:
                    results = ThuLaoChamBaiVhuProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case ThuLaoChamBaiVhuSelectMethod.GetPaged:
					results = ThuLaoChamBaiVhuProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case ThuLaoChamBaiVhuSelectMethod.Find:
					if ( FilterParameters != null )
						results = ThuLaoChamBaiVhuProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = ThuLaoChamBaiVhuProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case ThuLaoChamBaiVhuSelectMethod.GetById:
					_id = ( values["Id"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["Id"], typeof(System.Int32)) : (int)0;
					item = ThuLaoChamBaiVhuProvider.GetById(_id);
					results = new TList<ThuLaoChamBaiVhu>();
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
			if ( SelectMethod == ThuLaoChamBaiVhuSelectMethod.Get || SelectMethod == ThuLaoChamBaiVhuSelectMethod.GetById )
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
				ThuLaoChamBaiVhu entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					ThuLaoChamBaiVhuProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<ThuLaoChamBaiVhu> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			ThuLaoChamBaiVhuProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region ThuLaoChamBaiVhuDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the ThuLaoChamBaiVhuDataSource class.
	/// </summary>
	public class ThuLaoChamBaiVhuDataSourceDesigner : ProviderDataSourceDesigner<ThuLaoChamBaiVhu, ThuLaoChamBaiVhuKey>
	{
		/// <summary>
		/// Initializes a new instance of the ThuLaoChamBaiVhuDataSourceDesigner class.
		/// </summary>
		public ThuLaoChamBaiVhuDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public ThuLaoChamBaiVhuSelectMethod SelectMethod
		{
			get { return ((ThuLaoChamBaiVhuDataSource) DataSource).SelectMethod; }
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
				actions.Add(new ThuLaoChamBaiVhuDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region ThuLaoChamBaiVhuDataSourceActionList

	/// <summary>
	/// Supports the ThuLaoChamBaiVhuDataSourceDesigner class.
	/// </summary>
	internal class ThuLaoChamBaiVhuDataSourceActionList : DesignerActionList
	{
		private ThuLaoChamBaiVhuDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the ThuLaoChamBaiVhuDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public ThuLaoChamBaiVhuDataSourceActionList(ThuLaoChamBaiVhuDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public ThuLaoChamBaiVhuSelectMethod SelectMethod
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

	#endregion ThuLaoChamBaiVhuDataSourceActionList
	
	#endregion ThuLaoChamBaiVhuDataSourceDesigner
	
	#region ThuLaoChamBaiVhuSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the ThuLaoChamBaiVhuDataSource.SelectMethod property.
	/// </summary>
	public enum ThuLaoChamBaiVhuSelectMethod
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
		GetById
	}
	
	#endregion ThuLaoChamBaiVhuSelectMethod

	#region ThuLaoChamBaiVhuFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ThuLaoChamBaiVhu"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ThuLaoChamBaiVhuFilter : SqlFilter<ThuLaoChamBaiVhuColumn>
	{
	}
	
	#endregion ThuLaoChamBaiVhuFilter

	#region ThuLaoChamBaiVhuExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ThuLaoChamBaiVhu"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ThuLaoChamBaiVhuExpressionBuilder : SqlExpressionBuilder<ThuLaoChamBaiVhuColumn>
	{
	}
	
	#endregion ThuLaoChamBaiVhuExpressionBuilder	

	#region ThuLaoChamBaiVhuProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;ThuLaoChamBaiVhuChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="ThuLaoChamBaiVhu"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ThuLaoChamBaiVhuProperty : ChildEntityProperty<ThuLaoChamBaiVhuChildEntityTypes>
	{
	}
	
	#endregion ThuLaoChamBaiVhuProperty
}

