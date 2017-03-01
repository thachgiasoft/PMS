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
	/// Represents the DataRepository.ChietTinhBoiDuongGiangDayProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(ChietTinhBoiDuongGiangDayDataSourceDesigner))]
	public class ChietTinhBoiDuongGiangDayDataSource : ProviderDataSource<ChietTinhBoiDuongGiangDay, ChietTinhBoiDuongGiangDayKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ChietTinhBoiDuongGiangDayDataSource class.
		/// </summary>
		public ChietTinhBoiDuongGiangDayDataSource() : base(new ChietTinhBoiDuongGiangDayService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the ChietTinhBoiDuongGiangDayDataSourceView used by the ChietTinhBoiDuongGiangDayDataSource.
		/// </summary>
		protected ChietTinhBoiDuongGiangDayDataSourceView ChietTinhBoiDuongGiangDayView
		{
			get { return ( View as ChietTinhBoiDuongGiangDayDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the ChietTinhBoiDuongGiangDayDataSource control invokes to retrieve data.
		/// </summary>
		public ChietTinhBoiDuongGiangDaySelectMethod SelectMethod
		{
			get
			{
				ChietTinhBoiDuongGiangDaySelectMethod selectMethod = ChietTinhBoiDuongGiangDaySelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (ChietTinhBoiDuongGiangDaySelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the ChietTinhBoiDuongGiangDayDataSourceView class that is to be
		/// used by the ChietTinhBoiDuongGiangDayDataSource.
		/// </summary>
		/// <returns>An instance of the ChietTinhBoiDuongGiangDayDataSourceView class.</returns>
		protected override BaseDataSourceView<ChietTinhBoiDuongGiangDay, ChietTinhBoiDuongGiangDayKey> GetNewDataSourceView()
		{
			return new ChietTinhBoiDuongGiangDayDataSourceView(this, DefaultViewName);
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
	/// Supports the ChietTinhBoiDuongGiangDayDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class ChietTinhBoiDuongGiangDayDataSourceView : ProviderDataSourceView<ChietTinhBoiDuongGiangDay, ChietTinhBoiDuongGiangDayKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ChietTinhBoiDuongGiangDayDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the ChietTinhBoiDuongGiangDayDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public ChietTinhBoiDuongGiangDayDataSourceView(ChietTinhBoiDuongGiangDayDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal ChietTinhBoiDuongGiangDayDataSource ChietTinhBoiDuongGiangDayOwner
		{
			get { return Owner as ChietTinhBoiDuongGiangDayDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal ChietTinhBoiDuongGiangDaySelectMethod SelectMethod
		{
			get { return ChietTinhBoiDuongGiangDayOwner.SelectMethod; }
			set { ChietTinhBoiDuongGiangDayOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal ChietTinhBoiDuongGiangDayService ChietTinhBoiDuongGiangDayProvider
		{
			get { return Provider as ChietTinhBoiDuongGiangDayService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<ChietTinhBoiDuongGiangDay> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<ChietTinhBoiDuongGiangDay> results = null;
			ChietTinhBoiDuongGiangDay item;
			count = 0;
			
			System.String _maQuanLy;
			System.String _maLopHocPhan;
			System.String _maLopSinhVien;
			System.String sp14_MaGiangVien;
			System.String sp14_MaLopHocPhan;
			System.String sp14_MaLop;
			System.String sp14_NamHoc;
			System.String sp14_HocKy;

			switch ( SelectMethod )
			{
				case ChietTinhBoiDuongGiangDaySelectMethod.Get:
					ChietTinhBoiDuongGiangDayKey entityKey  = new ChietTinhBoiDuongGiangDayKey();
					entityKey.Load(values);
					item = ChietTinhBoiDuongGiangDayProvider.Get(entityKey);
					results = new TList<ChietTinhBoiDuongGiangDay>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case ChietTinhBoiDuongGiangDaySelectMethod.GetAll:
                    results = ChietTinhBoiDuongGiangDayProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case ChietTinhBoiDuongGiangDaySelectMethod.GetPaged:
					results = ChietTinhBoiDuongGiangDayProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case ChietTinhBoiDuongGiangDaySelectMethod.Find:
					if ( FilterParameters != null )
						results = ChietTinhBoiDuongGiangDayProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = ChietTinhBoiDuongGiangDayProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case ChietTinhBoiDuongGiangDaySelectMethod.GetByMaQuanLyMaLopHocPhanMaLopSinhVien:
					_maQuanLy = ( values["MaQuanLy"] != null ) ? (System.String) EntityUtil.ChangeType(values["MaQuanLy"], typeof(System.String)) : string.Empty;
					_maLopHocPhan = ( values["MaLopHocPhan"] != null ) ? (System.String) EntityUtil.ChangeType(values["MaLopHocPhan"], typeof(System.String)) : string.Empty;
					_maLopSinhVien = ( values["MaLopSinhVien"] != null ) ? (System.String) EntityUtil.ChangeType(values["MaLopSinhVien"], typeof(System.String)) : string.Empty;
					item = ChietTinhBoiDuongGiangDayProvider.GetByMaQuanLyMaLopHocPhanMaLopSinhVien(_maQuanLy, _maLopHocPhan, _maLopSinhVien);
					results = new TList<ChietTinhBoiDuongGiangDay>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				// IX
				// FK
				// M:M
				// Custom
				case ChietTinhBoiDuongGiangDaySelectMethod.GetByMaLopHocPhanMaLopMaGiangVienNamHocHocKy:
					sp14_MaGiangVien = (System.String) EntityUtil.ChangeType(values["MaGiangVien"], typeof(System.String));
					sp14_MaLopHocPhan = (System.String) EntityUtil.ChangeType(values["MaLopHocPhan"], typeof(System.String));
					sp14_MaLop = (System.String) EntityUtil.ChangeType(values["MaLop"], typeof(System.String));
					sp14_NamHoc = (System.String) EntityUtil.ChangeType(values["NamHoc"], typeof(System.String));
					sp14_HocKy = (System.String) EntityUtil.ChangeType(values["HocKy"], typeof(System.String));
					results = ChietTinhBoiDuongGiangDayProvider.GetByMaLopHocPhanMaLopMaGiangVienNamHocHocKy(sp14_MaGiangVien, sp14_MaLopHocPhan, sp14_MaLop, sp14_NamHoc, sp14_HocKy, StartIndex, PageSize);
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
			if ( SelectMethod == ChietTinhBoiDuongGiangDaySelectMethod.Get || SelectMethod == ChietTinhBoiDuongGiangDaySelectMethod.GetByMaQuanLyMaLopHocPhanMaLopSinhVien )
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
				ChietTinhBoiDuongGiangDay entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					ChietTinhBoiDuongGiangDayProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<ChietTinhBoiDuongGiangDay> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			ChietTinhBoiDuongGiangDayProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region ChietTinhBoiDuongGiangDayDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the ChietTinhBoiDuongGiangDayDataSource class.
	/// </summary>
	public class ChietTinhBoiDuongGiangDayDataSourceDesigner : ProviderDataSourceDesigner<ChietTinhBoiDuongGiangDay, ChietTinhBoiDuongGiangDayKey>
	{
		/// <summary>
		/// Initializes a new instance of the ChietTinhBoiDuongGiangDayDataSourceDesigner class.
		/// </summary>
		public ChietTinhBoiDuongGiangDayDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public ChietTinhBoiDuongGiangDaySelectMethod SelectMethod
		{
			get { return ((ChietTinhBoiDuongGiangDayDataSource) DataSource).SelectMethod; }
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
				actions.Add(new ChietTinhBoiDuongGiangDayDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region ChietTinhBoiDuongGiangDayDataSourceActionList

	/// <summary>
	/// Supports the ChietTinhBoiDuongGiangDayDataSourceDesigner class.
	/// </summary>
	internal class ChietTinhBoiDuongGiangDayDataSourceActionList : DesignerActionList
	{
		private ChietTinhBoiDuongGiangDayDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the ChietTinhBoiDuongGiangDayDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public ChietTinhBoiDuongGiangDayDataSourceActionList(ChietTinhBoiDuongGiangDayDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public ChietTinhBoiDuongGiangDaySelectMethod SelectMethod
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

	#endregion ChietTinhBoiDuongGiangDayDataSourceActionList
	
	#endregion ChietTinhBoiDuongGiangDayDataSourceDesigner
	
	#region ChietTinhBoiDuongGiangDaySelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the ChietTinhBoiDuongGiangDayDataSource.SelectMethod property.
	/// </summary>
	public enum ChietTinhBoiDuongGiangDaySelectMethod
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
		/// Represents the GetByMaQuanLyMaLopHocPhanMaLopSinhVien method.
		/// </summary>
		GetByMaQuanLyMaLopHocPhanMaLopSinhVien,
		/// <summary>
		/// Represents the GetByMaLopHocPhanMaLopMaGiangVienNamHocHocKy method.
		/// </summary>
		GetByMaLopHocPhanMaLopMaGiangVienNamHocHocKy
	}
	
	#endregion ChietTinhBoiDuongGiangDaySelectMethod

	#region ChietTinhBoiDuongGiangDayFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ChietTinhBoiDuongGiangDay"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ChietTinhBoiDuongGiangDayFilter : SqlFilter<ChietTinhBoiDuongGiangDayColumn>
	{
	}
	
	#endregion ChietTinhBoiDuongGiangDayFilter

	#region ChietTinhBoiDuongGiangDayExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ChietTinhBoiDuongGiangDay"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ChietTinhBoiDuongGiangDayExpressionBuilder : SqlExpressionBuilder<ChietTinhBoiDuongGiangDayColumn>
	{
	}
	
	#endregion ChietTinhBoiDuongGiangDayExpressionBuilder	

	#region ChietTinhBoiDuongGiangDayProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;ChietTinhBoiDuongGiangDayChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="ChietTinhBoiDuongGiangDay"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ChietTinhBoiDuongGiangDayProperty : ChildEntityProperty<ChietTinhBoiDuongGiangDayChildEntityTypes>
	{
	}
	
	#endregion ChietTinhBoiDuongGiangDayProperty
}

