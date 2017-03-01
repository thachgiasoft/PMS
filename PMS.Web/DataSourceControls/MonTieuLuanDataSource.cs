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
	/// Represents the DataRepository.MonTieuLuanProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(MonTieuLuanDataSourceDesigner))]
	public class MonTieuLuanDataSource : ProviderDataSource<MonTieuLuan, MonTieuLuanKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the MonTieuLuanDataSource class.
		/// </summary>
		public MonTieuLuanDataSource() : base(new MonTieuLuanService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the MonTieuLuanDataSourceView used by the MonTieuLuanDataSource.
		/// </summary>
		protected MonTieuLuanDataSourceView MonTieuLuanView
		{
			get { return ( View as MonTieuLuanDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the MonTieuLuanDataSource control invokes to retrieve data.
		/// </summary>
		public MonTieuLuanSelectMethod SelectMethod
		{
			get
			{
				MonTieuLuanSelectMethod selectMethod = MonTieuLuanSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (MonTieuLuanSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the MonTieuLuanDataSourceView class that is to be
		/// used by the MonTieuLuanDataSource.
		/// </summary>
		/// <returns>An instance of the MonTieuLuanDataSourceView class.</returns>
		protected override BaseDataSourceView<MonTieuLuan, MonTieuLuanKey> GetNewDataSourceView()
		{
			return new MonTieuLuanDataSourceView(this, DefaultViewName);
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
	/// Supports the MonTieuLuanDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class MonTieuLuanDataSourceView : ProviderDataSourceView<MonTieuLuan, MonTieuLuanKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the MonTieuLuanDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the MonTieuLuanDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public MonTieuLuanDataSourceView(MonTieuLuanDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal MonTieuLuanDataSource MonTieuLuanOwner
		{
			get { return Owner as MonTieuLuanDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal MonTieuLuanSelectMethod SelectMethod
		{
			get { return MonTieuLuanOwner.SelectMethod; }
			set { MonTieuLuanOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal MonTieuLuanService MonTieuLuanProvider
		{
			get { return Provider as MonTieuLuanService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<MonTieuLuan> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<MonTieuLuan> results = null;
			MonTieuLuan item;
			count = 0;
			
			System.Int32 _id;

			switch ( SelectMethod )
			{
				case MonTieuLuanSelectMethod.Get:
					MonTieuLuanKey entityKey  = new MonTieuLuanKey();
					entityKey.Load(values);
					item = MonTieuLuanProvider.Get(entityKey);
					results = new TList<MonTieuLuan>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case MonTieuLuanSelectMethod.GetAll:
                    results = MonTieuLuanProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case MonTieuLuanSelectMethod.GetPaged:
					results = MonTieuLuanProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case MonTieuLuanSelectMethod.Find:
					if ( FilterParameters != null )
						results = MonTieuLuanProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = MonTieuLuanProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case MonTieuLuanSelectMethod.GetById:
					_id = ( values["Id"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["Id"], typeof(System.Int32)) : (int)0;
					item = MonTieuLuanProvider.GetById(_id);
					results = new TList<MonTieuLuan>();
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
			if ( SelectMethod == MonTieuLuanSelectMethod.Get || SelectMethod == MonTieuLuanSelectMethod.GetById )
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
				MonTieuLuan entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					MonTieuLuanProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<MonTieuLuan> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			MonTieuLuanProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region MonTieuLuanDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the MonTieuLuanDataSource class.
	/// </summary>
	public class MonTieuLuanDataSourceDesigner : ProviderDataSourceDesigner<MonTieuLuan, MonTieuLuanKey>
	{
		/// <summary>
		/// Initializes a new instance of the MonTieuLuanDataSourceDesigner class.
		/// </summary>
		public MonTieuLuanDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public MonTieuLuanSelectMethod SelectMethod
		{
			get { return ((MonTieuLuanDataSource) DataSource).SelectMethod; }
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
				actions.Add(new MonTieuLuanDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region MonTieuLuanDataSourceActionList

	/// <summary>
	/// Supports the MonTieuLuanDataSourceDesigner class.
	/// </summary>
	internal class MonTieuLuanDataSourceActionList : DesignerActionList
	{
		private MonTieuLuanDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the MonTieuLuanDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public MonTieuLuanDataSourceActionList(MonTieuLuanDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public MonTieuLuanSelectMethod SelectMethod
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

	#endregion MonTieuLuanDataSourceActionList
	
	#endregion MonTieuLuanDataSourceDesigner
	
	#region MonTieuLuanSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the MonTieuLuanDataSource.SelectMethod property.
	/// </summary>
	public enum MonTieuLuanSelectMethod
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
	
	#endregion MonTieuLuanSelectMethod

	#region MonTieuLuanFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="MonTieuLuan"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class MonTieuLuanFilter : SqlFilter<MonTieuLuanColumn>
	{
	}
	
	#endregion MonTieuLuanFilter

	#region MonTieuLuanExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="MonTieuLuan"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class MonTieuLuanExpressionBuilder : SqlExpressionBuilder<MonTieuLuanColumn>
	{
	}
	
	#endregion MonTieuLuanExpressionBuilder	

	#region MonTieuLuanProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;MonTieuLuanChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="MonTieuLuan"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class MonTieuLuanProperty : ChildEntityProperty<MonTieuLuanChildEntityTypes>
	{
	}
	
	#endregion MonTieuLuanProperty
}

