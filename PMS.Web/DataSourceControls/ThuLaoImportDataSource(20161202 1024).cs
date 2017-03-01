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
	/// Represents the DataRepository.ThuLaoImportProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(ThuLaoImportDataSourceDesigner))]
	public class ThuLaoImportDataSource : ProviderDataSource<ThuLaoImport, ThuLaoImportKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ThuLaoImportDataSource class.
		/// </summary>
		public ThuLaoImportDataSource() : base(new ThuLaoImportService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the ThuLaoImportDataSourceView used by the ThuLaoImportDataSource.
		/// </summary>
		protected ThuLaoImportDataSourceView ThuLaoImportView
		{
			get { return ( View as ThuLaoImportDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the ThuLaoImportDataSource control invokes to retrieve data.
		/// </summary>
		public ThuLaoImportSelectMethod SelectMethod
		{
			get
			{
				ThuLaoImportSelectMethod selectMethod = ThuLaoImportSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (ThuLaoImportSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the ThuLaoImportDataSourceView class that is to be
		/// used by the ThuLaoImportDataSource.
		/// </summary>
		/// <returns>An instance of the ThuLaoImportDataSourceView class.</returns>
		protected override BaseDataSourceView<ThuLaoImport, ThuLaoImportKey> GetNewDataSourceView()
		{
			return new ThuLaoImportDataSourceView(this, DefaultViewName);
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
	/// Supports the ThuLaoImportDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class ThuLaoImportDataSourceView : ProviderDataSourceView<ThuLaoImport, ThuLaoImportKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ThuLaoImportDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the ThuLaoImportDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public ThuLaoImportDataSourceView(ThuLaoImportDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal ThuLaoImportDataSource ThuLaoImportOwner
		{
			get { return Owner as ThuLaoImportDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal ThuLaoImportSelectMethod SelectMethod
		{
			get { return ThuLaoImportOwner.SelectMethod; }
			set { ThuLaoImportOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal ThuLaoImportService ThuLaoImportProvider
		{
			get { return Provider as ThuLaoImportService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<ThuLaoImport> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<ThuLaoImport> results = null;
			ThuLaoImport item;
			count = 0;
			
			System.Int32 _id;
			System.String sp2965_DotChiTra;
			System.String sp2966_NamHoc;
			System.String sp2966_HocKy;
			System.String sp2966_DotChiTra;

			switch ( SelectMethod )
			{
				case ThuLaoImportSelectMethod.Get:
					ThuLaoImportKey entityKey  = new ThuLaoImportKey();
					entityKey.Load(values);
					item = ThuLaoImportProvider.Get(entityKey);
					results = new TList<ThuLaoImport>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case ThuLaoImportSelectMethod.GetAll:
                    results = ThuLaoImportProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case ThuLaoImportSelectMethod.GetPaged:
					results = ThuLaoImportProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case ThuLaoImportSelectMethod.Find:
					if ( FilterParameters != null )
						results = ThuLaoImportProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = ThuLaoImportProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case ThuLaoImportSelectMethod.GetById:
					_id = ( values["Id"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["Id"], typeof(System.Int32)) : (int)0;
					item = ThuLaoImportProvider.GetById(_id);
					results = new TList<ThuLaoImport>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				// IX
				// FK
				// M:M
				// Custom
				case ThuLaoImportSelectMethod.GetByDotChiTra:
					sp2965_DotChiTra = (System.String) EntityUtil.ChangeType(values["DotChiTra"], typeof(System.String));
					results = ThuLaoImportProvider.GetByDotChiTra(sp2965_DotChiTra, StartIndex, PageSize);
					break;
				case ThuLaoImportSelectMethod.GetByNamHocHocKyDotChiTra:
					sp2966_NamHoc = (System.String) EntityUtil.ChangeType(values["NamHoc"], typeof(System.String));
					sp2966_HocKy = (System.String) EntityUtil.ChangeType(values["HocKy"], typeof(System.String));
					sp2966_DotChiTra = (System.String) EntityUtil.ChangeType(values["DotChiTra"], typeof(System.String));
					results = ThuLaoImportProvider.GetByNamHocHocKyDotChiTra(sp2966_NamHoc, sp2966_HocKy, sp2966_DotChiTra, StartIndex, PageSize);
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
			if ( SelectMethod == ThuLaoImportSelectMethod.Get || SelectMethod == ThuLaoImportSelectMethod.GetById )
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
				ThuLaoImport entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					ThuLaoImportProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<ThuLaoImport> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			ThuLaoImportProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region ThuLaoImportDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the ThuLaoImportDataSource class.
	/// </summary>
	public class ThuLaoImportDataSourceDesigner : ProviderDataSourceDesigner<ThuLaoImport, ThuLaoImportKey>
	{
		/// <summary>
		/// Initializes a new instance of the ThuLaoImportDataSourceDesigner class.
		/// </summary>
		public ThuLaoImportDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public ThuLaoImportSelectMethod SelectMethod
		{
			get { return ((ThuLaoImportDataSource) DataSource).SelectMethod; }
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
				actions.Add(new ThuLaoImportDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region ThuLaoImportDataSourceActionList

	/// <summary>
	/// Supports the ThuLaoImportDataSourceDesigner class.
	/// </summary>
	internal class ThuLaoImportDataSourceActionList : DesignerActionList
	{
		private ThuLaoImportDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the ThuLaoImportDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public ThuLaoImportDataSourceActionList(ThuLaoImportDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public ThuLaoImportSelectMethod SelectMethod
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

	#endregion ThuLaoImportDataSourceActionList
	
	#endregion ThuLaoImportDataSourceDesigner
	
	#region ThuLaoImportSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the ThuLaoImportDataSource.SelectMethod property.
	/// </summary>
	public enum ThuLaoImportSelectMethod
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
		/// Represents the GetByDotChiTra method.
		/// </summary>
		GetByDotChiTra,
		/// <summary>
		/// Represents the GetByNamHocHocKyDotChiTra method.
		/// </summary>
		GetByNamHocHocKyDotChiTra
	}
	
	#endregion ThuLaoImportSelectMethod

	#region ThuLaoImportFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ThuLaoImport"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ThuLaoImportFilter : SqlFilter<ThuLaoImportColumn>
	{
	}
	
	#endregion ThuLaoImportFilter

	#region ThuLaoImportExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ThuLaoImport"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ThuLaoImportExpressionBuilder : SqlExpressionBuilder<ThuLaoImportColumn>
	{
	}
	
	#endregion ThuLaoImportExpressionBuilder	

	#region ThuLaoImportProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;ThuLaoImportChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="ThuLaoImport"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ThuLaoImportProperty : ChildEntityProperty<ThuLaoImportChildEntityTypes>
	{
	}
	
	#endregion ThuLaoImportProperty
}

