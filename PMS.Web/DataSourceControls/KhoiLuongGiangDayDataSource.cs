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
	/// Represents the DataRepository.KhoiLuongGiangDayProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(KhoiLuongGiangDayDataSourceDesigner))]
	public class KhoiLuongGiangDayDataSource : ProviderDataSource<KhoiLuongGiangDay, KhoiLuongGiangDayKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KhoiLuongGiangDayDataSource class.
		/// </summary>
		public KhoiLuongGiangDayDataSource() : base(new KhoiLuongGiangDayService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the KhoiLuongGiangDayDataSourceView used by the KhoiLuongGiangDayDataSource.
		/// </summary>
		protected KhoiLuongGiangDayDataSourceView KhoiLuongGiangDayView
		{
			get { return ( View as KhoiLuongGiangDayDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the KhoiLuongGiangDayDataSource control invokes to retrieve data.
		/// </summary>
		public KhoiLuongGiangDaySelectMethod SelectMethod
		{
			get
			{
				KhoiLuongGiangDaySelectMethod selectMethod = KhoiLuongGiangDaySelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (KhoiLuongGiangDaySelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the KhoiLuongGiangDayDataSourceView class that is to be
		/// used by the KhoiLuongGiangDayDataSource.
		/// </summary>
		/// <returns>An instance of the KhoiLuongGiangDayDataSourceView class.</returns>
		protected override BaseDataSourceView<KhoiLuongGiangDay, KhoiLuongGiangDayKey> GetNewDataSourceView()
		{
			return new KhoiLuongGiangDayDataSourceView(this, DefaultViewName);
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
	/// Supports the KhoiLuongGiangDayDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class KhoiLuongGiangDayDataSourceView : ProviderDataSourceView<KhoiLuongGiangDay, KhoiLuongGiangDayKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KhoiLuongGiangDayDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the KhoiLuongGiangDayDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public KhoiLuongGiangDayDataSourceView(KhoiLuongGiangDayDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal KhoiLuongGiangDayDataSource KhoiLuongGiangDayOwner
		{
			get { return Owner as KhoiLuongGiangDayDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal KhoiLuongGiangDaySelectMethod SelectMethod
		{
			get { return KhoiLuongGiangDayOwner.SelectMethod; }
			set { KhoiLuongGiangDayOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal KhoiLuongGiangDayService KhoiLuongGiangDayProvider
		{
			get { return Provider as KhoiLuongGiangDayService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<KhoiLuongGiangDay> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<KhoiLuongGiangDay> results = null;
			KhoiLuongGiangDay item;
			count = 0;
			
			System.Int32 _maKhoiLuong;
			System.Int32? _maKetQua_nullable;
			System.String sp555_LoaiHocPhan;
			System.String sp555_NamHoc;
			System.String sp555_HocKy;
			System.String sp557_MaLop;
			System.String sp557_MaLopHocPhan;
			System.Int32 sp556_MaKetQua;
			System.String sp556_MaLopHocPhan;

			switch ( SelectMethod )
			{
				case KhoiLuongGiangDaySelectMethod.Get:
					KhoiLuongGiangDayKey entityKey  = new KhoiLuongGiangDayKey();
					entityKey.Load(values);
					item = KhoiLuongGiangDayProvider.Get(entityKey);
					results = new TList<KhoiLuongGiangDay>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case KhoiLuongGiangDaySelectMethod.GetAll:
                    results = KhoiLuongGiangDayProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case KhoiLuongGiangDaySelectMethod.GetPaged:
					results = KhoiLuongGiangDayProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case KhoiLuongGiangDaySelectMethod.Find:
					if ( FilterParameters != null )
						results = KhoiLuongGiangDayProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = KhoiLuongGiangDayProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case KhoiLuongGiangDaySelectMethod.GetByMaKhoiLuong:
					_maKhoiLuong = ( values["MaKhoiLuong"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["MaKhoiLuong"], typeof(System.Int32)) : (int)0;
					item = KhoiLuongGiangDayProvider.GetByMaKhoiLuong(_maKhoiLuong);
					results = new TList<KhoiLuongGiangDay>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				// IX
				// FK
				case KhoiLuongGiangDaySelectMethod.GetByMaKetQua:
					_maKetQua_nullable = (System.Int32?) EntityUtil.ChangeType(values["MaKetQua"], typeof(System.Int32?));
					results = KhoiLuongGiangDayProvider.GetByMaKetQua(_maKetQua_nullable, this.StartIndex, this.PageSize, out count);
					break;
				// M:M
				// Custom
				case KhoiLuongGiangDaySelectMethod.GetByLoaiHocPhanNamHocHocKy:
					sp555_LoaiHocPhan = (System.String) EntityUtil.ChangeType(values["LoaiHocPhan"], typeof(System.String));
					sp555_NamHoc = (System.String) EntityUtil.ChangeType(values["NamHoc"], typeof(System.String));
					sp555_HocKy = (System.String) EntityUtil.ChangeType(values["HocKy"], typeof(System.String));
					results = KhoiLuongGiangDayProvider.GetByLoaiHocPhanNamHocHocKy(sp555_LoaiHocPhan, sp555_NamHoc, sp555_HocKy, StartIndex, PageSize);
					break;
				case KhoiLuongGiangDaySelectMethod.GetByMaLopMaLopHocPhan:
					sp557_MaLop = (System.String) EntityUtil.ChangeType(values["MaLop"], typeof(System.String));
					sp557_MaLopHocPhan = (System.String) EntityUtil.ChangeType(values["MaLopHocPhan"], typeof(System.String));
					results = KhoiLuongGiangDayProvider.GetByMaLopMaLopHocPhan(sp557_MaLop, sp557_MaLopHocPhan, StartIndex, PageSize);
					break;
				case KhoiLuongGiangDaySelectMethod.GetByMaKetQuaMaLopHocPhan:
					sp556_MaKetQua = (System.Int32) EntityUtil.ChangeType(values["MaKetQua"], typeof(System.Int32));
					sp556_MaLopHocPhan = (System.String) EntityUtil.ChangeType(values["MaLopHocPhan"], typeof(System.String));
					results = KhoiLuongGiangDayProvider.GetByMaKetQuaMaLopHocPhan(sp556_MaKetQua, sp556_MaLopHocPhan, StartIndex, PageSize);
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
			if ( SelectMethod == KhoiLuongGiangDaySelectMethod.Get || SelectMethod == KhoiLuongGiangDaySelectMethod.GetByMaKhoiLuong )
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
				KhoiLuongGiangDay entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					KhoiLuongGiangDayProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<KhoiLuongGiangDay> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			KhoiLuongGiangDayProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region KhoiLuongGiangDayDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the KhoiLuongGiangDayDataSource class.
	/// </summary>
	public class KhoiLuongGiangDayDataSourceDesigner : ProviderDataSourceDesigner<KhoiLuongGiangDay, KhoiLuongGiangDayKey>
	{
		/// <summary>
		/// Initializes a new instance of the KhoiLuongGiangDayDataSourceDesigner class.
		/// </summary>
		public KhoiLuongGiangDayDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public KhoiLuongGiangDaySelectMethod SelectMethod
		{
			get { return ((KhoiLuongGiangDayDataSource) DataSource).SelectMethod; }
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
				actions.Add(new KhoiLuongGiangDayDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region KhoiLuongGiangDayDataSourceActionList

	/// <summary>
	/// Supports the KhoiLuongGiangDayDataSourceDesigner class.
	/// </summary>
	internal class KhoiLuongGiangDayDataSourceActionList : DesignerActionList
	{
		private KhoiLuongGiangDayDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the KhoiLuongGiangDayDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public KhoiLuongGiangDayDataSourceActionList(KhoiLuongGiangDayDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public KhoiLuongGiangDaySelectMethod SelectMethod
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

	#endregion KhoiLuongGiangDayDataSourceActionList
	
	#endregion KhoiLuongGiangDayDataSourceDesigner
	
	#region KhoiLuongGiangDaySelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the KhoiLuongGiangDayDataSource.SelectMethod property.
	/// </summary>
	public enum KhoiLuongGiangDaySelectMethod
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
		/// Represents the GetByMaKhoiLuong method.
		/// </summary>
		GetByMaKhoiLuong,
		/// <summary>
		/// Represents the GetByMaKetQua method.
		/// </summary>
		GetByMaKetQua,
		/// <summary>
		/// Represents the GetByLoaiHocPhanNamHocHocKy method.
		/// </summary>
		GetByLoaiHocPhanNamHocHocKy,
		/// <summary>
		/// Represents the GetByMaLopMaLopHocPhan method.
		/// </summary>
		GetByMaLopMaLopHocPhan,
		/// <summary>
		/// Represents the GetByMaKetQuaMaLopHocPhan method.
		/// </summary>
		GetByMaKetQuaMaLopHocPhan
	}
	
	#endregion KhoiLuongGiangDaySelectMethod

	#region KhoiLuongGiangDayFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="KhoiLuongGiangDay"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KhoiLuongGiangDayFilter : SqlFilter<KhoiLuongGiangDayColumn>
	{
	}
	
	#endregion KhoiLuongGiangDayFilter

	#region KhoiLuongGiangDayExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="KhoiLuongGiangDay"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KhoiLuongGiangDayExpressionBuilder : SqlExpressionBuilder<KhoiLuongGiangDayColumn>
	{
	}
	
	#endregion KhoiLuongGiangDayExpressionBuilder	

	#region KhoiLuongGiangDayProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;KhoiLuongGiangDayChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="KhoiLuongGiangDay"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KhoiLuongGiangDayProperty : ChildEntityProperty<KhoiLuongGiangDayChildEntityTypes>
	{
	}
	
	#endregion KhoiLuongGiangDayProperty
}

