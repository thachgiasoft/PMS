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
	/// Represents the DataRepository.KhoiLuongKhacProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(KhoiLuongKhacDataSourceDesigner))]
	public class KhoiLuongKhacDataSource : ProviderDataSource<KhoiLuongKhac, KhoiLuongKhacKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KhoiLuongKhacDataSource class.
		/// </summary>
		public KhoiLuongKhacDataSource() : base(new KhoiLuongKhacService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the KhoiLuongKhacDataSourceView used by the KhoiLuongKhacDataSource.
		/// </summary>
		protected KhoiLuongKhacDataSourceView KhoiLuongKhacView
		{
			get { return ( View as KhoiLuongKhacDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the KhoiLuongKhacDataSource control invokes to retrieve data.
		/// </summary>
		public KhoiLuongKhacSelectMethod SelectMethod
		{
			get
			{
				KhoiLuongKhacSelectMethod selectMethod = KhoiLuongKhacSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (KhoiLuongKhacSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the KhoiLuongKhacDataSourceView class that is to be
		/// used by the KhoiLuongKhacDataSource.
		/// </summary>
		/// <returns>An instance of the KhoiLuongKhacDataSourceView class.</returns>
		protected override BaseDataSourceView<KhoiLuongKhac, KhoiLuongKhacKey> GetNewDataSourceView()
		{
			return new KhoiLuongKhacDataSourceView(this, DefaultViewName);
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
	/// Supports the KhoiLuongKhacDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class KhoiLuongKhacDataSourceView : ProviderDataSourceView<KhoiLuongKhac, KhoiLuongKhacKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KhoiLuongKhacDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the KhoiLuongKhacDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public KhoiLuongKhacDataSourceView(KhoiLuongKhacDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal KhoiLuongKhacDataSource KhoiLuongKhacOwner
		{
			get { return Owner as KhoiLuongKhacDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal KhoiLuongKhacSelectMethod SelectMethod
		{
			get { return KhoiLuongKhacOwner.SelectMethod; }
			set { KhoiLuongKhacOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal KhoiLuongKhacService KhoiLuongKhacProvider
		{
			get { return Provider as KhoiLuongKhacService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<KhoiLuongKhac> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<KhoiLuongKhac> results = null;
			KhoiLuongKhac item;
			count = 0;
			
			System.Int32 _maKhoiLuong;
			System.Int32? _maGiangVien_nullable;
			System.String sp615_NamHoc;
			System.String sp615_HocKy;
			System.Int32 sp615_PhanLoai;
			System.Int32 sp615_MaGiangVien;
			System.String sp614_NamHoc;
			System.String sp614_HocKy;
			System.Int32 sp614_PhanLoai;

			switch ( SelectMethod )
			{
				case KhoiLuongKhacSelectMethod.Get:
					KhoiLuongKhacKey entityKey  = new KhoiLuongKhacKey();
					entityKey.Load(values);
					item = KhoiLuongKhacProvider.Get(entityKey);
					results = new TList<KhoiLuongKhac>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case KhoiLuongKhacSelectMethod.GetAll:
                    results = KhoiLuongKhacProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case KhoiLuongKhacSelectMethod.GetPaged:
					results = KhoiLuongKhacProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case KhoiLuongKhacSelectMethod.Find:
					if ( FilterParameters != null )
						results = KhoiLuongKhacProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = KhoiLuongKhacProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case KhoiLuongKhacSelectMethod.GetByMaKhoiLuong:
					_maKhoiLuong = ( values["MaKhoiLuong"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["MaKhoiLuong"], typeof(System.Int32)) : (int)0;
					item = KhoiLuongKhacProvider.GetByMaKhoiLuong(_maKhoiLuong);
					results = new TList<KhoiLuongKhac>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				// IX
				// FK
				case KhoiLuongKhacSelectMethod.GetByMaGiangVien:
					_maGiangVien_nullable = (System.Int32?) EntityUtil.ChangeType(values["MaGiangVien"], typeof(System.Int32?));
					results = KhoiLuongKhacProvider.GetByMaGiangVien(_maGiangVien_nullable, this.StartIndex, this.PageSize, out count);
					break;
				// M:M
				// Custom
				case KhoiLuongKhacSelectMethod.GetByNamHocHocKyPhanLoaiMaGiangVien:
					sp615_NamHoc = (System.String) EntityUtil.ChangeType(values["NamHoc"], typeof(System.String));
					sp615_HocKy = (System.String) EntityUtil.ChangeType(values["HocKy"], typeof(System.String));
					sp615_PhanLoai = (System.Int32) EntityUtil.ChangeType(values["PhanLoai"], typeof(System.Int32));
					sp615_MaGiangVien = (System.Int32) EntityUtil.ChangeType(values["MaGiangVien"], typeof(System.Int32));
					results = KhoiLuongKhacProvider.GetByNamHocHocKyPhanLoaiMaGiangVien(sp615_NamHoc, sp615_HocKy, sp615_PhanLoai, sp615_MaGiangVien, StartIndex, PageSize);
					break;
				case KhoiLuongKhacSelectMethod.GetByNamHocHocKyPhanLoai:
					sp614_NamHoc = (System.String) EntityUtil.ChangeType(values["NamHoc"], typeof(System.String));
					sp614_HocKy = (System.String) EntityUtil.ChangeType(values["HocKy"], typeof(System.String));
					sp614_PhanLoai = (System.Int32) EntityUtil.ChangeType(values["PhanLoai"], typeof(System.Int32));
					results = KhoiLuongKhacProvider.GetByNamHocHocKyPhanLoai(sp614_NamHoc, sp614_HocKy, sp614_PhanLoai, StartIndex, PageSize);
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
			if ( SelectMethod == KhoiLuongKhacSelectMethod.Get || SelectMethod == KhoiLuongKhacSelectMethod.GetByMaKhoiLuong )
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
				KhoiLuongKhac entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					KhoiLuongKhacProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<KhoiLuongKhac> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			KhoiLuongKhacProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region KhoiLuongKhacDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the KhoiLuongKhacDataSource class.
	/// </summary>
	public class KhoiLuongKhacDataSourceDesigner : ProviderDataSourceDesigner<KhoiLuongKhac, KhoiLuongKhacKey>
	{
		/// <summary>
		/// Initializes a new instance of the KhoiLuongKhacDataSourceDesigner class.
		/// </summary>
		public KhoiLuongKhacDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public KhoiLuongKhacSelectMethod SelectMethod
		{
			get { return ((KhoiLuongKhacDataSource) DataSource).SelectMethod; }
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
				actions.Add(new KhoiLuongKhacDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region KhoiLuongKhacDataSourceActionList

	/// <summary>
	/// Supports the KhoiLuongKhacDataSourceDesigner class.
	/// </summary>
	internal class KhoiLuongKhacDataSourceActionList : DesignerActionList
	{
		private KhoiLuongKhacDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the KhoiLuongKhacDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public KhoiLuongKhacDataSourceActionList(KhoiLuongKhacDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public KhoiLuongKhacSelectMethod SelectMethod
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

	#endregion KhoiLuongKhacDataSourceActionList
	
	#endregion KhoiLuongKhacDataSourceDesigner
	
	#region KhoiLuongKhacSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the KhoiLuongKhacDataSource.SelectMethod property.
	/// </summary>
	public enum KhoiLuongKhacSelectMethod
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
		/// Represents the GetByMaGiangVien method.
		/// </summary>
		GetByMaGiangVien,
		/// <summary>
		/// Represents the GetByNamHocHocKyPhanLoaiMaGiangVien method.
		/// </summary>
		GetByNamHocHocKyPhanLoaiMaGiangVien,
		/// <summary>
		/// Represents the GetByNamHocHocKyPhanLoai method.
		/// </summary>
		GetByNamHocHocKyPhanLoai
	}
	
	#endregion KhoiLuongKhacSelectMethod

	#region KhoiLuongKhacFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="KhoiLuongKhac"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KhoiLuongKhacFilter : SqlFilter<KhoiLuongKhacColumn>
	{
	}
	
	#endregion KhoiLuongKhacFilter

	#region KhoiLuongKhacExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="KhoiLuongKhac"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KhoiLuongKhacExpressionBuilder : SqlExpressionBuilder<KhoiLuongKhacColumn>
	{
	}
	
	#endregion KhoiLuongKhacExpressionBuilder	

	#region KhoiLuongKhacProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;KhoiLuongKhacChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="KhoiLuongKhac"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KhoiLuongKhacProperty : ChildEntityProperty<KhoiLuongKhacChildEntityTypes>
	{
	}
	
	#endregion KhoiLuongKhacProperty
}

