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
	/// Represents the DataRepository.HoatDongNgoaiGiangDayClcProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(HoatDongNgoaiGiangDayClcDataSourceDesigner))]
	public class HoatDongNgoaiGiangDayClcDataSource : ProviderDataSource<HoatDongNgoaiGiangDayClc, HoatDongNgoaiGiangDayClcKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the HoatDongNgoaiGiangDayClcDataSource class.
		/// </summary>
		public HoatDongNgoaiGiangDayClcDataSource() : base(new HoatDongNgoaiGiangDayClcService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the HoatDongNgoaiGiangDayClcDataSourceView used by the HoatDongNgoaiGiangDayClcDataSource.
		/// </summary>
		protected HoatDongNgoaiGiangDayClcDataSourceView HoatDongNgoaiGiangDayClcView
		{
			get { return ( View as HoatDongNgoaiGiangDayClcDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the HoatDongNgoaiGiangDayClcDataSource control invokes to retrieve data.
		/// </summary>
		public HoatDongNgoaiGiangDayClcSelectMethod SelectMethod
		{
			get
			{
				HoatDongNgoaiGiangDayClcSelectMethod selectMethod = HoatDongNgoaiGiangDayClcSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (HoatDongNgoaiGiangDayClcSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the HoatDongNgoaiGiangDayClcDataSourceView class that is to be
		/// used by the HoatDongNgoaiGiangDayClcDataSource.
		/// </summary>
		/// <returns>An instance of the HoatDongNgoaiGiangDayClcDataSourceView class.</returns>
		protected override BaseDataSourceView<HoatDongNgoaiGiangDayClc, HoatDongNgoaiGiangDayClcKey> GetNewDataSourceView()
		{
			return new HoatDongNgoaiGiangDayClcDataSourceView(this, DefaultViewName);
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
	/// Supports the HoatDongNgoaiGiangDayClcDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class HoatDongNgoaiGiangDayClcDataSourceView : ProviderDataSourceView<HoatDongNgoaiGiangDayClc, HoatDongNgoaiGiangDayClcKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the HoatDongNgoaiGiangDayClcDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the HoatDongNgoaiGiangDayClcDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public HoatDongNgoaiGiangDayClcDataSourceView(HoatDongNgoaiGiangDayClcDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal HoatDongNgoaiGiangDayClcDataSource HoatDongNgoaiGiangDayClcOwner
		{
			get { return Owner as HoatDongNgoaiGiangDayClcDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal HoatDongNgoaiGiangDayClcSelectMethod SelectMethod
		{
			get { return HoatDongNgoaiGiangDayClcOwner.SelectMethod; }
			set { HoatDongNgoaiGiangDayClcOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal HoatDongNgoaiGiangDayClcService HoatDongNgoaiGiangDayClcProvider
		{
			get { return Provider as HoatDongNgoaiGiangDayClcService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<HoatDongNgoaiGiangDayClc> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<HoatDongNgoaiGiangDayClc> results = null;
			HoatDongNgoaiGiangDayClc item;
			count = 0;
			
			System.Int32 _id;

			switch ( SelectMethod )
			{
				case HoatDongNgoaiGiangDayClcSelectMethod.Get:
					HoatDongNgoaiGiangDayClcKey entityKey  = new HoatDongNgoaiGiangDayClcKey();
					entityKey.Load(values);
					item = HoatDongNgoaiGiangDayClcProvider.Get(entityKey);
					results = new TList<HoatDongNgoaiGiangDayClc>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case HoatDongNgoaiGiangDayClcSelectMethod.GetAll:
                    results = HoatDongNgoaiGiangDayClcProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case HoatDongNgoaiGiangDayClcSelectMethod.GetPaged:
					results = HoatDongNgoaiGiangDayClcProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case HoatDongNgoaiGiangDayClcSelectMethod.Find:
					if ( FilterParameters != null )
						results = HoatDongNgoaiGiangDayClcProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = HoatDongNgoaiGiangDayClcProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case HoatDongNgoaiGiangDayClcSelectMethod.GetById:
					_id = ( values["Id"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["Id"], typeof(System.Int32)) : (int)0;
					item = HoatDongNgoaiGiangDayClcProvider.GetById(_id);
					results = new TList<HoatDongNgoaiGiangDayClc>();
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
			if ( SelectMethod == HoatDongNgoaiGiangDayClcSelectMethod.Get || SelectMethod == HoatDongNgoaiGiangDayClcSelectMethod.GetById )
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
				HoatDongNgoaiGiangDayClc entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					HoatDongNgoaiGiangDayClcProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<HoatDongNgoaiGiangDayClc> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			HoatDongNgoaiGiangDayClcProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region HoatDongNgoaiGiangDayClcDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the HoatDongNgoaiGiangDayClcDataSource class.
	/// </summary>
	public class HoatDongNgoaiGiangDayClcDataSourceDesigner : ProviderDataSourceDesigner<HoatDongNgoaiGiangDayClc, HoatDongNgoaiGiangDayClcKey>
	{
		/// <summary>
		/// Initializes a new instance of the HoatDongNgoaiGiangDayClcDataSourceDesigner class.
		/// </summary>
		public HoatDongNgoaiGiangDayClcDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public HoatDongNgoaiGiangDayClcSelectMethod SelectMethod
		{
			get { return ((HoatDongNgoaiGiangDayClcDataSource) DataSource).SelectMethod; }
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
				actions.Add(new HoatDongNgoaiGiangDayClcDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region HoatDongNgoaiGiangDayClcDataSourceActionList

	/// <summary>
	/// Supports the HoatDongNgoaiGiangDayClcDataSourceDesigner class.
	/// </summary>
	internal class HoatDongNgoaiGiangDayClcDataSourceActionList : DesignerActionList
	{
		private HoatDongNgoaiGiangDayClcDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the HoatDongNgoaiGiangDayClcDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public HoatDongNgoaiGiangDayClcDataSourceActionList(HoatDongNgoaiGiangDayClcDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public HoatDongNgoaiGiangDayClcSelectMethod SelectMethod
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

	#endregion HoatDongNgoaiGiangDayClcDataSourceActionList
	
	#endregion HoatDongNgoaiGiangDayClcDataSourceDesigner
	
	#region HoatDongNgoaiGiangDayClcSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the HoatDongNgoaiGiangDayClcDataSource.SelectMethod property.
	/// </summary>
	public enum HoatDongNgoaiGiangDayClcSelectMethod
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
	
	#endregion HoatDongNgoaiGiangDayClcSelectMethod

	#region HoatDongNgoaiGiangDayClcFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="HoatDongNgoaiGiangDayClc"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class HoatDongNgoaiGiangDayClcFilter : SqlFilter<HoatDongNgoaiGiangDayClcColumn>
	{
	}
	
	#endregion HoatDongNgoaiGiangDayClcFilter

	#region HoatDongNgoaiGiangDayClcExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="HoatDongNgoaiGiangDayClc"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class HoatDongNgoaiGiangDayClcExpressionBuilder : SqlExpressionBuilder<HoatDongNgoaiGiangDayClcColumn>
	{
	}
	
	#endregion HoatDongNgoaiGiangDayClcExpressionBuilder	

	#region HoatDongNgoaiGiangDayClcProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;HoatDongNgoaiGiangDayClcChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="HoatDongNgoaiGiangDayClc"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class HoatDongNgoaiGiangDayClcProperty : ChildEntityProperty<HoatDongNgoaiGiangDayClcChildEntityTypes>
	{
	}
	
	#endregion HoatDongNgoaiGiangDayClcProperty
}

