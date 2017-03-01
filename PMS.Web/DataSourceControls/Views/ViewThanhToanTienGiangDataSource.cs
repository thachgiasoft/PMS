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
	/// Represents the DataRepository.ViewThanhToanTienGiangProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[CLSCompliant(true)]
	[Designer(typeof(ViewThanhToanTienGiangDataSourceDesigner))]
	public class ViewThanhToanTienGiangDataSource : ReadOnlyDataSource<ViewThanhToanTienGiang>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewThanhToanTienGiangDataSource class.
		/// </summary>
		public ViewThanhToanTienGiangDataSource() : base(new ViewThanhToanTienGiangService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the ViewThanhToanTienGiangDataSourceView used by the ViewThanhToanTienGiangDataSource.
		/// </summary>
		protected ViewThanhToanTienGiangDataSourceView ViewThanhToanTienGiangView
		{
			get { return ( View as ViewThanhToanTienGiangDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the ViewThanhToanTienGiangDataSource control invokes to retrieve data.
		/// </summary>
		public new ViewThanhToanTienGiangSelectMethod SelectMethod
		{
			get
			{
				ViewThanhToanTienGiangSelectMethod selectMethod = ViewThanhToanTienGiangSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (ViewThanhToanTienGiangSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}
		
		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the ViewThanhToanTienGiangDataSourceView class that is to be
		/// used by the ViewThanhToanTienGiangDataSource.
		/// </summary>
		/// <returns>An instance of the ViewThanhToanTienGiangDataSourceView class.</returns>
		protected override BaseDataSourceView<ViewThanhToanTienGiang, Object> GetNewDataSourceView()
		{
			return new ViewThanhToanTienGiangDataSourceView(this, DefaultViewName);
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
	/// Supports the ViewThanhToanTienGiangDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class ViewThanhToanTienGiangDataSourceView : ReadOnlyDataSourceView<ViewThanhToanTienGiang>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewThanhToanTienGiangDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the ViewThanhToanTienGiangDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public ViewThanhToanTienGiangDataSourceView(ViewThanhToanTienGiangDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal ViewThanhToanTienGiangDataSource ViewThanhToanTienGiangOwner
		{
			get { return Owner as ViewThanhToanTienGiangDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal new ViewThanhToanTienGiangSelectMethod SelectMethod
		{
			get { return ViewThanhToanTienGiangOwner.SelectMethod; }
			set { ViewThanhToanTienGiangOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal ViewThanhToanTienGiangService ViewThanhToanTienGiangProvider
		{
			get { return Provider as ViewThanhToanTienGiangService; }
		}

		#endregion Properties
		
		#region Methods
		
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
	    /// <param name="values"></param>
		/// <param name="count">The total number of rows in the DataSource.</param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<ViewThanhToanTienGiang> GetSelectData(IDictionary values, out int count)
		{	
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			
			IList<ViewThanhToanTienGiang> results = null;
			// ViewThanhToanTienGiang item;
			count = 0;
			
			System.Int32 sp1088_MaLoaiGiangVien;
			System.DateTime sp1088_TuNgay;
			System.DateTime sp1088_DenNgay;
			System.String sp1088_Value;

			switch ( SelectMethod )
			{
				case ViewThanhToanTienGiangSelectMethod.Get:
					results = ViewThanhToanTienGiangProvider.Get(WhereClause, OrderBy, PageIndex, PageSize, out count);
                    break;
				case ViewThanhToanTienGiangSelectMethod.GetPaged:
					results = ViewThanhToanTienGiangProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case ViewThanhToanTienGiangSelectMethod.GetAll:
					results = ViewThanhToanTienGiangProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case ViewThanhToanTienGiangSelectMethod.Find:
					results = ViewThanhToanTienGiangProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
                    break;
				// Custom
				case ViewThanhToanTienGiangSelectMethod.GetByMaLoaiGiangVienTuNgayDenNgay:
					sp1088_MaLoaiGiangVien = (System.Int32) EntityUtil.ChangeType(values["MaLoaiGiangVien"], typeof(System.Int32));
					sp1088_TuNgay = (System.DateTime) EntityUtil.ChangeType(values["TuNgay"], typeof(System.DateTime));
					sp1088_DenNgay = (System.DateTime) EntityUtil.ChangeType(values["DenNgay"], typeof(System.DateTime));
					sp1088_Value = (System.String) EntityUtil.ChangeType(values["Value"], typeof(System.String));
					results = ViewThanhToanTienGiangProvider.GetByMaLoaiGiangVienTuNgayDenNgay(sp1088_MaLoaiGiangVien, sp1088_TuNgay, sp1088_DenNgay, sp1088_Value, StartIndex, PageSize);
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

	#region ViewThanhToanTienGiangSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the ViewThanhToanTienGiangDataSource.SelectMethod property.
	/// </summary>
	public enum ViewThanhToanTienGiangSelectMethod
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
		/// Represents the GetByMaLoaiGiangVienTuNgayDenNgay method.
		/// </summary>
		GetByMaLoaiGiangVienTuNgayDenNgay
	}
	
	#endregion ViewThanhToanTienGiangSelectMethod
	
	#region ViewThanhToanTienGiangDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the ViewThanhToanTienGiangDataSource class.
	/// </summary>
	public class ViewThanhToanTienGiangDataSourceDesigner : ReadOnlyDataSourceDesigner<ViewThanhToanTienGiang>
	{
		/// <summary>
		/// Initializes a new instance of the ViewThanhToanTienGiangDataSourceDesigner class.
		/// </summary>
		public ViewThanhToanTienGiangDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public new ViewThanhToanTienGiangSelectMethod SelectMethod
		{
			get { return ((ViewThanhToanTienGiangDataSource) DataSource).SelectMethod; }
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
				actions.Add(new ViewThanhToanTienGiangDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region ViewThanhToanTienGiangDataSourceActionList

	/// <summary>
	/// Supports the ViewThanhToanTienGiangDataSourceDesigner class.
	/// </summary>
	internal class ViewThanhToanTienGiangDataSourceActionList : DesignerActionList
	{
		private ViewThanhToanTienGiangDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the ViewThanhToanTienGiangDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public ViewThanhToanTienGiangDataSourceActionList(ViewThanhToanTienGiangDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public ViewThanhToanTienGiangSelectMethod SelectMethod
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

	#endregion ViewThanhToanTienGiangDataSourceActionList

	#endregion ViewThanhToanTienGiangDataSourceDesigner

	#region ViewThanhToanTienGiangFilter

	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewThanhToanTienGiang"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewThanhToanTienGiangFilter : SqlFilter<ViewThanhToanTienGiangColumn>
	{
	}

	#endregion ViewThanhToanTienGiangFilter

	#region ViewThanhToanTienGiangExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewThanhToanTienGiang"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewThanhToanTienGiangExpressionBuilder : SqlExpressionBuilder<ViewThanhToanTienGiangColumn>
	{
	}
	
	#endregion ViewThanhToanTienGiangExpressionBuilder		
}

