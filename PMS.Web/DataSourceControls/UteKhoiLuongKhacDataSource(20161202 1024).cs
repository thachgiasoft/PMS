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
	/// Represents the DataRepository.UteKhoiLuongKhacProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(UteKhoiLuongKhacDataSourceDesigner))]
	public class UteKhoiLuongKhacDataSource : ProviderDataSource<UteKhoiLuongKhac, UteKhoiLuongKhacKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the UteKhoiLuongKhacDataSource class.
		/// </summary>
		public UteKhoiLuongKhacDataSource() : base(new UteKhoiLuongKhacService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the UteKhoiLuongKhacDataSourceView used by the UteKhoiLuongKhacDataSource.
		/// </summary>
		protected UteKhoiLuongKhacDataSourceView UteKhoiLuongKhacView
		{
			get { return ( View as UteKhoiLuongKhacDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the UteKhoiLuongKhacDataSource control invokes to retrieve data.
		/// </summary>
		public UteKhoiLuongKhacSelectMethod SelectMethod
		{
			get
			{
				UteKhoiLuongKhacSelectMethod selectMethod = UteKhoiLuongKhacSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (UteKhoiLuongKhacSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the UteKhoiLuongKhacDataSourceView class that is to be
		/// used by the UteKhoiLuongKhacDataSource.
		/// </summary>
		/// <returns>An instance of the UteKhoiLuongKhacDataSourceView class.</returns>
		protected override BaseDataSourceView<UteKhoiLuongKhac, UteKhoiLuongKhacKey> GetNewDataSourceView()
		{
			return new UteKhoiLuongKhacDataSourceView(this, DefaultViewName);
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
	/// Supports the UteKhoiLuongKhacDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class UteKhoiLuongKhacDataSourceView : ProviderDataSourceView<UteKhoiLuongKhac, UteKhoiLuongKhacKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the UteKhoiLuongKhacDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the UteKhoiLuongKhacDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public UteKhoiLuongKhacDataSourceView(UteKhoiLuongKhacDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal UteKhoiLuongKhacDataSource UteKhoiLuongKhacOwner
		{
			get { return Owner as UteKhoiLuongKhacDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal UteKhoiLuongKhacSelectMethod SelectMethod
		{
			get { return UteKhoiLuongKhacOwner.SelectMethod; }
			set { UteKhoiLuongKhacOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal UteKhoiLuongKhacService UteKhoiLuongKhacProvider
		{
			get { return Provider as UteKhoiLuongKhacService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<UteKhoiLuongKhac> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<UteKhoiLuongKhac> results = null;
			UteKhoiLuongKhac item;
			count = 0;
			
			System.Int32 _id;
			System.String sp3016_NamHoc;
			System.String sp3016_HocKy;

			switch ( SelectMethod )
			{
				case UteKhoiLuongKhacSelectMethod.Get:
					UteKhoiLuongKhacKey entityKey  = new UteKhoiLuongKhacKey();
					entityKey.Load(values);
					item = UteKhoiLuongKhacProvider.Get(entityKey);
					results = new TList<UteKhoiLuongKhac>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case UteKhoiLuongKhacSelectMethod.GetAll:
                    results = UteKhoiLuongKhacProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case UteKhoiLuongKhacSelectMethod.GetPaged:
					results = UteKhoiLuongKhacProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case UteKhoiLuongKhacSelectMethod.Find:
					if ( FilterParameters != null )
						results = UteKhoiLuongKhacProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = UteKhoiLuongKhacProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case UteKhoiLuongKhacSelectMethod.GetById:
					_id = ( values["Id"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["Id"], typeof(System.Int32)) : (int)0;
					item = UteKhoiLuongKhacProvider.GetById(_id);
					results = new TList<UteKhoiLuongKhac>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				// IX
				// FK
				// M:M
				// Custom
				case UteKhoiLuongKhacSelectMethod.GetByNamHocHocKy:
					sp3016_NamHoc = (System.String) EntityUtil.ChangeType(values["NamHoc"], typeof(System.String));
					sp3016_HocKy = (System.String) EntityUtil.ChangeType(values["HocKy"], typeof(System.String));
					results = UteKhoiLuongKhacProvider.GetByNamHocHocKy(sp3016_NamHoc, sp3016_HocKy, StartIndex, PageSize);
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
			if ( SelectMethod == UteKhoiLuongKhacSelectMethod.Get || SelectMethod == UteKhoiLuongKhacSelectMethod.GetById )
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
				UteKhoiLuongKhac entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					UteKhoiLuongKhacProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<UteKhoiLuongKhac> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			UteKhoiLuongKhacProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region UteKhoiLuongKhacDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the UteKhoiLuongKhacDataSource class.
	/// </summary>
	public class UteKhoiLuongKhacDataSourceDesigner : ProviderDataSourceDesigner<UteKhoiLuongKhac, UteKhoiLuongKhacKey>
	{
		/// <summary>
		/// Initializes a new instance of the UteKhoiLuongKhacDataSourceDesigner class.
		/// </summary>
		public UteKhoiLuongKhacDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public UteKhoiLuongKhacSelectMethod SelectMethod
		{
			get { return ((UteKhoiLuongKhacDataSource) DataSource).SelectMethod; }
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
				actions.Add(new UteKhoiLuongKhacDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region UteKhoiLuongKhacDataSourceActionList

	/// <summary>
	/// Supports the UteKhoiLuongKhacDataSourceDesigner class.
	/// </summary>
	internal class UteKhoiLuongKhacDataSourceActionList : DesignerActionList
	{
		private UteKhoiLuongKhacDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the UteKhoiLuongKhacDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public UteKhoiLuongKhacDataSourceActionList(UteKhoiLuongKhacDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public UteKhoiLuongKhacSelectMethod SelectMethod
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

	#endregion UteKhoiLuongKhacDataSourceActionList
	
	#endregion UteKhoiLuongKhacDataSourceDesigner
	
	#region UteKhoiLuongKhacSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the UteKhoiLuongKhacDataSource.SelectMethod property.
	/// </summary>
	public enum UteKhoiLuongKhacSelectMethod
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
	
	#endregion UteKhoiLuongKhacSelectMethod

	#region UteKhoiLuongKhacFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="UteKhoiLuongKhac"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class UteKhoiLuongKhacFilter : SqlFilter<UteKhoiLuongKhacColumn>
	{
	}
	
	#endregion UteKhoiLuongKhacFilter

	#region UteKhoiLuongKhacExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="UteKhoiLuongKhac"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class UteKhoiLuongKhacExpressionBuilder : SqlExpressionBuilder<UteKhoiLuongKhacColumn>
	{
	}
	
	#endregion UteKhoiLuongKhacExpressionBuilder	

	#region UteKhoiLuongKhacProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;UteKhoiLuongKhacChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="UteKhoiLuongKhac"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class UteKhoiLuongKhacProperty : ChildEntityProperty<UteKhoiLuongKhacChildEntityTypes>
	{
	}
	
	#endregion UteKhoiLuongKhacProperty
}

