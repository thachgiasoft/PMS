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
	/// Represents the DataRepository.MonTinhTheoQuyCheMoiProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(MonTinhTheoQuyCheMoiDataSourceDesigner))]
	public class MonTinhTheoQuyCheMoiDataSource : ProviderDataSource<MonTinhTheoQuyCheMoi, MonTinhTheoQuyCheMoiKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the MonTinhTheoQuyCheMoiDataSource class.
		/// </summary>
		public MonTinhTheoQuyCheMoiDataSource() : base(new MonTinhTheoQuyCheMoiService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the MonTinhTheoQuyCheMoiDataSourceView used by the MonTinhTheoQuyCheMoiDataSource.
		/// </summary>
		protected MonTinhTheoQuyCheMoiDataSourceView MonTinhTheoQuyCheMoiView
		{
			get { return ( View as MonTinhTheoQuyCheMoiDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the MonTinhTheoQuyCheMoiDataSource control invokes to retrieve data.
		/// </summary>
		public MonTinhTheoQuyCheMoiSelectMethod SelectMethod
		{
			get
			{
				MonTinhTheoQuyCheMoiSelectMethod selectMethod = MonTinhTheoQuyCheMoiSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (MonTinhTheoQuyCheMoiSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the MonTinhTheoQuyCheMoiDataSourceView class that is to be
		/// used by the MonTinhTheoQuyCheMoiDataSource.
		/// </summary>
		/// <returns>An instance of the MonTinhTheoQuyCheMoiDataSourceView class.</returns>
		protected override BaseDataSourceView<MonTinhTheoQuyCheMoi, MonTinhTheoQuyCheMoiKey> GetNewDataSourceView()
		{
			return new MonTinhTheoQuyCheMoiDataSourceView(this, DefaultViewName);
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
	/// Supports the MonTinhTheoQuyCheMoiDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class MonTinhTheoQuyCheMoiDataSourceView : ProviderDataSourceView<MonTinhTheoQuyCheMoi, MonTinhTheoQuyCheMoiKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the MonTinhTheoQuyCheMoiDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the MonTinhTheoQuyCheMoiDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public MonTinhTheoQuyCheMoiDataSourceView(MonTinhTheoQuyCheMoiDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal MonTinhTheoQuyCheMoiDataSource MonTinhTheoQuyCheMoiOwner
		{
			get { return Owner as MonTinhTheoQuyCheMoiDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal MonTinhTheoQuyCheMoiSelectMethod SelectMethod
		{
			get { return MonTinhTheoQuyCheMoiOwner.SelectMethod; }
			set { MonTinhTheoQuyCheMoiOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal MonTinhTheoQuyCheMoiService MonTinhTheoQuyCheMoiProvider
		{
			get { return Provider as MonTinhTheoQuyCheMoiService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<MonTinhTheoQuyCheMoi> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<MonTinhTheoQuyCheMoi> results = null;
			MonTinhTheoQuyCheMoi item;
			count = 0;
			
			System.Int32 _id;

			switch ( SelectMethod )
			{
				case MonTinhTheoQuyCheMoiSelectMethod.Get:
					MonTinhTheoQuyCheMoiKey entityKey  = new MonTinhTheoQuyCheMoiKey();
					entityKey.Load(values);
					item = MonTinhTheoQuyCheMoiProvider.Get(entityKey);
					results = new TList<MonTinhTheoQuyCheMoi>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case MonTinhTheoQuyCheMoiSelectMethod.GetAll:
                    results = MonTinhTheoQuyCheMoiProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case MonTinhTheoQuyCheMoiSelectMethod.GetPaged:
					results = MonTinhTheoQuyCheMoiProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case MonTinhTheoQuyCheMoiSelectMethod.Find:
					if ( FilterParameters != null )
						results = MonTinhTheoQuyCheMoiProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = MonTinhTheoQuyCheMoiProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case MonTinhTheoQuyCheMoiSelectMethod.GetById:
					_id = ( values["Id"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["Id"], typeof(System.Int32)) : (int)0;
					item = MonTinhTheoQuyCheMoiProvider.GetById(_id);
					results = new TList<MonTinhTheoQuyCheMoi>();
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
			if ( SelectMethod == MonTinhTheoQuyCheMoiSelectMethod.Get || SelectMethod == MonTinhTheoQuyCheMoiSelectMethod.GetById )
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
				MonTinhTheoQuyCheMoi entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					MonTinhTheoQuyCheMoiProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<MonTinhTheoQuyCheMoi> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			MonTinhTheoQuyCheMoiProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region MonTinhTheoQuyCheMoiDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the MonTinhTheoQuyCheMoiDataSource class.
	/// </summary>
	public class MonTinhTheoQuyCheMoiDataSourceDesigner : ProviderDataSourceDesigner<MonTinhTheoQuyCheMoi, MonTinhTheoQuyCheMoiKey>
	{
		/// <summary>
		/// Initializes a new instance of the MonTinhTheoQuyCheMoiDataSourceDesigner class.
		/// </summary>
		public MonTinhTheoQuyCheMoiDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public MonTinhTheoQuyCheMoiSelectMethod SelectMethod
		{
			get { return ((MonTinhTheoQuyCheMoiDataSource) DataSource).SelectMethod; }
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
				actions.Add(new MonTinhTheoQuyCheMoiDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region MonTinhTheoQuyCheMoiDataSourceActionList

	/// <summary>
	/// Supports the MonTinhTheoQuyCheMoiDataSourceDesigner class.
	/// </summary>
	internal class MonTinhTheoQuyCheMoiDataSourceActionList : DesignerActionList
	{
		private MonTinhTheoQuyCheMoiDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the MonTinhTheoQuyCheMoiDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public MonTinhTheoQuyCheMoiDataSourceActionList(MonTinhTheoQuyCheMoiDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public MonTinhTheoQuyCheMoiSelectMethod SelectMethod
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

	#endregion MonTinhTheoQuyCheMoiDataSourceActionList
	
	#endregion MonTinhTheoQuyCheMoiDataSourceDesigner
	
	#region MonTinhTheoQuyCheMoiSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the MonTinhTheoQuyCheMoiDataSource.SelectMethod property.
	/// </summary>
	public enum MonTinhTheoQuyCheMoiSelectMethod
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
	
	#endregion MonTinhTheoQuyCheMoiSelectMethod

	#region MonTinhTheoQuyCheMoiFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="MonTinhTheoQuyCheMoi"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class MonTinhTheoQuyCheMoiFilter : SqlFilter<MonTinhTheoQuyCheMoiColumn>
	{
	}
	
	#endregion MonTinhTheoQuyCheMoiFilter

	#region MonTinhTheoQuyCheMoiExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="MonTinhTheoQuyCheMoi"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class MonTinhTheoQuyCheMoiExpressionBuilder : SqlExpressionBuilder<MonTinhTheoQuyCheMoiColumn>
	{
	}
	
	#endregion MonTinhTheoQuyCheMoiExpressionBuilder	

	#region MonTinhTheoQuyCheMoiProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;MonTinhTheoQuyCheMoiChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="MonTinhTheoQuyCheMoi"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class MonTinhTheoQuyCheMoiProperty : ChildEntityProperty<MonTinhTheoQuyCheMoiChildEntityTypes>
	{
	}
	
	#endregion MonTinhTheoQuyCheMoiProperty
}

