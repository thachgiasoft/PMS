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
	/// Represents the DataRepository.KcqUteKhoiLuongKhacProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(KcqUteKhoiLuongKhacDataSourceDesigner))]
	public class KcqUteKhoiLuongKhacDataSource : ProviderDataSource<KcqUteKhoiLuongKhac, KcqUteKhoiLuongKhacKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KcqUteKhoiLuongKhacDataSource class.
		/// </summary>
		public KcqUteKhoiLuongKhacDataSource() : base(new KcqUteKhoiLuongKhacService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the KcqUteKhoiLuongKhacDataSourceView used by the KcqUteKhoiLuongKhacDataSource.
		/// </summary>
		protected KcqUteKhoiLuongKhacDataSourceView KcqUteKhoiLuongKhacView
		{
			get { return ( View as KcqUteKhoiLuongKhacDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the KcqUteKhoiLuongKhacDataSource control invokes to retrieve data.
		/// </summary>
		public KcqUteKhoiLuongKhacSelectMethod SelectMethod
		{
			get
			{
				KcqUteKhoiLuongKhacSelectMethod selectMethod = KcqUteKhoiLuongKhacSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (KcqUteKhoiLuongKhacSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the KcqUteKhoiLuongKhacDataSourceView class that is to be
		/// used by the KcqUteKhoiLuongKhacDataSource.
		/// </summary>
		/// <returns>An instance of the KcqUteKhoiLuongKhacDataSourceView class.</returns>
		protected override BaseDataSourceView<KcqUteKhoiLuongKhac, KcqUteKhoiLuongKhacKey> GetNewDataSourceView()
		{
			return new KcqUteKhoiLuongKhacDataSourceView(this, DefaultViewName);
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
	/// Supports the KcqUteKhoiLuongKhacDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class KcqUteKhoiLuongKhacDataSourceView : ProviderDataSourceView<KcqUteKhoiLuongKhac, KcqUteKhoiLuongKhacKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KcqUteKhoiLuongKhacDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the KcqUteKhoiLuongKhacDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public KcqUteKhoiLuongKhacDataSourceView(KcqUteKhoiLuongKhacDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal KcqUteKhoiLuongKhacDataSource KcqUteKhoiLuongKhacOwner
		{
			get { return Owner as KcqUteKhoiLuongKhacDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal KcqUteKhoiLuongKhacSelectMethod SelectMethod
		{
			get { return KcqUteKhoiLuongKhacOwner.SelectMethod; }
			set { KcqUteKhoiLuongKhacOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal KcqUteKhoiLuongKhacService KcqUteKhoiLuongKhacProvider
		{
			get { return Provider as KcqUteKhoiLuongKhacService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<KcqUteKhoiLuongKhac> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<KcqUteKhoiLuongKhac> results = null;
			KcqUteKhoiLuongKhac item;
			count = 0;
			
			System.Int32 _id;
			System.String sp399_NamHoc;
			System.String sp399_HocKy;
			System.String sp399_Dot;

			switch ( SelectMethod )
			{
				case KcqUteKhoiLuongKhacSelectMethod.Get:
					KcqUteKhoiLuongKhacKey entityKey  = new KcqUteKhoiLuongKhacKey();
					entityKey.Load(values);
					item = KcqUteKhoiLuongKhacProvider.Get(entityKey);
					results = new TList<KcqUteKhoiLuongKhac>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case KcqUteKhoiLuongKhacSelectMethod.GetAll:
                    results = KcqUteKhoiLuongKhacProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case KcqUteKhoiLuongKhacSelectMethod.GetPaged:
					results = KcqUteKhoiLuongKhacProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case KcqUteKhoiLuongKhacSelectMethod.Find:
					if ( FilterParameters != null )
						results = KcqUteKhoiLuongKhacProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = KcqUteKhoiLuongKhacProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case KcqUteKhoiLuongKhacSelectMethod.GetById:
					_id = ( values["Id"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["Id"], typeof(System.Int32)) : (int)0;
					item = KcqUteKhoiLuongKhacProvider.GetById(_id);
					results = new TList<KcqUteKhoiLuongKhac>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				// IX
				// FK
				// M:M
				// Custom
				case KcqUteKhoiLuongKhacSelectMethod.GetByNamHocHocKyDot:
					sp399_NamHoc = (System.String) EntityUtil.ChangeType(values["NamHoc"], typeof(System.String));
					sp399_HocKy = (System.String) EntityUtil.ChangeType(values["HocKy"], typeof(System.String));
					sp399_Dot = (System.String) EntityUtil.ChangeType(values["Dot"], typeof(System.String));
					results = KcqUteKhoiLuongKhacProvider.GetByNamHocHocKyDot(sp399_NamHoc, sp399_HocKy, sp399_Dot, StartIndex, PageSize);
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
			if ( SelectMethod == KcqUteKhoiLuongKhacSelectMethod.Get || SelectMethod == KcqUteKhoiLuongKhacSelectMethod.GetById )
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
				KcqUteKhoiLuongKhac entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					KcqUteKhoiLuongKhacProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<KcqUteKhoiLuongKhac> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			KcqUteKhoiLuongKhacProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region KcqUteKhoiLuongKhacDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the KcqUteKhoiLuongKhacDataSource class.
	/// </summary>
	public class KcqUteKhoiLuongKhacDataSourceDesigner : ProviderDataSourceDesigner<KcqUteKhoiLuongKhac, KcqUteKhoiLuongKhacKey>
	{
		/// <summary>
		/// Initializes a new instance of the KcqUteKhoiLuongKhacDataSourceDesigner class.
		/// </summary>
		public KcqUteKhoiLuongKhacDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public KcqUteKhoiLuongKhacSelectMethod SelectMethod
		{
			get { return ((KcqUteKhoiLuongKhacDataSource) DataSource).SelectMethod; }
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
				actions.Add(new KcqUteKhoiLuongKhacDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region KcqUteKhoiLuongKhacDataSourceActionList

	/// <summary>
	/// Supports the KcqUteKhoiLuongKhacDataSourceDesigner class.
	/// </summary>
	internal class KcqUteKhoiLuongKhacDataSourceActionList : DesignerActionList
	{
		private KcqUteKhoiLuongKhacDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the KcqUteKhoiLuongKhacDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public KcqUteKhoiLuongKhacDataSourceActionList(KcqUteKhoiLuongKhacDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public KcqUteKhoiLuongKhacSelectMethod SelectMethod
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

	#endregion KcqUteKhoiLuongKhacDataSourceActionList
	
	#endregion KcqUteKhoiLuongKhacDataSourceDesigner
	
	#region KcqUteKhoiLuongKhacSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the KcqUteKhoiLuongKhacDataSource.SelectMethod property.
	/// </summary>
	public enum KcqUteKhoiLuongKhacSelectMethod
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
		/// Represents the GetByNamHocHocKyDot method.
		/// </summary>
		GetByNamHocHocKyDot
	}
	
	#endregion KcqUteKhoiLuongKhacSelectMethod

	#region KcqUteKhoiLuongKhacFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="KcqUteKhoiLuongKhac"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KcqUteKhoiLuongKhacFilter : SqlFilter<KcqUteKhoiLuongKhacColumn>
	{
	}
	
	#endregion KcqUteKhoiLuongKhacFilter

	#region KcqUteKhoiLuongKhacExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="KcqUteKhoiLuongKhac"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KcqUteKhoiLuongKhacExpressionBuilder : SqlExpressionBuilder<KcqUteKhoiLuongKhacColumn>
	{
	}
	
	#endregion KcqUteKhoiLuongKhacExpressionBuilder	

	#region KcqUteKhoiLuongKhacProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;KcqUteKhoiLuongKhacChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="KcqUteKhoiLuongKhac"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KcqUteKhoiLuongKhacProperty : ChildEntityProperty<KcqUteKhoiLuongKhacChildEntityTypes>
	{
	}
	
	#endregion KcqUteKhoiLuongKhacProperty
}

