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
	/// Represents the DataRepository.TinhTrangTheoNamHocProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(TinhTrangTheoNamHocDataSourceDesigner))]
	public class TinhTrangTheoNamHocDataSource : ProviderDataSource<TinhTrangTheoNamHoc, TinhTrangTheoNamHocKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the TinhTrangTheoNamHocDataSource class.
		/// </summary>
		public TinhTrangTheoNamHocDataSource() : base(new TinhTrangTheoNamHocService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the TinhTrangTheoNamHocDataSourceView used by the TinhTrangTheoNamHocDataSource.
		/// </summary>
		protected TinhTrangTheoNamHocDataSourceView TinhTrangTheoNamHocView
		{
			get { return ( View as TinhTrangTheoNamHocDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the TinhTrangTheoNamHocDataSource control invokes to retrieve data.
		/// </summary>
		public TinhTrangTheoNamHocSelectMethod SelectMethod
		{
			get
			{
				TinhTrangTheoNamHocSelectMethod selectMethod = TinhTrangTheoNamHocSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (TinhTrangTheoNamHocSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the TinhTrangTheoNamHocDataSourceView class that is to be
		/// used by the TinhTrangTheoNamHocDataSource.
		/// </summary>
		/// <returns>An instance of the TinhTrangTheoNamHocDataSourceView class.</returns>
		protected override BaseDataSourceView<TinhTrangTheoNamHoc, TinhTrangTheoNamHocKey> GetNewDataSourceView()
		{
			return new TinhTrangTheoNamHocDataSourceView(this, DefaultViewName);
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
	/// Supports the TinhTrangTheoNamHocDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class TinhTrangTheoNamHocDataSourceView : ProviderDataSourceView<TinhTrangTheoNamHoc, TinhTrangTheoNamHocKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the TinhTrangTheoNamHocDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the TinhTrangTheoNamHocDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public TinhTrangTheoNamHocDataSourceView(TinhTrangTheoNamHocDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal TinhTrangTheoNamHocDataSource TinhTrangTheoNamHocOwner
		{
			get { return Owner as TinhTrangTheoNamHocDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal TinhTrangTheoNamHocSelectMethod SelectMethod
		{
			get { return TinhTrangTheoNamHocOwner.SelectMethod; }
			set { TinhTrangTheoNamHocOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal TinhTrangTheoNamHocService TinhTrangTheoNamHocProvider
		{
			get { return Provider as TinhTrangTheoNamHocService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<TinhTrangTheoNamHoc> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<TinhTrangTheoNamHoc> results = null;
			TinhTrangTheoNamHoc item;
			count = 0;
			
			System.Int32 _id;

			switch ( SelectMethod )
			{
				case TinhTrangTheoNamHocSelectMethod.Get:
					TinhTrangTheoNamHocKey entityKey  = new TinhTrangTheoNamHocKey();
					entityKey.Load(values);
					item = TinhTrangTheoNamHocProvider.Get(entityKey);
					results = new TList<TinhTrangTheoNamHoc>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case TinhTrangTheoNamHocSelectMethod.GetAll:
                    results = TinhTrangTheoNamHocProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case TinhTrangTheoNamHocSelectMethod.GetPaged:
					results = TinhTrangTheoNamHocProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case TinhTrangTheoNamHocSelectMethod.Find:
					if ( FilterParameters != null )
						results = TinhTrangTheoNamHocProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = TinhTrangTheoNamHocProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case TinhTrangTheoNamHocSelectMethod.GetById:
					_id = ( values["Id"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["Id"], typeof(System.Int32)) : (int)0;
					item = TinhTrangTheoNamHocProvider.GetById(_id);
					results = new TList<TinhTrangTheoNamHoc>();
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
			if ( SelectMethod == TinhTrangTheoNamHocSelectMethod.Get || SelectMethod == TinhTrangTheoNamHocSelectMethod.GetById )
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
				TinhTrangTheoNamHoc entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					TinhTrangTheoNamHocProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<TinhTrangTheoNamHoc> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			TinhTrangTheoNamHocProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region TinhTrangTheoNamHocDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the TinhTrangTheoNamHocDataSource class.
	/// </summary>
	public class TinhTrangTheoNamHocDataSourceDesigner : ProviderDataSourceDesigner<TinhTrangTheoNamHoc, TinhTrangTheoNamHocKey>
	{
		/// <summary>
		/// Initializes a new instance of the TinhTrangTheoNamHocDataSourceDesigner class.
		/// </summary>
		public TinhTrangTheoNamHocDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public TinhTrangTheoNamHocSelectMethod SelectMethod
		{
			get { return ((TinhTrangTheoNamHocDataSource) DataSource).SelectMethod; }
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
				actions.Add(new TinhTrangTheoNamHocDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region TinhTrangTheoNamHocDataSourceActionList

	/// <summary>
	/// Supports the TinhTrangTheoNamHocDataSourceDesigner class.
	/// </summary>
	internal class TinhTrangTheoNamHocDataSourceActionList : DesignerActionList
	{
		private TinhTrangTheoNamHocDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the TinhTrangTheoNamHocDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public TinhTrangTheoNamHocDataSourceActionList(TinhTrangTheoNamHocDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public TinhTrangTheoNamHocSelectMethod SelectMethod
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

	#endregion TinhTrangTheoNamHocDataSourceActionList
	
	#endregion TinhTrangTheoNamHocDataSourceDesigner
	
	#region TinhTrangTheoNamHocSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the TinhTrangTheoNamHocDataSource.SelectMethod property.
	/// </summary>
	public enum TinhTrangTheoNamHocSelectMethod
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
	
	#endregion TinhTrangTheoNamHocSelectMethod

	#region TinhTrangTheoNamHocFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="TinhTrangTheoNamHoc"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class TinhTrangTheoNamHocFilter : SqlFilter<TinhTrangTheoNamHocColumn>
	{
	}
	
	#endregion TinhTrangTheoNamHocFilter

	#region TinhTrangTheoNamHocExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="TinhTrangTheoNamHoc"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class TinhTrangTheoNamHocExpressionBuilder : SqlExpressionBuilder<TinhTrangTheoNamHocColumn>
	{
	}
	
	#endregion TinhTrangTheoNamHocExpressionBuilder	

	#region TinhTrangTheoNamHocProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;TinhTrangTheoNamHocChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="TinhTrangTheoNamHoc"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class TinhTrangTheoNamHocProperty : ChildEntityProperty<TinhTrangTheoNamHocChildEntityTypes>
	{
	}
	
	#endregion TinhTrangTheoNamHocProperty
}

