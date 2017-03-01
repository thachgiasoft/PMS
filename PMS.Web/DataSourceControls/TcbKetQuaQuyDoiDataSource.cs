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
	/// Represents the DataRepository.TcbKetQuaQuyDoiProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(TcbKetQuaQuyDoiDataSourceDesigner))]
	public class TcbKetQuaQuyDoiDataSource : ProviderDataSource<TcbKetQuaQuyDoi, TcbKetQuaQuyDoiKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the TcbKetQuaQuyDoiDataSource class.
		/// </summary>
		public TcbKetQuaQuyDoiDataSource() : base(new TcbKetQuaQuyDoiService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the TcbKetQuaQuyDoiDataSourceView used by the TcbKetQuaQuyDoiDataSource.
		/// </summary>
		protected TcbKetQuaQuyDoiDataSourceView TcbKetQuaQuyDoiView
		{
			get { return ( View as TcbKetQuaQuyDoiDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the TcbKetQuaQuyDoiDataSource control invokes to retrieve data.
		/// </summary>
		public TcbKetQuaQuyDoiSelectMethod SelectMethod
		{
			get
			{
				TcbKetQuaQuyDoiSelectMethod selectMethod = TcbKetQuaQuyDoiSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (TcbKetQuaQuyDoiSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the TcbKetQuaQuyDoiDataSourceView class that is to be
		/// used by the TcbKetQuaQuyDoiDataSource.
		/// </summary>
		/// <returns>An instance of the TcbKetQuaQuyDoiDataSourceView class.</returns>
		protected override BaseDataSourceView<TcbKetQuaQuyDoi, TcbKetQuaQuyDoiKey> GetNewDataSourceView()
		{
			return new TcbKetQuaQuyDoiDataSourceView(this, DefaultViewName);
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
	/// Supports the TcbKetQuaQuyDoiDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class TcbKetQuaQuyDoiDataSourceView : ProviderDataSourceView<TcbKetQuaQuyDoi, TcbKetQuaQuyDoiKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the TcbKetQuaQuyDoiDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the TcbKetQuaQuyDoiDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public TcbKetQuaQuyDoiDataSourceView(TcbKetQuaQuyDoiDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal TcbKetQuaQuyDoiDataSource TcbKetQuaQuyDoiOwner
		{
			get { return Owner as TcbKetQuaQuyDoiDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal TcbKetQuaQuyDoiSelectMethod SelectMethod
		{
			get { return TcbKetQuaQuyDoiOwner.SelectMethod; }
			set { TcbKetQuaQuyDoiOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal TcbKetQuaQuyDoiService TcbKetQuaQuyDoiProvider
		{
			get { return Provider as TcbKetQuaQuyDoiService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<TcbKetQuaQuyDoi> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<TcbKetQuaQuyDoi> results = null;
			TcbKetQuaQuyDoi item;
			count = 0;
			
			System.Int32 _id;

			switch ( SelectMethod )
			{
				case TcbKetQuaQuyDoiSelectMethod.Get:
					TcbKetQuaQuyDoiKey entityKey  = new TcbKetQuaQuyDoiKey();
					entityKey.Load(values);
					item = TcbKetQuaQuyDoiProvider.Get(entityKey);
					results = new TList<TcbKetQuaQuyDoi>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case TcbKetQuaQuyDoiSelectMethod.GetAll:
                    results = TcbKetQuaQuyDoiProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case TcbKetQuaQuyDoiSelectMethod.GetPaged:
					results = TcbKetQuaQuyDoiProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case TcbKetQuaQuyDoiSelectMethod.Find:
					if ( FilterParameters != null )
						results = TcbKetQuaQuyDoiProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = TcbKetQuaQuyDoiProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case TcbKetQuaQuyDoiSelectMethod.GetById:
					_id = ( values["Id"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["Id"], typeof(System.Int32)) : (int)0;
					item = TcbKetQuaQuyDoiProvider.GetById(_id);
					results = new TList<TcbKetQuaQuyDoi>();
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
			if ( SelectMethod == TcbKetQuaQuyDoiSelectMethod.Get || SelectMethod == TcbKetQuaQuyDoiSelectMethod.GetById )
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
				TcbKetQuaQuyDoi entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					TcbKetQuaQuyDoiProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<TcbKetQuaQuyDoi> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			TcbKetQuaQuyDoiProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region TcbKetQuaQuyDoiDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the TcbKetQuaQuyDoiDataSource class.
	/// </summary>
	public class TcbKetQuaQuyDoiDataSourceDesigner : ProviderDataSourceDesigner<TcbKetQuaQuyDoi, TcbKetQuaQuyDoiKey>
	{
		/// <summary>
		/// Initializes a new instance of the TcbKetQuaQuyDoiDataSourceDesigner class.
		/// </summary>
		public TcbKetQuaQuyDoiDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public TcbKetQuaQuyDoiSelectMethod SelectMethod
		{
			get { return ((TcbKetQuaQuyDoiDataSource) DataSource).SelectMethod; }
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
				actions.Add(new TcbKetQuaQuyDoiDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region TcbKetQuaQuyDoiDataSourceActionList

	/// <summary>
	/// Supports the TcbKetQuaQuyDoiDataSourceDesigner class.
	/// </summary>
	internal class TcbKetQuaQuyDoiDataSourceActionList : DesignerActionList
	{
		private TcbKetQuaQuyDoiDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the TcbKetQuaQuyDoiDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public TcbKetQuaQuyDoiDataSourceActionList(TcbKetQuaQuyDoiDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public TcbKetQuaQuyDoiSelectMethod SelectMethod
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

	#endregion TcbKetQuaQuyDoiDataSourceActionList
	
	#endregion TcbKetQuaQuyDoiDataSourceDesigner
	
	#region TcbKetQuaQuyDoiSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the TcbKetQuaQuyDoiDataSource.SelectMethod property.
	/// </summary>
	public enum TcbKetQuaQuyDoiSelectMethod
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
	
	#endregion TcbKetQuaQuyDoiSelectMethod

	#region TcbKetQuaQuyDoiFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="TcbKetQuaQuyDoi"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class TcbKetQuaQuyDoiFilter : SqlFilter<TcbKetQuaQuyDoiColumn>
	{
	}
	
	#endregion TcbKetQuaQuyDoiFilter

	#region TcbKetQuaQuyDoiExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="TcbKetQuaQuyDoi"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class TcbKetQuaQuyDoiExpressionBuilder : SqlExpressionBuilder<TcbKetQuaQuyDoiColumn>
	{
	}
	
	#endregion TcbKetQuaQuyDoiExpressionBuilder	

	#region TcbKetQuaQuyDoiProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;TcbKetQuaQuyDoiChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="TcbKetQuaQuyDoi"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class TcbKetQuaQuyDoiProperty : ChildEntityProperty<TcbKetQuaQuyDoiChildEntityTypes>
	{
	}
	
	#endregion TcbKetQuaQuyDoiProperty
}

