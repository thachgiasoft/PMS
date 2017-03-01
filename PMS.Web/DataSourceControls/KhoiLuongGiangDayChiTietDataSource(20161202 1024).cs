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
	/// Represents the DataRepository.KhoiLuongGiangDayChiTietProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(KhoiLuongGiangDayChiTietDataSourceDesigner))]
	public class KhoiLuongGiangDayChiTietDataSource : ProviderDataSource<KhoiLuongGiangDayChiTiet, KhoiLuongGiangDayChiTietKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KhoiLuongGiangDayChiTietDataSource class.
		/// </summary>
		public KhoiLuongGiangDayChiTietDataSource() : base(new KhoiLuongGiangDayChiTietService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the KhoiLuongGiangDayChiTietDataSourceView used by the KhoiLuongGiangDayChiTietDataSource.
		/// </summary>
		protected KhoiLuongGiangDayChiTietDataSourceView KhoiLuongGiangDayChiTietView
		{
			get { return ( View as KhoiLuongGiangDayChiTietDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the KhoiLuongGiangDayChiTietDataSource control invokes to retrieve data.
		/// </summary>
		public KhoiLuongGiangDayChiTietSelectMethod SelectMethod
		{
			get
			{
				KhoiLuongGiangDayChiTietSelectMethod selectMethod = KhoiLuongGiangDayChiTietSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (KhoiLuongGiangDayChiTietSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the KhoiLuongGiangDayChiTietDataSourceView class that is to be
		/// used by the KhoiLuongGiangDayChiTietDataSource.
		/// </summary>
		/// <returns>An instance of the KhoiLuongGiangDayChiTietDataSourceView class.</returns>
		protected override BaseDataSourceView<KhoiLuongGiangDayChiTiet, KhoiLuongGiangDayChiTietKey> GetNewDataSourceView()
		{
			return new KhoiLuongGiangDayChiTietDataSourceView(this, DefaultViewName);
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
	/// Supports the KhoiLuongGiangDayChiTietDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class KhoiLuongGiangDayChiTietDataSourceView : ProviderDataSourceView<KhoiLuongGiangDayChiTiet, KhoiLuongGiangDayChiTietKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KhoiLuongGiangDayChiTietDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the KhoiLuongGiangDayChiTietDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public KhoiLuongGiangDayChiTietDataSourceView(KhoiLuongGiangDayChiTietDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal KhoiLuongGiangDayChiTietDataSource KhoiLuongGiangDayChiTietOwner
		{
			get { return Owner as KhoiLuongGiangDayChiTietDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal KhoiLuongGiangDayChiTietSelectMethod SelectMethod
		{
			get { return KhoiLuongGiangDayChiTietOwner.SelectMethod; }
			set { KhoiLuongGiangDayChiTietOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal KhoiLuongGiangDayChiTietService KhoiLuongGiangDayChiTietProvider
		{
			get { return Provider as KhoiLuongGiangDayChiTietService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<KhoiLuongGiangDayChiTiet> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<KhoiLuongGiangDayChiTiet> results = null;
			KhoiLuongGiangDayChiTiet item;
			count = 0;
			
			System.Int32 _maKhoiLuong;
			System.String sp2664_NamHoc;
			System.String sp2664_HocKy;
			System.String sp2669_XmlData;
			System.String sp2669_NamHoc;
			System.String sp2669_HocKy;
			System.String sp2666_NamHoc;
			System.String sp2666_HocKy;
			System.Int32 sp2666_MaCauHinhChotGio;
			System.String sp2663_MaGiangVien;
			System.String sp2663_MaLopHocPhan;
			System.String sp2663_MaLop;
			System.String sp2667_NamHoc;
			System.String sp2667_HocKy;
			System.String sp2667_MaDonVi;
			System.String sp2681_NamHoc;
			System.String sp2681_HocKy;
			System.DateTime sp2668_TuNgay;
			System.DateTime sp2668_DenNgay;
			System.String sp2662_MaGiangVien;
			System.String sp2662_MaLopHocPhan;
			System.String sp2665_NamHoc;
			System.String sp2665_HocKy;

			switch ( SelectMethod )
			{
				case KhoiLuongGiangDayChiTietSelectMethod.Get:
					KhoiLuongGiangDayChiTietKey entityKey  = new KhoiLuongGiangDayChiTietKey();
					entityKey.Load(values);
					item = KhoiLuongGiangDayChiTietProvider.Get(entityKey);
					results = new TList<KhoiLuongGiangDayChiTiet>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case KhoiLuongGiangDayChiTietSelectMethod.GetAll:
                    results = KhoiLuongGiangDayChiTietProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case KhoiLuongGiangDayChiTietSelectMethod.GetPaged:
					results = KhoiLuongGiangDayChiTietProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case KhoiLuongGiangDayChiTietSelectMethod.Find:
					if ( FilterParameters != null )
						results = KhoiLuongGiangDayChiTietProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = KhoiLuongGiangDayChiTietProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case KhoiLuongGiangDayChiTietSelectMethod.GetByMaKhoiLuong:
					_maKhoiLuong = ( values["MaKhoiLuong"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["MaKhoiLuong"], typeof(System.Int32)) : (int)0;
					item = KhoiLuongGiangDayChiTietProvider.GetByMaKhoiLuong(_maKhoiLuong);
					results = new TList<KhoiLuongGiangDayChiTiet>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				// IX
				// FK
				// M:M
				// Custom
				case KhoiLuongGiangDayChiTietSelectMethod.GetByNamHocHocKy:
					sp2664_NamHoc = (System.String) EntityUtil.ChangeType(values["NamHoc"], typeof(System.String));
					sp2664_HocKy = (System.String) EntityUtil.ChangeType(values["HocKy"], typeof(System.String));
					results = KhoiLuongGiangDayChiTietProvider.GetByNamHocHocKy(sp2664_NamHoc, sp2664_HocKy, StartIndex, PageSize);
					break;
				case KhoiLuongGiangDayChiTietSelectMethod.GetByXmlData:
					sp2669_XmlData = (System.String) EntityUtil.ChangeType(values["XmlData"], typeof(System.String));
					sp2669_NamHoc = (System.String) EntityUtil.ChangeType(values["NamHoc"], typeof(System.String));
					sp2669_HocKy = (System.String) EntityUtil.ChangeType(values["HocKy"], typeof(System.String));
					results = KhoiLuongGiangDayChiTietProvider.GetByXmlData(sp2669_XmlData, sp2669_NamHoc, sp2669_HocKy, StartIndex, PageSize);
					break;
				case KhoiLuongGiangDayChiTietSelectMethod.GetByNamHocHocKyCauHinhChotGio:
					sp2666_NamHoc = (System.String) EntityUtil.ChangeType(values["NamHoc"], typeof(System.String));
					sp2666_HocKy = (System.String) EntityUtil.ChangeType(values["HocKy"], typeof(System.String));
					sp2666_MaCauHinhChotGio = (System.Int32) EntityUtil.ChangeType(values["MaCauHinhChotGio"], typeof(System.Int32));
					results = KhoiLuongGiangDayChiTietProvider.GetByNamHocHocKyCauHinhChotGio(sp2666_NamHoc, sp2666_HocKy, sp2666_MaCauHinhChotGio, StartIndex, PageSize);
					break;
				case KhoiLuongGiangDayChiTietSelectMethod.GetByMaGiangVienMaLopHocPhanMaLop:
					sp2663_MaGiangVien = (System.String) EntityUtil.ChangeType(values["MaGiangVien"], typeof(System.String));
					sp2663_MaLopHocPhan = (System.String) EntityUtil.ChangeType(values["MaLopHocPhan"], typeof(System.String));
					sp2663_MaLop = (System.String) EntityUtil.ChangeType(values["MaLop"], typeof(System.String));
					results = KhoiLuongGiangDayChiTietProvider.GetByMaGiangVienMaLopHocPhanMaLop(sp2663_MaGiangVien, sp2663_MaLopHocPhan, sp2663_MaLop, StartIndex, PageSize);
					break;
				case KhoiLuongGiangDayChiTietSelectMethod.GetByNamHocHocKyMaDonVi:
					sp2667_NamHoc = (System.String) EntityUtil.ChangeType(values["NamHoc"], typeof(System.String));
					sp2667_HocKy = (System.String) EntityUtil.ChangeType(values["HocKy"], typeof(System.String));
					sp2667_MaDonVi = (System.String) EntityUtil.ChangeType(values["MaDonVi"], typeof(System.String));
					results = KhoiLuongGiangDayChiTietProvider.GetByNamHocHocKyMaDonVi(sp2667_NamHoc, sp2667_HocKy, sp2667_MaDonVi, StartIndex, PageSize);
					break;
				case KhoiLuongGiangDayChiTietSelectMethod.GetSoTietBoSung:
					sp2681_NamHoc = (System.String) EntityUtil.ChangeType(values["NamHoc"], typeof(System.String));
					sp2681_HocKy = (System.String) EntityUtil.ChangeType(values["HocKy"], typeof(System.String));
					results = KhoiLuongGiangDayChiTietProvider.GetSoTietBoSung(sp2681_NamHoc, sp2681_HocKy, StartIndex, PageSize);
					break;
				case KhoiLuongGiangDayChiTietSelectMethod.GetByNgay:
					sp2668_TuNgay = (System.DateTime) EntityUtil.ChangeType(values["TuNgay"], typeof(System.DateTime));
					sp2668_DenNgay = (System.DateTime) EntityUtil.ChangeType(values["DenNgay"], typeof(System.DateTime));
					results = KhoiLuongGiangDayChiTietProvider.GetByNgay(sp2668_TuNgay, sp2668_DenNgay, StartIndex, PageSize);
					break;
				case KhoiLuongGiangDayChiTietSelectMethod.GetByMaGiangVienMaLopHocPhan:
					sp2662_MaGiangVien = (System.String) EntityUtil.ChangeType(values["MaGiangVien"], typeof(System.String));
					sp2662_MaLopHocPhan = (System.String) EntityUtil.ChangeType(values["MaLopHocPhan"], typeof(System.String));
					results = KhoiLuongGiangDayChiTietProvider.GetByMaGiangVienMaLopHocPhan(sp2662_MaGiangVien, sp2662_MaLopHocPhan, StartIndex, PageSize);
					break;
				case KhoiLuongGiangDayChiTietSelectMethod.GetByNamHocHocKyBoSung:
					sp2665_NamHoc = (System.String) EntityUtil.ChangeType(values["NamHoc"], typeof(System.String));
					sp2665_HocKy = (System.String) EntityUtil.ChangeType(values["HocKy"], typeof(System.String));
					results = KhoiLuongGiangDayChiTietProvider.GetByNamHocHocKyBoSung(sp2665_NamHoc, sp2665_HocKy, StartIndex, PageSize);
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
			if ( SelectMethod == KhoiLuongGiangDayChiTietSelectMethod.Get || SelectMethod == KhoiLuongGiangDayChiTietSelectMethod.GetByMaKhoiLuong )
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
				KhoiLuongGiangDayChiTiet entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					KhoiLuongGiangDayChiTietProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<KhoiLuongGiangDayChiTiet> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			KhoiLuongGiangDayChiTietProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region KhoiLuongGiangDayChiTietDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the KhoiLuongGiangDayChiTietDataSource class.
	/// </summary>
	public class KhoiLuongGiangDayChiTietDataSourceDesigner : ProviderDataSourceDesigner<KhoiLuongGiangDayChiTiet, KhoiLuongGiangDayChiTietKey>
	{
		/// <summary>
		/// Initializes a new instance of the KhoiLuongGiangDayChiTietDataSourceDesigner class.
		/// </summary>
		public KhoiLuongGiangDayChiTietDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public KhoiLuongGiangDayChiTietSelectMethod SelectMethod
		{
			get { return ((KhoiLuongGiangDayChiTietDataSource) DataSource).SelectMethod; }
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
				actions.Add(new KhoiLuongGiangDayChiTietDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region KhoiLuongGiangDayChiTietDataSourceActionList

	/// <summary>
	/// Supports the KhoiLuongGiangDayChiTietDataSourceDesigner class.
	/// </summary>
	internal class KhoiLuongGiangDayChiTietDataSourceActionList : DesignerActionList
	{
		private KhoiLuongGiangDayChiTietDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the KhoiLuongGiangDayChiTietDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public KhoiLuongGiangDayChiTietDataSourceActionList(KhoiLuongGiangDayChiTietDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public KhoiLuongGiangDayChiTietSelectMethod SelectMethod
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

	#endregion KhoiLuongGiangDayChiTietDataSourceActionList
	
	#endregion KhoiLuongGiangDayChiTietDataSourceDesigner
	
	#region KhoiLuongGiangDayChiTietSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the KhoiLuongGiangDayChiTietDataSource.SelectMethod property.
	/// </summary>
	public enum KhoiLuongGiangDayChiTietSelectMethod
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
		/// Represents the GetByNamHocHocKy method.
		/// </summary>
		GetByNamHocHocKy,
		/// <summary>
		/// Represents the GetByXmlData method.
		/// </summary>
		GetByXmlData,
		/// <summary>
		/// Represents the GetByNamHocHocKyCauHinhChotGio method.
		/// </summary>
		GetByNamHocHocKyCauHinhChotGio,
		/// <summary>
		/// Represents the GetByMaGiangVienMaLopHocPhanMaLop method.
		/// </summary>
		GetByMaGiangVienMaLopHocPhanMaLop,
		/// <summary>
		/// Represents the GetByNamHocHocKyMaDonVi method.
		/// </summary>
		GetByNamHocHocKyMaDonVi,
		/// <summary>
		/// Represents the GetSoTietBoSung method.
		/// </summary>
		GetSoTietBoSung,
		/// <summary>
		/// Represents the GetByNgay method.
		/// </summary>
		GetByNgay,
		/// <summary>
		/// Represents the GetByMaGiangVienMaLopHocPhan method.
		/// </summary>
		GetByMaGiangVienMaLopHocPhan,
		/// <summary>
		/// Represents the GetByNamHocHocKyBoSung method.
		/// </summary>
		GetByNamHocHocKyBoSung
	}
	
	#endregion KhoiLuongGiangDayChiTietSelectMethod

	#region KhoiLuongGiangDayChiTietFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="KhoiLuongGiangDayChiTiet"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KhoiLuongGiangDayChiTietFilter : SqlFilter<KhoiLuongGiangDayChiTietColumn>
	{
	}
	
	#endregion KhoiLuongGiangDayChiTietFilter

	#region KhoiLuongGiangDayChiTietExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="KhoiLuongGiangDayChiTiet"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KhoiLuongGiangDayChiTietExpressionBuilder : SqlExpressionBuilder<KhoiLuongGiangDayChiTietColumn>
	{
	}
	
	#endregion KhoiLuongGiangDayChiTietExpressionBuilder	

	#region KhoiLuongGiangDayChiTietProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;KhoiLuongGiangDayChiTietChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="KhoiLuongGiangDayChiTiet"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KhoiLuongGiangDayChiTietProperty : ChildEntityProperty<KhoiLuongGiangDayChiTietChildEntityTypes>
	{
	}
	
	#endregion KhoiLuongGiangDayChiTietProperty
}

