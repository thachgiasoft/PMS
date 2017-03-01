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
	/// Represents the DataRepository.DanhMucViPhamProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(DanhMucViPhamDataSourceDesigner))]
	public class DanhMucViPhamDataSource : ProviderDataSource<DanhMucViPham, DanhMucViPhamKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the DanhMucViPhamDataSource class.
		/// </summary>
		public DanhMucViPhamDataSource() : base(new DanhMucViPhamService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the DanhMucViPhamDataSourceView used by the DanhMucViPhamDataSource.
		/// </summary>
		protected DanhMucViPhamDataSourceView DanhMucViPhamView
		{
			get { return ( View as DanhMucViPhamDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DanhMucViPhamDataSource control invokes to retrieve data.
		/// </summary>
		public DanhMucViPhamSelectMethod SelectMethod
		{
			get
			{
				DanhMucViPhamSelectMethod selectMethod = DanhMucViPhamSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (DanhMucViPhamSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the DanhMucViPhamDataSourceView class that is to be
		/// used by the DanhMucViPhamDataSource.
		/// </summary>
		/// <returns>An instance of the DanhMucViPhamDataSourceView class.</returns>
		protected override BaseDataSourceView<DanhMucViPham, DanhMucViPhamKey> GetNewDataSourceView()
		{
			return new DanhMucViPhamDataSourceView(this, DefaultViewName);
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
	/// Supports the DanhMucViPhamDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class DanhMucViPhamDataSourceView : ProviderDataSourceView<DanhMucViPham, DanhMucViPhamKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the DanhMucViPhamDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the DanhMucViPhamDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public DanhMucViPhamDataSourceView(DanhMucViPhamDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal DanhMucViPhamDataSource DanhMucViPhamOwner
		{
			get { return Owner as DanhMucViPhamDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal DanhMucViPhamSelectMethod SelectMethod
		{
			get { return DanhMucViPhamOwner.SelectMethod; }
			set { DanhMucViPhamOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal DanhMucViPhamService DanhMucViPhamProvider
		{
			get { return Provider as DanhMucViPhamService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<DanhMucViPham> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<DanhMucViPham> results = null;
			DanhMucViPham item;
			count = 0;
			
			System.String _maViPham;

			switch ( SelectMethod )
			{
				case DanhMucViPhamSelectMethod.Get:
					DanhMucViPhamKey entityKey  = new DanhMucViPhamKey();
					entityKey.Load(values);
					item = DanhMucViPhamProvider.Get(entityKey);
					results = new TList<DanhMucViPham>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case DanhMucViPhamSelectMethod.GetAll:
                    results = DanhMucViPhamProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case DanhMucViPhamSelectMethod.GetPaged:
					results = DanhMucViPhamProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case DanhMucViPhamSelectMethod.Find:
					if ( FilterParameters != null )
						results = DanhMucViPhamProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = DanhMucViPhamProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case DanhMucViPhamSelectMethod.GetByMaViPham:
					_maViPham = ( values["MaViPham"] != null ) ? (System.String) EntityUtil.ChangeType(values["MaViPham"], typeof(System.String)) : string.Empty;
					item = DanhMucViPhamProvider.GetByMaViPham(_maViPham);
					results = new TList<DanhMucViPham>();
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
			if ( SelectMethod == DanhMucViPhamSelectMethod.Get || SelectMethod == DanhMucViPhamSelectMethod.GetByMaViPham )
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
				DanhMucViPham entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					DanhMucViPhamProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<DanhMucViPham> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			DanhMucViPhamProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region DanhMucViPhamDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the DanhMucViPhamDataSource class.
	/// </summary>
	public class DanhMucViPhamDataSourceDesigner : ProviderDataSourceDesigner<DanhMucViPham, DanhMucViPhamKey>
	{
		/// <summary>
		/// Initializes a new instance of the DanhMucViPhamDataSourceDesigner class.
		/// </summary>
		public DanhMucViPhamDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public DanhMucViPhamSelectMethod SelectMethod
		{
			get { return ((DanhMucViPhamDataSource) DataSource).SelectMethod; }
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
				actions.Add(new DanhMucViPhamDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region DanhMucViPhamDataSourceActionList

	/// <summary>
	/// Supports the DanhMucViPhamDataSourceDesigner class.
	/// </summary>
	internal class DanhMucViPhamDataSourceActionList : DesignerActionList
	{
		private DanhMucViPhamDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the DanhMucViPhamDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public DanhMucViPhamDataSourceActionList(DanhMucViPhamDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public DanhMucViPhamSelectMethod SelectMethod
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

	#endregion DanhMucViPhamDataSourceActionList
	
	#endregion DanhMucViPhamDataSourceDesigner
	
	#region DanhMucViPhamSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the DanhMucViPhamDataSource.SelectMethod property.
	/// </summary>
	public enum DanhMucViPhamSelectMethod
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
		/// Represents the GetByMaViPham method.
		/// </summary>
		GetByMaViPham
	}
	
	#endregion DanhMucViPhamSelectMethod

	#region DanhMucViPhamFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="DanhMucViPham"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class DanhMucViPhamFilter : SqlFilter<DanhMucViPhamColumn>
	{
	}
	
	#endregion DanhMucViPhamFilter

	#region DanhMucViPhamExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="DanhMucViPham"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class DanhMucViPhamExpressionBuilder : SqlExpressionBuilder<DanhMucViPhamColumn>
	{
	}
	
	#endregion DanhMucViPhamExpressionBuilder	

	#region DanhMucViPhamProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;DanhMucViPhamChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="DanhMucViPham"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class DanhMucViPhamProperty : ChildEntityProperty<DanhMucViPhamChildEntityTypes>
	{
	}
	
	#endregion DanhMucViPhamProperty
}

