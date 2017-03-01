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
	/// Represents the DataRepository.DinhMucGioChuanProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(DinhMucGioChuanDataSourceDesigner))]
	public class DinhMucGioChuanDataSource : ProviderDataSource<DinhMucGioChuan, DinhMucGioChuanKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the DinhMucGioChuanDataSource class.
		/// </summary>
		public DinhMucGioChuanDataSource() : base(new DinhMucGioChuanService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the DinhMucGioChuanDataSourceView used by the DinhMucGioChuanDataSource.
		/// </summary>
		protected DinhMucGioChuanDataSourceView DinhMucGioChuanView
		{
			get { return ( View as DinhMucGioChuanDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DinhMucGioChuanDataSource control invokes to retrieve data.
		/// </summary>
		public DinhMucGioChuanSelectMethod SelectMethod
		{
			get
			{
				DinhMucGioChuanSelectMethod selectMethod = DinhMucGioChuanSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (DinhMucGioChuanSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the DinhMucGioChuanDataSourceView class that is to be
		/// used by the DinhMucGioChuanDataSource.
		/// </summary>
		/// <returns>An instance of the DinhMucGioChuanDataSourceView class.</returns>
		protected override BaseDataSourceView<DinhMucGioChuan, DinhMucGioChuanKey> GetNewDataSourceView()
		{
			return new DinhMucGioChuanDataSourceView(this, DefaultViewName);
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
	/// Supports the DinhMucGioChuanDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class DinhMucGioChuanDataSourceView : ProviderDataSourceView<DinhMucGioChuan, DinhMucGioChuanKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the DinhMucGioChuanDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the DinhMucGioChuanDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public DinhMucGioChuanDataSourceView(DinhMucGioChuanDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal DinhMucGioChuanDataSource DinhMucGioChuanOwner
		{
			get { return Owner as DinhMucGioChuanDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal DinhMucGioChuanSelectMethod SelectMethod
		{
			get { return DinhMucGioChuanOwner.SelectMethod; }
			set { DinhMucGioChuanOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal DinhMucGioChuanService DinhMucGioChuanProvider
		{
			get { return Provider as DinhMucGioChuanService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<DinhMucGioChuan> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<DinhMucGioChuan> results = null;
			DinhMucGioChuan item;
			count = 0;
			
			System.Int32 _maDinhMuc;
			System.String sp64_NamHoc;
			System.String sp64_HocKy;

			switch ( SelectMethod )
			{
				case DinhMucGioChuanSelectMethod.Get:
					DinhMucGioChuanKey entityKey  = new DinhMucGioChuanKey();
					entityKey.Load(values);
					item = DinhMucGioChuanProvider.Get(entityKey);
					results = new TList<DinhMucGioChuan>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case DinhMucGioChuanSelectMethod.GetAll:
                    results = DinhMucGioChuanProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case DinhMucGioChuanSelectMethod.GetPaged:
					results = DinhMucGioChuanProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case DinhMucGioChuanSelectMethod.Find:
					if ( FilterParameters != null )
						results = DinhMucGioChuanProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = DinhMucGioChuanProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case DinhMucGioChuanSelectMethod.GetByMaDinhMuc:
					_maDinhMuc = ( values["MaDinhMuc"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["MaDinhMuc"], typeof(System.Int32)) : (int)0;
					item = DinhMucGioChuanProvider.GetByMaDinhMuc(_maDinhMuc);
					results = new TList<DinhMucGioChuan>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				// IX
				// FK
				// M:M
				// Custom
				case DinhMucGioChuanSelectMethod.GetByNamHocHocKy:
					sp64_NamHoc = (System.String) EntityUtil.ChangeType(values["NamHoc"], typeof(System.String));
					sp64_HocKy = (System.String) EntityUtil.ChangeType(values["HocKy"], typeof(System.String));
					results = DinhMucGioChuanProvider.GetByNamHocHocKy(sp64_NamHoc, sp64_HocKy, StartIndex, PageSize);
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
			if ( SelectMethod == DinhMucGioChuanSelectMethod.Get || SelectMethod == DinhMucGioChuanSelectMethod.GetByMaDinhMuc )
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
				DinhMucGioChuan entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					DinhMucGioChuanProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<DinhMucGioChuan> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			DinhMucGioChuanProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region DinhMucGioChuanDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the DinhMucGioChuanDataSource class.
	/// </summary>
	public class DinhMucGioChuanDataSourceDesigner : ProviderDataSourceDesigner<DinhMucGioChuan, DinhMucGioChuanKey>
	{
		/// <summary>
		/// Initializes a new instance of the DinhMucGioChuanDataSourceDesigner class.
		/// </summary>
		public DinhMucGioChuanDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public DinhMucGioChuanSelectMethod SelectMethod
		{
			get { return ((DinhMucGioChuanDataSource) DataSource).SelectMethod; }
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
				actions.Add(new DinhMucGioChuanDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region DinhMucGioChuanDataSourceActionList

	/// <summary>
	/// Supports the DinhMucGioChuanDataSourceDesigner class.
	/// </summary>
	internal class DinhMucGioChuanDataSourceActionList : DesignerActionList
	{
		private DinhMucGioChuanDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the DinhMucGioChuanDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public DinhMucGioChuanDataSourceActionList(DinhMucGioChuanDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public DinhMucGioChuanSelectMethod SelectMethod
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

	#endregion DinhMucGioChuanDataSourceActionList
	
	#endregion DinhMucGioChuanDataSourceDesigner
	
	#region DinhMucGioChuanSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the DinhMucGioChuanDataSource.SelectMethod property.
	/// </summary>
	public enum DinhMucGioChuanSelectMethod
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
		/// Represents the GetByMaDinhMuc method.
		/// </summary>
		GetByMaDinhMuc,
		/// <summary>
		/// Represents the GetByNamHocHocKy method.
		/// </summary>
		GetByNamHocHocKy
	}
	
	#endregion DinhMucGioChuanSelectMethod

	#region DinhMucGioChuanFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="DinhMucGioChuan"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class DinhMucGioChuanFilter : SqlFilter<DinhMucGioChuanColumn>
	{
	}
	
	#endregion DinhMucGioChuanFilter

	#region DinhMucGioChuanExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="DinhMucGioChuan"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class DinhMucGioChuanExpressionBuilder : SqlExpressionBuilder<DinhMucGioChuanColumn>
	{
	}
	
	#endregion DinhMucGioChuanExpressionBuilder	

	#region DinhMucGioChuanProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;DinhMucGioChuanChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="DinhMucGioChuan"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class DinhMucGioChuanProperty : ChildEntityProperty<DinhMucGioChuanChildEntityTypes>
	{
	}
	
	#endregion DinhMucGioChuanProperty
}

