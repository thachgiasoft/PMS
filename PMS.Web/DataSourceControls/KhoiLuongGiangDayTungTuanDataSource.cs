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
	/// Represents the DataRepository.KhoiLuongGiangDayTungTuanProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(KhoiLuongGiangDayTungTuanDataSourceDesigner))]
	public class KhoiLuongGiangDayTungTuanDataSource : ProviderDataSource<KhoiLuongGiangDayTungTuan, KhoiLuongGiangDayTungTuanKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KhoiLuongGiangDayTungTuanDataSource class.
		/// </summary>
		public KhoiLuongGiangDayTungTuanDataSource() : base(new KhoiLuongGiangDayTungTuanService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the KhoiLuongGiangDayTungTuanDataSourceView used by the KhoiLuongGiangDayTungTuanDataSource.
		/// </summary>
		protected KhoiLuongGiangDayTungTuanDataSourceView KhoiLuongGiangDayTungTuanView
		{
			get { return ( View as KhoiLuongGiangDayTungTuanDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the KhoiLuongGiangDayTungTuanDataSource control invokes to retrieve data.
		/// </summary>
		public KhoiLuongGiangDayTungTuanSelectMethod SelectMethod
		{
			get
			{
				KhoiLuongGiangDayTungTuanSelectMethod selectMethod = KhoiLuongGiangDayTungTuanSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (KhoiLuongGiangDayTungTuanSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the KhoiLuongGiangDayTungTuanDataSourceView class that is to be
		/// used by the KhoiLuongGiangDayTungTuanDataSource.
		/// </summary>
		/// <returns>An instance of the KhoiLuongGiangDayTungTuanDataSourceView class.</returns>
		protected override BaseDataSourceView<KhoiLuongGiangDayTungTuan, KhoiLuongGiangDayTungTuanKey> GetNewDataSourceView()
		{
			return new KhoiLuongGiangDayTungTuanDataSourceView(this, DefaultViewName);
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
	/// Supports the KhoiLuongGiangDayTungTuanDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class KhoiLuongGiangDayTungTuanDataSourceView : ProviderDataSourceView<KhoiLuongGiangDayTungTuan, KhoiLuongGiangDayTungTuanKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KhoiLuongGiangDayTungTuanDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the KhoiLuongGiangDayTungTuanDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public KhoiLuongGiangDayTungTuanDataSourceView(KhoiLuongGiangDayTungTuanDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal KhoiLuongGiangDayTungTuanDataSource KhoiLuongGiangDayTungTuanOwner
		{
			get { return Owner as KhoiLuongGiangDayTungTuanDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal KhoiLuongGiangDayTungTuanSelectMethod SelectMethod
		{
			get { return KhoiLuongGiangDayTungTuanOwner.SelectMethod; }
			set { KhoiLuongGiangDayTungTuanOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal KhoiLuongGiangDayTungTuanService KhoiLuongGiangDayTungTuanProvider
		{
			get { return Provider as KhoiLuongGiangDayTungTuanService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<KhoiLuongGiangDayTungTuan> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<KhoiLuongGiangDayTungTuan> results = null;
			KhoiLuongGiangDayTungTuan item;
			count = 0;
			
			System.Int32 _maKhoiLuong;
			System.String sp602_MaLopHocPhan;
			System.String sp602_MaGiangVien;
			System.Int32 sp602_Tuan;
			System.Int32 sp602_Nam;
			System.DateTime sp603_TuNgay;
			System.DateTime sp603_DenNgay;

			switch ( SelectMethod )
			{
				case KhoiLuongGiangDayTungTuanSelectMethod.Get:
					KhoiLuongGiangDayTungTuanKey entityKey  = new KhoiLuongGiangDayTungTuanKey();
					entityKey.Load(values);
					item = KhoiLuongGiangDayTungTuanProvider.Get(entityKey);
					results = new TList<KhoiLuongGiangDayTungTuan>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case KhoiLuongGiangDayTungTuanSelectMethod.GetAll:
                    results = KhoiLuongGiangDayTungTuanProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case KhoiLuongGiangDayTungTuanSelectMethod.GetPaged:
					results = KhoiLuongGiangDayTungTuanProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case KhoiLuongGiangDayTungTuanSelectMethod.Find:
					if ( FilterParameters != null )
						results = KhoiLuongGiangDayTungTuanProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = KhoiLuongGiangDayTungTuanProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case KhoiLuongGiangDayTungTuanSelectMethod.GetByMaKhoiLuong:
					_maKhoiLuong = ( values["MaKhoiLuong"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["MaKhoiLuong"], typeof(System.Int32)) : (int)0;
					item = KhoiLuongGiangDayTungTuanProvider.GetByMaKhoiLuong(_maKhoiLuong);
					results = new TList<KhoiLuongGiangDayTungTuan>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				// IX
				// FK
				// M:M
				// Custom
				case KhoiLuongGiangDayTungTuanSelectMethod.GetByMaLopHocPhanMaGiangVienTuanNam:
					sp602_MaLopHocPhan = (System.String) EntityUtil.ChangeType(values["MaLopHocPhan"], typeof(System.String));
					sp602_MaGiangVien = (System.String) EntityUtil.ChangeType(values["MaGiangVien"], typeof(System.String));
					sp602_Tuan = (System.Int32) EntityUtil.ChangeType(values["Tuan"], typeof(System.Int32));
					sp602_Nam = (System.Int32) EntityUtil.ChangeType(values["Nam"], typeof(System.Int32));
					results = KhoiLuongGiangDayTungTuanProvider.GetByMaLopHocPhanMaGiangVienTuanNam(sp602_MaLopHocPhan, sp602_MaGiangVien, sp602_Tuan, sp602_Nam, StartIndex, PageSize);
					break;
				case KhoiLuongGiangDayTungTuanSelectMethod.GetByTuNgayDenNgay:
					sp603_TuNgay = (System.DateTime) EntityUtil.ChangeType(values["TuNgay"], typeof(System.DateTime));
					sp603_DenNgay = (System.DateTime) EntityUtil.ChangeType(values["DenNgay"], typeof(System.DateTime));
					results = KhoiLuongGiangDayTungTuanProvider.GetByTuNgayDenNgay(sp603_TuNgay, sp603_DenNgay, StartIndex, PageSize);
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
			if ( SelectMethod == KhoiLuongGiangDayTungTuanSelectMethod.Get || SelectMethod == KhoiLuongGiangDayTungTuanSelectMethod.GetByMaKhoiLuong )
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
				KhoiLuongGiangDayTungTuan entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					KhoiLuongGiangDayTungTuanProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<KhoiLuongGiangDayTungTuan> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			KhoiLuongGiangDayTungTuanProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region KhoiLuongGiangDayTungTuanDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the KhoiLuongGiangDayTungTuanDataSource class.
	/// </summary>
	public class KhoiLuongGiangDayTungTuanDataSourceDesigner : ProviderDataSourceDesigner<KhoiLuongGiangDayTungTuan, KhoiLuongGiangDayTungTuanKey>
	{
		/// <summary>
		/// Initializes a new instance of the KhoiLuongGiangDayTungTuanDataSourceDesigner class.
		/// </summary>
		public KhoiLuongGiangDayTungTuanDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public KhoiLuongGiangDayTungTuanSelectMethod SelectMethod
		{
			get { return ((KhoiLuongGiangDayTungTuanDataSource) DataSource).SelectMethod; }
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
				actions.Add(new KhoiLuongGiangDayTungTuanDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region KhoiLuongGiangDayTungTuanDataSourceActionList

	/// <summary>
	/// Supports the KhoiLuongGiangDayTungTuanDataSourceDesigner class.
	/// </summary>
	internal class KhoiLuongGiangDayTungTuanDataSourceActionList : DesignerActionList
	{
		private KhoiLuongGiangDayTungTuanDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the KhoiLuongGiangDayTungTuanDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public KhoiLuongGiangDayTungTuanDataSourceActionList(KhoiLuongGiangDayTungTuanDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public KhoiLuongGiangDayTungTuanSelectMethod SelectMethod
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

	#endregion KhoiLuongGiangDayTungTuanDataSourceActionList
	
	#endregion KhoiLuongGiangDayTungTuanDataSourceDesigner
	
	#region KhoiLuongGiangDayTungTuanSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the KhoiLuongGiangDayTungTuanDataSource.SelectMethod property.
	/// </summary>
	public enum KhoiLuongGiangDayTungTuanSelectMethod
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
		/// Represents the GetByMaLopHocPhanMaGiangVienTuanNam method.
		/// </summary>
		GetByMaLopHocPhanMaGiangVienTuanNam,
		/// <summary>
		/// Represents the GetByTuNgayDenNgay method.
		/// </summary>
		GetByTuNgayDenNgay
	}
	
	#endregion KhoiLuongGiangDayTungTuanSelectMethod

	#region KhoiLuongGiangDayTungTuanFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="KhoiLuongGiangDayTungTuan"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KhoiLuongGiangDayTungTuanFilter : SqlFilter<KhoiLuongGiangDayTungTuanColumn>
	{
	}
	
	#endregion KhoiLuongGiangDayTungTuanFilter

	#region KhoiLuongGiangDayTungTuanExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="KhoiLuongGiangDayTungTuan"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KhoiLuongGiangDayTungTuanExpressionBuilder : SqlExpressionBuilder<KhoiLuongGiangDayTungTuanColumn>
	{
	}
	
	#endregion KhoiLuongGiangDayTungTuanExpressionBuilder	

	#region KhoiLuongGiangDayTungTuanProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;KhoiLuongGiangDayTungTuanChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="KhoiLuongGiangDayTungTuan"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KhoiLuongGiangDayTungTuanProperty : ChildEntityProperty<KhoiLuongGiangDayTungTuanChildEntityTypes>
	{
	}
	
	#endregion KhoiLuongGiangDayTungTuanProperty
}

