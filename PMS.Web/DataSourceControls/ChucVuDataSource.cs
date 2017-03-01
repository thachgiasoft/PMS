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
	/// Represents the DataRepository.ChucVuProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(ChucVuDataSourceDesigner))]
	public class ChucVuDataSource : ProviderDataSource<ChucVu, ChucVuKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ChucVuDataSource class.
		/// </summary>
		public ChucVuDataSource() : base(new ChucVuService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the ChucVuDataSourceView used by the ChucVuDataSource.
		/// </summary>
		protected ChucVuDataSourceView ChucVuView
		{
			get { return ( View as ChucVuDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the ChucVuDataSource control invokes to retrieve data.
		/// </summary>
		public ChucVuSelectMethod SelectMethod
		{
			get
			{
				ChucVuSelectMethod selectMethod = ChucVuSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (ChucVuSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the ChucVuDataSourceView class that is to be
		/// used by the ChucVuDataSource.
		/// </summary>
		/// <returns>An instance of the ChucVuDataSourceView class.</returns>
		protected override BaseDataSourceView<ChucVu, ChucVuKey> GetNewDataSourceView()
		{
			return new ChucVuDataSourceView(this, DefaultViewName);
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
	/// Supports the ChucVuDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class ChucVuDataSourceView : ProviderDataSourceView<ChucVu, ChucVuKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ChucVuDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the ChucVuDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public ChucVuDataSourceView(ChucVuDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal ChucVuDataSource ChucVuOwner
		{
			get { return Owner as ChucVuDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal ChucVuSelectMethod SelectMethod
		{
			get { return ChucVuOwner.SelectMethod; }
			set { ChucVuOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal ChucVuService ChucVuProvider
		{
			get { return Provider as ChucVuService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<ChucVu> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<ChucVu> results = null;
			ChucVu item;
			count = 0;
			
			System.String _maQuanLy;
			System.Int32 _maChucVu;
			System.String sp35_NamHoc;
			System.String sp35_HocKy;

			switch ( SelectMethod )
			{
				case ChucVuSelectMethod.Get:
					ChucVuKey entityKey  = new ChucVuKey();
					entityKey.Load(values);
					item = ChucVuProvider.Get(entityKey);
					results = new TList<ChucVu>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case ChucVuSelectMethod.GetAll:
                    results = ChucVuProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case ChucVuSelectMethod.GetPaged:
					results = ChucVuProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case ChucVuSelectMethod.Find:
					if ( FilterParameters != null )
						results = ChucVuProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = ChucVuProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case ChucVuSelectMethod.GetByMaChucVu:
					_maChucVu = ( values["MaChucVu"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["MaChucVu"], typeof(System.Int32)) : (int)0;
					item = ChucVuProvider.GetByMaChucVu(_maChucVu);
					results = new TList<ChucVu>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				// IX
				case ChucVuSelectMethod.GetByMaQuanLy:
					_maQuanLy = ( values["MaQuanLy"] != null ) ? (System.String) EntityUtil.ChangeType(values["MaQuanLy"], typeof(System.String)) : string.Empty;
					item = ChucVuProvider.GetByMaQuanLy(_maQuanLy);
					results = new TList<ChucVu>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				// FK
				// M:M
				// Custom
				case ChucVuSelectMethod.GetByNamHocHocKy:
					sp35_NamHoc = (System.String) EntityUtil.ChangeType(values["NamHoc"], typeof(System.String));
					sp35_HocKy = (System.String) EntityUtil.ChangeType(values["HocKy"], typeof(System.String));
					results = ChucVuProvider.GetByNamHocHocKy(sp35_NamHoc, sp35_HocKy, StartIndex, PageSize);
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
			if ( SelectMethod == ChucVuSelectMethod.Get || SelectMethod == ChucVuSelectMethod.GetByMaChucVu )
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
				ChucVu entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					ChucVuProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<ChucVu> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			ChucVuProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region ChucVuDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the ChucVuDataSource class.
	/// </summary>
	public class ChucVuDataSourceDesigner : ProviderDataSourceDesigner<ChucVu, ChucVuKey>
	{
		/// <summary>
		/// Initializes a new instance of the ChucVuDataSourceDesigner class.
		/// </summary>
		public ChucVuDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public ChucVuSelectMethod SelectMethod
		{
			get { return ((ChucVuDataSource) DataSource).SelectMethod; }
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
				actions.Add(new ChucVuDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region ChucVuDataSourceActionList

	/// <summary>
	/// Supports the ChucVuDataSourceDesigner class.
	/// </summary>
	internal class ChucVuDataSourceActionList : DesignerActionList
	{
		private ChucVuDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the ChucVuDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public ChucVuDataSourceActionList(ChucVuDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public ChucVuSelectMethod SelectMethod
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

	#endregion ChucVuDataSourceActionList
	
	#endregion ChucVuDataSourceDesigner
	
	#region ChucVuSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the ChucVuDataSource.SelectMethod property.
	/// </summary>
	public enum ChucVuSelectMethod
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
		/// Represents the GetByMaQuanLy method.
		/// </summary>
		GetByMaQuanLy,
		/// <summary>
		/// Represents the GetByMaChucVu method.
		/// </summary>
		GetByMaChucVu,
		/// <summary>
		/// Represents the GetByNamHocHocKy method.
		/// </summary>
		GetByNamHocHocKy
	}
	
	#endregion ChucVuSelectMethod

	#region ChucVuFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ChucVu"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ChucVuFilter : SqlFilter<ChucVuColumn>
	{
	}
	
	#endregion ChucVuFilter

	#region ChucVuExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ChucVu"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ChucVuExpressionBuilder : SqlExpressionBuilder<ChucVuColumn>
	{
	}
	
	#endregion ChucVuExpressionBuilder	

	#region ChucVuProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;ChucVuChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="ChucVu"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ChucVuProperty : ChildEntityProperty<ChucVuChildEntityTypes>
	{
	}
	
	#endregion ChucVuProperty
}

