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
	/// Represents the DataRepository.ViewThanhToanGioDayProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[CLSCompliant(true)]
	[Designer(typeof(ViewThanhToanGioDayDataSourceDesigner))]
	public class ViewThanhToanGioDayDataSource : ReadOnlyDataSource<ViewThanhToanGioDay>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewThanhToanGioDayDataSource class.
		/// </summary>
		public ViewThanhToanGioDayDataSource() : base(new ViewThanhToanGioDayService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the ViewThanhToanGioDayDataSourceView used by the ViewThanhToanGioDayDataSource.
		/// </summary>
		protected ViewThanhToanGioDayDataSourceView ViewThanhToanGioDayView
		{
			get { return ( View as ViewThanhToanGioDayDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the ViewThanhToanGioDayDataSource control invokes to retrieve data.
		/// </summary>
		public new ViewThanhToanGioDaySelectMethod SelectMethod
		{
			get
			{
				ViewThanhToanGioDaySelectMethod selectMethod = ViewThanhToanGioDaySelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (ViewThanhToanGioDaySelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}
		
		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the ViewThanhToanGioDayDataSourceView class that is to be
		/// used by the ViewThanhToanGioDayDataSource.
		/// </summary>
		/// <returns>An instance of the ViewThanhToanGioDayDataSourceView class.</returns>
		protected override BaseDataSourceView<ViewThanhToanGioDay, Object> GetNewDataSourceView()
		{
			return new ViewThanhToanGioDayDataSourceView(this, DefaultViewName);
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
	/// Supports the ViewThanhToanGioDayDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class ViewThanhToanGioDayDataSourceView : ReadOnlyDataSourceView<ViewThanhToanGioDay>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewThanhToanGioDayDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the ViewThanhToanGioDayDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public ViewThanhToanGioDayDataSourceView(ViewThanhToanGioDayDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal ViewThanhToanGioDayDataSource ViewThanhToanGioDayOwner
		{
			get { return Owner as ViewThanhToanGioDayDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal new ViewThanhToanGioDaySelectMethod SelectMethod
		{
			get { return ViewThanhToanGioDayOwner.SelectMethod; }
			set { ViewThanhToanGioDayOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal ViewThanhToanGioDayService ViewThanhToanGioDayProvider
		{
			get { return Provider as ViewThanhToanGioDayService; }
		}

		#endregion Properties
		
		#region Methods
		
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
	    /// <param name="values"></param>
		/// <param name="count">The total number of rows in the DataSource.</param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<ViewThanhToanGioDay> GetSelectData(IDictionary values, out int count)
		{	
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			
			IList<ViewThanhToanGioDay> results = null;
			// ViewThanhToanGioDay item;
			count = 0;
			
			System.String sp1085_NamHoc;
			System.String sp1085_HocKy;
			System.String sp1085_MaDonVi;
			System.String sp1086_NamHoc;
			System.String sp1086_HocKy;
			System.String sp1086_MaDonVi;
			System.Int32 sp1086_MaLoaiGiangVien;

			switch ( SelectMethod )
			{
				case ViewThanhToanGioDaySelectMethod.Get:
					results = ViewThanhToanGioDayProvider.Get(WhereClause, OrderBy, PageIndex, PageSize, out count);
                    break;
				case ViewThanhToanGioDaySelectMethod.GetPaged:
					results = ViewThanhToanGioDayProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case ViewThanhToanGioDaySelectMethod.GetAll:
					results = ViewThanhToanGioDayProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case ViewThanhToanGioDaySelectMethod.Find:
					results = ViewThanhToanGioDayProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
                    break;
				// Custom
				case ViewThanhToanGioDaySelectMethod.GetByNamHocHocKyMaDonVi:
					sp1085_NamHoc = (System.String) EntityUtil.ChangeType(values["NamHoc"], typeof(System.String));
					sp1085_HocKy = (System.String) EntityUtil.ChangeType(values["HocKy"], typeof(System.String));
					sp1085_MaDonVi = (System.String) EntityUtil.ChangeType(values["MaDonVi"], typeof(System.String));
					results = ViewThanhToanGioDayProvider.GetByNamHocHocKyMaDonVi(sp1085_NamHoc, sp1085_HocKy, sp1085_MaDonVi, StartIndex, PageSize);
					break;
				case ViewThanhToanGioDaySelectMethod.GetByNamHocHocKyMaDonViMaLoaiGiangVien:
					sp1086_NamHoc = (System.String) EntityUtil.ChangeType(values["NamHoc"], typeof(System.String));
					sp1086_HocKy = (System.String) EntityUtil.ChangeType(values["HocKy"], typeof(System.String));
					sp1086_MaDonVi = (System.String) EntityUtil.ChangeType(values["MaDonVi"], typeof(System.String));
					sp1086_MaLoaiGiangVien = (System.Int32) EntityUtil.ChangeType(values["MaLoaiGiangVien"], typeof(System.Int32));
					results = ViewThanhToanGioDayProvider.GetByNamHocHocKyMaDonViMaLoaiGiangVien(sp1086_NamHoc, sp1086_HocKy, sp1086_MaDonVi, sp1086_MaLoaiGiangVien, StartIndex, PageSize);
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

	#region ViewThanhToanGioDaySelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the ViewThanhToanGioDayDataSource.SelectMethod property.
	/// </summary>
	public enum ViewThanhToanGioDaySelectMethod
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
		/// Represents the GetByNamHocHocKyMaDonVi method.
		/// </summary>
		GetByNamHocHocKyMaDonVi,
		/// <summary>
		/// Represents the GetByNamHocHocKyMaDonViMaLoaiGiangVien method.
		/// </summary>
		GetByNamHocHocKyMaDonViMaLoaiGiangVien
	}
	
	#endregion ViewThanhToanGioDaySelectMethod
	
	#region ViewThanhToanGioDayDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the ViewThanhToanGioDayDataSource class.
	/// </summary>
	public class ViewThanhToanGioDayDataSourceDesigner : ReadOnlyDataSourceDesigner<ViewThanhToanGioDay>
	{
		/// <summary>
		/// Initializes a new instance of the ViewThanhToanGioDayDataSourceDesigner class.
		/// </summary>
		public ViewThanhToanGioDayDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public new ViewThanhToanGioDaySelectMethod SelectMethod
		{
			get { return ((ViewThanhToanGioDayDataSource) DataSource).SelectMethod; }
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
				actions.Add(new ViewThanhToanGioDayDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region ViewThanhToanGioDayDataSourceActionList

	/// <summary>
	/// Supports the ViewThanhToanGioDayDataSourceDesigner class.
	/// </summary>
	internal class ViewThanhToanGioDayDataSourceActionList : DesignerActionList
	{
		private ViewThanhToanGioDayDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the ViewThanhToanGioDayDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public ViewThanhToanGioDayDataSourceActionList(ViewThanhToanGioDayDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public ViewThanhToanGioDaySelectMethod SelectMethod
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

	#endregion ViewThanhToanGioDayDataSourceActionList

	#endregion ViewThanhToanGioDayDataSourceDesigner

	#region ViewThanhToanGioDayFilter

	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewThanhToanGioDay"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewThanhToanGioDayFilter : SqlFilter<ViewThanhToanGioDayColumn>
	{
	}

	#endregion ViewThanhToanGioDayFilter

	#region ViewThanhToanGioDayExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewThanhToanGioDay"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewThanhToanGioDayExpressionBuilder : SqlExpressionBuilder<ViewThanhToanGioDayColumn>
	{
	}
	
	#endregion ViewThanhToanGioDayExpressionBuilder		
}

