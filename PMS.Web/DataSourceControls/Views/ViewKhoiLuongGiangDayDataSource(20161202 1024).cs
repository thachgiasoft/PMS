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
	/// Represents the DataRepository.ViewKhoiLuongGiangDayProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[CLSCompliant(true)]
	[Designer(typeof(ViewKhoiLuongGiangDayDataSourceDesigner))]
	public class ViewKhoiLuongGiangDayDataSource : ReadOnlyDataSource<ViewKhoiLuongGiangDay>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewKhoiLuongGiangDayDataSource class.
		/// </summary>
		public ViewKhoiLuongGiangDayDataSource() : base(new ViewKhoiLuongGiangDayService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the ViewKhoiLuongGiangDayDataSourceView used by the ViewKhoiLuongGiangDayDataSource.
		/// </summary>
		protected ViewKhoiLuongGiangDayDataSourceView ViewKhoiLuongGiangDayView
		{
			get { return ( View as ViewKhoiLuongGiangDayDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the ViewKhoiLuongGiangDayDataSource control invokes to retrieve data.
		/// </summary>
		public new ViewKhoiLuongGiangDaySelectMethod SelectMethod
		{
			get
			{
				ViewKhoiLuongGiangDaySelectMethod selectMethod = ViewKhoiLuongGiangDaySelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (ViewKhoiLuongGiangDaySelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}
		
		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the ViewKhoiLuongGiangDayDataSourceView class that is to be
		/// used by the ViewKhoiLuongGiangDayDataSource.
		/// </summary>
		/// <returns>An instance of the ViewKhoiLuongGiangDayDataSourceView class.</returns>
		protected override BaseDataSourceView<ViewKhoiLuongGiangDay, Object> GetNewDataSourceView()
		{
			return new ViewKhoiLuongGiangDayDataSourceView(this, DefaultViewName);
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
	/// Supports the ViewKhoiLuongGiangDayDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class ViewKhoiLuongGiangDayDataSourceView : ReadOnlyDataSourceView<ViewKhoiLuongGiangDay>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewKhoiLuongGiangDayDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the ViewKhoiLuongGiangDayDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public ViewKhoiLuongGiangDayDataSourceView(ViewKhoiLuongGiangDayDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal ViewKhoiLuongGiangDayDataSource ViewKhoiLuongGiangDayOwner
		{
			get { return Owner as ViewKhoiLuongGiangDayDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal new ViewKhoiLuongGiangDaySelectMethod SelectMethod
		{
			get { return ViewKhoiLuongGiangDayOwner.SelectMethod; }
			set { ViewKhoiLuongGiangDayOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal ViewKhoiLuongGiangDayService ViewKhoiLuongGiangDayProvider
		{
			get { return Provider as ViewKhoiLuongGiangDayService; }
		}

		#endregion Properties
		
		#region Methods
		
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
	    /// <param name="values"></param>
		/// <param name="count">The total number of rows in the DataSource.</param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<ViewKhoiLuongGiangDay> GetSelectData(IDictionary values, out int count)
		{	
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			
			IList<ViewKhoiLuongGiangDay> results = null;
			// ViewKhoiLuongGiangDay item;
			count = 0;
			
			System.DateTime sp3121_TuNgay;
			System.DateTime sp3121_DenNgay;
			System.String sp3120_NamHoc;
			System.String sp3120_HocKy;
			System.String sp3119_MaGiangVien;
			System.String sp3119_MaLopHocPhan;
			System.String sp3119_MaLop;

			switch ( SelectMethod )
			{
				case ViewKhoiLuongGiangDaySelectMethod.Get:
					results = ViewKhoiLuongGiangDayProvider.Get(WhereClause, OrderBy, PageIndex, PageSize, out count);
                    break;
				case ViewKhoiLuongGiangDaySelectMethod.GetPaged:
					results = ViewKhoiLuongGiangDayProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case ViewKhoiLuongGiangDaySelectMethod.GetAll:
					results = ViewKhoiLuongGiangDayProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case ViewKhoiLuongGiangDaySelectMethod.Find:
					results = ViewKhoiLuongGiangDayProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
                    break;
				// Custom
				case ViewKhoiLuongGiangDaySelectMethod.GetByTuNgayDenNgay:
					sp3121_TuNgay = (System.DateTime) EntityUtil.ChangeType(values["TuNgay"], typeof(System.DateTime));
					sp3121_DenNgay = (System.DateTime) EntityUtil.ChangeType(values["DenNgay"], typeof(System.DateTime));
					results = ViewKhoiLuongGiangDayProvider.GetByTuNgayDenNgay(sp3121_TuNgay, sp3121_DenNgay, StartIndex, PageSize);
					break;
				case ViewKhoiLuongGiangDaySelectMethod.GetByNamHocHocKy:
					sp3120_NamHoc = (System.String) EntityUtil.ChangeType(values["NamHoc"], typeof(System.String));
					sp3120_HocKy = (System.String) EntityUtil.ChangeType(values["HocKy"], typeof(System.String));
					results = ViewKhoiLuongGiangDayProvider.GetByNamHocHocKy(sp3120_NamHoc, sp3120_HocKy, StartIndex, PageSize);
					break;
				case ViewKhoiLuongGiangDaySelectMethod.GetByMaGiangVienMaLopHocPhanMaLop:
					sp3119_MaGiangVien = (System.String) EntityUtil.ChangeType(values["MaGiangVien"], typeof(System.String));
					sp3119_MaLopHocPhan = (System.String) EntityUtil.ChangeType(values["MaLopHocPhan"], typeof(System.String));
					sp3119_MaLop = (System.String) EntityUtil.ChangeType(values["MaLop"], typeof(System.String));
					results = ViewKhoiLuongGiangDayProvider.GetByMaGiangVienMaLopHocPhanMaLop(sp3119_MaGiangVien, sp3119_MaLopHocPhan, sp3119_MaLop, StartIndex, PageSize);
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

	#region ViewKhoiLuongGiangDaySelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the ViewKhoiLuongGiangDayDataSource.SelectMethod property.
	/// </summary>
	public enum ViewKhoiLuongGiangDaySelectMethod
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
		/// Represents the GetByTuNgayDenNgay method.
		/// </summary>
		GetByTuNgayDenNgay,
		/// <summary>
		/// Represents the GetByNamHocHocKy method.
		/// </summary>
		GetByNamHocHocKy,
		/// <summary>
		/// Represents the GetByMaGiangVienMaLopHocPhanMaLop method.
		/// </summary>
		GetByMaGiangVienMaLopHocPhanMaLop
	}
	
	#endregion ViewKhoiLuongGiangDaySelectMethod
	
	#region ViewKhoiLuongGiangDayDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the ViewKhoiLuongGiangDayDataSource class.
	/// </summary>
	public class ViewKhoiLuongGiangDayDataSourceDesigner : ReadOnlyDataSourceDesigner<ViewKhoiLuongGiangDay>
	{
		/// <summary>
		/// Initializes a new instance of the ViewKhoiLuongGiangDayDataSourceDesigner class.
		/// </summary>
		public ViewKhoiLuongGiangDayDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public new ViewKhoiLuongGiangDaySelectMethod SelectMethod
		{
			get { return ((ViewKhoiLuongGiangDayDataSource) DataSource).SelectMethod; }
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
				actions.Add(new ViewKhoiLuongGiangDayDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region ViewKhoiLuongGiangDayDataSourceActionList

	/// <summary>
	/// Supports the ViewKhoiLuongGiangDayDataSourceDesigner class.
	/// </summary>
	internal class ViewKhoiLuongGiangDayDataSourceActionList : DesignerActionList
	{
		private ViewKhoiLuongGiangDayDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the ViewKhoiLuongGiangDayDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public ViewKhoiLuongGiangDayDataSourceActionList(ViewKhoiLuongGiangDayDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public ViewKhoiLuongGiangDaySelectMethod SelectMethod
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

	#endregion ViewKhoiLuongGiangDayDataSourceActionList

	#endregion ViewKhoiLuongGiangDayDataSourceDesigner

	#region ViewKhoiLuongGiangDayFilter

	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewKhoiLuongGiangDay"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewKhoiLuongGiangDayFilter : SqlFilter<ViewKhoiLuongGiangDayColumn>
	{
	}

	#endregion ViewKhoiLuongGiangDayFilter

	#region ViewKhoiLuongGiangDayExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewKhoiLuongGiangDay"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewKhoiLuongGiangDayExpressionBuilder : SqlExpressionBuilder<ViewKhoiLuongGiangDayColumn>
	{
	}
	
	#endregion ViewKhoiLuongGiangDayExpressionBuilder		
}

