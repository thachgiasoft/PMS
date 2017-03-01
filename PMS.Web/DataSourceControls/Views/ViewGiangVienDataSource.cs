#region Using Directives
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.ComponentModel.Design;
using PMS.Entities;
using PMS.Data;
using PMS.Data.Bases;
using PMS.Services;
#endregion

namespace PMS.Web.Data
{
	/// <summary>
	/// Represents the DataRepository.ViewGiangVienProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[CLSCompliant(true)]
	[Designer(typeof(ViewGiangVienDataSourceDesigner))]
	public class ViewGiangVienDataSource : ReadOnlyDataSource<ViewGiangVien>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewGiangVienDataSource class.
		/// </summary>
		public ViewGiangVienDataSource() : base(new ViewGiangVienService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the ViewGiangVienDataSourceView used by the ViewGiangVienDataSource.
		/// </summary>
		protected ViewGiangVienDataSourceView ViewGiangVienView
		{
			get { return ( View as ViewGiangVienDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the ViewGiangVienDataSource control invokes to retrieve data.
		/// </summary>
		public new ViewGiangVienSelectMethod SelectMethod
		{
			get
			{
				ViewGiangVienSelectMethod selectMethod = ViewGiangVienSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (ViewGiangVienSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}
		
		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the ViewGiangVienDataSourceView class that is to be
		/// used by the ViewGiangVienDataSource.
		/// </summary>
		/// <returns>An instance of the ViewGiangVienDataSourceView class.</returns>
		protected override BaseDataSourceView<ViewGiangVien, Object> GetNewDataSourceView()
		{
			return new ViewGiangVienDataSourceView(this, DefaultViewName);
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
	/// Supports the ViewGiangVienDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class ViewGiangVienDataSourceView : ReadOnlyDataSourceView<ViewGiangVien>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewGiangVienDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the ViewGiangVienDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public ViewGiangVienDataSourceView(ViewGiangVienDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal ViewGiangVienDataSource ViewGiangVienOwner
		{
			get { return Owner as ViewGiangVienDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal new ViewGiangVienSelectMethod SelectMethod
		{
			get { return ViewGiangVienOwner.SelectMethod; }
			set { ViewGiangVienOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal ViewGiangVienService ViewGiangVienProvider
		{
			get { return Provider as ViewGiangVienService; }
		}

		#endregion Properties
		
		#region Methods
		
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
	    /// <param name="values"></param>
		/// <param name="count">The total number of rows in the DataSource.</param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<ViewGiangVien> GetSelectData(IDictionary values, out int count)
		{	
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			
			IList<ViewGiangVien> results = null;
			// ViewGiangVien item;
			count = 0;
			
			System.String sp960_MaDonVi;
			System.String sp959_MaDonVi;
			System.String sp959_NamHoc;
			System.String sp959_HocKy;
			System.String sp958_MaDonVi;
			System.String sp958_MaLoaiGiangVien;
			System.String sp957_MaDonVi;
			System.String sp962_NhomQuyen;
			System.String sp961_MaDonVi;
			System.DateTime sp961_TuNgay;
			System.DateTime sp961_DenNgay;

			switch ( SelectMethod )
			{
				case ViewGiangVienSelectMethod.Get:
					results = ViewGiangVienProvider.Get(WhereClause, OrderBy, PageIndex, PageSize, out count);
                    break;
				case ViewGiangVienSelectMethod.GetPaged:
					results = ViewGiangVienProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case ViewGiangVienSelectMethod.GetAll:
					results = ViewGiangVienProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case ViewGiangVienSelectMethod.Find:
					results = ViewGiangVienProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
                    break;
				// Custom
				case ViewGiangVienSelectMethod.GetByMaDonViThongKeThanhTra:
					sp960_MaDonVi = (System.String) EntityUtil.ChangeType(values["MaDonVi"], typeof(System.String));
					results = ViewGiangVienProvider.GetByMaDonViThongKeThanhTra(sp960_MaDonVi, StartIndex, PageSize);
					break;
				case ViewGiangVienSelectMethod.GetByMaDonViNamHocHocKy:
					sp959_MaDonVi = (System.String) EntityUtil.ChangeType(values["MaDonVi"], typeof(System.String));
					sp959_NamHoc = (System.String) EntityUtil.ChangeType(values["NamHoc"], typeof(System.String));
					sp959_HocKy = (System.String) EntityUtil.ChangeType(values["HocKy"], typeof(System.String));
					results = ViewGiangVienProvider.GetByMaDonViNamHocHocKy(sp959_MaDonVi, sp959_NamHoc, sp959_HocKy, StartIndex, PageSize);
					break;
				case ViewGiangVienSelectMethod.GetByMaDonViMaLoaiGiangVien:
					sp958_MaDonVi = (System.String) EntityUtil.ChangeType(values["MaDonVi"], typeof(System.String));
					sp958_MaLoaiGiangVien = (System.String) EntityUtil.ChangeType(values["MaLoaiGiangVien"], typeof(System.String));
					results = ViewGiangVienProvider.GetByMaDonViMaLoaiGiangVien(sp958_MaDonVi, sp958_MaLoaiGiangVien, StartIndex, PageSize);
					break;
				case ViewGiangVienSelectMethod.GetByMaDonVi:
					sp957_MaDonVi = (System.String) EntityUtil.ChangeType(values["MaDonVi"], typeof(System.String));
					results = ViewGiangVienProvider.GetByMaDonVi(sp957_MaDonVi, StartIndex, PageSize);
					break;
				case ViewGiangVienSelectMethod.GetByNhomQuyen:
					sp962_NhomQuyen = (System.String) EntityUtil.ChangeType(values["NhomQuyen"], typeof(System.String));
					results = ViewGiangVienProvider.GetByNhomQuyen(sp962_NhomQuyen, StartIndex, PageSize);
					break;
				case ViewGiangVienSelectMethod.GetByMaDonViTuNgayDenNgay:
					sp961_MaDonVi = (System.String) EntityUtil.ChangeType(values["MaDonVi"], typeof(System.String));
					sp961_TuNgay = (System.DateTime) EntityUtil.ChangeType(values["TuNgay"], typeof(System.DateTime));
					sp961_DenNgay = (System.DateTime) EntityUtil.ChangeType(values["DenNgay"], typeof(System.DateTime));
					results = ViewGiangVienProvider.GetByMaDonViTuNgayDenNgay(sp961_MaDonVi, sp961_TuNgay, sp961_DenNgay, StartIndex, PageSize);
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
		
		#endregion Methods
	}

	#region ViewGiangVienSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the ViewGiangVienDataSource.SelectMethod property.
	/// </summary>
	public enum ViewGiangVienSelectMethod
	{
		/// <summary>
		/// Represents the Get method.
		/// </summary>
		Get,
		/// <summary>
		/// Represents the GetPaged method.
		/// </summary>
		GetPaged,
		/// <summary>
		/// Represents the GetAll method.
		/// </summary>
		GetAll,
		/// <summary>
		/// Represents the Find method.
		/// </summary>
		Find,
		/// <summary>
		/// Represents the GetByMaDonViThongKeThanhTra method.
		/// </summary>
		GetByMaDonViThongKeThanhTra,
		/// <summary>
		/// Represents the GetByMaDonViNamHocHocKy method.
		/// </summary>
		GetByMaDonViNamHocHocKy,
		/// <summary>
		/// Represents the GetByMaDonViMaLoaiGiangVien method.
		/// </summary>
		GetByMaDonViMaLoaiGiangVien,
		/// <summary>
		/// Represents the GetByMaDonVi method.
		/// </summary>
		GetByMaDonVi,
		/// <summary>
		/// Represents the GetByNhomQuyen method.
		/// </summary>
		GetByNhomQuyen,
		/// <summary>
		/// Represents the GetByMaDonViTuNgayDenNgay method.
		/// </summary>
		GetByMaDonViTuNgayDenNgay
	}
	
	#endregion ViewGiangVienSelectMethod
	
	#region ViewGiangVienDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the ViewGiangVienDataSource class.
	/// </summary>
	public class ViewGiangVienDataSourceDesigner : ReadOnlyDataSourceDesigner<ViewGiangVien>
	{
		/// <summary>
		/// Initializes a new instance of the ViewGiangVienDataSourceDesigner class.
		/// </summary>
		public ViewGiangVienDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public new ViewGiangVienSelectMethod SelectMethod
		{
			get { return ((ViewGiangVienDataSource) DataSource).SelectMethod; }
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
				actions.Add(new ViewGiangVienDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region ViewGiangVienDataSourceActionList

	/// <summary>
	/// Supports the ViewGiangVienDataSourceDesigner class.
	/// </summary>
	internal class ViewGiangVienDataSourceActionList : DesignerActionList
	{
		private ViewGiangVienDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the ViewGiangVienDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public ViewGiangVienDataSourceActionList(ViewGiangVienDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public ViewGiangVienSelectMethod SelectMethod
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

	#endregion ViewGiangVienDataSourceActionList

	#endregion ViewGiangVienDataSourceDesigner

	#region ViewGiangVienFilter

	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewGiangVien"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewGiangVienFilter : SqlFilter<ViewGiangVienColumn>
	{
	}

	#endregion ViewGiangVienFilter

	#region ViewGiangVienExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewGiangVien"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewGiangVienExpressionBuilder : SqlExpressionBuilder<ViewGiangVienColumn>
	{
	}
	
	#endregion ViewGiangVienExpressionBuilder		
}

