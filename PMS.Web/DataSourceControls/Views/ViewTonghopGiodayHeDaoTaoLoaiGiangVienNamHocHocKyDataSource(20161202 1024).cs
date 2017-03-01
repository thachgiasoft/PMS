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
	/// Represents the DataRepository.ViewTonghopGiodayHeDaoTaoLoaiGiangVienNamHocHocKyProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[CLSCompliant(true)]
	[Designer(typeof(ViewTonghopGiodayHeDaoTaoLoaiGiangVienNamHocHocKyDataSourceDesigner))]
	public class ViewTonghopGiodayHeDaoTaoLoaiGiangVienNamHocHocKyDataSource : ReadOnlyDataSource<ViewTonghopGiodayHeDaoTaoLoaiGiangVienNamHocHocKy>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewTonghopGiodayHeDaoTaoLoaiGiangVienNamHocHocKyDataSource class.
		/// </summary>
		public ViewTonghopGiodayHeDaoTaoLoaiGiangVienNamHocHocKyDataSource() : base(new ViewTonghopGiodayHeDaoTaoLoaiGiangVienNamHocHocKyService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the ViewTonghopGiodayHeDaoTaoLoaiGiangVienNamHocHocKyDataSourceView used by the ViewTonghopGiodayHeDaoTaoLoaiGiangVienNamHocHocKyDataSource.
		/// </summary>
		protected ViewTonghopGiodayHeDaoTaoLoaiGiangVienNamHocHocKyDataSourceView ViewTonghopGiodayHeDaoTaoLoaiGiangVienNamHocHocKyView
		{
			get { return ( View as ViewTonghopGiodayHeDaoTaoLoaiGiangVienNamHocHocKyDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the ViewTonghopGiodayHeDaoTaoLoaiGiangVienNamHocHocKyDataSource control invokes to retrieve data.
		/// </summary>
		public new ViewTonghopGiodayHeDaoTaoLoaiGiangVienNamHocHocKySelectMethod SelectMethod
		{
			get
			{
				ViewTonghopGiodayHeDaoTaoLoaiGiangVienNamHocHocKySelectMethod selectMethod = ViewTonghopGiodayHeDaoTaoLoaiGiangVienNamHocHocKySelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (ViewTonghopGiodayHeDaoTaoLoaiGiangVienNamHocHocKySelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}
		
		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the ViewTonghopGiodayHeDaoTaoLoaiGiangVienNamHocHocKyDataSourceView class that is to be
		/// used by the ViewTonghopGiodayHeDaoTaoLoaiGiangVienNamHocHocKyDataSource.
		/// </summary>
		/// <returns>An instance of the ViewTonghopGiodayHeDaoTaoLoaiGiangVienNamHocHocKyDataSourceView class.</returns>
		protected override BaseDataSourceView<ViewTonghopGiodayHeDaoTaoLoaiGiangVienNamHocHocKy, Object> GetNewDataSourceView()
		{
			return new ViewTonghopGiodayHeDaoTaoLoaiGiangVienNamHocHocKyDataSourceView(this, DefaultViewName);
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
	/// Supports the ViewTonghopGiodayHeDaoTaoLoaiGiangVienNamHocHocKyDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class ViewTonghopGiodayHeDaoTaoLoaiGiangVienNamHocHocKyDataSourceView : ReadOnlyDataSourceView<ViewTonghopGiodayHeDaoTaoLoaiGiangVienNamHocHocKy>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewTonghopGiodayHeDaoTaoLoaiGiangVienNamHocHocKyDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the ViewTonghopGiodayHeDaoTaoLoaiGiangVienNamHocHocKyDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public ViewTonghopGiodayHeDaoTaoLoaiGiangVienNamHocHocKyDataSourceView(ViewTonghopGiodayHeDaoTaoLoaiGiangVienNamHocHocKyDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal ViewTonghopGiodayHeDaoTaoLoaiGiangVienNamHocHocKyDataSource ViewTonghopGiodayHeDaoTaoLoaiGiangVienNamHocHocKyOwner
		{
			get { return Owner as ViewTonghopGiodayHeDaoTaoLoaiGiangVienNamHocHocKyDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal new ViewTonghopGiodayHeDaoTaoLoaiGiangVienNamHocHocKySelectMethod SelectMethod
		{
			get { return ViewTonghopGiodayHeDaoTaoLoaiGiangVienNamHocHocKyOwner.SelectMethod; }
			set { ViewTonghopGiodayHeDaoTaoLoaiGiangVienNamHocHocKyOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal ViewTonghopGiodayHeDaoTaoLoaiGiangVienNamHocHocKyService ViewTonghopGiodayHeDaoTaoLoaiGiangVienNamHocHocKyProvider
		{
			get { return Provider as ViewTonghopGiodayHeDaoTaoLoaiGiangVienNamHocHocKyService; }
		}

		#endregion Properties
		
		#region Methods
		
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
	    /// <param name="values"></param>
		/// <param name="count">The total number of rows in the DataSource.</param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<ViewTonghopGiodayHeDaoTaoLoaiGiangVienNamHocHocKy> GetSelectData(IDictionary values, out int count)
		{	
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			
			IList<ViewTonghopGiodayHeDaoTaoLoaiGiangVienNamHocHocKy> results = null;
			// ViewTonghopGiodayHeDaoTaoLoaiGiangVienNamHocHocKy item;
			count = 0;
			
			System.String sp3229_NamHoc;
			System.String sp3229_HocKy;
			System.Int32 sp3229_MaHeDaoTao;
			System.String sp3229_MaDonVi;
			System.String sp3228_NamHoc;
			System.String sp3228_HocKy;
			System.Int32 sp3228_MaLoaiGiangVien;
			System.String sp3228_MaHeDaoTao;

			switch ( SelectMethod )
			{
				case ViewTonghopGiodayHeDaoTaoLoaiGiangVienNamHocHocKySelectMethod.Get:
					results = ViewTonghopGiodayHeDaoTaoLoaiGiangVienNamHocHocKyProvider.Get(WhereClause, OrderBy, PageIndex, PageSize, out count);
                    break;
				case ViewTonghopGiodayHeDaoTaoLoaiGiangVienNamHocHocKySelectMethod.GetPaged:
					results = ViewTonghopGiodayHeDaoTaoLoaiGiangVienNamHocHocKyProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case ViewTonghopGiodayHeDaoTaoLoaiGiangVienNamHocHocKySelectMethod.GetAll:
					results = ViewTonghopGiodayHeDaoTaoLoaiGiangVienNamHocHocKyProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case ViewTonghopGiodayHeDaoTaoLoaiGiangVienNamHocHocKySelectMethod.Find:
					results = ViewTonghopGiodayHeDaoTaoLoaiGiangVienNamHocHocKyProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
                    break;
				// Custom
				case ViewTonghopGiodayHeDaoTaoLoaiGiangVienNamHocHocKySelectMethod.GetByMaDonViMaHeDaoTaoNamHocHocKy:
					sp3229_NamHoc = (System.String) EntityUtil.ChangeType(values["NamHoc"], typeof(System.String));
					sp3229_HocKy = (System.String) EntityUtil.ChangeType(values["HocKy"], typeof(System.String));
					sp3229_MaHeDaoTao = (System.Int32) EntityUtil.ChangeType(values["MaHeDaoTao"], typeof(System.Int32));
					sp3229_MaDonVi = (System.String) EntityUtil.ChangeType(values["MaDonVi"], typeof(System.String));
					results = ViewTonghopGiodayHeDaoTaoLoaiGiangVienNamHocHocKyProvider.GetByMaDonViMaHeDaoTaoNamHocHocKy(sp3229_NamHoc, sp3229_HocKy, sp3229_MaHeDaoTao, sp3229_MaDonVi, StartIndex, PageSize);
					break;
				case ViewTonghopGiodayHeDaoTaoLoaiGiangVienNamHocHocKySelectMethod.GetByLoaiGiangVienHeNHHK:
					sp3228_NamHoc = (System.String) EntityUtil.ChangeType(values["NamHoc"], typeof(System.String));
					sp3228_HocKy = (System.String) EntityUtil.ChangeType(values["HocKy"], typeof(System.String));
					sp3228_MaLoaiGiangVien = (System.Int32) EntityUtil.ChangeType(values["MaLoaiGiangVien"], typeof(System.Int32));
					sp3228_MaHeDaoTao = (System.String) EntityUtil.ChangeType(values["MaHeDaoTao"], typeof(System.String));
					results = ViewTonghopGiodayHeDaoTaoLoaiGiangVienNamHocHocKyProvider.GetByLoaiGiangVienHeNHHK(sp3228_NamHoc, sp3228_HocKy, sp3228_MaLoaiGiangVien, sp3228_MaHeDaoTao, StartIndex, PageSize);
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

	#region ViewTonghopGiodayHeDaoTaoLoaiGiangVienNamHocHocKySelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the ViewTonghopGiodayHeDaoTaoLoaiGiangVienNamHocHocKyDataSource.SelectMethod property.
	/// </summary>
	public enum ViewTonghopGiodayHeDaoTaoLoaiGiangVienNamHocHocKySelectMethod
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
		/// Represents the GetByMaDonViMaHeDaoTaoNamHocHocKy method.
		/// </summary>
		GetByMaDonViMaHeDaoTaoNamHocHocKy,
		/// <summary>
		/// Represents the GetByLoaiGiangVienHeNHHK method.
		/// </summary>
		GetByLoaiGiangVienHeNHHK
	}
	
	#endregion ViewTonghopGiodayHeDaoTaoLoaiGiangVienNamHocHocKySelectMethod
	
	#region ViewTonghopGiodayHeDaoTaoLoaiGiangVienNamHocHocKyDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the ViewTonghopGiodayHeDaoTaoLoaiGiangVienNamHocHocKyDataSource class.
	/// </summary>
	public class ViewTonghopGiodayHeDaoTaoLoaiGiangVienNamHocHocKyDataSourceDesigner : ReadOnlyDataSourceDesigner<ViewTonghopGiodayHeDaoTaoLoaiGiangVienNamHocHocKy>
	{
		/// <summary>
		/// Initializes a new instance of the ViewTonghopGiodayHeDaoTaoLoaiGiangVienNamHocHocKyDataSourceDesigner class.
		/// </summary>
		public ViewTonghopGiodayHeDaoTaoLoaiGiangVienNamHocHocKyDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public new ViewTonghopGiodayHeDaoTaoLoaiGiangVienNamHocHocKySelectMethod SelectMethod
		{
			get { return ((ViewTonghopGiodayHeDaoTaoLoaiGiangVienNamHocHocKyDataSource) DataSource).SelectMethod; }
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
				actions.Add(new ViewTonghopGiodayHeDaoTaoLoaiGiangVienNamHocHocKyDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region ViewTonghopGiodayHeDaoTaoLoaiGiangVienNamHocHocKyDataSourceActionList

	/// <summary>
	/// Supports the ViewTonghopGiodayHeDaoTaoLoaiGiangVienNamHocHocKyDataSourceDesigner class.
	/// </summary>
	internal class ViewTonghopGiodayHeDaoTaoLoaiGiangVienNamHocHocKyDataSourceActionList : DesignerActionList
	{
		private ViewTonghopGiodayHeDaoTaoLoaiGiangVienNamHocHocKyDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the ViewTonghopGiodayHeDaoTaoLoaiGiangVienNamHocHocKyDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public ViewTonghopGiodayHeDaoTaoLoaiGiangVienNamHocHocKyDataSourceActionList(ViewTonghopGiodayHeDaoTaoLoaiGiangVienNamHocHocKyDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public ViewTonghopGiodayHeDaoTaoLoaiGiangVienNamHocHocKySelectMethod SelectMethod
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

	#endregion ViewTonghopGiodayHeDaoTaoLoaiGiangVienNamHocHocKyDataSourceActionList

	#endregion ViewTonghopGiodayHeDaoTaoLoaiGiangVienNamHocHocKyDataSourceDesigner

	#region ViewTonghopGiodayHeDaoTaoLoaiGiangVienNamHocHocKyFilter

	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewTonghopGiodayHeDaoTaoLoaiGiangVienNamHocHocKy"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewTonghopGiodayHeDaoTaoLoaiGiangVienNamHocHocKyFilter : SqlFilter<ViewTonghopGiodayHeDaoTaoLoaiGiangVienNamHocHocKyColumn>
	{
	}

	#endregion ViewTonghopGiodayHeDaoTaoLoaiGiangVienNamHocHocKyFilter

	#region ViewTonghopGiodayHeDaoTaoLoaiGiangVienNamHocHocKyExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewTonghopGiodayHeDaoTaoLoaiGiangVienNamHocHocKy"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewTonghopGiodayHeDaoTaoLoaiGiangVienNamHocHocKyExpressionBuilder : SqlExpressionBuilder<ViewTonghopGiodayHeDaoTaoLoaiGiangVienNamHocHocKyColumn>
	{
	}
	
	#endregion ViewTonghopGiodayHeDaoTaoLoaiGiangVienNamHocHocKyExpressionBuilder		
}

