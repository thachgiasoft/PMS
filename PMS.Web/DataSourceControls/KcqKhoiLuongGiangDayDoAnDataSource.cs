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
	/// Represents the DataRepository.KcqKhoiLuongGiangDayDoAnProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(KcqKhoiLuongGiangDayDoAnDataSourceDesigner))]
	public class KcqKhoiLuongGiangDayDoAnDataSource : ProviderDataSource<KcqKhoiLuongGiangDayDoAn, KcqKhoiLuongGiangDayDoAnKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KcqKhoiLuongGiangDayDoAnDataSource class.
		/// </summary>
		public KcqKhoiLuongGiangDayDoAnDataSource() : base(new KcqKhoiLuongGiangDayDoAnService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the KcqKhoiLuongGiangDayDoAnDataSourceView used by the KcqKhoiLuongGiangDayDoAnDataSource.
		/// </summary>
		protected KcqKhoiLuongGiangDayDoAnDataSourceView KcqKhoiLuongGiangDayDoAnView
		{
			get { return ( View as KcqKhoiLuongGiangDayDoAnDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the KcqKhoiLuongGiangDayDoAnDataSource control invokes to retrieve data.
		/// </summary>
		public KcqKhoiLuongGiangDayDoAnSelectMethod SelectMethod
		{
			get
			{
				KcqKhoiLuongGiangDayDoAnSelectMethod selectMethod = KcqKhoiLuongGiangDayDoAnSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (KcqKhoiLuongGiangDayDoAnSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the KcqKhoiLuongGiangDayDoAnDataSourceView class that is to be
		/// used by the KcqKhoiLuongGiangDayDoAnDataSource.
		/// </summary>
		/// <returns>An instance of the KcqKhoiLuongGiangDayDoAnDataSourceView class.</returns>
		protected override BaseDataSourceView<KcqKhoiLuongGiangDayDoAn, KcqKhoiLuongGiangDayDoAnKey> GetNewDataSourceView()
		{
			return new KcqKhoiLuongGiangDayDoAnDataSourceView(this, DefaultViewName);
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
	/// Supports the KcqKhoiLuongGiangDayDoAnDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class KcqKhoiLuongGiangDayDoAnDataSourceView : ProviderDataSourceView<KcqKhoiLuongGiangDayDoAn, KcqKhoiLuongGiangDayDoAnKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KcqKhoiLuongGiangDayDoAnDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the KcqKhoiLuongGiangDayDoAnDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public KcqKhoiLuongGiangDayDoAnDataSourceView(KcqKhoiLuongGiangDayDoAnDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal KcqKhoiLuongGiangDayDoAnDataSource KcqKhoiLuongGiangDayDoAnOwner
		{
			get { return Owner as KcqKhoiLuongGiangDayDoAnDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal KcqKhoiLuongGiangDayDoAnSelectMethod SelectMethod
		{
			get { return KcqKhoiLuongGiangDayDoAnOwner.SelectMethod; }
			set { KcqKhoiLuongGiangDayDoAnOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal KcqKhoiLuongGiangDayDoAnService KcqKhoiLuongGiangDayDoAnProvider
		{
			get { return Provider as KcqKhoiLuongGiangDayDoAnService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<KcqKhoiLuongGiangDayDoAn> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<KcqKhoiLuongGiangDayDoAn> results = null;
			KcqKhoiLuongGiangDayDoAn item;
			count = 0;
			
			System.Int32 _id;
			System.String sp372_NamHoc;
			System.String sp372_HocKy;
			System.String sp372_Dot;

			switch ( SelectMethod )
			{
				case KcqKhoiLuongGiangDayDoAnSelectMethod.Get:
					KcqKhoiLuongGiangDayDoAnKey entityKey  = new KcqKhoiLuongGiangDayDoAnKey();
					entityKey.Load(values);
					item = KcqKhoiLuongGiangDayDoAnProvider.Get(entityKey);
					results = new TList<KcqKhoiLuongGiangDayDoAn>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case KcqKhoiLuongGiangDayDoAnSelectMethod.GetAll:
                    results = KcqKhoiLuongGiangDayDoAnProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case KcqKhoiLuongGiangDayDoAnSelectMethod.GetPaged:
					results = KcqKhoiLuongGiangDayDoAnProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case KcqKhoiLuongGiangDayDoAnSelectMethod.Find:
					if ( FilterParameters != null )
						results = KcqKhoiLuongGiangDayDoAnProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = KcqKhoiLuongGiangDayDoAnProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case KcqKhoiLuongGiangDayDoAnSelectMethod.GetById:
					_id = ( values["Id"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["Id"], typeof(System.Int32)) : (int)0;
					item = KcqKhoiLuongGiangDayDoAnProvider.GetById(_id);
					results = new TList<KcqKhoiLuongGiangDayDoAn>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				// IX
				// FK
				// M:M
				// Custom
				case KcqKhoiLuongGiangDayDoAnSelectMethod.GetByNamHocHocKyDot:
					sp372_NamHoc = (System.String) EntityUtil.ChangeType(values["NamHoc"], typeof(System.String));
					sp372_HocKy = (System.String) EntityUtil.ChangeType(values["HocKy"], typeof(System.String));
					sp372_Dot = (System.String) EntityUtil.ChangeType(values["Dot"], typeof(System.String));
					results = KcqKhoiLuongGiangDayDoAnProvider.GetByNamHocHocKyDot(sp372_NamHoc, sp372_HocKy, sp372_Dot, StartIndex, PageSize);
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
			if ( SelectMethod == KcqKhoiLuongGiangDayDoAnSelectMethod.Get || SelectMethod == KcqKhoiLuongGiangDayDoAnSelectMethod.GetById )
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
				KcqKhoiLuongGiangDayDoAn entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					KcqKhoiLuongGiangDayDoAnProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<KcqKhoiLuongGiangDayDoAn> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			KcqKhoiLuongGiangDayDoAnProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region KcqKhoiLuongGiangDayDoAnDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the KcqKhoiLuongGiangDayDoAnDataSource class.
	/// </summary>
	public class KcqKhoiLuongGiangDayDoAnDataSourceDesigner : ProviderDataSourceDesigner<KcqKhoiLuongGiangDayDoAn, KcqKhoiLuongGiangDayDoAnKey>
	{
		/// <summary>
		/// Initializes a new instance of the KcqKhoiLuongGiangDayDoAnDataSourceDesigner class.
		/// </summary>
		public KcqKhoiLuongGiangDayDoAnDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public KcqKhoiLuongGiangDayDoAnSelectMethod SelectMethod
		{
			get { return ((KcqKhoiLuongGiangDayDoAnDataSource) DataSource).SelectMethod; }
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
				actions.Add(new KcqKhoiLuongGiangDayDoAnDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region KcqKhoiLuongGiangDayDoAnDataSourceActionList

	/// <summary>
	/// Supports the KcqKhoiLuongGiangDayDoAnDataSourceDesigner class.
	/// </summary>
	internal class KcqKhoiLuongGiangDayDoAnDataSourceActionList : DesignerActionList
	{
		private KcqKhoiLuongGiangDayDoAnDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the KcqKhoiLuongGiangDayDoAnDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public KcqKhoiLuongGiangDayDoAnDataSourceActionList(KcqKhoiLuongGiangDayDoAnDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public KcqKhoiLuongGiangDayDoAnSelectMethod SelectMethod
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

	#endregion KcqKhoiLuongGiangDayDoAnDataSourceActionList
	
	#endregion KcqKhoiLuongGiangDayDoAnDataSourceDesigner
	
	#region KcqKhoiLuongGiangDayDoAnSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the KcqKhoiLuongGiangDayDoAnDataSource.SelectMethod property.
	/// </summary>
	public enum KcqKhoiLuongGiangDayDoAnSelectMethod
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
	
	#endregion KcqKhoiLuongGiangDayDoAnSelectMethod

	#region KcqKhoiLuongGiangDayDoAnFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="KcqKhoiLuongGiangDayDoAn"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KcqKhoiLuongGiangDayDoAnFilter : SqlFilter<KcqKhoiLuongGiangDayDoAnColumn>
	{
	}
	
	#endregion KcqKhoiLuongGiangDayDoAnFilter

	#region KcqKhoiLuongGiangDayDoAnExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="KcqKhoiLuongGiangDayDoAn"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KcqKhoiLuongGiangDayDoAnExpressionBuilder : SqlExpressionBuilder<KcqKhoiLuongGiangDayDoAnColumn>
	{
	}
	
	#endregion KcqKhoiLuongGiangDayDoAnExpressionBuilder	

	#region KcqKhoiLuongGiangDayDoAnProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;KcqKhoiLuongGiangDayDoAnChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="KcqKhoiLuongGiangDayDoAn"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KcqKhoiLuongGiangDayDoAnProperty : ChildEntityProperty<KcqKhoiLuongGiangDayDoAnChildEntityTypes>
	{
	}
	
	#endregion KcqKhoiLuongGiangDayDoAnProperty
}

