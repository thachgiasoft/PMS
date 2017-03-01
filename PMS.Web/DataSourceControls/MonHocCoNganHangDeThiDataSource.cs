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
	/// Represents the DataRepository.MonHocCoNganHangDeThiProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(MonHocCoNganHangDeThiDataSourceDesigner))]
	public class MonHocCoNganHangDeThiDataSource : ProviderDataSource<MonHocCoNganHangDeThi, MonHocCoNganHangDeThiKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the MonHocCoNganHangDeThiDataSource class.
		/// </summary>
		public MonHocCoNganHangDeThiDataSource() : base(new MonHocCoNganHangDeThiService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the MonHocCoNganHangDeThiDataSourceView used by the MonHocCoNganHangDeThiDataSource.
		/// </summary>
		protected MonHocCoNganHangDeThiDataSourceView MonHocCoNganHangDeThiView
		{
			get { return ( View as MonHocCoNganHangDeThiDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the MonHocCoNganHangDeThiDataSource control invokes to retrieve data.
		/// </summary>
		public MonHocCoNganHangDeThiSelectMethod SelectMethod
		{
			get
			{
				MonHocCoNganHangDeThiSelectMethod selectMethod = MonHocCoNganHangDeThiSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (MonHocCoNganHangDeThiSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the MonHocCoNganHangDeThiDataSourceView class that is to be
		/// used by the MonHocCoNganHangDeThiDataSource.
		/// </summary>
		/// <returns>An instance of the MonHocCoNganHangDeThiDataSourceView class.</returns>
		protected override BaseDataSourceView<MonHocCoNganHangDeThi, MonHocCoNganHangDeThiKey> GetNewDataSourceView()
		{
			return new MonHocCoNganHangDeThiDataSourceView(this, DefaultViewName);
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
	/// Supports the MonHocCoNganHangDeThiDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class MonHocCoNganHangDeThiDataSourceView : ProviderDataSourceView<MonHocCoNganHangDeThi, MonHocCoNganHangDeThiKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the MonHocCoNganHangDeThiDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the MonHocCoNganHangDeThiDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public MonHocCoNganHangDeThiDataSourceView(MonHocCoNganHangDeThiDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal MonHocCoNganHangDeThiDataSource MonHocCoNganHangDeThiOwner
		{
			get { return Owner as MonHocCoNganHangDeThiDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal MonHocCoNganHangDeThiSelectMethod SelectMethod
		{
			get { return MonHocCoNganHangDeThiOwner.SelectMethod; }
			set { MonHocCoNganHangDeThiOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal MonHocCoNganHangDeThiService MonHocCoNganHangDeThiProvider
		{
			get { return Provider as MonHocCoNganHangDeThiService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<MonHocCoNganHangDeThi> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<MonHocCoNganHangDeThi> results = null;
			MonHocCoNganHangDeThi item;
			count = 0;
			
			System.Int32 _maQuanLy;

			switch ( SelectMethod )
			{
				case MonHocCoNganHangDeThiSelectMethod.Get:
					MonHocCoNganHangDeThiKey entityKey  = new MonHocCoNganHangDeThiKey();
					entityKey.Load(values);
					item = MonHocCoNganHangDeThiProvider.Get(entityKey);
					results = new TList<MonHocCoNganHangDeThi>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case MonHocCoNganHangDeThiSelectMethod.GetAll:
                    results = MonHocCoNganHangDeThiProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case MonHocCoNganHangDeThiSelectMethod.GetPaged:
					results = MonHocCoNganHangDeThiProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case MonHocCoNganHangDeThiSelectMethod.Find:
					if ( FilterParameters != null )
						results = MonHocCoNganHangDeThiProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = MonHocCoNganHangDeThiProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case MonHocCoNganHangDeThiSelectMethod.GetByMaQuanLy:
					_maQuanLy = ( values["MaQuanLy"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["MaQuanLy"], typeof(System.Int32)) : (int)0;
					item = MonHocCoNganHangDeThiProvider.GetByMaQuanLy(_maQuanLy);
					results = new TList<MonHocCoNganHangDeThi>();
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
			if ( SelectMethod == MonHocCoNganHangDeThiSelectMethod.Get || SelectMethod == MonHocCoNganHangDeThiSelectMethod.GetByMaQuanLy )
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
				MonHocCoNganHangDeThi entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					MonHocCoNganHangDeThiProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<MonHocCoNganHangDeThi> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			MonHocCoNganHangDeThiProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region MonHocCoNganHangDeThiDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the MonHocCoNganHangDeThiDataSource class.
	/// </summary>
	public class MonHocCoNganHangDeThiDataSourceDesigner : ProviderDataSourceDesigner<MonHocCoNganHangDeThi, MonHocCoNganHangDeThiKey>
	{
		/// <summary>
		/// Initializes a new instance of the MonHocCoNganHangDeThiDataSourceDesigner class.
		/// </summary>
		public MonHocCoNganHangDeThiDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public MonHocCoNganHangDeThiSelectMethod SelectMethod
		{
			get { return ((MonHocCoNganHangDeThiDataSource) DataSource).SelectMethod; }
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
				actions.Add(new MonHocCoNganHangDeThiDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region MonHocCoNganHangDeThiDataSourceActionList

	/// <summary>
	/// Supports the MonHocCoNganHangDeThiDataSourceDesigner class.
	/// </summary>
	internal class MonHocCoNganHangDeThiDataSourceActionList : DesignerActionList
	{
		private MonHocCoNganHangDeThiDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the MonHocCoNganHangDeThiDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public MonHocCoNganHangDeThiDataSourceActionList(MonHocCoNganHangDeThiDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public MonHocCoNganHangDeThiSelectMethod SelectMethod
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

	#endregion MonHocCoNganHangDeThiDataSourceActionList
	
	#endregion MonHocCoNganHangDeThiDataSourceDesigner
	
	#region MonHocCoNganHangDeThiSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the MonHocCoNganHangDeThiDataSource.SelectMethod property.
	/// </summary>
	public enum MonHocCoNganHangDeThiSelectMethod
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
		/// Represents the GetByMaQuanLy method.
		/// </summary>
		GetByMaQuanLy
	}
	
	#endregion MonHocCoNganHangDeThiSelectMethod

	#region MonHocCoNganHangDeThiFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="MonHocCoNganHangDeThi"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class MonHocCoNganHangDeThiFilter : SqlFilter<MonHocCoNganHangDeThiColumn>
	{
	}
	
	#endregion MonHocCoNganHangDeThiFilter

	#region MonHocCoNganHangDeThiExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="MonHocCoNganHangDeThi"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class MonHocCoNganHangDeThiExpressionBuilder : SqlExpressionBuilder<MonHocCoNganHangDeThiColumn>
	{
	}
	
	#endregion MonHocCoNganHangDeThiExpressionBuilder	

	#region MonHocCoNganHangDeThiProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;MonHocCoNganHangDeThiChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="MonHocCoNganHangDeThi"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class MonHocCoNganHangDeThiProperty : ChildEntityProperty<MonHocCoNganHangDeThiChildEntityTypes>
	{
	}
	
	#endregion MonHocCoNganHangDeThiProperty
}

