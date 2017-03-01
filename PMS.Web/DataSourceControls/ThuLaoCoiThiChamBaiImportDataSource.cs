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
	/// Represents the DataRepository.ThuLaoCoiThiChamBaiImportProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(ThuLaoCoiThiChamBaiImportDataSourceDesigner))]
	public class ThuLaoCoiThiChamBaiImportDataSource : ProviderDataSource<ThuLaoCoiThiChamBaiImport, ThuLaoCoiThiChamBaiImportKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ThuLaoCoiThiChamBaiImportDataSource class.
		/// </summary>
		public ThuLaoCoiThiChamBaiImportDataSource() : base(new ThuLaoCoiThiChamBaiImportService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the ThuLaoCoiThiChamBaiImportDataSourceView used by the ThuLaoCoiThiChamBaiImportDataSource.
		/// </summary>
		protected ThuLaoCoiThiChamBaiImportDataSourceView ThuLaoCoiThiChamBaiImportView
		{
			get { return ( View as ThuLaoCoiThiChamBaiImportDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the ThuLaoCoiThiChamBaiImportDataSource control invokes to retrieve data.
		/// </summary>
		public ThuLaoCoiThiChamBaiImportSelectMethod SelectMethod
		{
			get
			{
				ThuLaoCoiThiChamBaiImportSelectMethod selectMethod = ThuLaoCoiThiChamBaiImportSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (ThuLaoCoiThiChamBaiImportSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the ThuLaoCoiThiChamBaiImportDataSourceView class that is to be
		/// used by the ThuLaoCoiThiChamBaiImportDataSource.
		/// </summary>
		/// <returns>An instance of the ThuLaoCoiThiChamBaiImportDataSourceView class.</returns>
		protected override BaseDataSourceView<ThuLaoCoiThiChamBaiImport, ThuLaoCoiThiChamBaiImportKey> GetNewDataSourceView()
		{
			return new ThuLaoCoiThiChamBaiImportDataSourceView(this, DefaultViewName);
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
	/// Supports the ThuLaoCoiThiChamBaiImportDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class ThuLaoCoiThiChamBaiImportDataSourceView : ProviderDataSourceView<ThuLaoCoiThiChamBaiImport, ThuLaoCoiThiChamBaiImportKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ThuLaoCoiThiChamBaiImportDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the ThuLaoCoiThiChamBaiImportDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public ThuLaoCoiThiChamBaiImportDataSourceView(ThuLaoCoiThiChamBaiImportDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal ThuLaoCoiThiChamBaiImportDataSource ThuLaoCoiThiChamBaiImportOwner
		{
			get { return Owner as ThuLaoCoiThiChamBaiImportDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal ThuLaoCoiThiChamBaiImportSelectMethod SelectMethod
		{
			get { return ThuLaoCoiThiChamBaiImportOwner.SelectMethod; }
			set { ThuLaoCoiThiChamBaiImportOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal ThuLaoCoiThiChamBaiImportService ThuLaoCoiThiChamBaiImportProvider
		{
			get { return Provider as ThuLaoCoiThiChamBaiImportService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<ThuLaoCoiThiChamBaiImport> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<ThuLaoCoiThiChamBaiImport> results = null;
			ThuLaoCoiThiChamBaiImport item;
			count = 0;
			
			System.Int32 _id;
			System.String sp839_NamHoc;
			System.String sp839_HocKy;
			System.String sp839_DotChiTra;

			switch ( SelectMethod )
			{
				case ThuLaoCoiThiChamBaiImportSelectMethod.Get:
					ThuLaoCoiThiChamBaiImportKey entityKey  = new ThuLaoCoiThiChamBaiImportKey();
					entityKey.Load(values);
					item = ThuLaoCoiThiChamBaiImportProvider.Get(entityKey);
					results = new TList<ThuLaoCoiThiChamBaiImport>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case ThuLaoCoiThiChamBaiImportSelectMethod.GetAll:
                    results = ThuLaoCoiThiChamBaiImportProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case ThuLaoCoiThiChamBaiImportSelectMethod.GetPaged:
					results = ThuLaoCoiThiChamBaiImportProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case ThuLaoCoiThiChamBaiImportSelectMethod.Find:
					if ( FilterParameters != null )
						results = ThuLaoCoiThiChamBaiImportProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = ThuLaoCoiThiChamBaiImportProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case ThuLaoCoiThiChamBaiImportSelectMethod.GetById:
					_id = ( values["Id"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["Id"], typeof(System.Int32)) : (int)0;
					item = ThuLaoCoiThiChamBaiImportProvider.GetById(_id);
					results = new TList<ThuLaoCoiThiChamBaiImport>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				// IX
				// FK
				// M:M
				// Custom
				case ThuLaoCoiThiChamBaiImportSelectMethod.GetByNamHocHocKyDotChiTra:
					sp839_NamHoc = (System.String) EntityUtil.ChangeType(values["NamHoc"], typeof(System.String));
					sp839_HocKy = (System.String) EntityUtil.ChangeType(values["HocKy"], typeof(System.String));
					sp839_DotChiTra = (System.String) EntityUtil.ChangeType(values["DotChiTra"], typeof(System.String));
					results = ThuLaoCoiThiChamBaiImportProvider.GetByNamHocHocKyDotChiTra(sp839_NamHoc, sp839_HocKy, sp839_DotChiTra, StartIndex, PageSize);
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
			if ( SelectMethod == ThuLaoCoiThiChamBaiImportSelectMethod.Get || SelectMethod == ThuLaoCoiThiChamBaiImportSelectMethod.GetById )
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
				ThuLaoCoiThiChamBaiImport entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					ThuLaoCoiThiChamBaiImportProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<ThuLaoCoiThiChamBaiImport> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			ThuLaoCoiThiChamBaiImportProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region ThuLaoCoiThiChamBaiImportDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the ThuLaoCoiThiChamBaiImportDataSource class.
	/// </summary>
	public class ThuLaoCoiThiChamBaiImportDataSourceDesigner : ProviderDataSourceDesigner<ThuLaoCoiThiChamBaiImport, ThuLaoCoiThiChamBaiImportKey>
	{
		/// <summary>
		/// Initializes a new instance of the ThuLaoCoiThiChamBaiImportDataSourceDesigner class.
		/// </summary>
		public ThuLaoCoiThiChamBaiImportDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public ThuLaoCoiThiChamBaiImportSelectMethod SelectMethod
		{
			get { return ((ThuLaoCoiThiChamBaiImportDataSource) DataSource).SelectMethod; }
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
				actions.Add(new ThuLaoCoiThiChamBaiImportDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region ThuLaoCoiThiChamBaiImportDataSourceActionList

	/// <summary>
	/// Supports the ThuLaoCoiThiChamBaiImportDataSourceDesigner class.
	/// </summary>
	internal class ThuLaoCoiThiChamBaiImportDataSourceActionList : DesignerActionList
	{
		private ThuLaoCoiThiChamBaiImportDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the ThuLaoCoiThiChamBaiImportDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public ThuLaoCoiThiChamBaiImportDataSourceActionList(ThuLaoCoiThiChamBaiImportDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public ThuLaoCoiThiChamBaiImportSelectMethod SelectMethod
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

	#endregion ThuLaoCoiThiChamBaiImportDataSourceActionList
	
	#endregion ThuLaoCoiThiChamBaiImportDataSourceDesigner
	
	#region ThuLaoCoiThiChamBaiImportSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the ThuLaoCoiThiChamBaiImportDataSource.SelectMethod property.
	/// </summary>
	public enum ThuLaoCoiThiChamBaiImportSelectMethod
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
		/// Represents the GetByNamHocHocKyDotChiTra method.
		/// </summary>
		GetByNamHocHocKyDotChiTra
	}
	
	#endregion ThuLaoCoiThiChamBaiImportSelectMethod

	#region ThuLaoCoiThiChamBaiImportFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ThuLaoCoiThiChamBaiImport"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ThuLaoCoiThiChamBaiImportFilter : SqlFilter<ThuLaoCoiThiChamBaiImportColumn>
	{
	}
	
	#endregion ThuLaoCoiThiChamBaiImportFilter

	#region ThuLaoCoiThiChamBaiImportExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ThuLaoCoiThiChamBaiImport"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ThuLaoCoiThiChamBaiImportExpressionBuilder : SqlExpressionBuilder<ThuLaoCoiThiChamBaiImportColumn>
	{
	}
	
	#endregion ThuLaoCoiThiChamBaiImportExpressionBuilder	

	#region ThuLaoCoiThiChamBaiImportProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;ThuLaoCoiThiChamBaiImportChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="ThuLaoCoiThiChamBaiImport"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ThuLaoCoiThiChamBaiImportProperty : ChildEntityProperty<ThuLaoCoiThiChamBaiImportChildEntityTypes>
	{
	}
	
	#endregion ThuLaoCoiThiChamBaiImportProperty
}

