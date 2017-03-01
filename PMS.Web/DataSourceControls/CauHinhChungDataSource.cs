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
	/// Represents the DataRepository.CauHinhChungProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(CauHinhChungDataSourceDesigner))]
	public class CauHinhChungDataSource : ProviderDataSource<CauHinhChung, CauHinhChungKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the CauHinhChungDataSource class.
		/// </summary>
		public CauHinhChungDataSource() : base(new CauHinhChungService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the CauHinhChungDataSourceView used by the CauHinhChungDataSource.
		/// </summary>
		protected CauHinhChungDataSourceView CauHinhChungView
		{
			get { return ( View as CauHinhChungDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the CauHinhChungDataSource control invokes to retrieve data.
		/// </summary>
		public CauHinhChungSelectMethod SelectMethod
		{
			get
			{
				CauHinhChungSelectMethod selectMethod = CauHinhChungSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (CauHinhChungSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the CauHinhChungDataSourceView class that is to be
		/// used by the CauHinhChungDataSource.
		/// </summary>
		/// <returns>An instance of the CauHinhChungDataSourceView class.</returns>
		protected override BaseDataSourceView<CauHinhChung, CauHinhChungKey> GetNewDataSourceView()
		{
			return new CauHinhChungDataSourceView(this, DefaultViewName);
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
	/// Supports the CauHinhChungDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class CauHinhChungDataSourceView : ProviderDataSourceView<CauHinhChung, CauHinhChungKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the CauHinhChungDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the CauHinhChungDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public CauHinhChungDataSourceView(CauHinhChungDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal CauHinhChungDataSource CauHinhChungOwner
		{
			get { return Owner as CauHinhChungDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal CauHinhChungSelectMethod SelectMethod
		{
			get { return CauHinhChungOwner.SelectMethod; }
			set { CauHinhChungOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal CauHinhChungService CauHinhChungProvider
		{
			get { return Provider as CauHinhChungService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<CauHinhChung> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<CauHinhChung> results = null;
			CauHinhChung item;
			count = 0;
			
			System.Int32 _maCauHinh;

			switch ( SelectMethod )
			{
				case CauHinhChungSelectMethod.Get:
					CauHinhChungKey entityKey  = new CauHinhChungKey();
					entityKey.Load(values);
					item = CauHinhChungProvider.Get(entityKey);
					results = new TList<CauHinhChung>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case CauHinhChungSelectMethod.GetAll:
                    results = CauHinhChungProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case CauHinhChungSelectMethod.GetPaged:
					results = CauHinhChungProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case CauHinhChungSelectMethod.Find:
					if ( FilterParameters != null )
						results = CauHinhChungProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = CauHinhChungProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case CauHinhChungSelectMethod.GetByMaCauHinh:
					_maCauHinh = ( values["MaCauHinh"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["MaCauHinh"], typeof(System.Int32)) : (int)0;
					item = CauHinhChungProvider.GetByMaCauHinh(_maCauHinh);
					results = new TList<CauHinhChung>();
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
			if ( SelectMethod == CauHinhChungSelectMethod.Get || SelectMethod == CauHinhChungSelectMethod.GetByMaCauHinh )
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
				CauHinhChung entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					CauHinhChungProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<CauHinhChung> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			CauHinhChungProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region CauHinhChungDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the CauHinhChungDataSource class.
	/// </summary>
	public class CauHinhChungDataSourceDesigner : ProviderDataSourceDesigner<CauHinhChung, CauHinhChungKey>
	{
		/// <summary>
		/// Initializes a new instance of the CauHinhChungDataSourceDesigner class.
		/// </summary>
		public CauHinhChungDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public CauHinhChungSelectMethod SelectMethod
		{
			get { return ((CauHinhChungDataSource) DataSource).SelectMethod; }
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
				actions.Add(new CauHinhChungDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region CauHinhChungDataSourceActionList

	/// <summary>
	/// Supports the CauHinhChungDataSourceDesigner class.
	/// </summary>
	internal class CauHinhChungDataSourceActionList : DesignerActionList
	{
		private CauHinhChungDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the CauHinhChungDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public CauHinhChungDataSourceActionList(CauHinhChungDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public CauHinhChungSelectMethod SelectMethod
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

	#endregion CauHinhChungDataSourceActionList
	
	#endregion CauHinhChungDataSourceDesigner
	
	#region CauHinhChungSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the CauHinhChungDataSource.SelectMethod property.
	/// </summary>
	public enum CauHinhChungSelectMethod
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
		/// Represents the GetByMaCauHinh method.
		/// </summary>
		GetByMaCauHinh
	}
	
	#endregion CauHinhChungSelectMethod

	#region CauHinhChungFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="CauHinhChung"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class CauHinhChungFilter : SqlFilter<CauHinhChungColumn>
	{
	}
	
	#endregion CauHinhChungFilter

	#region CauHinhChungExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="CauHinhChung"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class CauHinhChungExpressionBuilder : SqlExpressionBuilder<CauHinhChungColumn>
	{
	}
	
	#endregion CauHinhChungExpressionBuilder	

	#region CauHinhChungProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;CauHinhChungChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="CauHinhChung"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class CauHinhChungProperty : ChildEntityProperty<CauHinhChungChildEntityTypes>
	{
	}
	
	#endregion CauHinhChungProperty
}

