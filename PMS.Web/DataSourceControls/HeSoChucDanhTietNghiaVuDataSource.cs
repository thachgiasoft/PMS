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
	/// Represents the DataRepository.HeSoChucDanhTietNghiaVuProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(HeSoChucDanhTietNghiaVuDataSourceDesigner))]
	public class HeSoChucDanhTietNghiaVuDataSource : ProviderDataSource<HeSoChucDanhTietNghiaVu, HeSoChucDanhTietNghiaVuKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the HeSoChucDanhTietNghiaVuDataSource class.
		/// </summary>
		public HeSoChucDanhTietNghiaVuDataSource() : base(new HeSoChucDanhTietNghiaVuService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the HeSoChucDanhTietNghiaVuDataSourceView used by the HeSoChucDanhTietNghiaVuDataSource.
		/// </summary>
		protected HeSoChucDanhTietNghiaVuDataSourceView HeSoChucDanhTietNghiaVuView
		{
			get { return ( View as HeSoChucDanhTietNghiaVuDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the HeSoChucDanhTietNghiaVuDataSource control invokes to retrieve data.
		/// </summary>
		public HeSoChucDanhTietNghiaVuSelectMethod SelectMethod
		{
			get
			{
				HeSoChucDanhTietNghiaVuSelectMethod selectMethod = HeSoChucDanhTietNghiaVuSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (HeSoChucDanhTietNghiaVuSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the HeSoChucDanhTietNghiaVuDataSourceView class that is to be
		/// used by the HeSoChucDanhTietNghiaVuDataSource.
		/// </summary>
		/// <returns>An instance of the HeSoChucDanhTietNghiaVuDataSourceView class.</returns>
		protected override BaseDataSourceView<HeSoChucDanhTietNghiaVu, HeSoChucDanhTietNghiaVuKey> GetNewDataSourceView()
		{
			return new HeSoChucDanhTietNghiaVuDataSourceView(this, DefaultViewName);
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
	/// Supports the HeSoChucDanhTietNghiaVuDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class HeSoChucDanhTietNghiaVuDataSourceView : ProviderDataSourceView<HeSoChucDanhTietNghiaVu, HeSoChucDanhTietNghiaVuKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the HeSoChucDanhTietNghiaVuDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the HeSoChucDanhTietNghiaVuDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public HeSoChucDanhTietNghiaVuDataSourceView(HeSoChucDanhTietNghiaVuDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal HeSoChucDanhTietNghiaVuDataSource HeSoChucDanhTietNghiaVuOwner
		{
			get { return Owner as HeSoChucDanhTietNghiaVuDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal HeSoChucDanhTietNghiaVuSelectMethod SelectMethod
		{
			get { return HeSoChucDanhTietNghiaVuOwner.SelectMethod; }
			set { HeSoChucDanhTietNghiaVuOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal HeSoChucDanhTietNghiaVuService HeSoChucDanhTietNghiaVuProvider
		{
			get { return Provider as HeSoChucDanhTietNghiaVuService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<HeSoChucDanhTietNghiaVu> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<HeSoChucDanhTietNghiaVu> results = null;
			HeSoChucDanhTietNghiaVu item;
			count = 0;
			
			System.Int32 _maHeSo;
			System.Int32? _maHocHam_nullable;
			System.Int32? _maHocVi_nullable;
			System.String sp250_MaGiangVien;
			System.DateTime sp250_NgayDay;
			System.String sp250_NamHoc;
			System.String sp250_HocKy;

			switch ( SelectMethod )
			{
				case HeSoChucDanhTietNghiaVuSelectMethod.Get:
					HeSoChucDanhTietNghiaVuKey entityKey  = new HeSoChucDanhTietNghiaVuKey();
					entityKey.Load(values);
					item = HeSoChucDanhTietNghiaVuProvider.Get(entityKey);
					results = new TList<HeSoChucDanhTietNghiaVu>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case HeSoChucDanhTietNghiaVuSelectMethod.GetAll:
                    results = HeSoChucDanhTietNghiaVuProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case HeSoChucDanhTietNghiaVuSelectMethod.GetPaged:
					results = HeSoChucDanhTietNghiaVuProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case HeSoChucDanhTietNghiaVuSelectMethod.Find:
					if ( FilterParameters != null )
						results = HeSoChucDanhTietNghiaVuProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = HeSoChucDanhTietNghiaVuProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case HeSoChucDanhTietNghiaVuSelectMethod.GetByMaHeSo:
					_maHeSo = ( values["MaHeSo"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["MaHeSo"], typeof(System.Int32)) : (int)0;
					item = HeSoChucDanhTietNghiaVuProvider.GetByMaHeSo(_maHeSo);
					results = new TList<HeSoChucDanhTietNghiaVu>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				// IX
				// FK
				case HeSoChucDanhTietNghiaVuSelectMethod.GetByMaHocHam:
					_maHocHam_nullable = (System.Int32?) EntityUtil.ChangeType(values["MaHocHam"], typeof(System.Int32?));
					results = HeSoChucDanhTietNghiaVuProvider.GetByMaHocHam(_maHocHam_nullable, this.StartIndex, this.PageSize, out count);
					break;
				case HeSoChucDanhTietNghiaVuSelectMethod.GetByMaHocVi:
					_maHocVi_nullable = (System.Int32?) EntityUtil.ChangeType(values["MaHocVi"], typeof(System.Int32?));
					results = HeSoChucDanhTietNghiaVuProvider.GetByMaHocVi(_maHocVi_nullable, this.StartIndex, this.PageSize, out count);
					break;
				// M:M
				// Custom
				case HeSoChucDanhTietNghiaVuSelectMethod.GetByMaGiangVienNgayDay:
					sp250_MaGiangVien = (System.String) EntityUtil.ChangeType(values["MaGiangVien"], typeof(System.String));
					sp250_NgayDay = (System.DateTime) EntityUtil.ChangeType(values["NgayDay"], typeof(System.DateTime));
					sp250_NamHoc = (System.String) EntityUtil.ChangeType(values["NamHoc"], typeof(System.String));
					sp250_HocKy = (System.String) EntityUtil.ChangeType(values["HocKy"], typeof(System.String));
					results = HeSoChucDanhTietNghiaVuProvider.GetByMaGiangVienNgayDay(sp250_MaGiangVien, sp250_NgayDay, sp250_NamHoc, sp250_HocKy, StartIndex, PageSize);
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
			if ( SelectMethod == HeSoChucDanhTietNghiaVuSelectMethod.Get || SelectMethod == HeSoChucDanhTietNghiaVuSelectMethod.GetByMaHeSo )
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
				HeSoChucDanhTietNghiaVu entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					HeSoChucDanhTietNghiaVuProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<HeSoChucDanhTietNghiaVu> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			HeSoChucDanhTietNghiaVuProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region HeSoChucDanhTietNghiaVuDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the HeSoChucDanhTietNghiaVuDataSource class.
	/// </summary>
	public class HeSoChucDanhTietNghiaVuDataSourceDesigner : ProviderDataSourceDesigner<HeSoChucDanhTietNghiaVu, HeSoChucDanhTietNghiaVuKey>
	{
		/// <summary>
		/// Initializes a new instance of the HeSoChucDanhTietNghiaVuDataSourceDesigner class.
		/// </summary>
		public HeSoChucDanhTietNghiaVuDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public HeSoChucDanhTietNghiaVuSelectMethod SelectMethod
		{
			get { return ((HeSoChucDanhTietNghiaVuDataSource) DataSource).SelectMethod; }
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
				actions.Add(new HeSoChucDanhTietNghiaVuDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region HeSoChucDanhTietNghiaVuDataSourceActionList

	/// <summary>
	/// Supports the HeSoChucDanhTietNghiaVuDataSourceDesigner class.
	/// </summary>
	internal class HeSoChucDanhTietNghiaVuDataSourceActionList : DesignerActionList
	{
		private HeSoChucDanhTietNghiaVuDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the HeSoChucDanhTietNghiaVuDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public HeSoChucDanhTietNghiaVuDataSourceActionList(HeSoChucDanhTietNghiaVuDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public HeSoChucDanhTietNghiaVuSelectMethod SelectMethod
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

	#endregion HeSoChucDanhTietNghiaVuDataSourceActionList
	
	#endregion HeSoChucDanhTietNghiaVuDataSourceDesigner
	
	#region HeSoChucDanhTietNghiaVuSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the HeSoChucDanhTietNghiaVuDataSource.SelectMethod property.
	/// </summary>
	public enum HeSoChucDanhTietNghiaVuSelectMethod
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
		/// Represents the GetByMaHeSo method.
		/// </summary>
		GetByMaHeSo,
		/// <summary>
		/// Represents the GetByMaHocHam method.
		/// </summary>
		GetByMaHocHam,
		/// <summary>
		/// Represents the GetByMaHocVi method.
		/// </summary>
		GetByMaHocVi,
		/// <summary>
		/// Represents the GetByMaGiangVienNgayDay method.
		/// </summary>
		GetByMaGiangVienNgayDay
	}
	
	#endregion HeSoChucDanhTietNghiaVuSelectMethod

	#region HeSoChucDanhTietNghiaVuFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="HeSoChucDanhTietNghiaVu"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class HeSoChucDanhTietNghiaVuFilter : SqlFilter<HeSoChucDanhTietNghiaVuColumn>
	{
	}
	
	#endregion HeSoChucDanhTietNghiaVuFilter

	#region HeSoChucDanhTietNghiaVuExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="HeSoChucDanhTietNghiaVu"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class HeSoChucDanhTietNghiaVuExpressionBuilder : SqlExpressionBuilder<HeSoChucDanhTietNghiaVuColumn>
	{
	}
	
	#endregion HeSoChucDanhTietNghiaVuExpressionBuilder	

	#region HeSoChucDanhTietNghiaVuProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;HeSoChucDanhTietNghiaVuChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="HeSoChucDanhTietNghiaVu"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class HeSoChucDanhTietNghiaVuProperty : ChildEntityProperty<HeSoChucDanhTietNghiaVuChildEntityTypes>
	{
	}
	
	#endregion HeSoChucDanhTietNghiaVuProperty
}

