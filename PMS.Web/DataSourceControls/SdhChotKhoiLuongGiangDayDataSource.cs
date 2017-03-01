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
	/// Represents the DataRepository.SdhChotKhoiLuongGiangDayProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(SdhChotKhoiLuongGiangDayDataSourceDesigner))]
	public class SdhChotKhoiLuongGiangDayDataSource : ProviderDataSource<SdhChotKhoiLuongGiangDay, SdhChotKhoiLuongGiangDayKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SdhChotKhoiLuongGiangDayDataSource class.
		/// </summary>
		public SdhChotKhoiLuongGiangDayDataSource() : base(new SdhChotKhoiLuongGiangDayService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the SdhChotKhoiLuongGiangDayDataSourceView used by the SdhChotKhoiLuongGiangDayDataSource.
		/// </summary>
		protected SdhChotKhoiLuongGiangDayDataSourceView SdhChotKhoiLuongGiangDayView
		{
			get { return ( View as SdhChotKhoiLuongGiangDayDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the SdhChotKhoiLuongGiangDayDataSource control invokes to retrieve data.
		/// </summary>
		public SdhChotKhoiLuongGiangDaySelectMethod SelectMethod
		{
			get
			{
				SdhChotKhoiLuongGiangDaySelectMethod selectMethod = SdhChotKhoiLuongGiangDaySelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (SdhChotKhoiLuongGiangDaySelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the SdhChotKhoiLuongGiangDayDataSourceView class that is to be
		/// used by the SdhChotKhoiLuongGiangDayDataSource.
		/// </summary>
		/// <returns>An instance of the SdhChotKhoiLuongGiangDayDataSourceView class.</returns>
		protected override BaseDataSourceView<SdhChotKhoiLuongGiangDay, SdhChotKhoiLuongGiangDayKey> GetNewDataSourceView()
		{
			return new SdhChotKhoiLuongGiangDayDataSourceView(this, DefaultViewName);
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
	/// Supports the SdhChotKhoiLuongGiangDayDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class SdhChotKhoiLuongGiangDayDataSourceView : ProviderDataSourceView<SdhChotKhoiLuongGiangDay, SdhChotKhoiLuongGiangDayKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SdhChotKhoiLuongGiangDayDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the SdhChotKhoiLuongGiangDayDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public SdhChotKhoiLuongGiangDayDataSourceView(SdhChotKhoiLuongGiangDayDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal SdhChotKhoiLuongGiangDayDataSource SdhChotKhoiLuongGiangDayOwner
		{
			get { return Owner as SdhChotKhoiLuongGiangDayDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal SdhChotKhoiLuongGiangDaySelectMethod SelectMethod
		{
			get { return SdhChotKhoiLuongGiangDayOwner.SelectMethod; }
			set { SdhChotKhoiLuongGiangDayOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal SdhChotKhoiLuongGiangDayService SdhChotKhoiLuongGiangDayProvider
		{
			get { return Provider as SdhChotKhoiLuongGiangDayService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<SdhChotKhoiLuongGiangDay> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<SdhChotKhoiLuongGiangDay> results = null;
			SdhChotKhoiLuongGiangDay item;
			count = 0;
			
			System.Int32 _id;

			switch ( SelectMethod )
			{
				case SdhChotKhoiLuongGiangDaySelectMethod.Get:
					SdhChotKhoiLuongGiangDayKey entityKey  = new SdhChotKhoiLuongGiangDayKey();
					entityKey.Load(values);
					item = SdhChotKhoiLuongGiangDayProvider.Get(entityKey);
					results = new TList<SdhChotKhoiLuongGiangDay>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case SdhChotKhoiLuongGiangDaySelectMethod.GetAll:
                    results = SdhChotKhoiLuongGiangDayProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case SdhChotKhoiLuongGiangDaySelectMethod.GetPaged:
					results = SdhChotKhoiLuongGiangDayProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case SdhChotKhoiLuongGiangDaySelectMethod.Find:
					if ( FilterParameters != null )
						results = SdhChotKhoiLuongGiangDayProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = SdhChotKhoiLuongGiangDayProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case SdhChotKhoiLuongGiangDaySelectMethod.GetById:
					_id = ( values["Id"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["Id"], typeof(System.Int32)) : (int)0;
					item = SdhChotKhoiLuongGiangDayProvider.GetById(_id);
					results = new TList<SdhChotKhoiLuongGiangDay>();
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
			if ( SelectMethod == SdhChotKhoiLuongGiangDaySelectMethod.Get || SelectMethod == SdhChotKhoiLuongGiangDaySelectMethod.GetById )
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
				SdhChotKhoiLuongGiangDay entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					SdhChotKhoiLuongGiangDayProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<SdhChotKhoiLuongGiangDay> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			SdhChotKhoiLuongGiangDayProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region SdhChotKhoiLuongGiangDayDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the SdhChotKhoiLuongGiangDayDataSource class.
	/// </summary>
	public class SdhChotKhoiLuongGiangDayDataSourceDesigner : ProviderDataSourceDesigner<SdhChotKhoiLuongGiangDay, SdhChotKhoiLuongGiangDayKey>
	{
		/// <summary>
		/// Initializes a new instance of the SdhChotKhoiLuongGiangDayDataSourceDesigner class.
		/// </summary>
		public SdhChotKhoiLuongGiangDayDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public SdhChotKhoiLuongGiangDaySelectMethod SelectMethod
		{
			get { return ((SdhChotKhoiLuongGiangDayDataSource) DataSource).SelectMethod; }
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
				actions.Add(new SdhChotKhoiLuongGiangDayDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region SdhChotKhoiLuongGiangDayDataSourceActionList

	/// <summary>
	/// Supports the SdhChotKhoiLuongGiangDayDataSourceDesigner class.
	/// </summary>
	internal class SdhChotKhoiLuongGiangDayDataSourceActionList : DesignerActionList
	{
		private SdhChotKhoiLuongGiangDayDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the SdhChotKhoiLuongGiangDayDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public SdhChotKhoiLuongGiangDayDataSourceActionList(SdhChotKhoiLuongGiangDayDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public SdhChotKhoiLuongGiangDaySelectMethod SelectMethod
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

	#endregion SdhChotKhoiLuongGiangDayDataSourceActionList
	
	#endregion SdhChotKhoiLuongGiangDayDataSourceDesigner
	
	#region SdhChotKhoiLuongGiangDaySelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the SdhChotKhoiLuongGiangDayDataSource.SelectMethod property.
	/// </summary>
	public enum SdhChotKhoiLuongGiangDaySelectMethod
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
	
	#endregion SdhChotKhoiLuongGiangDaySelectMethod

	#region SdhChotKhoiLuongGiangDayFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SdhChotKhoiLuongGiangDay"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SdhChotKhoiLuongGiangDayFilter : SqlFilter<SdhChotKhoiLuongGiangDayColumn>
	{
	}
	
	#endregion SdhChotKhoiLuongGiangDayFilter

	#region SdhChotKhoiLuongGiangDayExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SdhChotKhoiLuongGiangDay"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SdhChotKhoiLuongGiangDayExpressionBuilder : SqlExpressionBuilder<SdhChotKhoiLuongGiangDayColumn>
	{
	}
	
	#endregion SdhChotKhoiLuongGiangDayExpressionBuilder	

	#region SdhChotKhoiLuongGiangDayProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;SdhChotKhoiLuongGiangDayChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="SdhChotKhoiLuongGiangDay"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SdhChotKhoiLuongGiangDayProperty : ChildEntityProperty<SdhChotKhoiLuongGiangDayChildEntityTypes>
	{
	}
	
	#endregion SdhChotKhoiLuongGiangDayProperty
}

