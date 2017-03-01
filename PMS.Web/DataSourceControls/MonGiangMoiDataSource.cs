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
	/// Represents the DataRepository.MonGiangMoiProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(MonGiangMoiDataSourceDesigner))]
	public class MonGiangMoiDataSource : ProviderDataSource<MonGiangMoi, MonGiangMoiKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the MonGiangMoiDataSource class.
		/// </summary>
		public MonGiangMoiDataSource() : base(new MonGiangMoiService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the MonGiangMoiDataSourceView used by the MonGiangMoiDataSource.
		/// </summary>
		protected MonGiangMoiDataSourceView MonGiangMoiView
		{
			get { return ( View as MonGiangMoiDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the MonGiangMoiDataSource control invokes to retrieve data.
		/// </summary>
		public MonGiangMoiSelectMethod SelectMethod
		{
			get
			{
				MonGiangMoiSelectMethod selectMethod = MonGiangMoiSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (MonGiangMoiSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the MonGiangMoiDataSourceView class that is to be
		/// used by the MonGiangMoiDataSource.
		/// </summary>
		/// <returns>An instance of the MonGiangMoiDataSourceView class.</returns>
		protected override BaseDataSourceView<MonGiangMoi, MonGiangMoiKey> GetNewDataSourceView()
		{
			return new MonGiangMoiDataSourceView(this, DefaultViewName);
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
	/// Supports the MonGiangMoiDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class MonGiangMoiDataSourceView : ProviderDataSourceView<MonGiangMoi, MonGiangMoiKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the MonGiangMoiDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the MonGiangMoiDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public MonGiangMoiDataSourceView(MonGiangMoiDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal MonGiangMoiDataSource MonGiangMoiOwner
		{
			get { return Owner as MonGiangMoiDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal MonGiangMoiSelectMethod SelectMethod
		{
			get { return MonGiangMoiOwner.SelectMethod; }
			set { MonGiangMoiOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal MonGiangMoiService MonGiangMoiProvider
		{
			get { return Provider as MonGiangMoiService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<MonGiangMoi> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<MonGiangMoi> results = null;
			MonGiangMoi item;
			count = 0;
			
			System.Int32 _id;

			switch ( SelectMethod )
			{
				case MonGiangMoiSelectMethod.Get:
					MonGiangMoiKey entityKey  = new MonGiangMoiKey();
					entityKey.Load(values);
					item = MonGiangMoiProvider.Get(entityKey);
					results = new TList<MonGiangMoi>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case MonGiangMoiSelectMethod.GetAll:
                    results = MonGiangMoiProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case MonGiangMoiSelectMethod.GetPaged:
					results = MonGiangMoiProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case MonGiangMoiSelectMethod.Find:
					if ( FilterParameters != null )
						results = MonGiangMoiProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = MonGiangMoiProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case MonGiangMoiSelectMethod.GetById:
					_id = ( values["Id"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["Id"], typeof(System.Int32)) : (int)0;
					item = MonGiangMoiProvider.GetById(_id);
					results = new TList<MonGiangMoi>();
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
			if ( SelectMethod == MonGiangMoiSelectMethod.Get || SelectMethod == MonGiangMoiSelectMethod.GetById )
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
				MonGiangMoi entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					MonGiangMoiProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<MonGiangMoi> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			MonGiangMoiProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region MonGiangMoiDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the MonGiangMoiDataSource class.
	/// </summary>
	public class MonGiangMoiDataSourceDesigner : ProviderDataSourceDesigner<MonGiangMoi, MonGiangMoiKey>
	{
		/// <summary>
		/// Initializes a new instance of the MonGiangMoiDataSourceDesigner class.
		/// </summary>
		public MonGiangMoiDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public MonGiangMoiSelectMethod SelectMethod
		{
			get { return ((MonGiangMoiDataSource) DataSource).SelectMethod; }
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
				actions.Add(new MonGiangMoiDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region MonGiangMoiDataSourceActionList

	/// <summary>
	/// Supports the MonGiangMoiDataSourceDesigner class.
	/// </summary>
	internal class MonGiangMoiDataSourceActionList : DesignerActionList
	{
		private MonGiangMoiDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the MonGiangMoiDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public MonGiangMoiDataSourceActionList(MonGiangMoiDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public MonGiangMoiSelectMethod SelectMethod
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

	#endregion MonGiangMoiDataSourceActionList
	
	#endregion MonGiangMoiDataSourceDesigner
	
	#region MonGiangMoiSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the MonGiangMoiDataSource.SelectMethod property.
	/// </summary>
	public enum MonGiangMoiSelectMethod
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
	
	#endregion MonGiangMoiSelectMethod

	#region MonGiangMoiFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="MonGiangMoi"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class MonGiangMoiFilter : SqlFilter<MonGiangMoiColumn>
	{
	}
	
	#endregion MonGiangMoiFilter

	#region MonGiangMoiExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="MonGiangMoi"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class MonGiangMoiExpressionBuilder : SqlExpressionBuilder<MonGiangMoiColumn>
	{
	}
	
	#endregion MonGiangMoiExpressionBuilder	

	#region MonGiangMoiProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;MonGiangMoiChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="MonGiangMoi"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class MonGiangMoiProperty : ChildEntityProperty<MonGiangMoiChildEntityTypes>
	{
	}
	
	#endregion MonGiangMoiProperty
}

