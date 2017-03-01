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
	/// Represents the DataRepository.HeSoNgayProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(HeSoNgayDataSourceDesigner))]
	public class HeSoNgayDataSource : ProviderDataSource<HeSoNgay, HeSoNgayKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the HeSoNgayDataSource class.
		/// </summary>
		public HeSoNgayDataSource() : base(new HeSoNgayService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the HeSoNgayDataSourceView used by the HeSoNgayDataSource.
		/// </summary>
		protected HeSoNgayDataSourceView HeSoNgayView
		{
			get { return ( View as HeSoNgayDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the HeSoNgayDataSource control invokes to retrieve data.
		/// </summary>
		public HeSoNgaySelectMethod SelectMethod
		{
			get
			{
				HeSoNgaySelectMethod selectMethod = HeSoNgaySelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (HeSoNgaySelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the HeSoNgayDataSourceView class that is to be
		/// used by the HeSoNgayDataSource.
		/// </summary>
		/// <returns>An instance of the HeSoNgayDataSourceView class.</returns>
		protected override BaseDataSourceView<HeSoNgay, HeSoNgayKey> GetNewDataSourceView()
		{
			return new HeSoNgayDataSourceView(this, DefaultViewName);
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
	/// Supports the HeSoNgayDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class HeSoNgayDataSourceView : ProviderDataSourceView<HeSoNgay, HeSoNgayKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the HeSoNgayDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the HeSoNgayDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public HeSoNgayDataSourceView(HeSoNgayDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal HeSoNgayDataSource HeSoNgayOwner
		{
			get { return Owner as HeSoNgayDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal HeSoNgaySelectMethod SelectMethod
		{
			get { return HeSoNgayOwner.SelectMethod; }
			set { HeSoNgayOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal HeSoNgayService HeSoNgayProvider
		{
			get { return Provider as HeSoNgayService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<HeSoNgay> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<HeSoNgay> results = null;
			HeSoNgay item;
			count = 0;
			
			System.String _maQuanLy;
			System.String _maBuoi_nullable;
			System.Int32 _maHeSo;
			System.String sp2396_MaQuanLy;

			switch ( SelectMethod )
			{
				case HeSoNgaySelectMethod.Get:
					HeSoNgayKey entityKey  = new HeSoNgayKey();
					entityKey.Load(values);
					item = HeSoNgayProvider.Get(entityKey);
					results = new TList<HeSoNgay>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case HeSoNgaySelectMethod.GetAll:
                    results = HeSoNgayProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case HeSoNgaySelectMethod.GetPaged:
					results = HeSoNgayProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case HeSoNgaySelectMethod.Find:
					if ( FilterParameters != null )
						results = HeSoNgayProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = HeSoNgayProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case HeSoNgaySelectMethod.GetByMaHeSo:
					_maHeSo = ( values["MaHeSo"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["MaHeSo"], typeof(System.Int32)) : (int)0;
					item = HeSoNgayProvider.GetByMaHeSo(_maHeSo);
					results = new TList<HeSoNgay>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				// IX
				case HeSoNgaySelectMethod.GetByMaQuanLyMaBuoi:
					_maQuanLy = ( values["MaQuanLy"] != null ) ? (System.String) EntityUtil.ChangeType(values["MaQuanLy"], typeof(System.String)) : string.Empty;
					_maBuoi_nullable = (System.String) EntityUtil.ChangeType(values["MaBuoi"], typeof(System.String));
					item = HeSoNgayProvider.GetByMaQuanLyMaBuoi(_maQuanLy, _maBuoi_nullable);
					results = new TList<HeSoNgay>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				// FK
				// M:M
				// Custom
				case HeSoNgaySelectMethod.GetByMaQuanLy:
					sp2396_MaQuanLy = (System.String) EntityUtil.ChangeType(values["MaQuanLy"], typeof(System.String));
					results = HeSoNgayProvider.GetByMaQuanLy(sp2396_MaQuanLy, StartIndex, PageSize);
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
			if ( SelectMethod == HeSoNgaySelectMethod.Get || SelectMethod == HeSoNgaySelectMethod.GetByMaHeSo )
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
				HeSoNgay entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					HeSoNgayProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<HeSoNgay> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			HeSoNgayProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region HeSoNgayDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the HeSoNgayDataSource class.
	/// </summary>
	public class HeSoNgayDataSourceDesigner : ProviderDataSourceDesigner<HeSoNgay, HeSoNgayKey>
	{
		/// <summary>
		/// Initializes a new instance of the HeSoNgayDataSourceDesigner class.
		/// </summary>
		public HeSoNgayDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public HeSoNgaySelectMethod SelectMethod
		{
			get { return ((HeSoNgayDataSource) DataSource).SelectMethod; }
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
				actions.Add(new HeSoNgayDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region HeSoNgayDataSourceActionList

	/// <summary>
	/// Supports the HeSoNgayDataSourceDesigner class.
	/// </summary>
	internal class HeSoNgayDataSourceActionList : DesignerActionList
	{
		private HeSoNgayDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the HeSoNgayDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public HeSoNgayDataSourceActionList(HeSoNgayDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public HeSoNgaySelectMethod SelectMethod
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

	#endregion HeSoNgayDataSourceActionList
	
	#endregion HeSoNgayDataSourceDesigner
	
	#region HeSoNgaySelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the HeSoNgayDataSource.SelectMethod property.
	/// </summary>
	public enum HeSoNgaySelectMethod
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
		/// Represents the GetByMaQuanLyMaBuoi method.
		/// </summary>
		GetByMaQuanLyMaBuoi,
		/// <summary>
		/// Represents the GetByMaHeSo method.
		/// </summary>
		GetByMaHeSo,
		/// <summary>
		/// Represents the GetByMaQuanLy method.
		/// </summary>
		GetByMaQuanLy
	}
	
	#endregion HeSoNgaySelectMethod

	#region HeSoNgayFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="HeSoNgay"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class HeSoNgayFilter : SqlFilter<HeSoNgayColumn>
	{
	}
	
	#endregion HeSoNgayFilter

	#region HeSoNgayExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="HeSoNgay"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class HeSoNgayExpressionBuilder : SqlExpressionBuilder<HeSoNgayColumn>
	{
	}
	
	#endregion HeSoNgayExpressionBuilder	

	#region HeSoNgayProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;HeSoNgayChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="HeSoNgay"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class HeSoNgayProperty : ChildEntityProperty<HeSoNgayChildEntityTypes>
	{
	}
	
	#endregion HeSoNgayProperty
}

