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
	/// Represents the DataRepository.ViewKetQuaThanhToanThuLaoProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[CLSCompliant(true)]
	[Designer(typeof(ViewKetQuaThanhToanThuLaoDataSourceDesigner))]
	public class ViewKetQuaThanhToanThuLaoDataSource : ReadOnlyDataSource<ViewKetQuaThanhToanThuLao>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewKetQuaThanhToanThuLaoDataSource class.
		/// </summary>
		public ViewKetQuaThanhToanThuLaoDataSource() : base(new ViewKetQuaThanhToanThuLaoService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the ViewKetQuaThanhToanThuLaoDataSourceView used by the ViewKetQuaThanhToanThuLaoDataSource.
		/// </summary>
		protected ViewKetQuaThanhToanThuLaoDataSourceView ViewKetQuaThanhToanThuLaoView
		{
			get { return ( View as ViewKetQuaThanhToanThuLaoDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the ViewKetQuaThanhToanThuLaoDataSource control invokes to retrieve data.
		/// </summary>
		public new ViewKetQuaThanhToanThuLaoSelectMethod SelectMethod
		{
			get
			{
				ViewKetQuaThanhToanThuLaoSelectMethod selectMethod = ViewKetQuaThanhToanThuLaoSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (ViewKetQuaThanhToanThuLaoSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}
		
		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the ViewKetQuaThanhToanThuLaoDataSourceView class that is to be
		/// used by the ViewKetQuaThanhToanThuLaoDataSource.
		/// </summary>
		/// <returns>An instance of the ViewKetQuaThanhToanThuLaoDataSourceView class.</returns>
		protected override BaseDataSourceView<ViewKetQuaThanhToanThuLao, Object> GetNewDataSourceView()
		{
			return new ViewKetQuaThanhToanThuLaoDataSourceView(this, DefaultViewName);
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
	/// Supports the ViewKetQuaThanhToanThuLaoDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class ViewKetQuaThanhToanThuLaoDataSourceView : ReadOnlyDataSourceView<ViewKetQuaThanhToanThuLao>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewKetQuaThanhToanThuLaoDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the ViewKetQuaThanhToanThuLaoDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public ViewKetQuaThanhToanThuLaoDataSourceView(ViewKetQuaThanhToanThuLaoDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal ViewKetQuaThanhToanThuLaoDataSource ViewKetQuaThanhToanThuLaoOwner
		{
			get { return Owner as ViewKetQuaThanhToanThuLaoDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal new ViewKetQuaThanhToanThuLaoSelectMethod SelectMethod
		{
			get { return ViewKetQuaThanhToanThuLaoOwner.SelectMethod; }
			set { ViewKetQuaThanhToanThuLaoOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal ViewKetQuaThanhToanThuLaoService ViewKetQuaThanhToanThuLaoProvider
		{
			get { return Provider as ViewKetQuaThanhToanThuLaoService; }
		}

		#endregion Properties
		
		#region Methods
		
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
	    /// <param name="values"></param>
		/// <param name="count">The total number of rows in the DataSource.</param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<ViewKetQuaThanhToanThuLao> GetSelectData(IDictionary values, out int count)
		{	
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			
			IList<ViewKetQuaThanhToanThuLao> results = null;
			// ViewKetQuaThanhToanThuLao item;
			count = 0;
			
			System.String sp1000_NamHoc;
			System.String sp1000_HocKy;
			System.String sp1000_ListMaGiangVien;
			System.String sp1003_NamHoc;
			System.String sp1003_HocKy;
			System.String sp1003_DonVi;
			System.String sp1003_LoaiGiangVien;
			System.String sp1003_LanChot;

			switch ( SelectMethod )
			{
				case ViewKetQuaThanhToanThuLaoSelectMethod.Get:
					results = ViewKetQuaThanhToanThuLaoProvider.Get(WhereClause, OrderBy, PageIndex, PageSize, out count);
                    break;
				case ViewKetQuaThanhToanThuLaoSelectMethod.GetPaged:
					results = ViewKetQuaThanhToanThuLaoProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case ViewKetQuaThanhToanThuLaoSelectMethod.GetAll:
					results = ViewKetQuaThanhToanThuLaoProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case ViewKetQuaThanhToanThuLaoSelectMethod.Find:
					results = ViewKetQuaThanhToanThuLaoProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
                    break;
				// Custom
				case ViewKetQuaThanhToanThuLaoSelectMethod.GetByMaGiangVienNamHocHocKy:
					sp1000_NamHoc = (System.String) EntityUtil.ChangeType(values["NamHoc"], typeof(System.String));
					sp1000_HocKy = (System.String) EntityUtil.ChangeType(values["HocKy"], typeof(System.String));
					sp1000_ListMaGiangVien = (System.String) EntityUtil.ChangeType(values["ListMaGiangVien"], typeof(System.String));
					results = ViewKetQuaThanhToanThuLaoProvider.GetByMaGiangVienNamHocHocKy(sp1000_NamHoc, sp1000_HocKy, sp1000_ListMaGiangVien, StartIndex, PageSize);
					break;
				case ViewKetQuaThanhToanThuLaoSelectMethod.GetByNamHocHocKyMaDonViMaLoaiGiangVienLanChot:
					sp1003_NamHoc = (System.String) EntityUtil.ChangeType(values["NamHoc"], typeof(System.String));
					sp1003_HocKy = (System.String) EntityUtil.ChangeType(values["HocKy"], typeof(System.String));
					sp1003_DonVi = (System.String) EntityUtil.ChangeType(values["DonVi"], typeof(System.String));
					sp1003_LoaiGiangVien = (System.String) EntityUtil.ChangeType(values["LoaiGiangVien"], typeof(System.String));
					sp1003_LanChot = (System.String) EntityUtil.ChangeType(values["LanChot"], typeof(System.String));
					results = ViewKetQuaThanhToanThuLaoProvider.GetByNamHocHocKyMaDonViMaLoaiGiangVienLanChot(sp1003_NamHoc, sp1003_HocKy, sp1003_DonVi, sp1003_LoaiGiangVien, sp1003_LanChot, StartIndex, PageSize);
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

	#region ViewKetQuaThanhToanThuLaoSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the ViewKetQuaThanhToanThuLaoDataSource.SelectMethod property.
	/// </summary>
	public enum ViewKetQuaThanhToanThuLaoSelectMethod
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
		/// Represents the GetByMaGiangVienNamHocHocKy method.
		/// </summary>
		GetByMaGiangVienNamHocHocKy,
		/// <summary>
		/// Represents the GetByNamHocHocKyMaDonViMaLoaiGiangVienLanChot method.
		/// </summary>
		GetByNamHocHocKyMaDonViMaLoaiGiangVienLanChot
	}
	
	#endregion ViewKetQuaThanhToanThuLaoSelectMethod
	
	#region ViewKetQuaThanhToanThuLaoDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the ViewKetQuaThanhToanThuLaoDataSource class.
	/// </summary>
	public class ViewKetQuaThanhToanThuLaoDataSourceDesigner : ReadOnlyDataSourceDesigner<ViewKetQuaThanhToanThuLao>
	{
		/// <summary>
		/// Initializes a new instance of the ViewKetQuaThanhToanThuLaoDataSourceDesigner class.
		/// </summary>
		public ViewKetQuaThanhToanThuLaoDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public new ViewKetQuaThanhToanThuLaoSelectMethod SelectMethod
		{
			get { return ((ViewKetQuaThanhToanThuLaoDataSource) DataSource).SelectMethod; }
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
				actions.Add(new ViewKetQuaThanhToanThuLaoDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region ViewKetQuaThanhToanThuLaoDataSourceActionList

	/// <summary>
	/// Supports the ViewKetQuaThanhToanThuLaoDataSourceDesigner class.
	/// </summary>
	internal class ViewKetQuaThanhToanThuLaoDataSourceActionList : DesignerActionList
	{
		private ViewKetQuaThanhToanThuLaoDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the ViewKetQuaThanhToanThuLaoDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public ViewKetQuaThanhToanThuLaoDataSourceActionList(ViewKetQuaThanhToanThuLaoDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public ViewKetQuaThanhToanThuLaoSelectMethod SelectMethod
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

	#endregion ViewKetQuaThanhToanThuLaoDataSourceActionList

	#endregion ViewKetQuaThanhToanThuLaoDataSourceDesigner

	#region ViewKetQuaThanhToanThuLaoFilter

	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewKetQuaThanhToanThuLao"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewKetQuaThanhToanThuLaoFilter : SqlFilter<ViewKetQuaThanhToanThuLaoColumn>
	{
	}

	#endregion ViewKetQuaThanhToanThuLaoFilter

	#region ViewKetQuaThanhToanThuLaoExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewKetQuaThanhToanThuLao"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewKetQuaThanhToanThuLaoExpressionBuilder : SqlExpressionBuilder<ViewKetQuaThanhToanThuLaoColumn>
	{
	}
	
	#endregion ViewKetQuaThanhToanThuLaoExpressionBuilder		
}

