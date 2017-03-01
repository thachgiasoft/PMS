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
	/// Represents the DataRepository.DonGiaCoiThiProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(DonGiaCoiThiDataSourceDesigner))]
	public class DonGiaCoiThiDataSource : ProviderDataSource<DonGiaCoiThi, DonGiaCoiThiKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the DonGiaCoiThiDataSource class.
		/// </summary>
		public DonGiaCoiThiDataSource() : base(new DonGiaCoiThiService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the DonGiaCoiThiDataSourceView used by the DonGiaCoiThiDataSource.
		/// </summary>
		protected DonGiaCoiThiDataSourceView DonGiaCoiThiView
		{
			get { return ( View as DonGiaCoiThiDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DonGiaCoiThiDataSource control invokes to retrieve data.
		/// </summary>
		public DonGiaCoiThiSelectMethod SelectMethod
		{
			get
			{
				DonGiaCoiThiSelectMethod selectMethod = DonGiaCoiThiSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (DonGiaCoiThiSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the DonGiaCoiThiDataSourceView class that is to be
		/// used by the DonGiaCoiThiDataSource.
		/// </summary>
		/// <returns>An instance of the DonGiaCoiThiDataSourceView class.</returns>
		protected override BaseDataSourceView<DonGiaCoiThi, DonGiaCoiThiKey> GetNewDataSourceView()
		{
			return new DonGiaCoiThiDataSourceView(this, DefaultViewName);
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
	/// Supports the DonGiaCoiThiDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class DonGiaCoiThiDataSourceView : ProviderDataSourceView<DonGiaCoiThi, DonGiaCoiThiKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the DonGiaCoiThiDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the DonGiaCoiThiDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public DonGiaCoiThiDataSourceView(DonGiaCoiThiDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal DonGiaCoiThiDataSource DonGiaCoiThiOwner
		{
			get { return Owner as DonGiaCoiThiDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal DonGiaCoiThiSelectMethod SelectMethod
		{
			get { return DonGiaCoiThiOwner.SelectMethod; }
			set { DonGiaCoiThiOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal DonGiaCoiThiService DonGiaCoiThiProvider
		{
			get { return Provider as DonGiaCoiThiService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<DonGiaCoiThi> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<DonGiaCoiThi> results = null;
			DonGiaCoiThi item;
			count = 0;
			
			System.Int32 _id;
			System.String sp2178_NamHoc;
			System.String sp2178_HocKy;

			switch ( SelectMethod )
			{
				case DonGiaCoiThiSelectMethod.Get:
					DonGiaCoiThiKey entityKey  = new DonGiaCoiThiKey();
					entityKey.Load(values);
					item = DonGiaCoiThiProvider.Get(entityKey);
					results = new TList<DonGiaCoiThi>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case DonGiaCoiThiSelectMethod.GetAll:
                    results = DonGiaCoiThiProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case DonGiaCoiThiSelectMethod.GetPaged:
					results = DonGiaCoiThiProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case DonGiaCoiThiSelectMethod.Find:
					if ( FilterParameters != null )
						results = DonGiaCoiThiProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = DonGiaCoiThiProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case DonGiaCoiThiSelectMethod.GetById:
					_id = ( values["Id"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["Id"], typeof(System.Int32)) : (int)0;
					item = DonGiaCoiThiProvider.GetById(_id);
					results = new TList<DonGiaCoiThi>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				// IX
				// FK
				// M:M
				// Custom
				case DonGiaCoiThiSelectMethod.GetByNamHocHocKy:
					sp2178_NamHoc = (System.String) EntityUtil.ChangeType(values["NamHoc"], typeof(System.String));
					sp2178_HocKy = (System.String) EntityUtil.ChangeType(values["HocKy"], typeof(System.String));
					results = DonGiaCoiThiProvider.GetByNamHocHocKy(sp2178_NamHoc, sp2178_HocKy, StartIndex, PageSize);
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
			if ( SelectMethod == DonGiaCoiThiSelectMethod.Get || SelectMethod == DonGiaCoiThiSelectMethod.GetById )
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
				DonGiaCoiThi entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					DonGiaCoiThiProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<DonGiaCoiThi> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			DonGiaCoiThiProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region DonGiaCoiThiDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the DonGiaCoiThiDataSource class.
	/// </summary>
	public class DonGiaCoiThiDataSourceDesigner : ProviderDataSourceDesigner<DonGiaCoiThi, DonGiaCoiThiKey>
	{
		/// <summary>
		/// Initializes a new instance of the DonGiaCoiThiDataSourceDesigner class.
		/// </summary>
		public DonGiaCoiThiDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public DonGiaCoiThiSelectMethod SelectMethod
		{
			get { return ((DonGiaCoiThiDataSource) DataSource).SelectMethod; }
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
				actions.Add(new DonGiaCoiThiDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region DonGiaCoiThiDataSourceActionList

	/// <summary>
	/// Supports the DonGiaCoiThiDataSourceDesigner class.
	/// </summary>
	internal class DonGiaCoiThiDataSourceActionList : DesignerActionList
	{
		private DonGiaCoiThiDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the DonGiaCoiThiDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public DonGiaCoiThiDataSourceActionList(DonGiaCoiThiDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public DonGiaCoiThiSelectMethod SelectMethod
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

	#endregion DonGiaCoiThiDataSourceActionList
	
	#endregion DonGiaCoiThiDataSourceDesigner
	
	#region DonGiaCoiThiSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the DonGiaCoiThiDataSource.SelectMethod property.
	/// </summary>
	public enum DonGiaCoiThiSelectMethod
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
	
	#endregion DonGiaCoiThiSelectMethod

	#region DonGiaCoiThiFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="DonGiaCoiThi"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class DonGiaCoiThiFilter : SqlFilter<DonGiaCoiThiColumn>
	{
	}
	
	#endregion DonGiaCoiThiFilter

	#region DonGiaCoiThiExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="DonGiaCoiThi"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class DonGiaCoiThiExpressionBuilder : SqlExpressionBuilder<DonGiaCoiThiColumn>
	{
	}
	
	#endregion DonGiaCoiThiExpressionBuilder	

	#region DonGiaCoiThiProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;DonGiaCoiThiChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="DonGiaCoiThi"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class DonGiaCoiThiProperty : ChildEntityProperty<DonGiaCoiThiChildEntityTypes>
	{
	}
	
	#endregion DonGiaCoiThiProperty
}

