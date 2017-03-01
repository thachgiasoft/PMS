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
	/// Represents the DataRepository.ViewBangPhuTroiGioDayGiangVienProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[CLSCompliant(true)]
	[Designer(typeof(ViewBangPhuTroiGioDayGiangVienDataSourceDesigner))]
	public class ViewBangPhuTroiGioDayGiangVienDataSource : ReadOnlyDataSource<ViewBangPhuTroiGioDayGiangVien>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewBangPhuTroiGioDayGiangVienDataSource class.
		/// </summary>
		public ViewBangPhuTroiGioDayGiangVienDataSource() : base(new ViewBangPhuTroiGioDayGiangVienService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the ViewBangPhuTroiGioDayGiangVienDataSourceView used by the ViewBangPhuTroiGioDayGiangVienDataSource.
		/// </summary>
		protected ViewBangPhuTroiGioDayGiangVienDataSourceView ViewBangPhuTroiGioDayGiangVienView
		{
			get { return ( View as ViewBangPhuTroiGioDayGiangVienDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the ViewBangPhuTroiGioDayGiangVienDataSource control invokes to retrieve data.
		/// </summary>
		public new ViewBangPhuTroiGioDayGiangVienSelectMethod SelectMethod
		{
			get
			{
				ViewBangPhuTroiGioDayGiangVienSelectMethod selectMethod = ViewBangPhuTroiGioDayGiangVienSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (ViewBangPhuTroiGioDayGiangVienSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}
		
		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the ViewBangPhuTroiGioDayGiangVienDataSourceView class that is to be
		/// used by the ViewBangPhuTroiGioDayGiangVienDataSource.
		/// </summary>
		/// <returns>An instance of the ViewBangPhuTroiGioDayGiangVienDataSourceView class.</returns>
		protected override BaseDataSourceView<ViewBangPhuTroiGioDayGiangVien, Object> GetNewDataSourceView()
		{
			return new ViewBangPhuTroiGioDayGiangVienDataSourceView(this, DefaultViewName);
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
	/// Supports the ViewBangPhuTroiGioDayGiangVienDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class ViewBangPhuTroiGioDayGiangVienDataSourceView : ReadOnlyDataSourceView<ViewBangPhuTroiGioDayGiangVien>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewBangPhuTroiGioDayGiangVienDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the ViewBangPhuTroiGioDayGiangVienDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public ViewBangPhuTroiGioDayGiangVienDataSourceView(ViewBangPhuTroiGioDayGiangVienDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal ViewBangPhuTroiGioDayGiangVienDataSource ViewBangPhuTroiGioDayGiangVienOwner
		{
			get { return Owner as ViewBangPhuTroiGioDayGiangVienDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal new ViewBangPhuTroiGioDayGiangVienSelectMethod SelectMethod
		{
			get { return ViewBangPhuTroiGioDayGiangVienOwner.SelectMethod; }
			set { ViewBangPhuTroiGioDayGiangVienOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal ViewBangPhuTroiGioDayGiangVienService ViewBangPhuTroiGioDayGiangVienProvider
		{
			get { return Provider as ViewBangPhuTroiGioDayGiangVienService; }
		}

		#endregion Properties
		
		#region Methods
		
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
	    /// <param name="values"></param>
		/// <param name="count">The total number of rows in the DataSource.</param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<ViewBangPhuTroiGioDayGiangVien> GetSelectData(IDictionary values, out int count)
		{	
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			
			IList<ViewBangPhuTroiGioDayGiangVien> results = null;
			// ViewBangPhuTroiGioDayGiangVien item;
			count = 0;
			
			System.String sp930_NamHoc;
			System.Int32 sp930_MaLoaiGiangVien;
			System.String sp930_MaDonVi;
			System.String sp929_NamHoc;
			System.Int32 sp929_MaLoaiGv;
			System.String sp929_MaDonVi;

			switch ( SelectMethod )
			{
				case ViewBangPhuTroiGioDayGiangVienSelectMethod.Get:
					results = ViewBangPhuTroiGioDayGiangVienProvider.Get(WhereClause, OrderBy, PageIndex, PageSize, out count);
                    break;
				case ViewBangPhuTroiGioDayGiangVienSelectMethod.GetPaged:
					results = ViewBangPhuTroiGioDayGiangVienProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case ViewBangPhuTroiGioDayGiangVienSelectMethod.GetAll:
					results = ViewBangPhuTroiGioDayGiangVienProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case ViewBangPhuTroiGioDayGiangVienSelectMethod.Find:
					results = ViewBangPhuTroiGioDayGiangVienProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
                    break;
				// Custom
				case ViewBangPhuTroiGioDayGiangVienSelectMethod.GetByNamHocMaLoaiGiangVienMaDonVi:
					sp930_NamHoc = (System.String) EntityUtil.ChangeType(values["NamHoc"], typeof(System.String));
					sp930_MaLoaiGiangVien = (System.Int32) EntityUtil.ChangeType(values["MaLoaiGiangVien"], typeof(System.Int32));
					sp930_MaDonVi = (System.String) EntityUtil.ChangeType(values["MaDonVi"], typeof(System.String));
					results = ViewBangPhuTroiGioDayGiangVienProvider.GetByNamHocMaLoaiGiangVienMaDonVi(sp930_NamHoc, sp930_MaLoaiGiangVien, sp930_MaDonVi, StartIndex, PageSize);
					break;
				case ViewBangPhuTroiGioDayGiangVienSelectMethod.GetByNamHocHocKyMaDonViMaLoaiGiangVien:
					sp929_NamHoc = (System.String) EntityUtil.ChangeType(values["NamHoc"], typeof(System.String));
					sp929_MaLoaiGv = (System.Int32) EntityUtil.ChangeType(values["MaLoaiGv"], typeof(System.Int32));
					sp929_MaDonVi = (System.String) EntityUtil.ChangeType(values["MaDonVi"], typeof(System.String));
					results = ViewBangPhuTroiGioDayGiangVienProvider.GetByNamHocHocKyMaDonViMaLoaiGiangVien(sp929_NamHoc, sp929_MaLoaiGv, sp929_MaDonVi, StartIndex, PageSize);
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

	#region ViewBangPhuTroiGioDayGiangVienSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the ViewBangPhuTroiGioDayGiangVienDataSource.SelectMethod property.
	/// </summary>
	public enum ViewBangPhuTroiGioDayGiangVienSelectMethod
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
		/// Represents the GetByNamHocMaLoaiGiangVienMaDonVi method.
		/// </summary>
		GetByNamHocMaLoaiGiangVienMaDonVi,
		/// <summary>
		/// Represents the GetByNamHocHocKyMaDonViMaLoaiGiangVien method.
		/// </summary>
		GetByNamHocHocKyMaDonViMaLoaiGiangVien
	}
	
	#endregion ViewBangPhuTroiGioDayGiangVienSelectMethod
	
	#region ViewBangPhuTroiGioDayGiangVienDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the ViewBangPhuTroiGioDayGiangVienDataSource class.
	/// </summary>
	public class ViewBangPhuTroiGioDayGiangVienDataSourceDesigner : ReadOnlyDataSourceDesigner<ViewBangPhuTroiGioDayGiangVien>
	{
		/// <summary>
		/// Initializes a new instance of the ViewBangPhuTroiGioDayGiangVienDataSourceDesigner class.
		/// </summary>
		public ViewBangPhuTroiGioDayGiangVienDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public new ViewBangPhuTroiGioDayGiangVienSelectMethod SelectMethod
		{
			get { return ((ViewBangPhuTroiGioDayGiangVienDataSource) DataSource).SelectMethod; }
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
				actions.Add(new ViewBangPhuTroiGioDayGiangVienDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region ViewBangPhuTroiGioDayGiangVienDataSourceActionList

	/// <summary>
	/// Supports the ViewBangPhuTroiGioDayGiangVienDataSourceDesigner class.
	/// </summary>
	internal class ViewBangPhuTroiGioDayGiangVienDataSourceActionList : DesignerActionList
	{
		private ViewBangPhuTroiGioDayGiangVienDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the ViewBangPhuTroiGioDayGiangVienDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public ViewBangPhuTroiGioDayGiangVienDataSourceActionList(ViewBangPhuTroiGioDayGiangVienDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public ViewBangPhuTroiGioDayGiangVienSelectMethod SelectMethod
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

	#endregion ViewBangPhuTroiGioDayGiangVienDataSourceActionList

	#endregion ViewBangPhuTroiGioDayGiangVienDataSourceDesigner

	#region ViewBangPhuTroiGioDayGiangVienFilter

	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewBangPhuTroiGioDayGiangVien"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewBangPhuTroiGioDayGiangVienFilter : SqlFilter<ViewBangPhuTroiGioDayGiangVienColumn>
	{
	}

	#endregion ViewBangPhuTroiGioDayGiangVienFilter

	#region ViewBangPhuTroiGioDayGiangVienExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewBangPhuTroiGioDayGiangVien"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewBangPhuTroiGioDayGiangVienExpressionBuilder : SqlExpressionBuilder<ViewBangPhuTroiGioDayGiangVienColumn>
	{
	}
	
	#endregion ViewBangPhuTroiGioDayGiangVienExpressionBuilder		
}

