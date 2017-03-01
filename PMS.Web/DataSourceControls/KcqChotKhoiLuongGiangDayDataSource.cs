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
	/// Represents the DataRepository.KcqChotKhoiLuongGiangDayProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(KcqChotKhoiLuongGiangDayDataSourceDesigner))]
	public class KcqChotKhoiLuongGiangDayDataSource : ProviderDataSource<KcqChotKhoiLuongGiangDay, KcqChotKhoiLuongGiangDayKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KcqChotKhoiLuongGiangDayDataSource class.
		/// </summary>
		public KcqChotKhoiLuongGiangDayDataSource() : base(new KcqChotKhoiLuongGiangDayService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the KcqChotKhoiLuongGiangDayDataSourceView used by the KcqChotKhoiLuongGiangDayDataSource.
		/// </summary>
		protected KcqChotKhoiLuongGiangDayDataSourceView KcqChotKhoiLuongGiangDayView
		{
			get { return ( View as KcqChotKhoiLuongGiangDayDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the KcqChotKhoiLuongGiangDayDataSource control invokes to retrieve data.
		/// </summary>
		public KcqChotKhoiLuongGiangDaySelectMethod SelectMethod
		{
			get
			{
				KcqChotKhoiLuongGiangDaySelectMethod selectMethod = KcqChotKhoiLuongGiangDaySelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (KcqChotKhoiLuongGiangDaySelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the KcqChotKhoiLuongGiangDayDataSourceView class that is to be
		/// used by the KcqChotKhoiLuongGiangDayDataSource.
		/// </summary>
		/// <returns>An instance of the KcqChotKhoiLuongGiangDayDataSourceView class.</returns>
		protected override BaseDataSourceView<KcqChotKhoiLuongGiangDay, KcqChotKhoiLuongGiangDayKey> GetNewDataSourceView()
		{
			return new KcqChotKhoiLuongGiangDayDataSourceView(this, DefaultViewName);
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
	/// Supports the KcqChotKhoiLuongGiangDayDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class KcqChotKhoiLuongGiangDayDataSourceView : ProviderDataSourceView<KcqChotKhoiLuongGiangDay, KcqChotKhoiLuongGiangDayKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KcqChotKhoiLuongGiangDayDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the KcqChotKhoiLuongGiangDayDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public KcqChotKhoiLuongGiangDayDataSourceView(KcqChotKhoiLuongGiangDayDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal KcqChotKhoiLuongGiangDayDataSource KcqChotKhoiLuongGiangDayOwner
		{
			get { return Owner as KcqChotKhoiLuongGiangDayDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal KcqChotKhoiLuongGiangDaySelectMethod SelectMethod
		{
			get { return KcqChotKhoiLuongGiangDayOwner.SelectMethod; }
			set { KcqChotKhoiLuongGiangDayOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal KcqChotKhoiLuongGiangDayService KcqChotKhoiLuongGiangDayProvider
		{
			get { return Provider as KcqChotKhoiLuongGiangDayService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<KcqChotKhoiLuongGiangDay> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<KcqChotKhoiLuongGiangDay> results = null;
			KcqChotKhoiLuongGiangDay item;
			count = 0;
			
			System.Int32 _id;

			switch ( SelectMethod )
			{
				case KcqChotKhoiLuongGiangDaySelectMethod.Get:
					KcqChotKhoiLuongGiangDayKey entityKey  = new KcqChotKhoiLuongGiangDayKey();
					entityKey.Load(values);
					item = KcqChotKhoiLuongGiangDayProvider.Get(entityKey);
					results = new TList<KcqChotKhoiLuongGiangDay>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case KcqChotKhoiLuongGiangDaySelectMethod.GetAll:
                    results = KcqChotKhoiLuongGiangDayProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case KcqChotKhoiLuongGiangDaySelectMethod.GetPaged:
					results = KcqChotKhoiLuongGiangDayProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case KcqChotKhoiLuongGiangDaySelectMethod.Find:
					if ( FilterParameters != null )
						results = KcqChotKhoiLuongGiangDayProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = KcqChotKhoiLuongGiangDayProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case KcqChotKhoiLuongGiangDaySelectMethod.GetById:
					_id = ( values["Id"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["Id"], typeof(System.Int32)) : (int)0;
					item = KcqChotKhoiLuongGiangDayProvider.GetById(_id);
					results = new TList<KcqChotKhoiLuongGiangDay>();
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
			if ( SelectMethod == KcqChotKhoiLuongGiangDaySelectMethod.Get || SelectMethod == KcqChotKhoiLuongGiangDaySelectMethod.GetById )
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
				KcqChotKhoiLuongGiangDay entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					KcqChotKhoiLuongGiangDayProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<KcqChotKhoiLuongGiangDay> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			KcqChotKhoiLuongGiangDayProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region KcqChotKhoiLuongGiangDayDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the KcqChotKhoiLuongGiangDayDataSource class.
	/// </summary>
	public class KcqChotKhoiLuongGiangDayDataSourceDesigner : ProviderDataSourceDesigner<KcqChotKhoiLuongGiangDay, KcqChotKhoiLuongGiangDayKey>
	{
		/// <summary>
		/// Initializes a new instance of the KcqChotKhoiLuongGiangDayDataSourceDesigner class.
		/// </summary>
		public KcqChotKhoiLuongGiangDayDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public KcqChotKhoiLuongGiangDaySelectMethod SelectMethod
		{
			get { return ((KcqChotKhoiLuongGiangDayDataSource) DataSource).SelectMethod; }
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
				actions.Add(new KcqChotKhoiLuongGiangDayDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region KcqChotKhoiLuongGiangDayDataSourceActionList

	/// <summary>
	/// Supports the KcqChotKhoiLuongGiangDayDataSourceDesigner class.
	/// </summary>
	internal class KcqChotKhoiLuongGiangDayDataSourceActionList : DesignerActionList
	{
		private KcqChotKhoiLuongGiangDayDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the KcqChotKhoiLuongGiangDayDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public KcqChotKhoiLuongGiangDayDataSourceActionList(KcqChotKhoiLuongGiangDayDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public KcqChotKhoiLuongGiangDaySelectMethod SelectMethod
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

	#endregion KcqChotKhoiLuongGiangDayDataSourceActionList
	
	#endregion KcqChotKhoiLuongGiangDayDataSourceDesigner
	
	#region KcqChotKhoiLuongGiangDaySelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the KcqChotKhoiLuongGiangDayDataSource.SelectMethod property.
	/// </summary>
	public enum KcqChotKhoiLuongGiangDaySelectMethod
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
		GetById
	}
	
	#endregion KcqChotKhoiLuongGiangDaySelectMethod

	#region KcqChotKhoiLuongGiangDayFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="KcqChotKhoiLuongGiangDay"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KcqChotKhoiLuongGiangDayFilter : SqlFilter<KcqChotKhoiLuongGiangDayColumn>
	{
	}
	
	#endregion KcqChotKhoiLuongGiangDayFilter

	#region KcqChotKhoiLuongGiangDayExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="KcqChotKhoiLuongGiangDay"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KcqChotKhoiLuongGiangDayExpressionBuilder : SqlExpressionBuilder<KcqChotKhoiLuongGiangDayColumn>
	{
	}
	
	#endregion KcqChotKhoiLuongGiangDayExpressionBuilder	

	#region KcqChotKhoiLuongGiangDayProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;KcqChotKhoiLuongGiangDayChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="KcqChotKhoiLuongGiangDay"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KcqChotKhoiLuongGiangDayProperty : ChildEntityProperty<KcqChotKhoiLuongGiangDayChildEntityTypes>
	{
	}
	
	#endregion KcqChotKhoiLuongGiangDayProperty
}

