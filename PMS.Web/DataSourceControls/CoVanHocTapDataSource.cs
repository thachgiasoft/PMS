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
	/// Represents the DataRepository.CoVanHocTapProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(CoVanHocTapDataSourceDesigner))]
	public class CoVanHocTapDataSource : ProviderDataSource<CoVanHocTap, CoVanHocTapKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the CoVanHocTapDataSource class.
		/// </summary>
		public CoVanHocTapDataSource() : base(new CoVanHocTapService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the CoVanHocTapDataSourceView used by the CoVanHocTapDataSource.
		/// </summary>
		protected CoVanHocTapDataSourceView CoVanHocTapView
		{
			get { return ( View as CoVanHocTapDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the CoVanHocTapDataSource control invokes to retrieve data.
		/// </summary>
		public CoVanHocTapSelectMethod SelectMethod
		{
			get
			{
				CoVanHocTapSelectMethod selectMethod = CoVanHocTapSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (CoVanHocTapSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the CoVanHocTapDataSourceView class that is to be
		/// used by the CoVanHocTapDataSource.
		/// </summary>
		/// <returns>An instance of the CoVanHocTapDataSourceView class.</returns>
		protected override BaseDataSourceView<CoVanHocTap, CoVanHocTapKey> GetNewDataSourceView()
		{
			return new CoVanHocTapDataSourceView(this, DefaultViewName);
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
	/// Supports the CoVanHocTapDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class CoVanHocTapDataSourceView : ProviderDataSourceView<CoVanHocTap, CoVanHocTapKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the CoVanHocTapDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the CoVanHocTapDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public CoVanHocTapDataSourceView(CoVanHocTapDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal CoVanHocTapDataSource CoVanHocTapOwner
		{
			get { return Owner as CoVanHocTapDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal CoVanHocTapSelectMethod SelectMethod
		{
			get { return CoVanHocTapOwner.SelectMethod; }
			set { CoVanHocTapOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal CoVanHocTapService CoVanHocTapProvider
		{
			get { return Provider as CoVanHocTapService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<CoVanHocTap> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<CoVanHocTap> results = null;
			CoVanHocTap item;
			count = 0;
			
			System.Int32? _maGiangVien_nullable;
			System.String _maLop_nullable;
			System.String _namHoc_nullable;
			System.String _hocKy_nullable;
			System.Int32 _maCoVan;
			System.String sp45_NamHoc;
			System.String sp45_HocKy;
			System.String sp45_MaKhoaHoc;
			System.Int32 sp41_MaGiangVien;
			System.String sp41_NamHoc;
			System.String sp41_HocKy;
			System.String sp42_NamHoc;
			System.String sp42_HocKy;
			System.String sp46_NamHoc;
			System.String sp46_HocKy;
			System.String sp46_NhomQuyen;
			System.Boolean sp49_TrangThai;

			switch ( SelectMethod )
			{
				case CoVanHocTapSelectMethod.Get:
					CoVanHocTapKey entityKey  = new CoVanHocTapKey();
					entityKey.Load(values);
					item = CoVanHocTapProvider.Get(entityKey);
					results = new TList<CoVanHocTap>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case CoVanHocTapSelectMethod.GetAll:
                    results = CoVanHocTapProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case CoVanHocTapSelectMethod.GetPaged:
					results = CoVanHocTapProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case CoVanHocTapSelectMethod.Find:
					if ( FilterParameters != null )
						results = CoVanHocTapProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = CoVanHocTapProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case CoVanHocTapSelectMethod.GetByMaCoVan:
					_maCoVan = ( values["MaCoVan"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["MaCoVan"], typeof(System.Int32)) : (int)0;
					item = CoVanHocTapProvider.GetByMaCoVan(_maCoVan);
					results = new TList<CoVanHocTap>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				// IX
				case CoVanHocTapSelectMethod.GetByMaGiangVienMaLopNamHocHocKy:
					_maGiangVien_nullable = (System.Int32?) EntityUtil.ChangeType(values["MaGiangVien"], typeof(System.Int32?));
					_maLop_nullable = (System.String) EntityUtil.ChangeType(values["MaLop"], typeof(System.String));
					_namHoc_nullable = (System.String) EntityUtil.ChangeType(values["NamHoc"], typeof(System.String));
					_hocKy_nullable = (System.String) EntityUtil.ChangeType(values["HocKy"], typeof(System.String));
					item = CoVanHocTapProvider.GetByMaGiangVienMaLopNamHocHocKy(_maGiangVien_nullable, _maLop_nullable, _namHoc_nullable, _hocKy_nullable);
					results = new TList<CoVanHocTap>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				// FK
				case CoVanHocTapSelectMethod.GetByMaGiangVien:
					_maGiangVien_nullable = (System.Int32?) EntityUtil.ChangeType(values["MaGiangVien"], typeof(System.Int32?));
					results = CoVanHocTapProvider.GetByMaGiangVien(_maGiangVien_nullable, this.StartIndex, this.PageSize, out count);
					break;
				// M:M
				// Custom
				case CoVanHocTapSelectMethod.GetByNamHocHocKyMaKhoaHoc:
					sp45_NamHoc = (System.String) EntityUtil.ChangeType(values["NamHoc"], typeof(System.String));
					sp45_HocKy = (System.String) EntityUtil.ChangeType(values["HocKy"], typeof(System.String));
					sp45_MaKhoaHoc = (System.String) EntityUtil.ChangeType(values["MaKhoaHoc"], typeof(System.String));
					results = CoVanHocTapProvider.GetByNamHocHocKyMaKhoaHoc(sp45_NamHoc, sp45_HocKy, sp45_MaKhoaHoc, StartIndex, PageSize);
					break;
				case CoVanHocTapSelectMethod.GetByMaGiangVienNamHocHocKy:
					sp41_MaGiangVien = (System.Int32) EntityUtil.ChangeType(values["MaGiangVien"], typeof(System.Int32));
					sp41_NamHoc = (System.String) EntityUtil.ChangeType(values["NamHoc"], typeof(System.String));
					sp41_HocKy = (System.String) EntityUtil.ChangeType(values["HocKy"], typeof(System.String));
					results = CoVanHocTapProvider.GetByMaGiangVienNamHocHocKy(sp41_MaGiangVien, sp41_NamHoc, sp41_HocKy, StartIndex, PageSize);
					break;
				case CoVanHocTapSelectMethod.GetByNamHocHocKy:
					sp42_NamHoc = (System.String) EntityUtil.ChangeType(values["NamHoc"], typeof(System.String));
					sp42_HocKy = (System.String) EntityUtil.ChangeType(values["HocKy"], typeof(System.String));
					results = CoVanHocTapProvider.GetByNamHocHocKy(sp42_NamHoc, sp42_HocKy, StartIndex, PageSize);
					break;
				case CoVanHocTapSelectMethod.GetByNamHocHocKyNhomQuyen:
					sp46_NamHoc = (System.String) EntityUtil.ChangeType(values["NamHoc"], typeof(System.String));
					sp46_HocKy = (System.String) EntityUtil.ChangeType(values["HocKy"], typeof(System.String));
					sp46_NhomQuyen = (System.String) EntityUtil.ChangeType(values["NhomQuyen"], typeof(System.String));
					results = CoVanHocTapProvider.GetByNamHocHocKyNhomQuyen(sp46_NamHoc, sp46_HocKy, sp46_NhomQuyen, StartIndex, PageSize);
					break;
				case CoVanHocTapSelectMethod.GetByTrangThai:
					sp49_TrangThai = (System.Boolean) EntityUtil.ChangeType(values["TrangThai"], typeof(System.Boolean));
					results = CoVanHocTapProvider.GetByTrangThai(sp49_TrangThai, StartIndex, PageSize);
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
			if ( SelectMethod == CoVanHocTapSelectMethod.Get || SelectMethod == CoVanHocTapSelectMethod.GetByMaCoVan )
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
				CoVanHocTap entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					CoVanHocTapProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<CoVanHocTap> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			CoVanHocTapProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region CoVanHocTapDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the CoVanHocTapDataSource class.
	/// </summary>
	public class CoVanHocTapDataSourceDesigner : ProviderDataSourceDesigner<CoVanHocTap, CoVanHocTapKey>
	{
		/// <summary>
		/// Initializes a new instance of the CoVanHocTapDataSourceDesigner class.
		/// </summary>
		public CoVanHocTapDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public CoVanHocTapSelectMethod SelectMethod
		{
			get { return ((CoVanHocTapDataSource) DataSource).SelectMethod; }
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
				actions.Add(new CoVanHocTapDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region CoVanHocTapDataSourceActionList

	/// <summary>
	/// Supports the CoVanHocTapDataSourceDesigner class.
	/// </summary>
	internal class CoVanHocTapDataSourceActionList : DesignerActionList
	{
		private CoVanHocTapDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the CoVanHocTapDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public CoVanHocTapDataSourceActionList(CoVanHocTapDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public CoVanHocTapSelectMethod SelectMethod
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

	#endregion CoVanHocTapDataSourceActionList
	
	#endregion CoVanHocTapDataSourceDesigner
	
	#region CoVanHocTapSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the CoVanHocTapDataSource.SelectMethod property.
	/// </summary>
	public enum CoVanHocTapSelectMethod
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
		/// Represents the GetByMaGiangVienMaLopNamHocHocKy method.
		/// </summary>
		GetByMaGiangVienMaLopNamHocHocKy,
		/// <summary>
		/// Represents the GetByMaCoVan method.
		/// </summary>
		GetByMaCoVan,
		/// <summary>
		/// Represents the GetByMaGiangVien method.
		/// </summary>
		GetByMaGiangVien,
		/// <summary>
		/// Represents the GetByNamHocHocKyMaKhoaHoc method.
		/// </summary>
		GetByNamHocHocKyMaKhoaHoc,
		/// <summary>
		/// Represents the GetByMaGiangVienNamHocHocKy method.
		/// </summary>
		GetByMaGiangVienNamHocHocKy,
		/// <summary>
		/// Represents the GetByNamHocHocKy method.
		/// </summary>
		GetByNamHocHocKy,
		/// <summary>
		/// Represents the GetByNamHocHocKyNhomQuyen method.
		/// </summary>
		GetByNamHocHocKyNhomQuyen,
		/// <summary>
		/// Represents the GetByTrangThai method.
		/// </summary>
		GetByTrangThai
	}
	
	#endregion CoVanHocTapSelectMethod

	#region CoVanHocTapFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="CoVanHocTap"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class CoVanHocTapFilter : SqlFilter<CoVanHocTapColumn>
	{
	}
	
	#endregion CoVanHocTapFilter

	#region CoVanHocTapExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="CoVanHocTap"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class CoVanHocTapExpressionBuilder : SqlExpressionBuilder<CoVanHocTapColumn>
	{
	}
	
	#endregion CoVanHocTapExpressionBuilder	

	#region CoVanHocTapProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;CoVanHocTapChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="CoVanHocTap"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class CoVanHocTapProperty : ChildEntityProperty<CoVanHocTapChildEntityTypes>
	{
	}
	
	#endregion CoVanHocTapProperty
}

