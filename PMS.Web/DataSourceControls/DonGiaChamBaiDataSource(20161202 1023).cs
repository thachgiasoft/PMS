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
	/// Represents the DataRepository.DonGiaChamBaiProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(DonGiaChamBaiDataSourceDesigner))]
	public class DonGiaChamBaiDataSource : ProviderDataSource<DonGiaChamBai, DonGiaChamBaiKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the DonGiaChamBaiDataSource class.
		/// </summary>
		public DonGiaChamBaiDataSource() : base(new DonGiaChamBaiService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the DonGiaChamBaiDataSourceView used by the DonGiaChamBaiDataSource.
		/// </summary>
		protected DonGiaChamBaiDataSourceView DonGiaChamBaiView
		{
			get { return ( View as DonGiaChamBaiDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DonGiaChamBaiDataSource control invokes to retrieve data.
		/// </summary>
		public DonGiaChamBaiSelectMethod SelectMethod
		{
			get
			{
				DonGiaChamBaiSelectMethod selectMethod = DonGiaChamBaiSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (DonGiaChamBaiSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the DonGiaChamBaiDataSourceView class that is to be
		/// used by the DonGiaChamBaiDataSource.
		/// </summary>
		/// <returns>An instance of the DonGiaChamBaiDataSourceView class.</returns>
		protected override BaseDataSourceView<DonGiaChamBai, DonGiaChamBaiKey> GetNewDataSourceView()
		{
			return new DonGiaChamBaiDataSourceView(this, DefaultViewName);
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
	/// Supports the DonGiaChamBaiDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class DonGiaChamBaiDataSourceView : ProviderDataSourceView<DonGiaChamBai, DonGiaChamBaiKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the DonGiaChamBaiDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the DonGiaChamBaiDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public DonGiaChamBaiDataSourceView(DonGiaChamBaiDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal DonGiaChamBaiDataSource DonGiaChamBaiOwner
		{
			get { return Owner as DonGiaChamBaiDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal DonGiaChamBaiSelectMethod SelectMethod
		{
			get { return DonGiaChamBaiOwner.SelectMethod; }
			set { DonGiaChamBaiOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal DonGiaChamBaiService DonGiaChamBaiProvider
		{
			get { return Provider as DonGiaChamBaiService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<DonGiaChamBai> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<DonGiaChamBai> results = null;
			DonGiaChamBai item;
			count = 0;
			
			System.Int32 _id;
			System.String sp2175_NamHoc;
			System.String sp2175_HocKy;

			switch ( SelectMethod )
			{
				case DonGiaChamBaiSelectMethod.Get:
					DonGiaChamBaiKey entityKey  = new DonGiaChamBaiKey();
					entityKey.Load(values);
					item = DonGiaChamBaiProvider.Get(entityKey);
					results = new TList<DonGiaChamBai>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case DonGiaChamBaiSelectMethod.GetAll:
                    results = DonGiaChamBaiProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case DonGiaChamBaiSelectMethod.GetPaged:
					results = DonGiaChamBaiProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case DonGiaChamBaiSelectMethod.Find:
					if ( FilterParameters != null )
						results = DonGiaChamBaiProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = DonGiaChamBaiProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case DonGiaChamBaiSelectMethod.GetById:
					_id = ( values["Id"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["Id"], typeof(System.Int32)) : (int)0;
					item = DonGiaChamBaiProvider.GetById(_id);
					results = new TList<DonGiaChamBai>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				// IX
				// FK
				// M:M
				// Custom
				case DonGiaChamBaiSelectMethod.GetByNamHocHocKy:
					sp2175_NamHoc = (System.String) EntityUtil.ChangeType(values["NamHoc"], typeof(System.String));
					sp2175_HocKy = (System.String) EntityUtil.ChangeType(values["HocKy"], typeof(System.String));
					results = DonGiaChamBaiProvider.GetByNamHocHocKy(sp2175_NamHoc, sp2175_HocKy, StartIndex, PageSize);
					break;
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
			if ( SelectMethod == DonGiaChamBaiSelectMethod.Get || SelectMethod == DonGiaChamBaiSelectMethod.GetById )
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
				DonGiaChamBai entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					DonGiaChamBaiProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<DonGiaChamBai> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			DonGiaChamBaiProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region DonGiaChamBaiDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the DonGiaChamBaiDataSource class.
	/// </summary>
	public class DonGiaChamBaiDataSourceDesigner : ProviderDataSourceDesigner<DonGiaChamBai, DonGiaChamBaiKey>
	{
		/// <summary>
		/// Initializes a new instance of the DonGiaChamBaiDataSourceDesigner class.
		/// </summary>
		public DonGiaChamBaiDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public DonGiaChamBaiSelectMethod SelectMethod
		{
			get { return ((DonGiaChamBaiDataSource) DataSource).SelectMethod; }
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
				actions.Add(new DonGiaChamBaiDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region DonGiaChamBaiDataSourceActionList

	/// <summary>
	/// Supports the DonGiaChamBaiDataSourceDesigner class.
	/// </summary>
	internal class DonGiaChamBaiDataSourceActionList : DesignerActionList
	{
		private DonGiaChamBaiDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the DonGiaChamBaiDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public DonGiaChamBaiDataSourceActionList(DonGiaChamBaiDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public DonGiaChamBaiSelectMethod SelectMethod
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

	#endregion DonGiaChamBaiDataSourceActionList
	
	#endregion DonGiaChamBaiDataSourceDesigner
	
	#region DonGiaChamBaiSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the DonGiaChamBaiDataSource.SelectMethod property.
	/// </summary>
	public enum DonGiaChamBaiSelectMethod
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
		GetById,
		/// <summary>
		/// Represents the GetByNamHocHocKy method.
		/// </summary>
		GetByNamHocHocKy
	}
	
	#endregion DonGiaChamBaiSelectMethod

	#region DonGiaChamBaiFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="DonGiaChamBai"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class DonGiaChamBaiFilter : SqlFilter<DonGiaChamBaiColumn>
	{
	}
	
	#endregion DonGiaChamBaiFilter

	#region DonGiaChamBaiExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="DonGiaChamBai"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class DonGiaChamBaiExpressionBuilder : SqlExpressionBuilder<DonGiaChamBaiColumn>
	{
	}
	
	#endregion DonGiaChamBaiExpressionBuilder	

	#region DonGiaChamBaiProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;DonGiaChamBaiChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="DonGiaChamBai"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class DonGiaChamBaiProperty : ChildEntityProperty<DonGiaChamBaiChildEntityTypes>
	{
	}
	
	#endregion DonGiaChamBaiProperty
}

