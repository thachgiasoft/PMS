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
	/// Represents the DataRepository.KhoiLuongGiangDayDoAnProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(KhoiLuongGiangDayDoAnDataSourceDesigner))]
	public class KhoiLuongGiangDayDoAnDataSource : ProviderDataSource<KhoiLuongGiangDayDoAn, KhoiLuongGiangDayDoAnKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KhoiLuongGiangDayDoAnDataSource class.
		/// </summary>
		public KhoiLuongGiangDayDoAnDataSource() : base(new KhoiLuongGiangDayDoAnService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the KhoiLuongGiangDayDoAnDataSourceView used by the KhoiLuongGiangDayDoAnDataSource.
		/// </summary>
		protected KhoiLuongGiangDayDoAnDataSourceView KhoiLuongGiangDayDoAnView
		{
			get { return ( View as KhoiLuongGiangDayDoAnDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the KhoiLuongGiangDayDoAnDataSource control invokes to retrieve data.
		/// </summary>
		public KhoiLuongGiangDayDoAnSelectMethod SelectMethod
		{
			get
			{
				KhoiLuongGiangDayDoAnSelectMethod selectMethod = KhoiLuongGiangDayDoAnSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (KhoiLuongGiangDayDoAnSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the KhoiLuongGiangDayDoAnDataSourceView class that is to be
		/// used by the KhoiLuongGiangDayDoAnDataSource.
		/// </summary>
		/// <returns>An instance of the KhoiLuongGiangDayDoAnDataSourceView class.</returns>
		protected override BaseDataSourceView<KhoiLuongGiangDayDoAn, KhoiLuongGiangDayDoAnKey> GetNewDataSourceView()
		{
			return new KhoiLuongGiangDayDoAnDataSourceView(this, DefaultViewName);
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
	/// Supports the KhoiLuongGiangDayDoAnDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class KhoiLuongGiangDayDoAnDataSourceView : ProviderDataSourceView<KhoiLuongGiangDayDoAn, KhoiLuongGiangDayDoAnKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KhoiLuongGiangDayDoAnDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the KhoiLuongGiangDayDoAnDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public KhoiLuongGiangDayDoAnDataSourceView(KhoiLuongGiangDayDoAnDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal KhoiLuongGiangDayDoAnDataSource KhoiLuongGiangDayDoAnOwner
		{
			get { return Owner as KhoiLuongGiangDayDoAnDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal KhoiLuongGiangDayDoAnSelectMethod SelectMethod
		{
			get { return KhoiLuongGiangDayDoAnOwner.SelectMethod; }
			set { KhoiLuongGiangDayDoAnOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal KhoiLuongGiangDayDoAnService KhoiLuongGiangDayDoAnProvider
		{
			get { return Provider as KhoiLuongGiangDayDoAnService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<KhoiLuongGiangDayDoAn> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<KhoiLuongGiangDayDoAn> results = null;
			KhoiLuongGiangDayDoAn item;
			count = 0;
			
			System.Int32 _id;
			System.String sp2692_NamHoc;
			System.String sp2692_HocKy;

			switch ( SelectMethod )
			{
				case KhoiLuongGiangDayDoAnSelectMethod.Get:
					KhoiLuongGiangDayDoAnKey entityKey  = new KhoiLuongGiangDayDoAnKey();
					entityKey.Load(values);
					item = KhoiLuongGiangDayDoAnProvider.Get(entityKey);
					results = new TList<KhoiLuongGiangDayDoAn>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case KhoiLuongGiangDayDoAnSelectMethod.GetAll:
                    results = KhoiLuongGiangDayDoAnProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case KhoiLuongGiangDayDoAnSelectMethod.GetPaged:
					results = KhoiLuongGiangDayDoAnProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case KhoiLuongGiangDayDoAnSelectMethod.Find:
					if ( FilterParameters != null )
						results = KhoiLuongGiangDayDoAnProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = KhoiLuongGiangDayDoAnProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case KhoiLuongGiangDayDoAnSelectMethod.GetById:
					_id = ( values["Id"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["Id"], typeof(System.Int32)) : (int)0;
					item = KhoiLuongGiangDayDoAnProvider.GetById(_id);
					results = new TList<KhoiLuongGiangDayDoAn>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				// IX
				// FK
				// M:M
				// Custom
				case KhoiLuongGiangDayDoAnSelectMethod.GetByNamHocHocKy:
					sp2692_NamHoc = (System.String) EntityUtil.ChangeType(values["NamHoc"], typeof(System.String));
					sp2692_HocKy = (System.String) EntityUtil.ChangeType(values["HocKy"], typeof(System.String));
					results = KhoiLuongGiangDayDoAnProvider.GetByNamHocHocKy(sp2692_NamHoc, sp2692_HocKy, StartIndex, PageSize);
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
			if ( SelectMethod == KhoiLuongGiangDayDoAnSelectMethod.Get || SelectMethod == KhoiLuongGiangDayDoAnSelectMethod.GetById )
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
				KhoiLuongGiangDayDoAn entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					KhoiLuongGiangDayDoAnProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<KhoiLuongGiangDayDoAn> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			KhoiLuongGiangDayDoAnProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region KhoiLuongGiangDayDoAnDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the KhoiLuongGiangDayDoAnDataSource class.
	/// </summary>
	public class KhoiLuongGiangDayDoAnDataSourceDesigner : ProviderDataSourceDesigner<KhoiLuongGiangDayDoAn, KhoiLuongGiangDayDoAnKey>
	{
		/// <summary>
		/// Initializes a new instance of the KhoiLuongGiangDayDoAnDataSourceDesigner class.
		/// </summary>
		public KhoiLuongGiangDayDoAnDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public KhoiLuongGiangDayDoAnSelectMethod SelectMethod
		{
			get { return ((KhoiLuongGiangDayDoAnDataSource) DataSource).SelectMethod; }
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
				actions.Add(new KhoiLuongGiangDayDoAnDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region KhoiLuongGiangDayDoAnDataSourceActionList

	/// <summary>
	/// Supports the KhoiLuongGiangDayDoAnDataSourceDesigner class.
	/// </summary>
	internal class KhoiLuongGiangDayDoAnDataSourceActionList : DesignerActionList
	{
		private KhoiLuongGiangDayDoAnDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the KhoiLuongGiangDayDoAnDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public KhoiLuongGiangDayDoAnDataSourceActionList(KhoiLuongGiangDayDoAnDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public KhoiLuongGiangDayDoAnSelectMethod SelectMethod
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

	#endregion KhoiLuongGiangDayDoAnDataSourceActionList
	
	#endregion KhoiLuongGiangDayDoAnDataSourceDesigner
	
	#region KhoiLuongGiangDayDoAnSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the KhoiLuongGiangDayDoAnDataSource.SelectMethod property.
	/// </summary>
	public enum KhoiLuongGiangDayDoAnSelectMethod
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
	
	#endregion KhoiLuongGiangDayDoAnSelectMethod

	#region KhoiLuongGiangDayDoAnFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="KhoiLuongGiangDayDoAn"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KhoiLuongGiangDayDoAnFilter : SqlFilter<KhoiLuongGiangDayDoAnColumn>
	{
	}
	
	#endregion KhoiLuongGiangDayDoAnFilter

	#region KhoiLuongGiangDayDoAnExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="KhoiLuongGiangDayDoAn"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KhoiLuongGiangDayDoAnExpressionBuilder : SqlExpressionBuilder<KhoiLuongGiangDayDoAnColumn>
	{
	}
	
	#endregion KhoiLuongGiangDayDoAnExpressionBuilder	

	#region KhoiLuongGiangDayDoAnProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;KhoiLuongGiangDayDoAnChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="KhoiLuongGiangDayDoAn"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KhoiLuongGiangDayDoAnProperty : ChildEntityProperty<KhoiLuongGiangDayDoAnChildEntityTypes>
	{
	}
	
	#endregion KhoiLuongGiangDayDoAnProperty
}

