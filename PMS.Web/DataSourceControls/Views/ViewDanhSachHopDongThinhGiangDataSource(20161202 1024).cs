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
	/// Represents the DataRepository.ViewDanhSachHopDongThinhGiangProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[CLSCompliant(true)]
	[Designer(typeof(ViewDanhSachHopDongThinhGiangDataSourceDesigner))]
	public class ViewDanhSachHopDongThinhGiangDataSource : ReadOnlyDataSource<ViewDanhSachHopDongThinhGiang>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewDanhSachHopDongThinhGiangDataSource class.
		/// </summary>
		public ViewDanhSachHopDongThinhGiangDataSource() : base(new ViewDanhSachHopDongThinhGiangService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the ViewDanhSachHopDongThinhGiangDataSourceView used by the ViewDanhSachHopDongThinhGiangDataSource.
		/// </summary>
		protected ViewDanhSachHopDongThinhGiangDataSourceView ViewDanhSachHopDongThinhGiangView
		{
			get { return ( View as ViewDanhSachHopDongThinhGiangDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the ViewDanhSachHopDongThinhGiangDataSource control invokes to retrieve data.
		/// </summary>
		public new ViewDanhSachHopDongThinhGiangSelectMethod SelectMethod
		{
			get
			{
				ViewDanhSachHopDongThinhGiangSelectMethod selectMethod = ViewDanhSachHopDongThinhGiangSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (ViewDanhSachHopDongThinhGiangSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}
		
		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the ViewDanhSachHopDongThinhGiangDataSourceView class that is to be
		/// used by the ViewDanhSachHopDongThinhGiangDataSource.
		/// </summary>
		/// <returns>An instance of the ViewDanhSachHopDongThinhGiangDataSourceView class.</returns>
		protected override BaseDataSourceView<ViewDanhSachHopDongThinhGiang, Object> GetNewDataSourceView()
		{
			return new ViewDanhSachHopDongThinhGiangDataSourceView(this, DefaultViewName);
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
	/// Supports the ViewDanhSachHopDongThinhGiangDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class ViewDanhSachHopDongThinhGiangDataSourceView : ReadOnlyDataSourceView<ViewDanhSachHopDongThinhGiang>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewDanhSachHopDongThinhGiangDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the ViewDanhSachHopDongThinhGiangDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public ViewDanhSachHopDongThinhGiangDataSourceView(ViewDanhSachHopDongThinhGiangDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal ViewDanhSachHopDongThinhGiangDataSource ViewDanhSachHopDongThinhGiangOwner
		{
			get { return Owner as ViewDanhSachHopDongThinhGiangDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal new ViewDanhSachHopDongThinhGiangSelectMethod SelectMethod
		{
			get { return ViewDanhSachHopDongThinhGiangOwner.SelectMethod; }
			set { ViewDanhSachHopDongThinhGiangOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal ViewDanhSachHopDongThinhGiangService ViewDanhSachHopDongThinhGiangProvider
		{
			get { return Provider as ViewDanhSachHopDongThinhGiangService; }
		}

		#endregion Properties
		
		#region Methods
		
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
	    /// <param name="values"></param>
		/// <param name="count">The total number of rows in the DataSource.</param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<ViewDanhSachHopDongThinhGiang> GetSelectData(IDictionary values, out int count)
		{	
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			
			IList<ViewDanhSachHopDongThinhGiang> results = null;
			// ViewDanhSachHopDongThinhGiang item;
			count = 0;
			
			System.String sp3043_NamHoc;
			System.String sp3043_HocKy;
			System.String sp3043_MaDonVi;
			System.String sp3044_NamHoc;
			System.String sp3044_HocKy;
			System.String sp3044_MaDonVi;

			switch ( SelectMethod )
			{
				case ViewDanhSachHopDongThinhGiangSelectMethod.Get:
					results = ViewDanhSachHopDongThinhGiangProvider.Get(WhereClause, OrderBy, PageIndex, PageSize, out count);
                    break;
				case ViewDanhSachHopDongThinhGiangSelectMethod.GetPaged:
					results = ViewDanhSachHopDongThinhGiangProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case ViewDanhSachHopDongThinhGiangSelectMethod.GetAll:
					results = ViewDanhSachHopDongThinhGiangProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case ViewDanhSachHopDongThinhGiangSelectMethod.Find:
					results = ViewDanhSachHopDongThinhGiangProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
                    break;
				// Custom
				case ViewDanhSachHopDongThinhGiangSelectMethod.GetHopDongChuaXacNhan:
					sp3043_NamHoc = (System.String) EntityUtil.ChangeType(values["NamHoc"], typeof(System.String));
					sp3043_HocKy = (System.String) EntityUtil.ChangeType(values["HocKy"], typeof(System.String));
					sp3043_MaDonVi = (System.String) EntityUtil.ChangeType(values["MaDonVi"], typeof(System.String));
					results = ViewDanhSachHopDongThinhGiangProvider.GetHopDongChuaXacNhan(sp3043_NamHoc, sp3043_HocKy, sp3043_MaDonVi, StartIndex, PageSize);
					break;
				case ViewDanhSachHopDongThinhGiangSelectMethod.GetHopDongDaXacNhan:
					sp3044_NamHoc = (System.String) EntityUtil.ChangeType(values["NamHoc"], typeof(System.String));
					sp3044_HocKy = (System.String) EntityUtil.ChangeType(values["HocKy"], typeof(System.String));
					sp3044_MaDonVi = (System.String) EntityUtil.ChangeType(values["MaDonVi"], typeof(System.String));
					results = ViewDanhSachHopDongThinhGiangProvider.GetHopDongDaXacNhan(sp3044_NamHoc, sp3044_HocKy, sp3044_MaDonVi, StartIndex, PageSize);
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

	#region ViewDanhSachHopDongThinhGiangSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the ViewDanhSachHopDongThinhGiangDataSource.SelectMethod property.
	/// </summary>
	public enum ViewDanhSachHopDongThinhGiangSelectMethod
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
		/// Represents the GetHopDongChuaXacNhan method.
		/// </summary>
		GetHopDongChuaXacNhan,
		/// <summary>
		/// Represents the GetHopDongDaXacNhan method.
		/// </summary>
		GetHopDongDaXacNhan
	}
	
	#endregion ViewDanhSachHopDongThinhGiangSelectMethod
	
	#region ViewDanhSachHopDongThinhGiangDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the ViewDanhSachHopDongThinhGiangDataSource class.
	/// </summary>
	public class ViewDanhSachHopDongThinhGiangDataSourceDesigner : ReadOnlyDataSourceDesigner<ViewDanhSachHopDongThinhGiang>
	{
		/// <summary>
		/// Initializes a new instance of the ViewDanhSachHopDongThinhGiangDataSourceDesigner class.
		/// </summary>
		public ViewDanhSachHopDongThinhGiangDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public new ViewDanhSachHopDongThinhGiangSelectMethod SelectMethod
		{
			get { return ((ViewDanhSachHopDongThinhGiangDataSource) DataSource).SelectMethod; }
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
				actions.Add(new ViewDanhSachHopDongThinhGiangDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region ViewDanhSachHopDongThinhGiangDataSourceActionList

	/// <summary>
	/// Supports the ViewDanhSachHopDongThinhGiangDataSourceDesigner class.
	/// </summary>
	internal class ViewDanhSachHopDongThinhGiangDataSourceActionList : DesignerActionList
	{
		private ViewDanhSachHopDongThinhGiangDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the ViewDanhSachHopDongThinhGiangDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public ViewDanhSachHopDongThinhGiangDataSourceActionList(ViewDanhSachHopDongThinhGiangDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public ViewDanhSachHopDongThinhGiangSelectMethod SelectMethod
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

	#endregion ViewDanhSachHopDongThinhGiangDataSourceActionList

	#endregion ViewDanhSachHopDongThinhGiangDataSourceDesigner

	#region ViewDanhSachHopDongThinhGiangFilter

	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewDanhSachHopDongThinhGiang"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewDanhSachHopDongThinhGiangFilter : SqlFilter<ViewDanhSachHopDongThinhGiangColumn>
	{
	}

	#endregion ViewDanhSachHopDongThinhGiangFilter

	#region ViewDanhSachHopDongThinhGiangExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewDanhSachHopDongThinhGiang"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewDanhSachHopDongThinhGiangExpressionBuilder : SqlExpressionBuilder<ViewDanhSachHopDongThinhGiangColumn>
	{
	}
	
	#endregion ViewDanhSachHopDongThinhGiangExpressionBuilder		
}

