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
	/// Represents the DataRepository.UteKhoiLuongGiangDayProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(UteKhoiLuongGiangDayDataSourceDesigner))]
	public class UteKhoiLuongGiangDayDataSource : ProviderDataSource<UteKhoiLuongGiangDay, UteKhoiLuongGiangDayKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the UteKhoiLuongGiangDayDataSource class.
		/// </summary>
		public UteKhoiLuongGiangDayDataSource() : base(new UteKhoiLuongGiangDayService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the UteKhoiLuongGiangDayDataSourceView used by the UteKhoiLuongGiangDayDataSource.
		/// </summary>
		protected UteKhoiLuongGiangDayDataSourceView UteKhoiLuongGiangDayView
		{
			get { return ( View as UteKhoiLuongGiangDayDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the UteKhoiLuongGiangDayDataSource control invokes to retrieve data.
		/// </summary>
		public UteKhoiLuongGiangDaySelectMethod SelectMethod
		{
			get
			{
				UteKhoiLuongGiangDaySelectMethod selectMethod = UteKhoiLuongGiangDaySelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (UteKhoiLuongGiangDaySelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the UteKhoiLuongGiangDayDataSourceView class that is to be
		/// used by the UteKhoiLuongGiangDayDataSource.
		/// </summary>
		/// <returns>An instance of the UteKhoiLuongGiangDayDataSourceView class.</returns>
		protected override BaseDataSourceView<UteKhoiLuongGiangDay, UteKhoiLuongGiangDayKey> GetNewDataSourceView()
		{
			return new UteKhoiLuongGiangDayDataSourceView(this, DefaultViewName);
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
	/// Supports the UteKhoiLuongGiangDayDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class UteKhoiLuongGiangDayDataSourceView : ProviderDataSourceView<UteKhoiLuongGiangDay, UteKhoiLuongGiangDayKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the UteKhoiLuongGiangDayDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the UteKhoiLuongGiangDayDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public UteKhoiLuongGiangDayDataSourceView(UteKhoiLuongGiangDayDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal UteKhoiLuongGiangDayDataSource UteKhoiLuongGiangDayOwner
		{
			get { return Owner as UteKhoiLuongGiangDayDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal UteKhoiLuongGiangDaySelectMethod SelectMethod
		{
			get { return UteKhoiLuongGiangDayOwner.SelectMethod; }
			set { UteKhoiLuongGiangDayOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal UteKhoiLuongGiangDayService UteKhoiLuongGiangDayProvider
		{
			get { return Provider as UteKhoiLuongGiangDayService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<UteKhoiLuongGiangDay> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<UteKhoiLuongGiangDay> results = null;
			UteKhoiLuongGiangDay item;
			count = 0;
			
			System.Int32 _id;

			switch ( SelectMethod )
			{
				case UteKhoiLuongGiangDaySelectMethod.Get:
					UteKhoiLuongGiangDayKey entityKey  = new UteKhoiLuongGiangDayKey();
					entityKey.Load(values);
					item = UteKhoiLuongGiangDayProvider.Get(entityKey);
					results = new TList<UteKhoiLuongGiangDay>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case UteKhoiLuongGiangDaySelectMethod.GetAll:
                    results = UteKhoiLuongGiangDayProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case UteKhoiLuongGiangDaySelectMethod.GetPaged:
					results = UteKhoiLuongGiangDayProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case UteKhoiLuongGiangDaySelectMethod.Find:
					if ( FilterParameters != null )
						results = UteKhoiLuongGiangDayProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = UteKhoiLuongGiangDayProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case UteKhoiLuongGiangDaySelectMethod.GetById:
					_id = ( values["Id"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["Id"], typeof(System.Int32)) : (int)0;
					item = UteKhoiLuongGiangDayProvider.GetById(_id);
					results = new TList<UteKhoiLuongGiangDay>();
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
			if ( SelectMethod == UteKhoiLuongGiangDaySelectMethod.Get || SelectMethod == UteKhoiLuongGiangDaySelectMethod.GetById )
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
				UteKhoiLuongGiangDay entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					UteKhoiLuongGiangDayProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<UteKhoiLuongGiangDay> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			UteKhoiLuongGiangDayProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region UteKhoiLuongGiangDayDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the UteKhoiLuongGiangDayDataSource class.
	/// </summary>
	public class UteKhoiLuongGiangDayDataSourceDesigner : ProviderDataSourceDesigner<UteKhoiLuongGiangDay, UteKhoiLuongGiangDayKey>
	{
		/// <summary>
		/// Initializes a new instance of the UteKhoiLuongGiangDayDataSourceDesigner class.
		/// </summary>
		public UteKhoiLuongGiangDayDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public UteKhoiLuongGiangDaySelectMethod SelectMethod
		{
			get { return ((UteKhoiLuongGiangDayDataSource) DataSource).SelectMethod; }
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
				actions.Add(new UteKhoiLuongGiangDayDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region UteKhoiLuongGiangDayDataSourceActionList

	/// <summary>
	/// Supports the UteKhoiLuongGiangDayDataSourceDesigner class.
	/// </summary>
	internal class UteKhoiLuongGiangDayDataSourceActionList : DesignerActionList
	{
		private UteKhoiLuongGiangDayDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the UteKhoiLuongGiangDayDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public UteKhoiLuongGiangDayDataSourceActionList(UteKhoiLuongGiangDayDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public UteKhoiLuongGiangDaySelectMethod SelectMethod
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

	#endregion UteKhoiLuongGiangDayDataSourceActionList
	
	#endregion UteKhoiLuongGiangDayDataSourceDesigner
	
	#region UteKhoiLuongGiangDaySelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the UteKhoiLuongGiangDayDataSource.SelectMethod property.
	/// </summary>
	public enum UteKhoiLuongGiangDaySelectMethod
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
	
	#endregion UteKhoiLuongGiangDaySelectMethod

	#region UteKhoiLuongGiangDayFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="UteKhoiLuongGiangDay"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class UteKhoiLuongGiangDayFilter : SqlFilter<UteKhoiLuongGiangDayColumn>
	{
	}
	
	#endregion UteKhoiLuongGiangDayFilter

	#region UteKhoiLuongGiangDayExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="UteKhoiLuongGiangDay"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class UteKhoiLuongGiangDayExpressionBuilder : SqlExpressionBuilder<UteKhoiLuongGiangDayColumn>
	{
	}
	
	#endregion UteKhoiLuongGiangDayExpressionBuilder	

	#region UteKhoiLuongGiangDayProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;UteKhoiLuongGiangDayChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="UteKhoiLuongGiangDay"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class UteKhoiLuongGiangDayProperty : ChildEntityProperty<UteKhoiLuongGiangDayChildEntityTypes>
	{
	}
	
	#endregion UteKhoiLuongGiangDayProperty
}

