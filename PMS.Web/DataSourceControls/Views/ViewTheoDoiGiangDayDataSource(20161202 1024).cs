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
	/// Represents the DataRepository.ViewTheoDoiGiangDayProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[CLSCompliant(true)]
	[Designer(typeof(ViewTheoDoiGiangDayDataSourceDesigner))]
	public class ViewTheoDoiGiangDayDataSource : ReadOnlyDataSource<ViewTheoDoiGiangDay>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewTheoDoiGiangDayDataSource class.
		/// </summary>
		public ViewTheoDoiGiangDayDataSource() : base(new ViewTheoDoiGiangDayService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the ViewTheoDoiGiangDayDataSourceView used by the ViewTheoDoiGiangDayDataSource.
		/// </summary>
		protected ViewTheoDoiGiangDayDataSourceView ViewTheoDoiGiangDayView
		{
			get { return ( View as ViewTheoDoiGiangDayDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the ViewTheoDoiGiangDayDataSource control invokes to retrieve data.
		/// </summary>
		public new ViewTheoDoiGiangDaySelectMethod SelectMethod
		{
			get
			{
				ViewTheoDoiGiangDaySelectMethod selectMethod = ViewTheoDoiGiangDaySelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (ViewTheoDoiGiangDaySelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}
		
		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the ViewTheoDoiGiangDayDataSourceView class that is to be
		/// used by the ViewTheoDoiGiangDayDataSource.
		/// </summary>
		/// <returns>An instance of the ViewTheoDoiGiangDayDataSourceView class.</returns>
		protected override BaseDataSourceView<ViewTheoDoiGiangDay, Object> GetNewDataSourceView()
		{
			return new ViewTheoDoiGiangDayDataSourceView(this, DefaultViewName);
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
	/// Supports the ViewTheoDoiGiangDayDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class ViewTheoDoiGiangDayDataSourceView : ReadOnlyDataSourceView<ViewTheoDoiGiangDay>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewTheoDoiGiangDayDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the ViewTheoDoiGiangDayDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public ViewTheoDoiGiangDayDataSourceView(ViewTheoDoiGiangDayDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal ViewTheoDoiGiangDayDataSource ViewTheoDoiGiangDayOwner
		{
			get { return Owner as ViewTheoDoiGiangDayDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal new ViewTheoDoiGiangDaySelectMethod SelectMethod
		{
			get { return ViewTheoDoiGiangDayOwner.SelectMethod; }
			set { ViewTheoDoiGiangDayOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal ViewTheoDoiGiangDayService ViewTheoDoiGiangDayProvider
		{
			get { return Provider as ViewTheoDoiGiangDayService; }
		}

		#endregion Properties
		
		#region Methods
		
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
	    /// <param name="values"></param>
		/// <param name="count">The total number of rows in the DataSource.</param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<ViewTheoDoiGiangDay> GetSelectData(IDictionary values, out int count)
		{	
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			
			IList<ViewTheoDoiGiangDay> results = null;
			// ViewTheoDoiGiangDay item;
			count = 0;
			
			System.String sp3198_MaCoSo;
			System.Int32 sp3198_MaLoaiGiangVien;
			System.DateTime sp3198_TuNgay;
			System.DateTime sp3198_DenNgay;
			System.String sp3198_Value;
			System.Int32 sp3199_MaLoaiGiangVien;
			System.DateTime sp3199_TuNgay;
			System.DateTime sp3199_DenNgay;
			System.String sp3199_Value;

			switch ( SelectMethod )
			{
				case ViewTheoDoiGiangDaySelectMethod.Get:
					results = ViewTheoDoiGiangDayProvider.Get(WhereClause, OrderBy, PageIndex, PageSize, out count);
                    break;
				case ViewTheoDoiGiangDaySelectMethod.GetPaged:
					results = ViewTheoDoiGiangDayProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case ViewTheoDoiGiangDaySelectMethod.GetAll:
					results = ViewTheoDoiGiangDayProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case ViewTheoDoiGiangDaySelectMethod.Find:
					results = ViewTheoDoiGiangDayProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
                    break;
				// Custom
				case ViewTheoDoiGiangDaySelectMethod.GetByMaCoSoMaLoaiGiangVienTuNgayDenNgay:
					sp3198_MaCoSo = (System.String) EntityUtil.ChangeType(values["MaCoSo"], typeof(System.String));
					sp3198_MaLoaiGiangVien = (System.Int32) EntityUtil.ChangeType(values["MaLoaiGiangVien"], typeof(System.Int32));
					sp3198_TuNgay = (System.DateTime) EntityUtil.ChangeType(values["TuNgay"], typeof(System.DateTime));
					sp3198_DenNgay = (System.DateTime) EntityUtil.ChangeType(values["DenNgay"], typeof(System.DateTime));
					sp3198_Value = (System.String) EntityUtil.ChangeType(values["Value"], typeof(System.String));
					results = ViewTheoDoiGiangDayProvider.GetByMaCoSoMaLoaiGiangVienTuNgayDenNgay(sp3198_MaCoSo, sp3198_MaLoaiGiangVien, sp3198_TuNgay, sp3198_DenNgay, sp3198_Value, StartIndex, PageSize);
					break;
				case ViewTheoDoiGiangDaySelectMethod.GetByMaLoaiGiangVienTuNgayDenNgay:
					sp3199_MaLoaiGiangVien = (System.Int32) EntityUtil.ChangeType(values["MaLoaiGiangVien"], typeof(System.Int32));
					sp3199_TuNgay = (System.DateTime) EntityUtil.ChangeType(values["TuNgay"], typeof(System.DateTime));
					sp3199_DenNgay = (System.DateTime) EntityUtil.ChangeType(values["DenNgay"], typeof(System.DateTime));
					sp3199_Value = (System.String) EntityUtil.ChangeType(values["Value"], typeof(System.String));
					results = ViewTheoDoiGiangDayProvider.GetByMaLoaiGiangVienTuNgayDenNgay(sp3199_MaLoaiGiangVien, sp3199_TuNgay, sp3199_DenNgay, sp3199_Value, StartIndex, PageSize);
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

	#region ViewTheoDoiGiangDaySelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the ViewTheoDoiGiangDayDataSource.SelectMethod property.
	/// </summary>
	public enum ViewTheoDoiGiangDaySelectMethod
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
		/// Represents the GetByMaCoSoMaLoaiGiangVienTuNgayDenNgay method.
		/// </summary>
		GetByMaCoSoMaLoaiGiangVienTuNgayDenNgay,
		/// <summary>
		/// Represents the GetByMaLoaiGiangVienTuNgayDenNgay method.
		/// </summary>
		GetByMaLoaiGiangVienTuNgayDenNgay
	}
	
	#endregion ViewTheoDoiGiangDaySelectMethod
	
	#region ViewTheoDoiGiangDayDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the ViewTheoDoiGiangDayDataSource class.
	/// </summary>
	public class ViewTheoDoiGiangDayDataSourceDesigner : ReadOnlyDataSourceDesigner<ViewTheoDoiGiangDay>
	{
		/// <summary>
		/// Initializes a new instance of the ViewTheoDoiGiangDayDataSourceDesigner class.
		/// </summary>
		public ViewTheoDoiGiangDayDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public new ViewTheoDoiGiangDaySelectMethod SelectMethod
		{
			get { return ((ViewTheoDoiGiangDayDataSource) DataSource).SelectMethod; }
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
				actions.Add(new ViewTheoDoiGiangDayDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region ViewTheoDoiGiangDayDataSourceActionList

	/// <summary>
	/// Supports the ViewTheoDoiGiangDayDataSourceDesigner class.
	/// </summary>
	internal class ViewTheoDoiGiangDayDataSourceActionList : DesignerActionList
	{
		private ViewTheoDoiGiangDayDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the ViewTheoDoiGiangDayDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public ViewTheoDoiGiangDayDataSourceActionList(ViewTheoDoiGiangDayDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public ViewTheoDoiGiangDaySelectMethod SelectMethod
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

	#endregion ViewTheoDoiGiangDayDataSourceActionList

	#endregion ViewTheoDoiGiangDayDataSourceDesigner

	#region ViewTheoDoiGiangDayFilter

	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewTheoDoiGiangDay"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewTheoDoiGiangDayFilter : SqlFilter<ViewTheoDoiGiangDayColumn>
	{
	}

	#endregion ViewTheoDoiGiangDayFilter

	#region ViewTheoDoiGiangDayExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewTheoDoiGiangDay"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewTheoDoiGiangDayExpressionBuilder : SqlExpressionBuilder<ViewTheoDoiGiangDayColumn>
	{
	}
	
	#endregion ViewTheoDoiGiangDayExpressionBuilder		
}

