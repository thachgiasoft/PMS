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
	/// Represents the DataRepository.ThuLaoRaDeVhuProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(ThuLaoRaDeVhuDataSourceDesigner))]
	public class ThuLaoRaDeVhuDataSource : ProviderDataSource<ThuLaoRaDeVhu, ThuLaoRaDeVhuKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ThuLaoRaDeVhuDataSource class.
		/// </summary>
		public ThuLaoRaDeVhuDataSource() : base(new ThuLaoRaDeVhuService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the ThuLaoRaDeVhuDataSourceView used by the ThuLaoRaDeVhuDataSource.
		/// </summary>
		protected ThuLaoRaDeVhuDataSourceView ThuLaoRaDeVhuView
		{
			get { return ( View as ThuLaoRaDeVhuDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the ThuLaoRaDeVhuDataSource control invokes to retrieve data.
		/// </summary>
		public ThuLaoRaDeVhuSelectMethod SelectMethod
		{
			get
			{
				ThuLaoRaDeVhuSelectMethod selectMethod = ThuLaoRaDeVhuSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (ThuLaoRaDeVhuSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the ThuLaoRaDeVhuDataSourceView class that is to be
		/// used by the ThuLaoRaDeVhuDataSource.
		/// </summary>
		/// <returns>An instance of the ThuLaoRaDeVhuDataSourceView class.</returns>
		protected override BaseDataSourceView<ThuLaoRaDeVhu, ThuLaoRaDeVhuKey> GetNewDataSourceView()
		{
			return new ThuLaoRaDeVhuDataSourceView(this, DefaultViewName);
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
	/// Supports the ThuLaoRaDeVhuDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class ThuLaoRaDeVhuDataSourceView : ProviderDataSourceView<ThuLaoRaDeVhu, ThuLaoRaDeVhuKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ThuLaoRaDeVhuDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the ThuLaoRaDeVhuDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public ThuLaoRaDeVhuDataSourceView(ThuLaoRaDeVhuDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal ThuLaoRaDeVhuDataSource ThuLaoRaDeVhuOwner
		{
			get { return Owner as ThuLaoRaDeVhuDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal ThuLaoRaDeVhuSelectMethod SelectMethod
		{
			get { return ThuLaoRaDeVhuOwner.SelectMethod; }
			set { ThuLaoRaDeVhuOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal ThuLaoRaDeVhuService ThuLaoRaDeVhuProvider
		{
			get { return Provider as ThuLaoRaDeVhuService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<ThuLaoRaDeVhu> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<ThuLaoRaDeVhu> results = null;
			ThuLaoRaDeVhu item;
			count = 0;
			
			System.Int32 _id;

			switch ( SelectMethod )
			{
				case ThuLaoRaDeVhuSelectMethod.Get:
					ThuLaoRaDeVhuKey entityKey  = new ThuLaoRaDeVhuKey();
					entityKey.Load(values);
					item = ThuLaoRaDeVhuProvider.Get(entityKey);
					results = new TList<ThuLaoRaDeVhu>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case ThuLaoRaDeVhuSelectMethod.GetAll:
                    results = ThuLaoRaDeVhuProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case ThuLaoRaDeVhuSelectMethod.GetPaged:
					results = ThuLaoRaDeVhuProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case ThuLaoRaDeVhuSelectMethod.Find:
					if ( FilterParameters != null )
						results = ThuLaoRaDeVhuProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = ThuLaoRaDeVhuProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case ThuLaoRaDeVhuSelectMethod.GetById:
					_id = ( values["Id"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["Id"], typeof(System.Int32)) : (int)0;
					item = ThuLaoRaDeVhuProvider.GetById(_id);
					results = new TList<ThuLaoRaDeVhu>();
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
			if ( SelectMethod == ThuLaoRaDeVhuSelectMethod.Get || SelectMethod == ThuLaoRaDeVhuSelectMethod.GetById )
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
				ThuLaoRaDeVhu entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					ThuLaoRaDeVhuProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<ThuLaoRaDeVhu> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			ThuLaoRaDeVhuProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region ThuLaoRaDeVhuDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the ThuLaoRaDeVhuDataSource class.
	/// </summary>
	public class ThuLaoRaDeVhuDataSourceDesigner : ProviderDataSourceDesigner<ThuLaoRaDeVhu, ThuLaoRaDeVhuKey>
	{
		/// <summary>
		/// Initializes a new instance of the ThuLaoRaDeVhuDataSourceDesigner class.
		/// </summary>
		public ThuLaoRaDeVhuDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public ThuLaoRaDeVhuSelectMethod SelectMethod
		{
			get { return ((ThuLaoRaDeVhuDataSource) DataSource).SelectMethod; }
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
				actions.Add(new ThuLaoRaDeVhuDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region ThuLaoRaDeVhuDataSourceActionList

	/// <summary>
	/// Supports the ThuLaoRaDeVhuDataSourceDesigner class.
	/// </summary>
	internal class ThuLaoRaDeVhuDataSourceActionList : DesignerActionList
	{
		private ThuLaoRaDeVhuDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the ThuLaoRaDeVhuDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public ThuLaoRaDeVhuDataSourceActionList(ThuLaoRaDeVhuDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public ThuLaoRaDeVhuSelectMethod SelectMethod
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

	#endregion ThuLaoRaDeVhuDataSourceActionList
	
	#endregion ThuLaoRaDeVhuDataSourceDesigner
	
	#region ThuLaoRaDeVhuSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the ThuLaoRaDeVhuDataSource.SelectMethod property.
	/// </summary>
	public enum ThuLaoRaDeVhuSelectMethod
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
	
	#endregion ThuLaoRaDeVhuSelectMethod

	#region ThuLaoRaDeVhuFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ThuLaoRaDeVhu"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ThuLaoRaDeVhuFilter : SqlFilter<ThuLaoRaDeVhuColumn>
	{
	}
	
	#endregion ThuLaoRaDeVhuFilter

	#region ThuLaoRaDeVhuExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ThuLaoRaDeVhu"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ThuLaoRaDeVhuExpressionBuilder : SqlExpressionBuilder<ThuLaoRaDeVhuColumn>
	{
	}
	
	#endregion ThuLaoRaDeVhuExpressionBuilder	

	#region ThuLaoRaDeVhuProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;ThuLaoRaDeVhuChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="ThuLaoRaDeVhu"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ThuLaoRaDeVhuProperty : ChildEntityProperty<ThuLaoRaDeVhuChildEntityTypes>
	{
	}
	
	#endregion ThuLaoRaDeVhuProperty
}

