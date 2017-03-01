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
	/// Represents the DataRepository.ViewGiangVienLopHocPhanProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[CLSCompliant(true)]
	[Designer(typeof(ViewGiangVienLopHocPhanDataSourceDesigner))]
	public class ViewGiangVienLopHocPhanDataSource : ReadOnlyDataSource<ViewGiangVienLopHocPhan>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewGiangVienLopHocPhanDataSource class.
		/// </summary>
		public ViewGiangVienLopHocPhanDataSource() : base(new ViewGiangVienLopHocPhanService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the ViewGiangVienLopHocPhanDataSourceView used by the ViewGiangVienLopHocPhanDataSource.
		/// </summary>
		protected ViewGiangVienLopHocPhanDataSourceView ViewGiangVienLopHocPhanView
		{
			get { return ( View as ViewGiangVienLopHocPhanDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the ViewGiangVienLopHocPhanDataSource control invokes to retrieve data.
		/// </summary>
		public new ViewGiangVienLopHocPhanSelectMethod SelectMethod
		{
			get
			{
				ViewGiangVienLopHocPhanSelectMethod selectMethod = ViewGiangVienLopHocPhanSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (ViewGiangVienLopHocPhanSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}
		
		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the ViewGiangVienLopHocPhanDataSourceView class that is to be
		/// used by the ViewGiangVienLopHocPhanDataSource.
		/// </summary>
		/// <returns>An instance of the ViewGiangVienLopHocPhanDataSourceView class.</returns>
		protected override BaseDataSourceView<ViewGiangVienLopHocPhan, Object> GetNewDataSourceView()
		{
			return new ViewGiangVienLopHocPhanDataSourceView(this, DefaultViewName);
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
	/// Supports the ViewGiangVienLopHocPhanDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class ViewGiangVienLopHocPhanDataSourceView : ReadOnlyDataSourceView<ViewGiangVienLopHocPhan>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewGiangVienLopHocPhanDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the ViewGiangVienLopHocPhanDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public ViewGiangVienLopHocPhanDataSourceView(ViewGiangVienLopHocPhanDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal ViewGiangVienLopHocPhanDataSource ViewGiangVienLopHocPhanOwner
		{
			get { return Owner as ViewGiangVienLopHocPhanDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal new ViewGiangVienLopHocPhanSelectMethod SelectMethod
		{
			get { return ViewGiangVienLopHocPhanOwner.SelectMethod; }
			set { ViewGiangVienLopHocPhanOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal ViewGiangVienLopHocPhanService ViewGiangVienLopHocPhanProvider
		{
			get { return Provider as ViewGiangVienLopHocPhanService; }
		}

		#endregion Properties
		
		#region Methods
		
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
	    /// <param name="values"></param>
		/// <param name="count">The total number of rows in the DataSource.</param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<ViewGiangVienLopHocPhan> GetSelectData(IDictionary values, out int count)
		{	
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			
			IList<ViewGiangVienLopHocPhan> results = null;
			// ViewGiangVienLopHocPhan item;
			count = 0;
			
			System.String sp965_NamHoc;
			System.String sp965_HocKy;
			System.Int32 sp965_MaGiangVien;
			System.String sp964_NamHoc;
			System.String sp964_HocKy;
			System.DateTime sp963_TuNgay;
			System.DateTime sp963_DenNgay;
			System.DateTime sp966_TuNgay;
			System.DateTime sp966_DenNgay;

			switch ( SelectMethod )
			{
				case ViewGiangVienLopHocPhanSelectMethod.Get:
					results = ViewGiangVienLopHocPhanProvider.Get(WhereClause, OrderBy, PageIndex, PageSize, out count);
                    break;
				case ViewGiangVienLopHocPhanSelectMethod.GetPaged:
					results = ViewGiangVienLopHocPhanProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case ViewGiangVienLopHocPhanSelectMethod.GetAll:
					results = ViewGiangVienLopHocPhanProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case ViewGiangVienLopHocPhanSelectMethod.Find:
					results = ViewGiangVienLopHocPhanProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
                    break;
				// Custom
				case ViewGiangVienLopHocPhanSelectMethod.GetByNamHocHocKyMaGiangVien:
					sp965_NamHoc = (System.String) EntityUtil.ChangeType(values["NamHoc"], typeof(System.String));
					sp965_HocKy = (System.String) EntityUtil.ChangeType(values["HocKy"], typeof(System.String));
					sp965_MaGiangVien = (System.Int32) EntityUtil.ChangeType(values["MaGiangVien"], typeof(System.Int32));
					results = ViewGiangVienLopHocPhanProvider.GetByNamHocHocKyMaGiangVien(sp965_NamHoc, sp965_HocKy, sp965_MaGiangVien, StartIndex, PageSize);
					break;
				case ViewGiangVienLopHocPhanSelectMethod.GetByNamHocHocKy:
					sp964_NamHoc = (System.String) EntityUtil.ChangeType(values["NamHoc"], typeof(System.String));
					sp964_HocKy = (System.String) EntityUtil.ChangeType(values["HocKy"], typeof(System.String));
					results = ViewGiangVienLopHocPhanProvider.GetByNamHocHocKy(sp964_NamHoc, sp964_HocKy, StartIndex, PageSize);
					break;
				case ViewGiangVienLopHocPhanSelectMethod.GetBatDauByTuNgayDenNgay:
					sp963_TuNgay = (System.DateTime) EntityUtil.ChangeType(values["TuNgay"], typeof(System.DateTime));
					sp963_DenNgay = (System.DateTime) EntityUtil.ChangeType(values["DenNgay"], typeof(System.DateTime));
					results = ViewGiangVienLopHocPhanProvider.GetBatDauByTuNgayDenNgay(sp963_TuNgay, sp963_DenNgay, StartIndex, PageSize);
					break;
				case ViewGiangVienLopHocPhanSelectMethod.GetKetThucByTuNgayDenNgay:
					sp966_TuNgay = (System.DateTime) EntityUtil.ChangeType(values["TuNgay"], typeof(System.DateTime));
					sp966_DenNgay = (System.DateTime) EntityUtil.ChangeType(values["DenNgay"], typeof(System.DateTime));
					results = ViewGiangVienLopHocPhanProvider.GetKetThucByTuNgayDenNgay(sp966_TuNgay, sp966_DenNgay, StartIndex, PageSize);
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

	#region ViewGiangVienLopHocPhanSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the ViewGiangVienLopHocPhanDataSource.SelectMethod property.
	/// </summary>
	public enum ViewGiangVienLopHocPhanSelectMethod
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
		/// Represents the GetByNamHocHocKyMaGiangVien method.
		/// </summary>
		GetByNamHocHocKyMaGiangVien,
		/// <summary>
		/// Represents the GetByNamHocHocKy method.
		/// </summary>
		GetByNamHocHocKy,
		/// <summary>
		/// Represents the GetBatDauByTuNgayDenNgay method.
		/// </summary>
		GetBatDauByTuNgayDenNgay,
		/// <summary>
		/// Represents the GetKetThucByTuNgayDenNgay method.
		/// </summary>
		GetKetThucByTuNgayDenNgay
	}
	
	#endregion ViewGiangVienLopHocPhanSelectMethod
	
	#region ViewGiangVienLopHocPhanDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the ViewGiangVienLopHocPhanDataSource class.
	/// </summary>
	public class ViewGiangVienLopHocPhanDataSourceDesigner : ReadOnlyDataSourceDesigner<ViewGiangVienLopHocPhan>
	{
		/// <summary>
		/// Initializes a new instance of the ViewGiangVienLopHocPhanDataSourceDesigner class.
		/// </summary>
		public ViewGiangVienLopHocPhanDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public new ViewGiangVienLopHocPhanSelectMethod SelectMethod
		{
			get { return ((ViewGiangVienLopHocPhanDataSource) DataSource).SelectMethod; }
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
				actions.Add(new ViewGiangVienLopHocPhanDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region ViewGiangVienLopHocPhanDataSourceActionList

	/// <summary>
	/// Supports the ViewGiangVienLopHocPhanDataSourceDesigner class.
	/// </summary>
	internal class ViewGiangVienLopHocPhanDataSourceActionList : DesignerActionList
	{
		private ViewGiangVienLopHocPhanDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the ViewGiangVienLopHocPhanDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public ViewGiangVienLopHocPhanDataSourceActionList(ViewGiangVienLopHocPhanDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public ViewGiangVienLopHocPhanSelectMethod SelectMethod
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

	#endregion ViewGiangVienLopHocPhanDataSourceActionList

	#endregion ViewGiangVienLopHocPhanDataSourceDesigner

	#region ViewGiangVienLopHocPhanFilter

	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewGiangVienLopHocPhan"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewGiangVienLopHocPhanFilter : SqlFilter<ViewGiangVienLopHocPhanColumn>
	{
	}

	#endregion ViewGiangVienLopHocPhanFilter

	#region ViewGiangVienLopHocPhanExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewGiangVienLopHocPhan"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewGiangVienLopHocPhanExpressionBuilder : SqlExpressionBuilder<ViewGiangVienLopHocPhanColumn>
	{
	}
	
	#endregion ViewGiangVienLopHocPhanExpressionBuilder		
}

