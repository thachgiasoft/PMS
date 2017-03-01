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
	/// Represents the DataRepository.CauHinhChotGioProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(CauHinhChotGioDataSourceDesigner))]
	public class CauHinhChotGioDataSource : ProviderDataSource<CauHinhChotGio, CauHinhChotGioKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the CauHinhChotGioDataSource class.
		/// </summary>
		public CauHinhChotGioDataSource() : base(new CauHinhChotGioService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the CauHinhChotGioDataSourceView used by the CauHinhChotGioDataSource.
		/// </summary>
		protected CauHinhChotGioDataSourceView CauHinhChotGioView
		{
			get { return ( View as CauHinhChotGioDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the CauHinhChotGioDataSource control invokes to retrieve data.
		/// </summary>
		public CauHinhChotGioSelectMethod SelectMethod
		{
			get
			{
				CauHinhChotGioSelectMethod selectMethod = CauHinhChotGioSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (CauHinhChotGioSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the CauHinhChotGioDataSourceView class that is to be
		/// used by the CauHinhChotGioDataSource.
		/// </summary>
		/// <returns>An instance of the CauHinhChotGioDataSourceView class.</returns>
		protected override BaseDataSourceView<CauHinhChotGio, CauHinhChotGioKey> GetNewDataSourceView()
		{
			return new CauHinhChotGioDataSourceView(this, DefaultViewName);
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
	/// Supports the CauHinhChotGioDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class CauHinhChotGioDataSourceView : ProviderDataSourceView<CauHinhChotGio, CauHinhChotGioKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the CauHinhChotGioDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the CauHinhChotGioDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public CauHinhChotGioDataSourceView(CauHinhChotGioDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal CauHinhChotGioDataSource CauHinhChotGioOwner
		{
			get { return Owner as CauHinhChotGioDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal CauHinhChotGioSelectMethod SelectMethod
		{
			get { return CauHinhChotGioOwner.SelectMethod; }
			set { CauHinhChotGioOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal CauHinhChotGioService CauHinhChotGioProvider
		{
			get { return Provider as CauHinhChotGioService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<CauHinhChotGio> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<CauHinhChotGio> results = null;
			CauHinhChotGio item;
			count = 0;
			
			System.Int32 _maCauHinhChotGio;
			System.String sp4_ListMaCauHinhChotGio;
			System.String sp6_NamHoc;
			System.String sp6_HocKy;
			System.String sp7_NamHoc;
			System.String sp7_HocKy;
			System.String sp5_NamHoc;
			System.DateTime sp8_TuNgay;
			System.DateTime sp8_DenNgay;

			switch ( SelectMethod )
			{
				case CauHinhChotGioSelectMethod.Get:
					CauHinhChotGioKey entityKey  = new CauHinhChotGioKey();
					entityKey.Load(values);
					item = CauHinhChotGioProvider.Get(entityKey);
					results = new TList<CauHinhChotGio>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case CauHinhChotGioSelectMethod.GetAll:
                    results = CauHinhChotGioProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case CauHinhChotGioSelectMethod.GetPaged:
					results = CauHinhChotGioProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case CauHinhChotGioSelectMethod.Find:
					if ( FilterParameters != null )
						results = CauHinhChotGioProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = CauHinhChotGioProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case CauHinhChotGioSelectMethod.GetByMaCauHinhChotGio:
					_maCauHinhChotGio = ( values["MaCauHinhChotGio"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["MaCauHinhChotGio"], typeof(System.Int32)) : (int)0;
					item = CauHinhChotGioProvider.GetByMaCauHinhChotGio(_maCauHinhChotGio);
					results = new TList<CauHinhChotGio>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				// IX
				// FK
				// M:M
				// Custom
				case CauHinhChotGioSelectMethod.GetByListMaCauHinhChotGio:
					sp4_ListMaCauHinhChotGio = (System.String) EntityUtil.ChangeType(values["ListMaCauHinhChotGio"], typeof(System.String));
					results = CauHinhChotGioProvider.GetByListMaCauHinhChotGio(sp4_ListMaCauHinhChotGio, StartIndex, PageSize);
					break;
				case CauHinhChotGioSelectMethod.GetByNamHocHocKy:
					sp6_NamHoc = (System.String) EntityUtil.ChangeType(values["NamHoc"], typeof(System.String));
					sp6_HocKy = (System.String) EntityUtil.ChangeType(values["HocKy"], typeof(System.String));
					results = CauHinhChotGioProvider.GetByNamHocHocKy(sp6_NamHoc, sp6_HocKy, StartIndex, PageSize);
					break;
				case CauHinhChotGioSelectMethod.GetByNamHocHocKyTamUng:
					sp7_NamHoc = (System.String) EntityUtil.ChangeType(values["NamHoc"], typeof(System.String));
					sp7_HocKy = (System.String) EntityUtil.ChangeType(values["HocKy"], typeof(System.String));
					results = CauHinhChotGioProvider.GetByNamHocHocKyTamUng(sp7_NamHoc, sp7_HocKy, StartIndex, PageSize);
					break;
				case CauHinhChotGioSelectMethod.GetByNamHoc:
					sp5_NamHoc = (System.String) EntityUtil.ChangeType(values["NamHoc"], typeof(System.String));
					results = CauHinhChotGioProvider.GetByNamHoc(sp5_NamHoc, StartIndex, PageSize);
					break;
				case CauHinhChotGioSelectMethod.GetByTuNgayDenNgay:
					sp8_TuNgay = (System.DateTime) EntityUtil.ChangeType(values["TuNgay"], typeof(System.DateTime));
					sp8_DenNgay = (System.DateTime) EntityUtil.ChangeType(values["DenNgay"], typeof(System.DateTime));
					results = CauHinhChotGioProvider.GetByTuNgayDenNgay(sp8_TuNgay, sp8_DenNgay, StartIndex, PageSize);
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
			if ( SelectMethod == CauHinhChotGioSelectMethod.Get || SelectMethod == CauHinhChotGioSelectMethod.GetByMaCauHinhChotGio )
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
				CauHinhChotGio entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					CauHinhChotGioProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<CauHinhChotGio> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			CauHinhChotGioProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region CauHinhChotGioDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the CauHinhChotGioDataSource class.
	/// </summary>
	public class CauHinhChotGioDataSourceDesigner : ProviderDataSourceDesigner<CauHinhChotGio, CauHinhChotGioKey>
	{
		/// <summary>
		/// Initializes a new instance of the CauHinhChotGioDataSourceDesigner class.
		/// </summary>
		public CauHinhChotGioDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public CauHinhChotGioSelectMethod SelectMethod
		{
			get { return ((CauHinhChotGioDataSource) DataSource).SelectMethod; }
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
				actions.Add(new CauHinhChotGioDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region CauHinhChotGioDataSourceActionList

	/// <summary>
	/// Supports the CauHinhChotGioDataSourceDesigner class.
	/// </summary>
	internal class CauHinhChotGioDataSourceActionList : DesignerActionList
	{
		private CauHinhChotGioDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the CauHinhChotGioDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public CauHinhChotGioDataSourceActionList(CauHinhChotGioDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public CauHinhChotGioSelectMethod SelectMethod
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

	#endregion CauHinhChotGioDataSourceActionList
	
	#endregion CauHinhChotGioDataSourceDesigner
	
	#region CauHinhChotGioSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the CauHinhChotGioDataSource.SelectMethod property.
	/// </summary>
	public enum CauHinhChotGioSelectMethod
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
		/// Represents the GetByMaCauHinhChotGio method.
		/// </summary>
		GetByMaCauHinhChotGio,
		/// <summary>
		/// Represents the GetByListMaCauHinhChotGio method.
		/// </summary>
		GetByListMaCauHinhChotGio,
		/// <summary>
		/// Represents the GetByNamHocHocKy method.
		/// </summary>
		GetByNamHocHocKy,
		/// <summary>
		/// Represents the GetByNamHocHocKyTamUng method.
		/// </summary>
		GetByNamHocHocKyTamUng,
		/// <summary>
		/// Represents the GetByNamHoc method.
		/// </summary>
		GetByNamHoc,
		/// <summary>
		/// Represents the GetByTuNgayDenNgay method.
		/// </summary>
		GetByTuNgayDenNgay
	}
	
	#endregion CauHinhChotGioSelectMethod

	#region CauHinhChotGioFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="CauHinhChotGio"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class CauHinhChotGioFilter : SqlFilter<CauHinhChotGioColumn>
	{
	}
	
	#endregion CauHinhChotGioFilter

	#region CauHinhChotGioExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="CauHinhChotGio"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class CauHinhChotGioExpressionBuilder : SqlExpressionBuilder<CauHinhChotGioColumn>
	{
	}
	
	#endregion CauHinhChotGioExpressionBuilder	

	#region CauHinhChotGioProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;CauHinhChotGioChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="CauHinhChotGio"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class CauHinhChotGioProperty : ChildEntityProperty<CauHinhChotGioChildEntityTypes>
	{
	}
	
	#endregion CauHinhChotGioProperty
}

