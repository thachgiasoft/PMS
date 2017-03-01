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
	/// Represents the DataRepository.DinhMucNghienCuuKhoaHocProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(DinhMucNghienCuuKhoaHocDataSourceDesigner))]
	public class DinhMucNghienCuuKhoaHocDataSource : ProviderDataSource<DinhMucNghienCuuKhoaHoc, DinhMucNghienCuuKhoaHocKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the DinhMucNghienCuuKhoaHocDataSource class.
		/// </summary>
		public DinhMucNghienCuuKhoaHocDataSource() : base(new DinhMucNghienCuuKhoaHocService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the DinhMucNghienCuuKhoaHocDataSourceView used by the DinhMucNghienCuuKhoaHocDataSource.
		/// </summary>
		protected DinhMucNghienCuuKhoaHocDataSourceView DinhMucNghienCuuKhoaHocView
		{
			get { return ( View as DinhMucNghienCuuKhoaHocDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DinhMucNghienCuuKhoaHocDataSource control invokes to retrieve data.
		/// </summary>
		public DinhMucNghienCuuKhoaHocSelectMethod SelectMethod
		{
			get
			{
				DinhMucNghienCuuKhoaHocSelectMethod selectMethod = DinhMucNghienCuuKhoaHocSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (DinhMucNghienCuuKhoaHocSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the DinhMucNghienCuuKhoaHocDataSourceView class that is to be
		/// used by the DinhMucNghienCuuKhoaHocDataSource.
		/// </summary>
		/// <returns>An instance of the DinhMucNghienCuuKhoaHocDataSourceView class.</returns>
		protected override BaseDataSourceView<DinhMucNghienCuuKhoaHoc, DinhMucNghienCuuKhoaHocKey> GetNewDataSourceView()
		{
			return new DinhMucNghienCuuKhoaHocDataSourceView(this, DefaultViewName);
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
	/// Supports the DinhMucNghienCuuKhoaHocDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class DinhMucNghienCuuKhoaHocDataSourceView : ProviderDataSourceView<DinhMucNghienCuuKhoaHoc, DinhMucNghienCuuKhoaHocKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the DinhMucNghienCuuKhoaHocDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the DinhMucNghienCuuKhoaHocDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public DinhMucNghienCuuKhoaHocDataSourceView(DinhMucNghienCuuKhoaHocDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal DinhMucNghienCuuKhoaHocDataSource DinhMucNghienCuuKhoaHocOwner
		{
			get { return Owner as DinhMucNghienCuuKhoaHocDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal DinhMucNghienCuuKhoaHocSelectMethod SelectMethod
		{
			get { return DinhMucNghienCuuKhoaHocOwner.SelectMethod; }
			set { DinhMucNghienCuuKhoaHocOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal DinhMucNghienCuuKhoaHocService DinhMucNghienCuuKhoaHocProvider
		{
			get { return Provider as DinhMucNghienCuuKhoaHocService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<DinhMucNghienCuuKhoaHoc> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<DinhMucNghienCuuKhoaHoc> results = null;
			DinhMucNghienCuuKhoaHoc item;
			count = 0;
			
			System.Int32 _id;

			switch ( SelectMethod )
			{
				case DinhMucNghienCuuKhoaHocSelectMethod.Get:
					DinhMucNghienCuuKhoaHocKey entityKey  = new DinhMucNghienCuuKhoaHocKey();
					entityKey.Load(values);
					item = DinhMucNghienCuuKhoaHocProvider.Get(entityKey);
					results = new TList<DinhMucNghienCuuKhoaHoc>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case DinhMucNghienCuuKhoaHocSelectMethod.GetAll:
                    results = DinhMucNghienCuuKhoaHocProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case DinhMucNghienCuuKhoaHocSelectMethod.GetPaged:
					results = DinhMucNghienCuuKhoaHocProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case DinhMucNghienCuuKhoaHocSelectMethod.Find:
					if ( FilterParameters != null )
						results = DinhMucNghienCuuKhoaHocProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = DinhMucNghienCuuKhoaHocProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case DinhMucNghienCuuKhoaHocSelectMethod.GetById:
					_id = ( values["Id"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["Id"], typeof(System.Int32)) : (int)0;
					item = DinhMucNghienCuuKhoaHocProvider.GetById(_id);
					results = new TList<DinhMucNghienCuuKhoaHoc>();
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
			if ( SelectMethod == DinhMucNghienCuuKhoaHocSelectMethod.Get || SelectMethod == DinhMucNghienCuuKhoaHocSelectMethod.GetById )
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
				DinhMucNghienCuuKhoaHoc entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					DinhMucNghienCuuKhoaHocProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<DinhMucNghienCuuKhoaHoc> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			DinhMucNghienCuuKhoaHocProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region DinhMucNghienCuuKhoaHocDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the DinhMucNghienCuuKhoaHocDataSource class.
	/// </summary>
	public class DinhMucNghienCuuKhoaHocDataSourceDesigner : ProviderDataSourceDesigner<DinhMucNghienCuuKhoaHoc, DinhMucNghienCuuKhoaHocKey>
	{
		/// <summary>
		/// Initializes a new instance of the DinhMucNghienCuuKhoaHocDataSourceDesigner class.
		/// </summary>
		public DinhMucNghienCuuKhoaHocDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public DinhMucNghienCuuKhoaHocSelectMethod SelectMethod
		{
			get { return ((DinhMucNghienCuuKhoaHocDataSource) DataSource).SelectMethod; }
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
				actions.Add(new DinhMucNghienCuuKhoaHocDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region DinhMucNghienCuuKhoaHocDataSourceActionList

	/// <summary>
	/// Supports the DinhMucNghienCuuKhoaHocDataSourceDesigner class.
	/// </summary>
	internal class DinhMucNghienCuuKhoaHocDataSourceActionList : DesignerActionList
	{
		private DinhMucNghienCuuKhoaHocDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the DinhMucNghienCuuKhoaHocDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public DinhMucNghienCuuKhoaHocDataSourceActionList(DinhMucNghienCuuKhoaHocDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public DinhMucNghienCuuKhoaHocSelectMethod SelectMethod
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

	#endregion DinhMucNghienCuuKhoaHocDataSourceActionList
	
	#endregion DinhMucNghienCuuKhoaHocDataSourceDesigner
	
	#region DinhMucNghienCuuKhoaHocSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the DinhMucNghienCuuKhoaHocDataSource.SelectMethod property.
	/// </summary>
	public enum DinhMucNghienCuuKhoaHocSelectMethod
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
	
	#endregion DinhMucNghienCuuKhoaHocSelectMethod

	#region DinhMucNghienCuuKhoaHocFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="DinhMucNghienCuuKhoaHoc"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class DinhMucNghienCuuKhoaHocFilter : SqlFilter<DinhMucNghienCuuKhoaHocColumn>
	{
	}
	
	#endregion DinhMucNghienCuuKhoaHocFilter

	#region DinhMucNghienCuuKhoaHocExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="DinhMucNghienCuuKhoaHoc"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class DinhMucNghienCuuKhoaHocExpressionBuilder : SqlExpressionBuilder<DinhMucNghienCuuKhoaHocColumn>
	{
	}
	
	#endregion DinhMucNghienCuuKhoaHocExpressionBuilder	

	#region DinhMucNghienCuuKhoaHocProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;DinhMucNghienCuuKhoaHocChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="DinhMucNghienCuuKhoaHoc"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class DinhMucNghienCuuKhoaHocProperty : ChildEntityProperty<DinhMucNghienCuuKhoaHocChildEntityTypes>
	{
	}
	
	#endregion DinhMucNghienCuuKhoaHocProperty
}

