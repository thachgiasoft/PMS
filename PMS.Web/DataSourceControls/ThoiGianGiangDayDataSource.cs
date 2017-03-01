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
	/// Represents the DataRepository.ThoiGianGiangDayProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(ThoiGianGiangDayDataSourceDesigner))]
	public class ThoiGianGiangDayDataSource : ProviderDataSource<ThoiGianGiangDay, ThoiGianGiangDayKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ThoiGianGiangDayDataSource class.
		/// </summary>
		public ThoiGianGiangDayDataSource() : base(new ThoiGianGiangDayService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the ThoiGianGiangDayDataSourceView used by the ThoiGianGiangDayDataSource.
		/// </summary>
		protected ThoiGianGiangDayDataSourceView ThoiGianGiangDayView
		{
			get { return ( View as ThoiGianGiangDayDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the ThoiGianGiangDayDataSource control invokes to retrieve data.
		/// </summary>
		public ThoiGianGiangDaySelectMethod SelectMethod
		{
			get
			{
				ThoiGianGiangDaySelectMethod selectMethod = ThoiGianGiangDaySelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (ThoiGianGiangDaySelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the ThoiGianGiangDayDataSourceView class that is to be
		/// used by the ThoiGianGiangDayDataSource.
		/// </summary>
		/// <returns>An instance of the ThoiGianGiangDayDataSourceView class.</returns>
		protected override BaseDataSourceView<ThoiGianGiangDay, ThoiGianGiangDayKey> GetNewDataSourceView()
		{
			return new ThoiGianGiangDayDataSourceView(this, DefaultViewName);
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
	/// Supports the ThoiGianGiangDayDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class ThoiGianGiangDayDataSourceView : ProviderDataSourceView<ThoiGianGiangDay, ThoiGianGiangDayKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ThoiGianGiangDayDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the ThoiGianGiangDayDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public ThoiGianGiangDayDataSourceView(ThoiGianGiangDayDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal ThoiGianGiangDayDataSource ThoiGianGiangDayOwner
		{
			get { return Owner as ThoiGianGiangDayDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal ThoiGianGiangDaySelectMethod SelectMethod
		{
			get { return ThoiGianGiangDayOwner.SelectMethod; }
			set { ThoiGianGiangDayOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal ThoiGianGiangDayService ThoiGianGiangDayProvider
		{
			get { return Provider as ThoiGianGiangDayService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<ThoiGianGiangDay> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<ThoiGianGiangDay> results = null;
			ThoiGianGiangDay item;
			count = 0;
			
			System.String _namHoc;
			System.String _hocKy;

			switch ( SelectMethod )
			{
				case ThoiGianGiangDaySelectMethod.Get:
					ThoiGianGiangDayKey entityKey  = new ThoiGianGiangDayKey();
					entityKey.Load(values);
					item = ThoiGianGiangDayProvider.Get(entityKey);
					results = new TList<ThoiGianGiangDay>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case ThoiGianGiangDaySelectMethod.GetAll:
                    results = ThoiGianGiangDayProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case ThoiGianGiangDaySelectMethod.GetPaged:
					results = ThoiGianGiangDayProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case ThoiGianGiangDaySelectMethod.Find:
					if ( FilterParameters != null )
						results = ThoiGianGiangDayProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = ThoiGianGiangDayProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case ThoiGianGiangDaySelectMethod.GetByNamHocHocKy:
					_namHoc = ( values["NamHoc"] != null ) ? (System.String) EntityUtil.ChangeType(values["NamHoc"], typeof(System.String)) : string.Empty;
					_hocKy = ( values["HocKy"] != null ) ? (System.String) EntityUtil.ChangeType(values["HocKy"], typeof(System.String)) : string.Empty;
					item = ThoiGianGiangDayProvider.GetByNamHocHocKy(_namHoc, _hocKy);
					results = new TList<ThoiGianGiangDay>();
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
			if ( SelectMethod == ThoiGianGiangDaySelectMethod.Get || SelectMethod == ThoiGianGiangDaySelectMethod.GetByNamHocHocKy )
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
				ThoiGianGiangDay entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					ThoiGianGiangDayProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<ThoiGianGiangDay> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			ThoiGianGiangDayProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region ThoiGianGiangDayDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the ThoiGianGiangDayDataSource class.
	/// </summary>
	public class ThoiGianGiangDayDataSourceDesigner : ProviderDataSourceDesigner<ThoiGianGiangDay, ThoiGianGiangDayKey>
	{
		/// <summary>
		/// Initializes a new instance of the ThoiGianGiangDayDataSourceDesigner class.
		/// </summary>
		public ThoiGianGiangDayDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public ThoiGianGiangDaySelectMethod SelectMethod
		{
			get { return ((ThoiGianGiangDayDataSource) DataSource).SelectMethod; }
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
				actions.Add(new ThoiGianGiangDayDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region ThoiGianGiangDayDataSourceActionList

	/// <summary>
	/// Supports the ThoiGianGiangDayDataSourceDesigner class.
	/// </summary>
	internal class ThoiGianGiangDayDataSourceActionList : DesignerActionList
	{
		private ThoiGianGiangDayDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the ThoiGianGiangDayDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public ThoiGianGiangDayDataSourceActionList(ThoiGianGiangDayDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public ThoiGianGiangDaySelectMethod SelectMethod
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

	#endregion ThoiGianGiangDayDataSourceActionList
	
	#endregion ThoiGianGiangDayDataSourceDesigner
	
	#region ThoiGianGiangDaySelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the ThoiGianGiangDayDataSource.SelectMethod property.
	/// </summary>
	public enum ThoiGianGiangDaySelectMethod
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
		/// Represents the GetByNamHocHocKy method.
		/// </summary>
		GetByNamHocHocKy
	}
	
	#endregion ThoiGianGiangDaySelectMethod

	#region ThoiGianGiangDayFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ThoiGianGiangDay"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ThoiGianGiangDayFilter : SqlFilter<ThoiGianGiangDayColumn>
	{
	}
	
	#endregion ThoiGianGiangDayFilter

	#region ThoiGianGiangDayExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ThoiGianGiangDay"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ThoiGianGiangDayExpressionBuilder : SqlExpressionBuilder<ThoiGianGiangDayColumn>
	{
	}
	
	#endregion ThoiGianGiangDayExpressionBuilder	

	#region ThoiGianGiangDayProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;ThoiGianGiangDayChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="ThoiGianGiangDay"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ThoiGianGiangDayProperty : ChildEntityProperty<ThoiGianGiangDayChildEntityTypes>
	{
	}
	
	#endregion ThoiGianGiangDayProperty
}

