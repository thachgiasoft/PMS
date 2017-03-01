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
	/// Represents the DataRepository.SdhUteKhoiLuongGiangDayProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(SdhUteKhoiLuongGiangDayDataSourceDesigner))]
	public class SdhUteKhoiLuongGiangDayDataSource : ProviderDataSource<SdhUteKhoiLuongGiangDay, SdhUteKhoiLuongGiangDayKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SdhUteKhoiLuongGiangDayDataSource class.
		/// </summary>
		public SdhUteKhoiLuongGiangDayDataSource() : base(new SdhUteKhoiLuongGiangDayService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the SdhUteKhoiLuongGiangDayDataSourceView used by the SdhUteKhoiLuongGiangDayDataSource.
		/// </summary>
		protected SdhUteKhoiLuongGiangDayDataSourceView SdhUteKhoiLuongGiangDayView
		{
			get { return ( View as SdhUteKhoiLuongGiangDayDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the SdhUteKhoiLuongGiangDayDataSource control invokes to retrieve data.
		/// </summary>
		public SdhUteKhoiLuongGiangDaySelectMethod SelectMethod
		{
			get
			{
				SdhUteKhoiLuongGiangDaySelectMethod selectMethod = SdhUteKhoiLuongGiangDaySelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (SdhUteKhoiLuongGiangDaySelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the SdhUteKhoiLuongGiangDayDataSourceView class that is to be
		/// used by the SdhUteKhoiLuongGiangDayDataSource.
		/// </summary>
		/// <returns>An instance of the SdhUteKhoiLuongGiangDayDataSourceView class.</returns>
		protected override BaseDataSourceView<SdhUteKhoiLuongGiangDay, SdhUteKhoiLuongGiangDayKey> GetNewDataSourceView()
		{
			return new SdhUteKhoiLuongGiangDayDataSourceView(this, DefaultViewName);
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
	/// Supports the SdhUteKhoiLuongGiangDayDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class SdhUteKhoiLuongGiangDayDataSourceView : ProviderDataSourceView<SdhUteKhoiLuongGiangDay, SdhUteKhoiLuongGiangDayKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SdhUteKhoiLuongGiangDayDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the SdhUteKhoiLuongGiangDayDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public SdhUteKhoiLuongGiangDayDataSourceView(SdhUteKhoiLuongGiangDayDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal SdhUteKhoiLuongGiangDayDataSource SdhUteKhoiLuongGiangDayOwner
		{
			get { return Owner as SdhUteKhoiLuongGiangDayDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal SdhUteKhoiLuongGiangDaySelectMethod SelectMethod
		{
			get { return SdhUteKhoiLuongGiangDayOwner.SelectMethod; }
			set { SdhUteKhoiLuongGiangDayOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal SdhUteKhoiLuongGiangDayService SdhUteKhoiLuongGiangDayProvider
		{
			get { return Provider as SdhUteKhoiLuongGiangDayService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<SdhUteKhoiLuongGiangDay> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<SdhUteKhoiLuongGiangDay> results = null;
			SdhUteKhoiLuongGiangDay item;
			count = 0;
			
			System.Int32 _id;

			switch ( SelectMethod )
			{
				case SdhUteKhoiLuongGiangDaySelectMethod.Get:
					SdhUteKhoiLuongGiangDayKey entityKey  = new SdhUteKhoiLuongGiangDayKey();
					entityKey.Load(values);
					item = SdhUteKhoiLuongGiangDayProvider.Get(entityKey);
					results = new TList<SdhUteKhoiLuongGiangDay>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case SdhUteKhoiLuongGiangDaySelectMethod.GetAll:
                    results = SdhUteKhoiLuongGiangDayProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case SdhUteKhoiLuongGiangDaySelectMethod.GetPaged:
					results = SdhUteKhoiLuongGiangDayProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case SdhUteKhoiLuongGiangDaySelectMethod.Find:
					if ( FilterParameters != null )
						results = SdhUteKhoiLuongGiangDayProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = SdhUteKhoiLuongGiangDayProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case SdhUteKhoiLuongGiangDaySelectMethod.GetById:
					_id = ( values["Id"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["Id"], typeof(System.Int32)) : (int)0;
					item = SdhUteKhoiLuongGiangDayProvider.GetById(_id);
					results = new TList<SdhUteKhoiLuongGiangDay>();
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
			if ( SelectMethod == SdhUteKhoiLuongGiangDaySelectMethod.Get || SelectMethod == SdhUteKhoiLuongGiangDaySelectMethod.GetById )
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
				SdhUteKhoiLuongGiangDay entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					SdhUteKhoiLuongGiangDayProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<SdhUteKhoiLuongGiangDay> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			SdhUteKhoiLuongGiangDayProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region SdhUteKhoiLuongGiangDayDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the SdhUteKhoiLuongGiangDayDataSource class.
	/// </summary>
	public class SdhUteKhoiLuongGiangDayDataSourceDesigner : ProviderDataSourceDesigner<SdhUteKhoiLuongGiangDay, SdhUteKhoiLuongGiangDayKey>
	{
		/// <summary>
		/// Initializes a new instance of the SdhUteKhoiLuongGiangDayDataSourceDesigner class.
		/// </summary>
		public SdhUteKhoiLuongGiangDayDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public SdhUteKhoiLuongGiangDaySelectMethod SelectMethod
		{
			get { return ((SdhUteKhoiLuongGiangDayDataSource) DataSource).SelectMethod; }
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
				actions.Add(new SdhUteKhoiLuongGiangDayDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region SdhUteKhoiLuongGiangDayDataSourceActionList

	/// <summary>
	/// Supports the SdhUteKhoiLuongGiangDayDataSourceDesigner class.
	/// </summary>
	internal class SdhUteKhoiLuongGiangDayDataSourceActionList : DesignerActionList
	{
		private SdhUteKhoiLuongGiangDayDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the SdhUteKhoiLuongGiangDayDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public SdhUteKhoiLuongGiangDayDataSourceActionList(SdhUteKhoiLuongGiangDayDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public SdhUteKhoiLuongGiangDaySelectMethod SelectMethod
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

	#endregion SdhUteKhoiLuongGiangDayDataSourceActionList
	
	#endregion SdhUteKhoiLuongGiangDayDataSourceDesigner
	
	#region SdhUteKhoiLuongGiangDaySelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the SdhUteKhoiLuongGiangDayDataSource.SelectMethod property.
	/// </summary>
	public enum SdhUteKhoiLuongGiangDaySelectMethod
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
	
	#endregion SdhUteKhoiLuongGiangDaySelectMethod

	#region SdhUteKhoiLuongGiangDayFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SdhUteKhoiLuongGiangDay"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SdhUteKhoiLuongGiangDayFilter : SqlFilter<SdhUteKhoiLuongGiangDayColumn>
	{
	}
	
	#endregion SdhUteKhoiLuongGiangDayFilter

	#region SdhUteKhoiLuongGiangDayExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SdhUteKhoiLuongGiangDay"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SdhUteKhoiLuongGiangDayExpressionBuilder : SqlExpressionBuilder<SdhUteKhoiLuongGiangDayColumn>
	{
	}
	
	#endregion SdhUteKhoiLuongGiangDayExpressionBuilder	

	#region SdhUteKhoiLuongGiangDayProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;SdhUteKhoiLuongGiangDayChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="SdhUteKhoiLuongGiangDay"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SdhUteKhoiLuongGiangDayProperty : ChildEntityProperty<SdhUteKhoiLuongGiangDayChildEntityTypes>
	{
	}
	
	#endregion SdhUteKhoiLuongGiangDayProperty
}

