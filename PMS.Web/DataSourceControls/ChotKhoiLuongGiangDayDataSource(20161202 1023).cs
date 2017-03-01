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
	/// Represents the DataRepository.ChotKhoiLuongGiangDayProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(ChotKhoiLuongGiangDayDataSourceDesigner))]
	public class ChotKhoiLuongGiangDayDataSource : ProviderDataSource<ChotKhoiLuongGiangDay, ChotKhoiLuongGiangDayKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ChotKhoiLuongGiangDayDataSource class.
		/// </summary>
		public ChotKhoiLuongGiangDayDataSource() : base(new ChotKhoiLuongGiangDayService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the ChotKhoiLuongGiangDayDataSourceView used by the ChotKhoiLuongGiangDayDataSource.
		/// </summary>
		protected ChotKhoiLuongGiangDayDataSourceView ChotKhoiLuongGiangDayView
		{
			get { return ( View as ChotKhoiLuongGiangDayDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the ChotKhoiLuongGiangDayDataSource control invokes to retrieve data.
		/// </summary>
		public ChotKhoiLuongGiangDaySelectMethod SelectMethod
		{
			get
			{
				ChotKhoiLuongGiangDaySelectMethod selectMethod = ChotKhoiLuongGiangDaySelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (ChotKhoiLuongGiangDaySelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the ChotKhoiLuongGiangDayDataSourceView class that is to be
		/// used by the ChotKhoiLuongGiangDayDataSource.
		/// </summary>
		/// <returns>An instance of the ChotKhoiLuongGiangDayDataSourceView class.</returns>
		protected override BaseDataSourceView<ChotKhoiLuongGiangDay, ChotKhoiLuongGiangDayKey> GetNewDataSourceView()
		{
			return new ChotKhoiLuongGiangDayDataSourceView(this, DefaultViewName);
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
	/// Supports the ChotKhoiLuongGiangDayDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class ChotKhoiLuongGiangDayDataSourceView : ProviderDataSourceView<ChotKhoiLuongGiangDay, ChotKhoiLuongGiangDayKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ChotKhoiLuongGiangDayDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the ChotKhoiLuongGiangDayDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public ChotKhoiLuongGiangDayDataSourceView(ChotKhoiLuongGiangDayDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal ChotKhoiLuongGiangDayDataSource ChotKhoiLuongGiangDayOwner
		{
			get { return Owner as ChotKhoiLuongGiangDayDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal ChotKhoiLuongGiangDaySelectMethod SelectMethod
		{
			get { return ChotKhoiLuongGiangDayOwner.SelectMethod; }
			set { ChotKhoiLuongGiangDayOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal ChotKhoiLuongGiangDayService ChotKhoiLuongGiangDayProvider
		{
			get { return Provider as ChotKhoiLuongGiangDayService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<ChotKhoiLuongGiangDay> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<ChotKhoiLuongGiangDay> results = null;
			ChotKhoiLuongGiangDay item;
			count = 0;
			
			System.Int32 _id;
			System.String sp2119_NamHoc;
			System.String sp2119_HocKy;

			switch ( SelectMethod )
			{
				case ChotKhoiLuongGiangDaySelectMethod.Get:
					ChotKhoiLuongGiangDayKey entityKey  = new ChotKhoiLuongGiangDayKey();
					entityKey.Load(values);
					item = ChotKhoiLuongGiangDayProvider.Get(entityKey);
					results = new TList<ChotKhoiLuongGiangDay>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case ChotKhoiLuongGiangDaySelectMethod.GetAll:
                    results = ChotKhoiLuongGiangDayProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case ChotKhoiLuongGiangDaySelectMethod.GetPaged:
					results = ChotKhoiLuongGiangDayProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case ChotKhoiLuongGiangDaySelectMethod.Find:
					if ( FilterParameters != null )
						results = ChotKhoiLuongGiangDayProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = ChotKhoiLuongGiangDayProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case ChotKhoiLuongGiangDaySelectMethod.GetById:
					_id = ( values["Id"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["Id"], typeof(System.Int32)) : (int)0;
					item = ChotKhoiLuongGiangDayProvider.GetById(_id);
					results = new TList<ChotKhoiLuongGiangDay>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				// IX
				// FK
				// M:M
				// Custom
				case ChotKhoiLuongGiangDaySelectMethod.GetByNamHocHocKy:
					sp2119_NamHoc = (System.String) EntityUtil.ChangeType(values["NamHoc"], typeof(System.String));
					sp2119_HocKy = (System.String) EntityUtil.ChangeType(values["HocKy"], typeof(System.String));
					results = ChotKhoiLuongGiangDayProvider.GetByNamHocHocKy(sp2119_NamHoc, sp2119_HocKy, StartIndex, PageSize);
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
			if ( SelectMethod == ChotKhoiLuongGiangDaySelectMethod.Get || SelectMethod == ChotKhoiLuongGiangDaySelectMethod.GetById )
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
				ChotKhoiLuongGiangDay entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					ChotKhoiLuongGiangDayProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<ChotKhoiLuongGiangDay> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			ChotKhoiLuongGiangDayProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region ChotKhoiLuongGiangDayDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the ChotKhoiLuongGiangDayDataSource class.
	/// </summary>
	public class ChotKhoiLuongGiangDayDataSourceDesigner : ProviderDataSourceDesigner<ChotKhoiLuongGiangDay, ChotKhoiLuongGiangDayKey>
	{
		/// <summary>
		/// Initializes a new instance of the ChotKhoiLuongGiangDayDataSourceDesigner class.
		/// </summary>
		public ChotKhoiLuongGiangDayDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public ChotKhoiLuongGiangDaySelectMethod SelectMethod
		{
			get { return ((ChotKhoiLuongGiangDayDataSource) DataSource).SelectMethod; }
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
				actions.Add(new ChotKhoiLuongGiangDayDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region ChotKhoiLuongGiangDayDataSourceActionList

	/// <summary>
	/// Supports the ChotKhoiLuongGiangDayDataSourceDesigner class.
	/// </summary>
	internal class ChotKhoiLuongGiangDayDataSourceActionList : DesignerActionList
	{
		private ChotKhoiLuongGiangDayDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the ChotKhoiLuongGiangDayDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public ChotKhoiLuongGiangDayDataSourceActionList(ChotKhoiLuongGiangDayDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public ChotKhoiLuongGiangDaySelectMethod SelectMethod
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

	#endregion ChotKhoiLuongGiangDayDataSourceActionList
	
	#endregion ChotKhoiLuongGiangDayDataSourceDesigner
	
	#region ChotKhoiLuongGiangDaySelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the ChotKhoiLuongGiangDayDataSource.SelectMethod property.
	/// </summary>
	public enum ChotKhoiLuongGiangDaySelectMethod
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
	
	#endregion ChotKhoiLuongGiangDaySelectMethod

	#region ChotKhoiLuongGiangDayFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ChotKhoiLuongGiangDay"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ChotKhoiLuongGiangDayFilter : SqlFilter<ChotKhoiLuongGiangDayColumn>
	{
	}
	
	#endregion ChotKhoiLuongGiangDayFilter

	#region ChotKhoiLuongGiangDayExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ChotKhoiLuongGiangDay"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ChotKhoiLuongGiangDayExpressionBuilder : SqlExpressionBuilder<ChotKhoiLuongGiangDayColumn>
	{
	}
	
	#endregion ChotKhoiLuongGiangDayExpressionBuilder	

	#region ChotKhoiLuongGiangDayProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;ChotKhoiLuongGiangDayChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="ChotKhoiLuongGiangDay"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ChotKhoiLuongGiangDayProperty : ChildEntityProperty<ChotKhoiLuongGiangDayChildEntityTypes>
	{
	}
	
	#endregion ChotKhoiLuongGiangDayProperty
}

