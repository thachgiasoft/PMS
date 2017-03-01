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
	/// Represents the DataRepository.MonHocTinhHeSoKhoiNganhProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(MonHocTinhHeSoKhoiNganhDataSourceDesigner))]
	public class MonHocTinhHeSoKhoiNganhDataSource : ProviderDataSource<MonHocTinhHeSoKhoiNganh, MonHocTinhHeSoKhoiNganhKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the MonHocTinhHeSoKhoiNganhDataSource class.
		/// </summary>
		public MonHocTinhHeSoKhoiNganhDataSource() : base(new MonHocTinhHeSoKhoiNganhService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the MonHocTinhHeSoKhoiNganhDataSourceView used by the MonHocTinhHeSoKhoiNganhDataSource.
		/// </summary>
		protected MonHocTinhHeSoKhoiNganhDataSourceView MonHocTinhHeSoKhoiNganhView
		{
			get { return ( View as MonHocTinhHeSoKhoiNganhDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the MonHocTinhHeSoKhoiNganhDataSource control invokes to retrieve data.
		/// </summary>
		public MonHocTinhHeSoKhoiNganhSelectMethod SelectMethod
		{
			get
			{
				MonHocTinhHeSoKhoiNganhSelectMethod selectMethod = MonHocTinhHeSoKhoiNganhSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (MonHocTinhHeSoKhoiNganhSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the MonHocTinhHeSoKhoiNganhDataSourceView class that is to be
		/// used by the MonHocTinhHeSoKhoiNganhDataSource.
		/// </summary>
		/// <returns>An instance of the MonHocTinhHeSoKhoiNganhDataSourceView class.</returns>
		protected override BaseDataSourceView<MonHocTinhHeSoKhoiNganh, MonHocTinhHeSoKhoiNganhKey> GetNewDataSourceView()
		{
			return new MonHocTinhHeSoKhoiNganhDataSourceView(this, DefaultViewName);
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
	/// Supports the MonHocTinhHeSoKhoiNganhDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class MonHocTinhHeSoKhoiNganhDataSourceView : ProviderDataSourceView<MonHocTinhHeSoKhoiNganh, MonHocTinhHeSoKhoiNganhKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the MonHocTinhHeSoKhoiNganhDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the MonHocTinhHeSoKhoiNganhDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public MonHocTinhHeSoKhoiNganhDataSourceView(MonHocTinhHeSoKhoiNganhDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal MonHocTinhHeSoKhoiNganhDataSource MonHocTinhHeSoKhoiNganhOwner
		{
			get { return Owner as MonHocTinhHeSoKhoiNganhDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal MonHocTinhHeSoKhoiNganhSelectMethod SelectMethod
		{
			get { return MonHocTinhHeSoKhoiNganhOwner.SelectMethod; }
			set { MonHocTinhHeSoKhoiNganhOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal MonHocTinhHeSoKhoiNganhService MonHocTinhHeSoKhoiNganhProvider
		{
			get { return Provider as MonHocTinhHeSoKhoiNganhService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<MonHocTinhHeSoKhoiNganh> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<MonHocTinhHeSoKhoiNganh> results = null;
			MonHocTinhHeSoKhoiNganh item;
			count = 0;
			
			System.Int32 _id;

			switch ( SelectMethod )
			{
				case MonHocTinhHeSoKhoiNganhSelectMethod.Get:
					MonHocTinhHeSoKhoiNganhKey entityKey  = new MonHocTinhHeSoKhoiNganhKey();
					entityKey.Load(values);
					item = MonHocTinhHeSoKhoiNganhProvider.Get(entityKey);
					results = new TList<MonHocTinhHeSoKhoiNganh>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case MonHocTinhHeSoKhoiNganhSelectMethod.GetAll:
                    results = MonHocTinhHeSoKhoiNganhProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case MonHocTinhHeSoKhoiNganhSelectMethod.GetPaged:
					results = MonHocTinhHeSoKhoiNganhProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case MonHocTinhHeSoKhoiNganhSelectMethod.Find:
					if ( FilterParameters != null )
						results = MonHocTinhHeSoKhoiNganhProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = MonHocTinhHeSoKhoiNganhProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case MonHocTinhHeSoKhoiNganhSelectMethod.GetById:
					_id = ( values["Id"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["Id"], typeof(System.Int32)) : (int)0;
					item = MonHocTinhHeSoKhoiNganhProvider.GetById(_id);
					results = new TList<MonHocTinhHeSoKhoiNganh>();
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
			if ( SelectMethod == MonHocTinhHeSoKhoiNganhSelectMethod.Get || SelectMethod == MonHocTinhHeSoKhoiNganhSelectMethod.GetById )
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
				MonHocTinhHeSoKhoiNganh entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					MonHocTinhHeSoKhoiNganhProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<MonHocTinhHeSoKhoiNganh> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			MonHocTinhHeSoKhoiNganhProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region MonHocTinhHeSoKhoiNganhDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the MonHocTinhHeSoKhoiNganhDataSource class.
	/// </summary>
	public class MonHocTinhHeSoKhoiNganhDataSourceDesigner : ProviderDataSourceDesigner<MonHocTinhHeSoKhoiNganh, MonHocTinhHeSoKhoiNganhKey>
	{
		/// <summary>
		/// Initializes a new instance of the MonHocTinhHeSoKhoiNganhDataSourceDesigner class.
		/// </summary>
		public MonHocTinhHeSoKhoiNganhDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public MonHocTinhHeSoKhoiNganhSelectMethod SelectMethod
		{
			get { return ((MonHocTinhHeSoKhoiNganhDataSource) DataSource).SelectMethod; }
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
				actions.Add(new MonHocTinhHeSoKhoiNganhDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region MonHocTinhHeSoKhoiNganhDataSourceActionList

	/// <summary>
	/// Supports the MonHocTinhHeSoKhoiNganhDataSourceDesigner class.
	/// </summary>
	internal class MonHocTinhHeSoKhoiNganhDataSourceActionList : DesignerActionList
	{
		private MonHocTinhHeSoKhoiNganhDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the MonHocTinhHeSoKhoiNganhDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public MonHocTinhHeSoKhoiNganhDataSourceActionList(MonHocTinhHeSoKhoiNganhDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public MonHocTinhHeSoKhoiNganhSelectMethod SelectMethod
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

	#endregion MonHocTinhHeSoKhoiNganhDataSourceActionList
	
	#endregion MonHocTinhHeSoKhoiNganhDataSourceDesigner
	
	#region MonHocTinhHeSoKhoiNganhSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the MonHocTinhHeSoKhoiNganhDataSource.SelectMethod property.
	/// </summary>
	public enum MonHocTinhHeSoKhoiNganhSelectMethod
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
	
	#endregion MonHocTinhHeSoKhoiNganhSelectMethod

	#region MonHocTinhHeSoKhoiNganhFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="MonHocTinhHeSoKhoiNganh"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class MonHocTinhHeSoKhoiNganhFilter : SqlFilter<MonHocTinhHeSoKhoiNganhColumn>
	{
	}
	
	#endregion MonHocTinhHeSoKhoiNganhFilter

	#region MonHocTinhHeSoKhoiNganhExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="MonHocTinhHeSoKhoiNganh"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class MonHocTinhHeSoKhoiNganhExpressionBuilder : SqlExpressionBuilder<MonHocTinhHeSoKhoiNganhColumn>
	{
	}
	
	#endregion MonHocTinhHeSoKhoiNganhExpressionBuilder	

	#region MonHocTinhHeSoKhoiNganhProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;MonHocTinhHeSoKhoiNganhChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="MonHocTinhHeSoKhoiNganh"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class MonHocTinhHeSoKhoiNganhProperty : ChildEntityProperty<MonHocTinhHeSoKhoiNganhChildEntityTypes>
	{
	}
	
	#endregion MonHocTinhHeSoKhoiNganhProperty
}

