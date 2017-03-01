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
	/// Represents the DataRepository.DanhMucGioGiangProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(DanhMucGioGiangDataSourceDesigner))]
	public class DanhMucGioGiangDataSource : ProviderDataSource<DanhMucGioGiang, DanhMucGioGiangKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the DanhMucGioGiangDataSource class.
		/// </summary>
		public DanhMucGioGiangDataSource() : base(new DanhMucGioGiangService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the DanhMucGioGiangDataSourceView used by the DanhMucGioGiangDataSource.
		/// </summary>
		protected DanhMucGioGiangDataSourceView DanhMucGioGiangView
		{
			get { return ( View as DanhMucGioGiangDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DanhMucGioGiangDataSource control invokes to retrieve data.
		/// </summary>
		public DanhMucGioGiangSelectMethod SelectMethod
		{
			get
			{
				DanhMucGioGiangSelectMethod selectMethod = DanhMucGioGiangSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (DanhMucGioGiangSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the DanhMucGioGiangDataSourceView class that is to be
		/// used by the DanhMucGioGiangDataSource.
		/// </summary>
		/// <returns>An instance of the DanhMucGioGiangDataSourceView class.</returns>
		protected override BaseDataSourceView<DanhMucGioGiang, DanhMucGioGiangKey> GetNewDataSourceView()
		{
			return new DanhMucGioGiangDataSourceView(this, DefaultViewName);
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
	/// Supports the DanhMucGioGiangDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class DanhMucGioGiangDataSourceView : ProviderDataSourceView<DanhMucGioGiang, DanhMucGioGiangKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the DanhMucGioGiangDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the DanhMucGioGiangDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public DanhMucGioGiangDataSourceView(DanhMucGioGiangDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal DanhMucGioGiangDataSource DanhMucGioGiangOwner
		{
			get { return Owner as DanhMucGioGiangDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal DanhMucGioGiangSelectMethod SelectMethod
		{
			get { return DanhMucGioGiangOwner.SelectMethod; }
			set { DanhMucGioGiangOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal DanhMucGioGiangService DanhMucGioGiangProvider
		{
			get { return Provider as DanhMucGioGiangService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<DanhMucGioGiang> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<DanhMucGioGiang> results = null;
			DanhMucGioGiang item;
			count = 0;
			
			System.Int32 _id;

			switch ( SelectMethod )
			{
				case DanhMucGioGiangSelectMethod.Get:
					DanhMucGioGiangKey entityKey  = new DanhMucGioGiangKey();
					entityKey.Load(values);
					item = DanhMucGioGiangProvider.Get(entityKey);
					results = new TList<DanhMucGioGiang>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case DanhMucGioGiangSelectMethod.GetAll:
                    results = DanhMucGioGiangProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case DanhMucGioGiangSelectMethod.GetPaged:
					results = DanhMucGioGiangProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case DanhMucGioGiangSelectMethod.Find:
					if ( FilterParameters != null )
						results = DanhMucGioGiangProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = DanhMucGioGiangProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case DanhMucGioGiangSelectMethod.GetById:
					_id = ( values["Id"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["Id"], typeof(System.Int32)) : (int)0;
					item = DanhMucGioGiangProvider.GetById(_id);
					results = new TList<DanhMucGioGiang>();
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
			if ( SelectMethod == DanhMucGioGiangSelectMethod.Get || SelectMethod == DanhMucGioGiangSelectMethod.GetById )
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
				DanhMucGioGiang entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					DanhMucGioGiangProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<DanhMucGioGiang> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			DanhMucGioGiangProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region DanhMucGioGiangDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the DanhMucGioGiangDataSource class.
	/// </summary>
	public class DanhMucGioGiangDataSourceDesigner : ProviderDataSourceDesigner<DanhMucGioGiang, DanhMucGioGiangKey>
	{
		/// <summary>
		/// Initializes a new instance of the DanhMucGioGiangDataSourceDesigner class.
		/// </summary>
		public DanhMucGioGiangDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public DanhMucGioGiangSelectMethod SelectMethod
		{
			get { return ((DanhMucGioGiangDataSource) DataSource).SelectMethod; }
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
				actions.Add(new DanhMucGioGiangDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region DanhMucGioGiangDataSourceActionList

	/// <summary>
	/// Supports the DanhMucGioGiangDataSourceDesigner class.
	/// </summary>
	internal class DanhMucGioGiangDataSourceActionList : DesignerActionList
	{
		private DanhMucGioGiangDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the DanhMucGioGiangDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public DanhMucGioGiangDataSourceActionList(DanhMucGioGiangDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public DanhMucGioGiangSelectMethod SelectMethod
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

	#endregion DanhMucGioGiangDataSourceActionList
	
	#endregion DanhMucGioGiangDataSourceDesigner
	
	#region DanhMucGioGiangSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the DanhMucGioGiangDataSource.SelectMethod property.
	/// </summary>
	public enum DanhMucGioGiangSelectMethod
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
	
	#endregion DanhMucGioGiangSelectMethod

	#region DanhMucGioGiangFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="DanhMucGioGiang"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class DanhMucGioGiangFilter : SqlFilter<DanhMucGioGiangColumn>
	{
	}
	
	#endregion DanhMucGioGiangFilter

	#region DanhMucGioGiangExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="DanhMucGioGiang"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class DanhMucGioGiangExpressionBuilder : SqlExpressionBuilder<DanhMucGioGiangColumn>
	{
	}
	
	#endregion DanhMucGioGiangExpressionBuilder	

	#region DanhMucGioGiangProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;DanhMucGioGiangChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="DanhMucGioGiang"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class DanhMucGioGiangProperty : ChildEntityProperty<DanhMucGioGiangChildEntityTypes>
	{
	}
	
	#endregion DanhMucGioGiangProperty
}

