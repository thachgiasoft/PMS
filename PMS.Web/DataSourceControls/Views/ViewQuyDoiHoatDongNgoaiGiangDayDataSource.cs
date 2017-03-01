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
	/// Represents the DataRepository.ViewQuyDoiHoatDongNgoaiGiangDayProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[CLSCompliant(true)]
	[Designer(typeof(ViewQuyDoiHoatDongNgoaiGiangDayDataSourceDesigner))]
	public class ViewQuyDoiHoatDongNgoaiGiangDayDataSource : ReadOnlyDataSource<ViewQuyDoiHoatDongNgoaiGiangDay>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewQuyDoiHoatDongNgoaiGiangDayDataSource class.
		/// </summary>
		public ViewQuyDoiHoatDongNgoaiGiangDayDataSource() : base(new ViewQuyDoiHoatDongNgoaiGiangDayService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the ViewQuyDoiHoatDongNgoaiGiangDayDataSourceView used by the ViewQuyDoiHoatDongNgoaiGiangDayDataSource.
		/// </summary>
		protected ViewQuyDoiHoatDongNgoaiGiangDayDataSourceView ViewQuyDoiHoatDongNgoaiGiangDayView
		{
			get { return ( View as ViewQuyDoiHoatDongNgoaiGiangDayDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the ViewQuyDoiHoatDongNgoaiGiangDayDataSource control invokes to retrieve data.
		/// </summary>
		public new ViewQuyDoiHoatDongNgoaiGiangDaySelectMethod SelectMethod
		{
			get
			{
				ViewQuyDoiHoatDongNgoaiGiangDaySelectMethod selectMethod = ViewQuyDoiHoatDongNgoaiGiangDaySelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (ViewQuyDoiHoatDongNgoaiGiangDaySelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}
		
		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the ViewQuyDoiHoatDongNgoaiGiangDayDataSourceView class that is to be
		/// used by the ViewQuyDoiHoatDongNgoaiGiangDayDataSource.
		/// </summary>
		/// <returns>An instance of the ViewQuyDoiHoatDongNgoaiGiangDayDataSourceView class.</returns>
		protected override BaseDataSourceView<ViewQuyDoiHoatDongNgoaiGiangDay, Object> GetNewDataSourceView()
		{
			return new ViewQuyDoiHoatDongNgoaiGiangDayDataSourceView(this, DefaultViewName);
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
	/// Supports the ViewQuyDoiHoatDongNgoaiGiangDayDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class ViewQuyDoiHoatDongNgoaiGiangDayDataSourceView : ReadOnlyDataSourceView<ViewQuyDoiHoatDongNgoaiGiangDay>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewQuyDoiHoatDongNgoaiGiangDayDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the ViewQuyDoiHoatDongNgoaiGiangDayDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public ViewQuyDoiHoatDongNgoaiGiangDayDataSourceView(ViewQuyDoiHoatDongNgoaiGiangDayDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal ViewQuyDoiHoatDongNgoaiGiangDayDataSource ViewQuyDoiHoatDongNgoaiGiangDayOwner
		{
			get { return Owner as ViewQuyDoiHoatDongNgoaiGiangDayDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal new ViewQuyDoiHoatDongNgoaiGiangDaySelectMethod SelectMethod
		{
			get { return ViewQuyDoiHoatDongNgoaiGiangDayOwner.SelectMethod; }
			set { ViewQuyDoiHoatDongNgoaiGiangDayOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal ViewQuyDoiHoatDongNgoaiGiangDayService ViewQuyDoiHoatDongNgoaiGiangDayProvider
		{
			get { return Provider as ViewQuyDoiHoatDongNgoaiGiangDayService; }
		}

		#endregion Properties
		
		#region Methods
		
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
	    /// <param name="values"></param>
		/// <param name="count">The total number of rows in the DataSource.</param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<ViewQuyDoiHoatDongNgoaiGiangDay> GetSelectData(IDictionary values, out int count)
		{	
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			
			IList<ViewQuyDoiHoatDongNgoaiGiangDay> results = null;
			// ViewQuyDoiHoatDongNgoaiGiangDay item;
			count = 0;
			
			System.String sp1075_NamHoc;
			System.String sp1075_HocKy;
			System.String sp1075_MaDonVi;
			System.String sp1074_NamHoc;
			System.String sp1074_HocKy;

			switch ( SelectMethod )
			{
				case ViewQuyDoiHoatDongNgoaiGiangDaySelectMethod.Get:
					results = ViewQuyDoiHoatDongNgoaiGiangDayProvider.Get(WhereClause, OrderBy, PageIndex, PageSize, out count);
                    break;
				case ViewQuyDoiHoatDongNgoaiGiangDaySelectMethod.GetPaged:
					results = ViewQuyDoiHoatDongNgoaiGiangDayProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case ViewQuyDoiHoatDongNgoaiGiangDaySelectMethod.GetAll:
					results = ViewQuyDoiHoatDongNgoaiGiangDayProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case ViewQuyDoiHoatDongNgoaiGiangDaySelectMethod.Find:
					results = ViewQuyDoiHoatDongNgoaiGiangDayProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
                    break;
				// Custom
				case ViewQuyDoiHoatDongNgoaiGiangDaySelectMethod.GetByNamHocHocKyMaDonVi:
					sp1075_NamHoc = (System.String) EntityUtil.ChangeType(values["NamHoc"], typeof(System.String));
					sp1075_HocKy = (System.String) EntityUtil.ChangeType(values["HocKy"], typeof(System.String));
					sp1075_MaDonVi = (System.String) EntityUtil.ChangeType(values["MaDonVi"], typeof(System.String));
					results = ViewQuyDoiHoatDongNgoaiGiangDayProvider.GetByNamHocHocKyMaDonVi(sp1075_NamHoc, sp1075_HocKy, sp1075_MaDonVi, StartIndex, PageSize);
					break;
				case ViewQuyDoiHoatDongNgoaiGiangDaySelectMethod.GetByNamHocHocKy:
					sp1074_NamHoc = (System.String) EntityUtil.ChangeType(values["NamHoc"], typeof(System.String));
					sp1074_HocKy = (System.String) EntityUtil.ChangeType(values["HocKy"], typeof(System.String));
					results = ViewQuyDoiHoatDongNgoaiGiangDayProvider.GetByNamHocHocKy(sp1074_NamHoc, sp1074_HocKy, StartIndex, PageSize);
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

	#region ViewQuyDoiHoatDongNgoaiGiangDaySelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the ViewQuyDoiHoatDongNgoaiGiangDayDataSource.SelectMethod property.
	/// </summary>
	public enum ViewQuyDoiHoatDongNgoaiGiangDaySelectMethod
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
		/// Represents the GetByNamHocHocKy method.
		/// </summary>
		GetByNamHocHocKy
	}
	
	#endregion ViewQuyDoiHoatDongNgoaiGiangDaySelectMethod
	
	#region ViewQuyDoiHoatDongNgoaiGiangDayDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the ViewQuyDoiHoatDongNgoaiGiangDayDataSource class.
	/// </summary>
	public class ViewQuyDoiHoatDongNgoaiGiangDayDataSourceDesigner : ReadOnlyDataSourceDesigner<ViewQuyDoiHoatDongNgoaiGiangDay>
	{
		/// <summary>
		/// Initializes a new instance of the ViewQuyDoiHoatDongNgoaiGiangDayDataSourceDesigner class.
		/// </summary>
		public ViewQuyDoiHoatDongNgoaiGiangDayDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public new ViewQuyDoiHoatDongNgoaiGiangDaySelectMethod SelectMethod
		{
			get { return ((ViewQuyDoiHoatDongNgoaiGiangDayDataSource) DataSource).SelectMethod; }
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
				actions.Add(new ViewQuyDoiHoatDongNgoaiGiangDayDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region ViewQuyDoiHoatDongNgoaiGiangDayDataSourceActionList

	/// <summary>
	/// Supports the ViewQuyDoiHoatDongNgoaiGiangDayDataSourceDesigner class.
	/// </summary>
	internal class ViewQuyDoiHoatDongNgoaiGiangDayDataSourceActionList : DesignerActionList
	{
		private ViewQuyDoiHoatDongNgoaiGiangDayDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the ViewQuyDoiHoatDongNgoaiGiangDayDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public ViewQuyDoiHoatDongNgoaiGiangDayDataSourceActionList(ViewQuyDoiHoatDongNgoaiGiangDayDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public ViewQuyDoiHoatDongNgoaiGiangDaySelectMethod SelectMethod
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

	#endregion ViewQuyDoiHoatDongNgoaiGiangDayDataSourceActionList

	#endregion ViewQuyDoiHoatDongNgoaiGiangDayDataSourceDesigner

	#region ViewQuyDoiHoatDongNgoaiGiangDayFilter

	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewQuyDoiHoatDongNgoaiGiangDay"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewQuyDoiHoatDongNgoaiGiangDayFilter : SqlFilter<ViewQuyDoiHoatDongNgoaiGiangDayColumn>
	{
	}

	#endregion ViewQuyDoiHoatDongNgoaiGiangDayFilter

	#region ViewQuyDoiHoatDongNgoaiGiangDayExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewQuyDoiHoatDongNgoaiGiangDay"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewQuyDoiHoatDongNgoaiGiangDayExpressionBuilder : SqlExpressionBuilder<ViewQuyDoiHoatDongNgoaiGiangDayColumn>
	{
	}
	
	#endregion ViewQuyDoiHoatDongNgoaiGiangDayExpressionBuilder		
}

