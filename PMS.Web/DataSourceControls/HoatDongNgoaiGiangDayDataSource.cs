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
	/// Represents the DataRepository.HoatDongNgoaiGiangDayProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(HoatDongNgoaiGiangDayDataSourceDesigner))]
	public class HoatDongNgoaiGiangDayDataSource : ProviderDataSource<HoatDongNgoaiGiangDay, HoatDongNgoaiGiangDayKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the HoatDongNgoaiGiangDayDataSource class.
		/// </summary>
		public HoatDongNgoaiGiangDayDataSource() : base(new HoatDongNgoaiGiangDayService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the HoatDongNgoaiGiangDayDataSourceView used by the HoatDongNgoaiGiangDayDataSource.
		/// </summary>
		protected HoatDongNgoaiGiangDayDataSourceView HoatDongNgoaiGiangDayView
		{
			get { return ( View as HoatDongNgoaiGiangDayDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the HoatDongNgoaiGiangDayDataSource control invokes to retrieve data.
		/// </summary>
		public HoatDongNgoaiGiangDaySelectMethod SelectMethod
		{
			get
			{
				HoatDongNgoaiGiangDaySelectMethod selectMethod = HoatDongNgoaiGiangDaySelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (HoatDongNgoaiGiangDaySelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the HoatDongNgoaiGiangDayDataSourceView class that is to be
		/// used by the HoatDongNgoaiGiangDayDataSource.
		/// </summary>
		/// <returns>An instance of the HoatDongNgoaiGiangDayDataSourceView class.</returns>
		protected override BaseDataSourceView<HoatDongNgoaiGiangDay, HoatDongNgoaiGiangDayKey> GetNewDataSourceView()
		{
			return new HoatDongNgoaiGiangDayDataSourceView(this, DefaultViewName);
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
	/// Supports the HoatDongNgoaiGiangDayDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class HoatDongNgoaiGiangDayDataSourceView : ProviderDataSourceView<HoatDongNgoaiGiangDay, HoatDongNgoaiGiangDayKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the HoatDongNgoaiGiangDayDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the HoatDongNgoaiGiangDayDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public HoatDongNgoaiGiangDayDataSourceView(HoatDongNgoaiGiangDayDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal HoatDongNgoaiGiangDayDataSource HoatDongNgoaiGiangDayOwner
		{
			get { return Owner as HoatDongNgoaiGiangDayDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal HoatDongNgoaiGiangDaySelectMethod SelectMethod
		{
			get { return HoatDongNgoaiGiangDayOwner.SelectMethod; }
			set { HoatDongNgoaiGiangDayOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal HoatDongNgoaiGiangDayService HoatDongNgoaiGiangDayProvider
		{
			get { return Provider as HoatDongNgoaiGiangDayService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<HoatDongNgoaiGiangDay> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<HoatDongNgoaiGiangDay> results = null;
			HoatDongNgoaiGiangDay item;
			count = 0;
			
			System.Int32 _maQuanLy;
			System.String _maNhom_nullable;

			switch ( SelectMethod )
			{
				case HoatDongNgoaiGiangDaySelectMethod.Get:
					HoatDongNgoaiGiangDayKey entityKey  = new HoatDongNgoaiGiangDayKey();
					entityKey.Load(values);
					item = HoatDongNgoaiGiangDayProvider.Get(entityKey);
					results = new TList<HoatDongNgoaiGiangDay>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case HoatDongNgoaiGiangDaySelectMethod.GetAll:
                    results = HoatDongNgoaiGiangDayProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case HoatDongNgoaiGiangDaySelectMethod.GetPaged:
					results = HoatDongNgoaiGiangDayProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case HoatDongNgoaiGiangDaySelectMethod.Find:
					if ( FilterParameters != null )
						results = HoatDongNgoaiGiangDayProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = HoatDongNgoaiGiangDayProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case HoatDongNgoaiGiangDaySelectMethod.GetByMaQuanLy:
					_maQuanLy = ( values["MaQuanLy"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["MaQuanLy"], typeof(System.Int32)) : (int)0;
					item = HoatDongNgoaiGiangDayProvider.GetByMaQuanLy(_maQuanLy);
					results = new TList<HoatDongNgoaiGiangDay>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				// IX
				// FK
				case HoatDongNgoaiGiangDaySelectMethod.GetByMaNhom:
					_maNhom_nullable = (System.String) EntityUtil.ChangeType(values["MaNhom"], typeof(System.String));
					results = HoatDongNgoaiGiangDayProvider.GetByMaNhom(_maNhom_nullable, this.StartIndex, this.PageSize, out count);
					break;
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
			if ( SelectMethod == HoatDongNgoaiGiangDaySelectMethod.Get || SelectMethod == HoatDongNgoaiGiangDaySelectMethod.GetByMaQuanLy )
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
				HoatDongNgoaiGiangDay entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					HoatDongNgoaiGiangDayProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<HoatDongNgoaiGiangDay> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			HoatDongNgoaiGiangDayProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region HoatDongNgoaiGiangDayDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the HoatDongNgoaiGiangDayDataSource class.
	/// </summary>
	public class HoatDongNgoaiGiangDayDataSourceDesigner : ProviderDataSourceDesigner<HoatDongNgoaiGiangDay, HoatDongNgoaiGiangDayKey>
	{
		/// <summary>
		/// Initializes a new instance of the HoatDongNgoaiGiangDayDataSourceDesigner class.
		/// </summary>
		public HoatDongNgoaiGiangDayDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public HoatDongNgoaiGiangDaySelectMethod SelectMethod
		{
			get { return ((HoatDongNgoaiGiangDayDataSource) DataSource).SelectMethod; }
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
				actions.Add(new HoatDongNgoaiGiangDayDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region HoatDongNgoaiGiangDayDataSourceActionList

	/// <summary>
	/// Supports the HoatDongNgoaiGiangDayDataSourceDesigner class.
	/// </summary>
	internal class HoatDongNgoaiGiangDayDataSourceActionList : DesignerActionList
	{
		private HoatDongNgoaiGiangDayDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the HoatDongNgoaiGiangDayDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public HoatDongNgoaiGiangDayDataSourceActionList(HoatDongNgoaiGiangDayDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public HoatDongNgoaiGiangDaySelectMethod SelectMethod
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

	#endregion HoatDongNgoaiGiangDayDataSourceActionList
	
	#endregion HoatDongNgoaiGiangDayDataSourceDesigner
	
	#region HoatDongNgoaiGiangDaySelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the HoatDongNgoaiGiangDayDataSource.SelectMethod property.
	/// </summary>
	public enum HoatDongNgoaiGiangDaySelectMethod
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
		/// Represents the GetByMaQuanLy method.
		/// </summary>
		GetByMaQuanLy,
		/// <summary>
		/// Represents the GetByMaNhom method.
		/// </summary>
		GetByMaNhom
	}
	
	#endregion HoatDongNgoaiGiangDaySelectMethod

	#region HoatDongNgoaiGiangDayFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="HoatDongNgoaiGiangDay"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class HoatDongNgoaiGiangDayFilter : SqlFilter<HoatDongNgoaiGiangDayColumn>
	{
	}
	
	#endregion HoatDongNgoaiGiangDayFilter

	#region HoatDongNgoaiGiangDayExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="HoatDongNgoaiGiangDay"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class HoatDongNgoaiGiangDayExpressionBuilder : SqlExpressionBuilder<HoatDongNgoaiGiangDayColumn>
	{
	}
	
	#endregion HoatDongNgoaiGiangDayExpressionBuilder	

	#region HoatDongNgoaiGiangDayProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;HoatDongNgoaiGiangDayChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="HoatDongNgoaiGiangDay"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class HoatDongNgoaiGiangDayProperty : ChildEntityProperty<HoatDongNgoaiGiangDayChildEntityTypes>
	{
	}
	
	#endregion HoatDongNgoaiGiangDayProperty
}

