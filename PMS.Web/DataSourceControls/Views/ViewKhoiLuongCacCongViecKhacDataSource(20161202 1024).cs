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
	/// Represents the DataRepository.ViewKhoiLuongCacCongViecKhacProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[CLSCompliant(true)]
	[Designer(typeof(ViewKhoiLuongCacCongViecKhacDataSourceDesigner))]
	public class ViewKhoiLuongCacCongViecKhacDataSource : ReadOnlyDataSource<ViewKhoiLuongCacCongViecKhac>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewKhoiLuongCacCongViecKhacDataSource class.
		/// </summary>
		public ViewKhoiLuongCacCongViecKhacDataSource() : base(new ViewKhoiLuongCacCongViecKhacService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the ViewKhoiLuongCacCongViecKhacDataSourceView used by the ViewKhoiLuongCacCongViecKhacDataSource.
		/// </summary>
		protected ViewKhoiLuongCacCongViecKhacDataSourceView ViewKhoiLuongCacCongViecKhacView
		{
			get { return ( View as ViewKhoiLuongCacCongViecKhacDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the ViewKhoiLuongCacCongViecKhacDataSource control invokes to retrieve data.
		/// </summary>
		public new ViewKhoiLuongCacCongViecKhacSelectMethod SelectMethod
		{
			get
			{
				ViewKhoiLuongCacCongViecKhacSelectMethod selectMethod = ViewKhoiLuongCacCongViecKhacSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (ViewKhoiLuongCacCongViecKhacSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}
		
		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the ViewKhoiLuongCacCongViecKhacDataSourceView class that is to be
		/// used by the ViewKhoiLuongCacCongViecKhacDataSource.
		/// </summary>
		/// <returns>An instance of the ViewKhoiLuongCacCongViecKhacDataSourceView class.</returns>
		protected override BaseDataSourceView<ViewKhoiLuongCacCongViecKhac, Object> GetNewDataSourceView()
		{
			return new ViewKhoiLuongCacCongViecKhacDataSourceView(this, DefaultViewName);
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
	/// Supports the ViewKhoiLuongCacCongViecKhacDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class ViewKhoiLuongCacCongViecKhacDataSourceView : ReadOnlyDataSourceView<ViewKhoiLuongCacCongViecKhac>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewKhoiLuongCacCongViecKhacDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the ViewKhoiLuongCacCongViecKhacDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public ViewKhoiLuongCacCongViecKhacDataSourceView(ViewKhoiLuongCacCongViecKhacDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal ViewKhoiLuongCacCongViecKhacDataSource ViewKhoiLuongCacCongViecKhacOwner
		{
			get { return Owner as ViewKhoiLuongCacCongViecKhacDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal new ViewKhoiLuongCacCongViecKhacSelectMethod SelectMethod
		{
			get { return ViewKhoiLuongCacCongViecKhacOwner.SelectMethod; }
			set { ViewKhoiLuongCacCongViecKhacOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal ViewKhoiLuongCacCongViecKhacService ViewKhoiLuongCacCongViecKhacProvider
		{
			get { return Provider as ViewKhoiLuongCacCongViecKhacService; }
		}

		#endregion Properties
		
		#region Methods
		
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
	    /// <param name="values"></param>
		/// <param name="count">The total number of rows in the DataSource.</param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<ViewKhoiLuongCacCongViecKhac> GetSelectData(IDictionary values, out int count)
		{	
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			
			IList<ViewKhoiLuongCacCongViecKhac> results = null;
			// ViewKhoiLuongCacCongViecKhac item;
			count = 0;
			
			System.String sp3124_NamHoc;
			System.String sp3124_HocKy;
			System.Int32 sp3124_DotThanhToan;
			System.String sp3123_NamHoc;
			System.String sp3123_HocKy;
			System.String sp3125_NamHoc;
			System.String sp3125_HocKy;
			System.String sp3125_MaKhoiLuong;
			System.String sp3125_MaDonVi;

			switch ( SelectMethod )
			{
				case ViewKhoiLuongCacCongViecKhacSelectMethod.Get:
					results = ViewKhoiLuongCacCongViecKhacProvider.Get(WhereClause, OrderBy, PageIndex, PageSize, out count);
                    break;
				case ViewKhoiLuongCacCongViecKhacSelectMethod.GetPaged:
					results = ViewKhoiLuongCacCongViecKhacProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case ViewKhoiLuongCacCongViecKhacSelectMethod.GetAll:
					results = ViewKhoiLuongCacCongViecKhacProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case ViewKhoiLuongCacCongViecKhacSelectMethod.Find:
					results = ViewKhoiLuongCacCongViecKhacProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
                    break;
				// Custom
				case ViewKhoiLuongCacCongViecKhacSelectMethod.GetByNamHocHocKyDotThanhToan:
					sp3124_NamHoc = (System.String) EntityUtil.ChangeType(values["NamHoc"], typeof(System.String));
					sp3124_HocKy = (System.String) EntityUtil.ChangeType(values["HocKy"], typeof(System.String));
					sp3124_DotThanhToan = (System.Int32) EntityUtil.ChangeType(values["DotThanhToan"], typeof(System.Int32));
					results = ViewKhoiLuongCacCongViecKhacProvider.GetByNamHocHocKyDotThanhToan(sp3124_NamHoc, sp3124_HocKy, sp3124_DotThanhToan, StartIndex, PageSize);
					break;
				case ViewKhoiLuongCacCongViecKhacSelectMethod.GetByNamHocHocKy:
					sp3123_NamHoc = (System.String) EntityUtil.ChangeType(values["NamHoc"], typeof(System.String));
					sp3123_HocKy = (System.String) EntityUtil.ChangeType(values["HocKy"], typeof(System.String));
					results = ViewKhoiLuongCacCongViecKhacProvider.GetByNamHocHocKy(sp3123_NamHoc, sp3123_HocKy, StartIndex, PageSize);
					break;
				case ViewKhoiLuongCacCongViecKhacSelectMethod.GetByNamHocHocKyLoaiCongViecKhoaDonVi:
					sp3125_NamHoc = (System.String) EntityUtil.ChangeType(values["NamHoc"], typeof(System.String));
					sp3125_HocKy = (System.String) EntityUtil.ChangeType(values["HocKy"], typeof(System.String));
					sp3125_MaKhoiLuong = (System.String) EntityUtil.ChangeType(values["MaKhoiLuong"], typeof(System.String));
					sp3125_MaDonVi = (System.String) EntityUtil.ChangeType(values["MaDonVi"], typeof(System.String));
					results = ViewKhoiLuongCacCongViecKhacProvider.GetByNamHocHocKyLoaiCongViecKhoaDonVi(sp3125_NamHoc, sp3125_HocKy, sp3125_MaKhoiLuong, sp3125_MaDonVi, StartIndex, PageSize);
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

	#region ViewKhoiLuongCacCongViecKhacSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the ViewKhoiLuongCacCongViecKhacDataSource.SelectMethod property.
	/// </summary>
	public enum ViewKhoiLuongCacCongViecKhacSelectMethod
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
		/// Represents the GetByNamHocHocKyDotThanhToan method.
		/// </summary>
		GetByNamHocHocKyDotThanhToan,
		/// <summary>
		/// Represents the GetByNamHocHocKy method.
		/// </summary>
		GetByNamHocHocKy,
		/// <summary>
		/// Represents the GetByNamHocHocKyLoaiCongViecKhoaDonVi method.
		/// </summary>
		GetByNamHocHocKyLoaiCongViecKhoaDonVi
	}
	
	#endregion ViewKhoiLuongCacCongViecKhacSelectMethod
	
	#region ViewKhoiLuongCacCongViecKhacDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the ViewKhoiLuongCacCongViecKhacDataSource class.
	/// </summary>
	public class ViewKhoiLuongCacCongViecKhacDataSourceDesigner : ReadOnlyDataSourceDesigner<ViewKhoiLuongCacCongViecKhac>
	{
		/// <summary>
		/// Initializes a new instance of the ViewKhoiLuongCacCongViecKhacDataSourceDesigner class.
		/// </summary>
		public ViewKhoiLuongCacCongViecKhacDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public new ViewKhoiLuongCacCongViecKhacSelectMethod SelectMethod
		{
			get { return ((ViewKhoiLuongCacCongViecKhacDataSource) DataSource).SelectMethod; }
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
				actions.Add(new ViewKhoiLuongCacCongViecKhacDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region ViewKhoiLuongCacCongViecKhacDataSourceActionList

	/// <summary>
	/// Supports the ViewKhoiLuongCacCongViecKhacDataSourceDesigner class.
	/// </summary>
	internal class ViewKhoiLuongCacCongViecKhacDataSourceActionList : DesignerActionList
	{
		private ViewKhoiLuongCacCongViecKhacDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the ViewKhoiLuongCacCongViecKhacDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public ViewKhoiLuongCacCongViecKhacDataSourceActionList(ViewKhoiLuongCacCongViecKhacDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public ViewKhoiLuongCacCongViecKhacSelectMethod SelectMethod
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

	#endregion ViewKhoiLuongCacCongViecKhacDataSourceActionList

	#endregion ViewKhoiLuongCacCongViecKhacDataSourceDesigner

	#region ViewKhoiLuongCacCongViecKhacFilter

	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewKhoiLuongCacCongViecKhac"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewKhoiLuongCacCongViecKhacFilter : SqlFilter<ViewKhoiLuongCacCongViecKhacColumn>
	{
	}

	#endregion ViewKhoiLuongCacCongViecKhacFilter

	#region ViewKhoiLuongCacCongViecKhacExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewKhoiLuongCacCongViecKhac"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewKhoiLuongCacCongViecKhacExpressionBuilder : SqlExpressionBuilder<ViewKhoiLuongCacCongViecKhacColumn>
	{
	}
	
	#endregion ViewKhoiLuongCacCongViecKhacExpressionBuilder		
}

