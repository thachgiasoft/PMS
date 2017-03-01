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
	/// Represents the DataRepository.ThanhTraGiangDayProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(ThanhTraGiangDayDataSourceDesigner))]
	public class ThanhTraGiangDayDataSource : ProviderDataSource<ThanhTraGiangDay, ThanhTraGiangDayKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ThanhTraGiangDayDataSource class.
		/// </summary>
		public ThanhTraGiangDayDataSource() : base(new ThanhTraGiangDayService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the ThanhTraGiangDayDataSourceView used by the ThanhTraGiangDayDataSource.
		/// </summary>
		protected ThanhTraGiangDayDataSourceView ThanhTraGiangDayView
		{
			get { return ( View as ThanhTraGiangDayDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the ThanhTraGiangDayDataSource control invokes to retrieve data.
		/// </summary>
		public ThanhTraGiangDaySelectMethod SelectMethod
		{
			get
			{
				ThanhTraGiangDaySelectMethod selectMethod = ThanhTraGiangDaySelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (ThanhTraGiangDaySelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the ThanhTraGiangDayDataSourceView class that is to be
		/// used by the ThanhTraGiangDayDataSource.
		/// </summary>
		/// <returns>An instance of the ThanhTraGiangDayDataSourceView class.</returns>
		protected override BaseDataSourceView<ThanhTraGiangDay, ThanhTraGiangDayKey> GetNewDataSourceView()
		{
			return new ThanhTraGiangDayDataSourceView(this, DefaultViewName);
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
	/// Supports the ThanhTraGiangDayDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class ThanhTraGiangDayDataSourceView : ProviderDataSourceView<ThanhTraGiangDay, ThanhTraGiangDayKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ThanhTraGiangDayDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the ThanhTraGiangDayDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public ThanhTraGiangDayDataSourceView(ThanhTraGiangDayDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal ThanhTraGiangDayDataSource ThanhTraGiangDayOwner
		{
			get { return Owner as ThanhTraGiangDayDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal ThanhTraGiangDaySelectMethod SelectMethod
		{
			get { return ThanhTraGiangDayOwner.SelectMethod; }
			set { ThanhTraGiangDayOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal ThanhTraGiangDayService ThanhTraGiangDayProvider
		{
			get { return Provider as ThanhTraGiangDayService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<ThanhTraGiangDay> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<ThanhTraGiangDay> results = null;
			ThanhTraGiangDay item;
			count = 0;
			
			System.Int32 _maHoSoThanhTra;
			System.DateTime sp2862_TuNgay;
			System.DateTime sp2862_DenNgay;
			System.DateTime sp2863_TuNgay;
			System.DateTime sp2863_DenNgay;
			System.String sp2863_MaBoMon;

			switch ( SelectMethod )
			{
				case ThanhTraGiangDaySelectMethod.Get:
					ThanhTraGiangDayKey entityKey  = new ThanhTraGiangDayKey();
					entityKey.Load(values);
					item = ThanhTraGiangDayProvider.Get(entityKey);
					results = new TList<ThanhTraGiangDay>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case ThanhTraGiangDaySelectMethod.GetAll:
                    results = ThanhTraGiangDayProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case ThanhTraGiangDaySelectMethod.GetPaged:
					results = ThanhTraGiangDayProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case ThanhTraGiangDaySelectMethod.Find:
					if ( FilterParameters != null )
						results = ThanhTraGiangDayProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = ThanhTraGiangDayProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case ThanhTraGiangDaySelectMethod.GetByMaHoSoThanhTra:
					_maHoSoThanhTra = ( values["MaHoSoThanhTra"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["MaHoSoThanhTra"], typeof(System.Int32)) : (int)0;
					item = ThanhTraGiangDayProvider.GetByMaHoSoThanhTra(_maHoSoThanhTra);
					results = new TList<ThanhTraGiangDay>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				// IX
				// FK
				// M:M
				// Custom
				case ThanhTraGiangDaySelectMethod.GetByTuNgayDenNgay:
					sp2862_TuNgay = (System.DateTime) EntityUtil.ChangeType(values["TuNgay"], typeof(System.DateTime));
					sp2862_DenNgay = (System.DateTime) EntityUtil.ChangeType(values["DenNgay"], typeof(System.DateTime));
					results = ThanhTraGiangDayProvider.GetByTuNgayDenNgay(sp2862_TuNgay, sp2862_DenNgay, StartIndex, PageSize);
					break;
				case ThanhTraGiangDaySelectMethod.GetByTuNgayDenNgayMaDonVi:
					sp2863_TuNgay = (System.DateTime) EntityUtil.ChangeType(values["TuNgay"], typeof(System.DateTime));
					sp2863_DenNgay = (System.DateTime) EntityUtil.ChangeType(values["DenNgay"], typeof(System.DateTime));
					sp2863_MaBoMon = (System.String) EntityUtil.ChangeType(values["MaBoMon"], typeof(System.String));
					results = ThanhTraGiangDayProvider.GetByTuNgayDenNgayMaDonVi(sp2863_TuNgay, sp2863_DenNgay, sp2863_MaBoMon, StartIndex, PageSize);
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
			if ( SelectMethod == ThanhTraGiangDaySelectMethod.Get || SelectMethod == ThanhTraGiangDaySelectMethod.GetByMaHoSoThanhTra )
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
				ThanhTraGiangDay entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					ThanhTraGiangDayProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<ThanhTraGiangDay> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			ThanhTraGiangDayProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region ThanhTraGiangDayDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the ThanhTraGiangDayDataSource class.
	/// </summary>
	public class ThanhTraGiangDayDataSourceDesigner : ProviderDataSourceDesigner<ThanhTraGiangDay, ThanhTraGiangDayKey>
	{
		/// <summary>
		/// Initializes a new instance of the ThanhTraGiangDayDataSourceDesigner class.
		/// </summary>
		public ThanhTraGiangDayDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public ThanhTraGiangDaySelectMethod SelectMethod
		{
			get { return ((ThanhTraGiangDayDataSource) DataSource).SelectMethod; }
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
				actions.Add(new ThanhTraGiangDayDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region ThanhTraGiangDayDataSourceActionList

	/// <summary>
	/// Supports the ThanhTraGiangDayDataSourceDesigner class.
	/// </summary>
	internal class ThanhTraGiangDayDataSourceActionList : DesignerActionList
	{
		private ThanhTraGiangDayDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the ThanhTraGiangDayDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public ThanhTraGiangDayDataSourceActionList(ThanhTraGiangDayDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public ThanhTraGiangDaySelectMethod SelectMethod
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

	#endregion ThanhTraGiangDayDataSourceActionList
	
	#endregion ThanhTraGiangDayDataSourceDesigner
	
	#region ThanhTraGiangDaySelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the ThanhTraGiangDayDataSource.SelectMethod property.
	/// </summary>
	public enum ThanhTraGiangDaySelectMethod
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
		/// Represents the GetByMaHoSoThanhTra method.
		/// </summary>
		GetByMaHoSoThanhTra,
		/// <summary>
		/// Represents the GetByTuNgayDenNgay method.
		/// </summary>
		GetByTuNgayDenNgay,
		/// <summary>
		/// Represents the GetByTuNgayDenNgayMaDonVi method.
		/// </summary>
		GetByTuNgayDenNgayMaDonVi
	}
	
	#endregion ThanhTraGiangDaySelectMethod

	#region ThanhTraGiangDayFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ThanhTraGiangDay"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ThanhTraGiangDayFilter : SqlFilter<ThanhTraGiangDayColumn>
	{
	}
	
	#endregion ThanhTraGiangDayFilter

	#region ThanhTraGiangDayExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ThanhTraGiangDay"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ThanhTraGiangDayExpressionBuilder : SqlExpressionBuilder<ThanhTraGiangDayColumn>
	{
	}
	
	#endregion ThanhTraGiangDayExpressionBuilder	

	#region ThanhTraGiangDayProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;ThanhTraGiangDayChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="ThanhTraGiangDay"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ThanhTraGiangDayProperty : ChildEntityProperty<ThanhTraGiangDayChildEntityTypes>
	{
	}
	
	#endregion ThanhTraGiangDayProperty
}

