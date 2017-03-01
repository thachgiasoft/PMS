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
	/// Represents the DataRepository.MonXepLichChuNhatKhongTinhHeSoProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(MonXepLichChuNhatKhongTinhHeSoDataSourceDesigner))]
	public class MonXepLichChuNhatKhongTinhHeSoDataSource : ProviderDataSource<MonXepLichChuNhatKhongTinhHeSo, MonXepLichChuNhatKhongTinhHeSoKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the MonXepLichChuNhatKhongTinhHeSoDataSource class.
		/// </summary>
		public MonXepLichChuNhatKhongTinhHeSoDataSource() : base(new MonXepLichChuNhatKhongTinhHeSoService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the MonXepLichChuNhatKhongTinhHeSoDataSourceView used by the MonXepLichChuNhatKhongTinhHeSoDataSource.
		/// </summary>
		protected MonXepLichChuNhatKhongTinhHeSoDataSourceView MonXepLichChuNhatKhongTinhHeSoView
		{
			get { return ( View as MonXepLichChuNhatKhongTinhHeSoDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the MonXepLichChuNhatKhongTinhHeSoDataSource control invokes to retrieve data.
		/// </summary>
		public MonXepLichChuNhatKhongTinhHeSoSelectMethod SelectMethod
		{
			get
			{
				MonXepLichChuNhatKhongTinhHeSoSelectMethod selectMethod = MonXepLichChuNhatKhongTinhHeSoSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (MonXepLichChuNhatKhongTinhHeSoSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the MonXepLichChuNhatKhongTinhHeSoDataSourceView class that is to be
		/// used by the MonXepLichChuNhatKhongTinhHeSoDataSource.
		/// </summary>
		/// <returns>An instance of the MonXepLichChuNhatKhongTinhHeSoDataSourceView class.</returns>
		protected override BaseDataSourceView<MonXepLichChuNhatKhongTinhHeSo, MonXepLichChuNhatKhongTinhHeSoKey> GetNewDataSourceView()
		{
			return new MonXepLichChuNhatKhongTinhHeSoDataSourceView(this, DefaultViewName);
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
	/// Supports the MonXepLichChuNhatKhongTinhHeSoDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class MonXepLichChuNhatKhongTinhHeSoDataSourceView : ProviderDataSourceView<MonXepLichChuNhatKhongTinhHeSo, MonXepLichChuNhatKhongTinhHeSoKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the MonXepLichChuNhatKhongTinhHeSoDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the MonXepLichChuNhatKhongTinhHeSoDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public MonXepLichChuNhatKhongTinhHeSoDataSourceView(MonXepLichChuNhatKhongTinhHeSoDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal MonXepLichChuNhatKhongTinhHeSoDataSource MonXepLichChuNhatKhongTinhHeSoOwner
		{
			get { return Owner as MonXepLichChuNhatKhongTinhHeSoDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal MonXepLichChuNhatKhongTinhHeSoSelectMethod SelectMethod
		{
			get { return MonXepLichChuNhatKhongTinhHeSoOwner.SelectMethod; }
			set { MonXepLichChuNhatKhongTinhHeSoOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal MonXepLichChuNhatKhongTinhHeSoService MonXepLichChuNhatKhongTinhHeSoProvider
		{
			get { return Provider as MonXepLichChuNhatKhongTinhHeSoService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<MonXepLichChuNhatKhongTinhHeSo> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<MonXepLichChuNhatKhongTinhHeSo> results = null;
			MonXepLichChuNhatKhongTinhHeSo item;
			count = 0;
			
			System.Int32 _id;

			switch ( SelectMethod )
			{
				case MonXepLichChuNhatKhongTinhHeSoSelectMethod.Get:
					MonXepLichChuNhatKhongTinhHeSoKey entityKey  = new MonXepLichChuNhatKhongTinhHeSoKey();
					entityKey.Load(values);
					item = MonXepLichChuNhatKhongTinhHeSoProvider.Get(entityKey);
					results = new TList<MonXepLichChuNhatKhongTinhHeSo>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case MonXepLichChuNhatKhongTinhHeSoSelectMethod.GetAll:
                    results = MonXepLichChuNhatKhongTinhHeSoProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case MonXepLichChuNhatKhongTinhHeSoSelectMethod.GetPaged:
					results = MonXepLichChuNhatKhongTinhHeSoProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case MonXepLichChuNhatKhongTinhHeSoSelectMethod.Find:
					if ( FilterParameters != null )
						results = MonXepLichChuNhatKhongTinhHeSoProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = MonXepLichChuNhatKhongTinhHeSoProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case MonXepLichChuNhatKhongTinhHeSoSelectMethod.GetById:
					_id = ( values["Id"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["Id"], typeof(System.Int32)) : (int)0;
					item = MonXepLichChuNhatKhongTinhHeSoProvider.GetById(_id);
					results = new TList<MonXepLichChuNhatKhongTinhHeSo>();
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
			if ( SelectMethod == MonXepLichChuNhatKhongTinhHeSoSelectMethod.Get || SelectMethod == MonXepLichChuNhatKhongTinhHeSoSelectMethod.GetById )
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
				MonXepLichChuNhatKhongTinhHeSo entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					MonXepLichChuNhatKhongTinhHeSoProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<MonXepLichChuNhatKhongTinhHeSo> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			MonXepLichChuNhatKhongTinhHeSoProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region MonXepLichChuNhatKhongTinhHeSoDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the MonXepLichChuNhatKhongTinhHeSoDataSource class.
	/// </summary>
	public class MonXepLichChuNhatKhongTinhHeSoDataSourceDesigner : ProviderDataSourceDesigner<MonXepLichChuNhatKhongTinhHeSo, MonXepLichChuNhatKhongTinhHeSoKey>
	{
		/// <summary>
		/// Initializes a new instance of the MonXepLichChuNhatKhongTinhHeSoDataSourceDesigner class.
		/// </summary>
		public MonXepLichChuNhatKhongTinhHeSoDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public MonXepLichChuNhatKhongTinhHeSoSelectMethod SelectMethod
		{
			get { return ((MonXepLichChuNhatKhongTinhHeSoDataSource) DataSource).SelectMethod; }
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
				actions.Add(new MonXepLichChuNhatKhongTinhHeSoDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region MonXepLichChuNhatKhongTinhHeSoDataSourceActionList

	/// <summary>
	/// Supports the MonXepLichChuNhatKhongTinhHeSoDataSourceDesigner class.
	/// </summary>
	internal class MonXepLichChuNhatKhongTinhHeSoDataSourceActionList : DesignerActionList
	{
		private MonXepLichChuNhatKhongTinhHeSoDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the MonXepLichChuNhatKhongTinhHeSoDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public MonXepLichChuNhatKhongTinhHeSoDataSourceActionList(MonXepLichChuNhatKhongTinhHeSoDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public MonXepLichChuNhatKhongTinhHeSoSelectMethod SelectMethod
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

	#endregion MonXepLichChuNhatKhongTinhHeSoDataSourceActionList
	
	#endregion MonXepLichChuNhatKhongTinhHeSoDataSourceDesigner
	
	#region MonXepLichChuNhatKhongTinhHeSoSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the MonXepLichChuNhatKhongTinhHeSoDataSource.SelectMethod property.
	/// </summary>
	public enum MonXepLichChuNhatKhongTinhHeSoSelectMethod
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
	
	#endregion MonXepLichChuNhatKhongTinhHeSoSelectMethod

	#region MonXepLichChuNhatKhongTinhHeSoFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="MonXepLichChuNhatKhongTinhHeSo"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class MonXepLichChuNhatKhongTinhHeSoFilter : SqlFilter<MonXepLichChuNhatKhongTinhHeSoColumn>
	{
	}
	
	#endregion MonXepLichChuNhatKhongTinhHeSoFilter

	#region MonXepLichChuNhatKhongTinhHeSoExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="MonXepLichChuNhatKhongTinhHeSo"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class MonXepLichChuNhatKhongTinhHeSoExpressionBuilder : SqlExpressionBuilder<MonXepLichChuNhatKhongTinhHeSoColumn>
	{
	}
	
	#endregion MonXepLichChuNhatKhongTinhHeSoExpressionBuilder	

	#region MonXepLichChuNhatKhongTinhHeSoProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;MonXepLichChuNhatKhongTinhHeSoChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="MonXepLichChuNhatKhongTinhHeSo"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class MonXepLichChuNhatKhongTinhHeSoProperty : ChildEntityProperty<MonXepLichChuNhatKhongTinhHeSoChildEntityTypes>
	{
	}
	
	#endregion MonXepLichChuNhatKhongTinhHeSoProperty
}

