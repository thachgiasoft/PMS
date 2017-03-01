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
	/// Represents the DataRepository.MonKhongTinhProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(MonKhongTinhDataSourceDesigner))]
	public class MonKhongTinhDataSource : ProviderDataSource<MonKhongTinh, MonKhongTinhKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the MonKhongTinhDataSource class.
		/// </summary>
		public MonKhongTinhDataSource() : base(new MonKhongTinhService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the MonKhongTinhDataSourceView used by the MonKhongTinhDataSource.
		/// </summary>
		protected MonKhongTinhDataSourceView MonKhongTinhView
		{
			get { return ( View as MonKhongTinhDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the MonKhongTinhDataSource control invokes to retrieve data.
		/// </summary>
		public MonKhongTinhSelectMethod SelectMethod
		{
			get
			{
				MonKhongTinhSelectMethod selectMethod = MonKhongTinhSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (MonKhongTinhSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the MonKhongTinhDataSourceView class that is to be
		/// used by the MonKhongTinhDataSource.
		/// </summary>
		/// <returns>An instance of the MonKhongTinhDataSourceView class.</returns>
		protected override BaseDataSourceView<MonKhongTinh, MonKhongTinhKey> GetNewDataSourceView()
		{
			return new MonKhongTinhDataSourceView(this, DefaultViewName);
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
	/// Supports the MonKhongTinhDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class MonKhongTinhDataSourceView : ProviderDataSourceView<MonKhongTinh, MonKhongTinhKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the MonKhongTinhDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the MonKhongTinhDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public MonKhongTinhDataSourceView(MonKhongTinhDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal MonKhongTinhDataSource MonKhongTinhOwner
		{
			get { return Owner as MonKhongTinhDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal MonKhongTinhSelectMethod SelectMethod
		{
			get { return MonKhongTinhOwner.SelectMethod; }
			set { MonKhongTinhOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal MonKhongTinhService MonKhongTinhProvider
		{
			get { return Provider as MonKhongTinhService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<MonKhongTinh> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<MonKhongTinh> results = null;
			MonKhongTinh item;
			count = 0;
			
			System.String _maMonHoc;

			switch ( SelectMethod )
			{
				case MonKhongTinhSelectMethod.Get:
					MonKhongTinhKey entityKey  = new MonKhongTinhKey();
					entityKey.Load(values);
					item = MonKhongTinhProvider.Get(entityKey);
					results = new TList<MonKhongTinh>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case MonKhongTinhSelectMethod.GetAll:
                    results = MonKhongTinhProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case MonKhongTinhSelectMethod.GetPaged:
					results = MonKhongTinhProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case MonKhongTinhSelectMethod.Find:
					if ( FilterParameters != null )
						results = MonKhongTinhProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = MonKhongTinhProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case MonKhongTinhSelectMethod.GetByMaMonHoc:
					_maMonHoc = ( values["MaMonHoc"] != null ) ? (System.String) EntityUtil.ChangeType(values["MaMonHoc"], typeof(System.String)) : string.Empty;
					item = MonKhongTinhProvider.GetByMaMonHoc(_maMonHoc);
					results = new TList<MonKhongTinh>();
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
			if ( SelectMethod == MonKhongTinhSelectMethod.Get || SelectMethod == MonKhongTinhSelectMethod.GetByMaMonHoc )
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
				MonKhongTinh entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					MonKhongTinhProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<MonKhongTinh> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			MonKhongTinhProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region MonKhongTinhDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the MonKhongTinhDataSource class.
	/// </summary>
	public class MonKhongTinhDataSourceDesigner : ProviderDataSourceDesigner<MonKhongTinh, MonKhongTinhKey>
	{
		/// <summary>
		/// Initializes a new instance of the MonKhongTinhDataSourceDesigner class.
		/// </summary>
		public MonKhongTinhDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public MonKhongTinhSelectMethod SelectMethod
		{
			get { return ((MonKhongTinhDataSource) DataSource).SelectMethod; }
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
				actions.Add(new MonKhongTinhDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region MonKhongTinhDataSourceActionList

	/// <summary>
	/// Supports the MonKhongTinhDataSourceDesigner class.
	/// </summary>
	internal class MonKhongTinhDataSourceActionList : DesignerActionList
	{
		private MonKhongTinhDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the MonKhongTinhDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public MonKhongTinhDataSourceActionList(MonKhongTinhDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public MonKhongTinhSelectMethod SelectMethod
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

	#endregion MonKhongTinhDataSourceActionList
	
	#endregion MonKhongTinhDataSourceDesigner
	
	#region MonKhongTinhSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the MonKhongTinhDataSource.SelectMethod property.
	/// </summary>
	public enum MonKhongTinhSelectMethod
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
		/// Represents the GetByMaMonHoc method.
		/// </summary>
		GetByMaMonHoc
	}
	
	#endregion MonKhongTinhSelectMethod

	#region MonKhongTinhFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="MonKhongTinh"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class MonKhongTinhFilter : SqlFilter<MonKhongTinhColumn>
	{
	}
	
	#endregion MonKhongTinhFilter

	#region MonKhongTinhExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="MonKhongTinh"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class MonKhongTinhExpressionBuilder : SqlExpressionBuilder<MonKhongTinhColumn>
	{
	}
	
	#endregion MonKhongTinhExpressionBuilder	

	#region MonKhongTinhProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;MonKhongTinhChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="MonKhongTinh"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class MonKhongTinhProperty : ChildEntityProperty<MonKhongTinhChildEntityTypes>
	{
	}
	
	#endregion MonKhongTinhProperty
}

