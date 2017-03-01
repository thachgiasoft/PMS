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
	/// Represents the DataRepository.HuongDanKhoaLuanThucTapProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(HuongDanKhoaLuanThucTapDataSourceDesigner))]
	public class HuongDanKhoaLuanThucTapDataSource : ProviderDataSource<HuongDanKhoaLuanThucTap, HuongDanKhoaLuanThucTapKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the HuongDanKhoaLuanThucTapDataSource class.
		/// </summary>
		public HuongDanKhoaLuanThucTapDataSource() : base(new HuongDanKhoaLuanThucTapService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the HuongDanKhoaLuanThucTapDataSourceView used by the HuongDanKhoaLuanThucTapDataSource.
		/// </summary>
		protected HuongDanKhoaLuanThucTapDataSourceView HuongDanKhoaLuanThucTapView
		{
			get { return ( View as HuongDanKhoaLuanThucTapDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the HuongDanKhoaLuanThucTapDataSource control invokes to retrieve data.
		/// </summary>
		public HuongDanKhoaLuanThucTapSelectMethod SelectMethod
		{
			get
			{
				HuongDanKhoaLuanThucTapSelectMethod selectMethod = HuongDanKhoaLuanThucTapSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (HuongDanKhoaLuanThucTapSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the HuongDanKhoaLuanThucTapDataSourceView class that is to be
		/// used by the HuongDanKhoaLuanThucTapDataSource.
		/// </summary>
		/// <returns>An instance of the HuongDanKhoaLuanThucTapDataSourceView class.</returns>
		protected override BaseDataSourceView<HuongDanKhoaLuanThucTap, HuongDanKhoaLuanThucTapKey> GetNewDataSourceView()
		{
			return new HuongDanKhoaLuanThucTapDataSourceView(this, DefaultViewName);
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
	/// Supports the HuongDanKhoaLuanThucTapDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class HuongDanKhoaLuanThucTapDataSourceView : ProviderDataSourceView<HuongDanKhoaLuanThucTap, HuongDanKhoaLuanThucTapKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the HuongDanKhoaLuanThucTapDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the HuongDanKhoaLuanThucTapDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public HuongDanKhoaLuanThucTapDataSourceView(HuongDanKhoaLuanThucTapDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal HuongDanKhoaLuanThucTapDataSource HuongDanKhoaLuanThucTapOwner
		{
			get { return Owner as HuongDanKhoaLuanThucTapDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal HuongDanKhoaLuanThucTapSelectMethod SelectMethod
		{
			get { return HuongDanKhoaLuanThucTapOwner.SelectMethod; }
			set { HuongDanKhoaLuanThucTapOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal HuongDanKhoaLuanThucTapService HuongDanKhoaLuanThucTapProvider
		{
			get { return Provider as HuongDanKhoaLuanThucTapService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<HuongDanKhoaLuanThucTap> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<HuongDanKhoaLuanThucTap> results = null;
			HuongDanKhoaLuanThucTap item;
			count = 0;
			
			System.Int32 _id;
			System.String sp341_NamHoc;
			System.String sp341_HocKy;
			System.String sp341_MaHinhThucDaoTao;
			System.String sp341_MaLoaiKhoiLuong;
			System.String sp341_MaDonVi;

			switch ( SelectMethod )
			{
				case HuongDanKhoaLuanThucTapSelectMethod.Get:
					HuongDanKhoaLuanThucTapKey entityKey  = new HuongDanKhoaLuanThucTapKey();
					entityKey.Load(values);
					item = HuongDanKhoaLuanThucTapProvider.Get(entityKey);
					results = new TList<HuongDanKhoaLuanThucTap>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case HuongDanKhoaLuanThucTapSelectMethod.GetAll:
                    results = HuongDanKhoaLuanThucTapProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case HuongDanKhoaLuanThucTapSelectMethod.GetPaged:
					results = HuongDanKhoaLuanThucTapProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case HuongDanKhoaLuanThucTapSelectMethod.Find:
					if ( FilterParameters != null )
						results = HuongDanKhoaLuanThucTapProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = HuongDanKhoaLuanThucTapProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case HuongDanKhoaLuanThucTapSelectMethod.GetById:
					_id = ( values["Id"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["Id"], typeof(System.Int32)) : (int)0;
					item = HuongDanKhoaLuanThucTapProvider.GetById(_id);
					results = new TList<HuongDanKhoaLuanThucTap>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				// IX
				// FK
				// M:M
				// Custom
				case HuongDanKhoaLuanThucTapSelectMethod.GetByNamHocHocKyHinhThucDaoTaoLoaiKhoiLuongKhoaDonVi:
					sp341_NamHoc = (System.String) EntityUtil.ChangeType(values["NamHoc"], typeof(System.String));
					sp341_HocKy = (System.String) EntityUtil.ChangeType(values["HocKy"], typeof(System.String));
					sp341_MaHinhThucDaoTao = (System.String) EntityUtil.ChangeType(values["MaHinhThucDaoTao"], typeof(System.String));
					sp341_MaLoaiKhoiLuong = (System.String) EntityUtil.ChangeType(values["MaLoaiKhoiLuong"], typeof(System.String));
					sp341_MaDonVi = (System.String) EntityUtil.ChangeType(values["MaDonVi"], typeof(System.String));
					results = HuongDanKhoaLuanThucTapProvider.GetByNamHocHocKyHinhThucDaoTaoLoaiKhoiLuongKhoaDonVi(sp341_NamHoc, sp341_HocKy, sp341_MaHinhThucDaoTao, sp341_MaLoaiKhoiLuong, sp341_MaDonVi, StartIndex, PageSize);
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
			if ( SelectMethod == HuongDanKhoaLuanThucTapSelectMethod.Get || SelectMethod == HuongDanKhoaLuanThucTapSelectMethod.GetById )
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
				HuongDanKhoaLuanThucTap entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					HuongDanKhoaLuanThucTapProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<HuongDanKhoaLuanThucTap> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			HuongDanKhoaLuanThucTapProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region HuongDanKhoaLuanThucTapDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the HuongDanKhoaLuanThucTapDataSource class.
	/// </summary>
	public class HuongDanKhoaLuanThucTapDataSourceDesigner : ProviderDataSourceDesigner<HuongDanKhoaLuanThucTap, HuongDanKhoaLuanThucTapKey>
	{
		/// <summary>
		/// Initializes a new instance of the HuongDanKhoaLuanThucTapDataSourceDesigner class.
		/// </summary>
		public HuongDanKhoaLuanThucTapDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public HuongDanKhoaLuanThucTapSelectMethod SelectMethod
		{
			get { return ((HuongDanKhoaLuanThucTapDataSource) DataSource).SelectMethod; }
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
				actions.Add(new HuongDanKhoaLuanThucTapDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region HuongDanKhoaLuanThucTapDataSourceActionList

	/// <summary>
	/// Supports the HuongDanKhoaLuanThucTapDataSourceDesigner class.
	/// </summary>
	internal class HuongDanKhoaLuanThucTapDataSourceActionList : DesignerActionList
	{
		private HuongDanKhoaLuanThucTapDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the HuongDanKhoaLuanThucTapDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public HuongDanKhoaLuanThucTapDataSourceActionList(HuongDanKhoaLuanThucTapDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public HuongDanKhoaLuanThucTapSelectMethod SelectMethod
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

	#endregion HuongDanKhoaLuanThucTapDataSourceActionList
	
	#endregion HuongDanKhoaLuanThucTapDataSourceDesigner
	
	#region HuongDanKhoaLuanThucTapSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the HuongDanKhoaLuanThucTapDataSource.SelectMethod property.
	/// </summary>
	public enum HuongDanKhoaLuanThucTapSelectMethod
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
		GetById,
		/// <summary>
		/// Represents the GetByNamHocHocKyHinhThucDaoTaoLoaiKhoiLuongKhoaDonVi method.
		/// </summary>
		GetByNamHocHocKyHinhThucDaoTaoLoaiKhoiLuongKhoaDonVi
	}
	
	#endregion HuongDanKhoaLuanThucTapSelectMethod

	#region HuongDanKhoaLuanThucTapFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="HuongDanKhoaLuanThucTap"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class HuongDanKhoaLuanThucTapFilter : SqlFilter<HuongDanKhoaLuanThucTapColumn>
	{
	}
	
	#endregion HuongDanKhoaLuanThucTapFilter

	#region HuongDanKhoaLuanThucTapExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="HuongDanKhoaLuanThucTap"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class HuongDanKhoaLuanThucTapExpressionBuilder : SqlExpressionBuilder<HuongDanKhoaLuanThucTapColumn>
	{
	}
	
	#endregion HuongDanKhoaLuanThucTapExpressionBuilder	

	#region HuongDanKhoaLuanThucTapProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;HuongDanKhoaLuanThucTapChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="HuongDanKhoaLuanThucTap"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class HuongDanKhoaLuanThucTapProperty : ChildEntityProperty<HuongDanKhoaLuanThucTapChildEntityTypes>
	{
	}
	
	#endregion HuongDanKhoaLuanThucTapProperty
}

