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
	/// Represents the DataRepository.ThuLaoGiangDayThucHanhProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(ThuLaoGiangDayThucHanhDataSourceDesigner))]
	public class ThuLaoGiangDayThucHanhDataSource : ProviderDataSource<ThuLaoGiangDayThucHanh, ThuLaoGiangDayThucHanhKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ThuLaoGiangDayThucHanhDataSource class.
		/// </summary>
		public ThuLaoGiangDayThucHanhDataSource() : base(new ThuLaoGiangDayThucHanhService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the ThuLaoGiangDayThucHanhDataSourceView used by the ThuLaoGiangDayThucHanhDataSource.
		/// </summary>
		protected ThuLaoGiangDayThucHanhDataSourceView ThuLaoGiangDayThucHanhView
		{
			get { return ( View as ThuLaoGiangDayThucHanhDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the ThuLaoGiangDayThucHanhDataSource control invokes to retrieve data.
		/// </summary>
		public ThuLaoGiangDayThucHanhSelectMethod SelectMethod
		{
			get
			{
				ThuLaoGiangDayThucHanhSelectMethod selectMethod = ThuLaoGiangDayThucHanhSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (ThuLaoGiangDayThucHanhSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the ThuLaoGiangDayThucHanhDataSourceView class that is to be
		/// used by the ThuLaoGiangDayThucHanhDataSource.
		/// </summary>
		/// <returns>An instance of the ThuLaoGiangDayThucHanhDataSourceView class.</returns>
		protected override BaseDataSourceView<ThuLaoGiangDayThucHanh, ThuLaoGiangDayThucHanhKey> GetNewDataSourceView()
		{
			return new ThuLaoGiangDayThucHanhDataSourceView(this, DefaultViewName);
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
	/// Supports the ThuLaoGiangDayThucHanhDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class ThuLaoGiangDayThucHanhDataSourceView : ProviderDataSourceView<ThuLaoGiangDayThucHanh, ThuLaoGiangDayThucHanhKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ThuLaoGiangDayThucHanhDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the ThuLaoGiangDayThucHanhDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public ThuLaoGiangDayThucHanhDataSourceView(ThuLaoGiangDayThucHanhDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal ThuLaoGiangDayThucHanhDataSource ThuLaoGiangDayThucHanhOwner
		{
			get { return Owner as ThuLaoGiangDayThucHanhDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal ThuLaoGiangDayThucHanhSelectMethod SelectMethod
		{
			get { return ThuLaoGiangDayThucHanhOwner.SelectMethod; }
			set { ThuLaoGiangDayThucHanhOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal ThuLaoGiangDayThucHanhService ThuLaoGiangDayThucHanhProvider
		{
			get { return Provider as ThuLaoGiangDayThucHanhService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<ThuLaoGiangDayThucHanh> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<ThuLaoGiangDayThucHanh> results = null;
			ThuLaoGiangDayThucHanh item;
			count = 0;
			
			System.Int32 _id;
			System.String sp852_NamHoc;
			System.String sp852_HocKy;

			switch ( SelectMethod )
			{
				case ThuLaoGiangDayThucHanhSelectMethod.Get:
					ThuLaoGiangDayThucHanhKey entityKey  = new ThuLaoGiangDayThucHanhKey();
					entityKey.Load(values);
					item = ThuLaoGiangDayThucHanhProvider.Get(entityKey);
					results = new TList<ThuLaoGiangDayThucHanh>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case ThuLaoGiangDayThucHanhSelectMethod.GetAll:
                    results = ThuLaoGiangDayThucHanhProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case ThuLaoGiangDayThucHanhSelectMethod.GetPaged:
					results = ThuLaoGiangDayThucHanhProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case ThuLaoGiangDayThucHanhSelectMethod.Find:
					if ( FilterParameters != null )
						results = ThuLaoGiangDayThucHanhProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = ThuLaoGiangDayThucHanhProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case ThuLaoGiangDayThucHanhSelectMethod.GetById:
					_id = ( values["Id"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["Id"], typeof(System.Int32)) : (int)0;
					item = ThuLaoGiangDayThucHanhProvider.GetById(_id);
					results = new TList<ThuLaoGiangDayThucHanh>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				// IX
				// FK
				// M:M
				// Custom
				case ThuLaoGiangDayThucHanhSelectMethod.GetByNamHocHocKy:
					sp852_NamHoc = (System.String) EntityUtil.ChangeType(values["NamHoc"], typeof(System.String));
					sp852_HocKy = (System.String) EntityUtil.ChangeType(values["HocKy"], typeof(System.String));
					results = ThuLaoGiangDayThucHanhProvider.GetByNamHocHocKy(sp852_NamHoc, sp852_HocKy, StartIndex, PageSize);
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
			if ( SelectMethod == ThuLaoGiangDayThucHanhSelectMethod.Get || SelectMethod == ThuLaoGiangDayThucHanhSelectMethod.GetById )
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
				ThuLaoGiangDayThucHanh entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					ThuLaoGiangDayThucHanhProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<ThuLaoGiangDayThucHanh> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			ThuLaoGiangDayThucHanhProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region ThuLaoGiangDayThucHanhDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the ThuLaoGiangDayThucHanhDataSource class.
	/// </summary>
	public class ThuLaoGiangDayThucHanhDataSourceDesigner : ProviderDataSourceDesigner<ThuLaoGiangDayThucHanh, ThuLaoGiangDayThucHanhKey>
	{
		/// <summary>
		/// Initializes a new instance of the ThuLaoGiangDayThucHanhDataSourceDesigner class.
		/// </summary>
		public ThuLaoGiangDayThucHanhDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public ThuLaoGiangDayThucHanhSelectMethod SelectMethod
		{
			get { return ((ThuLaoGiangDayThucHanhDataSource) DataSource).SelectMethod; }
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
				actions.Add(new ThuLaoGiangDayThucHanhDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region ThuLaoGiangDayThucHanhDataSourceActionList

	/// <summary>
	/// Supports the ThuLaoGiangDayThucHanhDataSourceDesigner class.
	/// </summary>
	internal class ThuLaoGiangDayThucHanhDataSourceActionList : DesignerActionList
	{
		private ThuLaoGiangDayThucHanhDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the ThuLaoGiangDayThucHanhDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public ThuLaoGiangDayThucHanhDataSourceActionList(ThuLaoGiangDayThucHanhDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public ThuLaoGiangDayThucHanhSelectMethod SelectMethod
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

	#endregion ThuLaoGiangDayThucHanhDataSourceActionList
	
	#endregion ThuLaoGiangDayThucHanhDataSourceDesigner
	
	#region ThuLaoGiangDayThucHanhSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the ThuLaoGiangDayThucHanhDataSource.SelectMethod property.
	/// </summary>
	public enum ThuLaoGiangDayThucHanhSelectMethod
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
	
	#endregion ThuLaoGiangDayThucHanhSelectMethod

	#region ThuLaoGiangDayThucHanhFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ThuLaoGiangDayThucHanh"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ThuLaoGiangDayThucHanhFilter : SqlFilter<ThuLaoGiangDayThucHanhColumn>
	{
	}
	
	#endregion ThuLaoGiangDayThucHanhFilter

	#region ThuLaoGiangDayThucHanhExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ThuLaoGiangDayThucHanh"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ThuLaoGiangDayThucHanhExpressionBuilder : SqlExpressionBuilder<ThuLaoGiangDayThucHanhColumn>
	{
	}
	
	#endregion ThuLaoGiangDayThucHanhExpressionBuilder	

	#region ThuLaoGiangDayThucHanhProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;ThuLaoGiangDayThucHanhChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="ThuLaoGiangDayThucHanh"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ThuLaoGiangDayThucHanhProperty : ChildEntityProperty<ThuLaoGiangDayThucHanhChildEntityTypes>
	{
	}
	
	#endregion ThuLaoGiangDayThucHanhProperty
}

