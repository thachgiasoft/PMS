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
	/// Represents the DataRepository.LyDoTamNghiProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(LyDoTamNghiDataSourceDesigner))]
	public class LyDoTamNghiDataSource : ProviderDataSource<LyDoTamNghi, LyDoTamNghiKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the LyDoTamNghiDataSource class.
		/// </summary>
		public LyDoTamNghiDataSource() : base(new LyDoTamNghiService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the LyDoTamNghiDataSourceView used by the LyDoTamNghiDataSource.
		/// </summary>
		protected LyDoTamNghiDataSourceView LyDoTamNghiView
		{
			get { return ( View as LyDoTamNghiDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the LyDoTamNghiDataSource control invokes to retrieve data.
		/// </summary>
		public LyDoTamNghiSelectMethod SelectMethod
		{
			get
			{
				LyDoTamNghiSelectMethod selectMethod = LyDoTamNghiSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (LyDoTamNghiSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the LyDoTamNghiDataSourceView class that is to be
		/// used by the LyDoTamNghiDataSource.
		/// </summary>
		/// <returns>An instance of the LyDoTamNghiDataSourceView class.</returns>
		protected override BaseDataSourceView<LyDoTamNghi, LyDoTamNghiKey> GetNewDataSourceView()
		{
			return new LyDoTamNghiDataSourceView(this, DefaultViewName);
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
	/// Supports the LyDoTamNghiDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class LyDoTamNghiDataSourceView : ProviderDataSourceView<LyDoTamNghi, LyDoTamNghiKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the LyDoTamNghiDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the LyDoTamNghiDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public LyDoTamNghiDataSourceView(LyDoTamNghiDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal LyDoTamNghiDataSource LyDoTamNghiOwner
		{
			get { return Owner as LyDoTamNghiDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal LyDoTamNghiSelectMethod SelectMethod
		{
			get { return LyDoTamNghiOwner.SelectMethod; }
			set { LyDoTamNghiOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal LyDoTamNghiService LyDoTamNghiProvider
		{
			get { return Provider as LyDoTamNghiService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<LyDoTamNghi> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<LyDoTamNghi> results = null;
			LyDoTamNghi item;
			count = 0;
			
			System.Int32 _id;

			switch ( SelectMethod )
			{
				case LyDoTamNghiSelectMethod.Get:
					LyDoTamNghiKey entityKey  = new LyDoTamNghiKey();
					entityKey.Load(values);
					item = LyDoTamNghiProvider.Get(entityKey);
					results = new TList<LyDoTamNghi>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case LyDoTamNghiSelectMethod.GetAll:
                    results = LyDoTamNghiProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case LyDoTamNghiSelectMethod.GetPaged:
					results = LyDoTamNghiProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case LyDoTamNghiSelectMethod.Find:
					if ( FilterParameters != null )
						results = LyDoTamNghiProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = LyDoTamNghiProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case LyDoTamNghiSelectMethod.GetById:
					_id = ( values["Id"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["Id"], typeof(System.Int32)) : (int)0;
					item = LyDoTamNghiProvider.GetById(_id);
					results = new TList<LyDoTamNghi>();
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
			if ( SelectMethod == LyDoTamNghiSelectMethod.Get || SelectMethod == LyDoTamNghiSelectMethod.GetById )
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
				LyDoTamNghi entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					LyDoTamNghiProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<LyDoTamNghi> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			LyDoTamNghiProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region LyDoTamNghiDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the LyDoTamNghiDataSource class.
	/// </summary>
	public class LyDoTamNghiDataSourceDesigner : ProviderDataSourceDesigner<LyDoTamNghi, LyDoTamNghiKey>
	{
		/// <summary>
		/// Initializes a new instance of the LyDoTamNghiDataSourceDesigner class.
		/// </summary>
		public LyDoTamNghiDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public LyDoTamNghiSelectMethod SelectMethod
		{
			get { return ((LyDoTamNghiDataSource) DataSource).SelectMethod; }
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
				actions.Add(new LyDoTamNghiDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region LyDoTamNghiDataSourceActionList

	/// <summary>
	/// Supports the LyDoTamNghiDataSourceDesigner class.
	/// </summary>
	internal class LyDoTamNghiDataSourceActionList : DesignerActionList
	{
		private LyDoTamNghiDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the LyDoTamNghiDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public LyDoTamNghiDataSourceActionList(LyDoTamNghiDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public LyDoTamNghiSelectMethod SelectMethod
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

	#endregion LyDoTamNghiDataSourceActionList
	
	#endregion LyDoTamNghiDataSourceDesigner
	
	#region LyDoTamNghiSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the LyDoTamNghiDataSource.SelectMethod property.
	/// </summary>
	public enum LyDoTamNghiSelectMethod
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
	
	#endregion LyDoTamNghiSelectMethod

	#region LyDoTamNghiFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="LyDoTamNghi"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class LyDoTamNghiFilter : SqlFilter<LyDoTamNghiColumn>
	{
	}
	
	#endregion LyDoTamNghiFilter

	#region LyDoTamNghiExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="LyDoTamNghi"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class LyDoTamNghiExpressionBuilder : SqlExpressionBuilder<LyDoTamNghiColumn>
	{
	}
	
	#endregion LyDoTamNghiExpressionBuilder	

	#region LyDoTamNghiProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;LyDoTamNghiChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="LyDoTamNghi"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class LyDoTamNghiProperty : ChildEntityProperty<LyDoTamNghiChildEntityTypes>
	{
	}
	
	#endregion LyDoTamNghiProperty
}

