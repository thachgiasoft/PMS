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
	/// Represents the DataRepository.ViewThanhToanThuLaoProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[CLSCompliant(true)]
	[Designer(typeof(ViewThanhToanThuLaoDataSourceDesigner))]
	public class ViewThanhToanThuLaoDataSource : ReadOnlyDataSource<ViewThanhToanThuLao>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewThanhToanThuLaoDataSource class.
		/// </summary>
		public ViewThanhToanThuLaoDataSource() : base(new ViewThanhToanThuLaoService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the ViewThanhToanThuLaoDataSourceView used by the ViewThanhToanThuLaoDataSource.
		/// </summary>
		protected ViewThanhToanThuLaoDataSourceView ViewThanhToanThuLaoView
		{
			get { return ( View as ViewThanhToanThuLaoDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the ViewThanhToanThuLaoDataSource control invokes to retrieve data.
		/// </summary>
		public new ViewThanhToanThuLaoSelectMethod SelectMethod
		{
			get
			{
				ViewThanhToanThuLaoSelectMethod selectMethod = ViewThanhToanThuLaoSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (ViewThanhToanThuLaoSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}
		
		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the ViewThanhToanThuLaoDataSourceView class that is to be
		/// used by the ViewThanhToanThuLaoDataSource.
		/// </summary>
		/// <returns>An instance of the ViewThanhToanThuLaoDataSourceView class.</returns>
		protected override BaseDataSourceView<ViewThanhToanThuLao, Object> GetNewDataSourceView()
		{
			return new ViewThanhToanThuLaoDataSourceView(this, DefaultViewName);
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
	/// Supports the ViewThanhToanThuLaoDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class ViewThanhToanThuLaoDataSourceView : ReadOnlyDataSourceView<ViewThanhToanThuLao>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewThanhToanThuLaoDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the ViewThanhToanThuLaoDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public ViewThanhToanThuLaoDataSourceView(ViewThanhToanThuLaoDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal ViewThanhToanThuLaoDataSource ViewThanhToanThuLaoOwner
		{
			get { return Owner as ViewThanhToanThuLaoDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal new ViewThanhToanThuLaoSelectMethod SelectMethod
		{
			get { return ViewThanhToanThuLaoOwner.SelectMethod; }
			set { ViewThanhToanThuLaoOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal ViewThanhToanThuLaoService ViewThanhToanThuLaoProvider
		{
			get { return Provider as ViewThanhToanThuLaoService; }
		}

		#endregion Properties
		
		#region Methods
		
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
	    /// <param name="values"></param>
		/// <param name="count">The total number of rows in the DataSource.</param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<ViewThanhToanThuLao> GetSelectData(IDictionary values, out int count)
		{	
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			
			IList<ViewThanhToanThuLao> results = null;
			// ViewThanhToanThuLao item;
			count = 0;
			
			System.String sp1087_NamHoc;
			System.String sp1087_HocKy;
			System.String sp1087_MaDonVi;
			System.Int32 sp1087_MaLoaiGiangVien;

			switch ( SelectMethod )
			{
				case ViewThanhToanThuLaoSelectMethod.Get:
					results = ViewThanhToanThuLaoProvider.Get(WhereClause, OrderBy, PageIndex, PageSize, out count);
                    break;
				case ViewThanhToanThuLaoSelectMethod.GetPaged:
					results = ViewThanhToanThuLaoProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case ViewThanhToanThuLaoSelectMethod.GetAll:
					results = ViewThanhToanThuLaoProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case ViewThanhToanThuLaoSelectMethod.Find:
					results = ViewThanhToanThuLaoProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
                    break;
				// Custom
				case ViewThanhToanThuLaoSelectMethod.GetByNamHocHocKyDonViLoaiGiangVien:
					sp1087_NamHoc = (System.String) EntityUtil.ChangeType(values["NamHoc"], typeof(System.String));
					sp1087_HocKy = (System.String) EntityUtil.ChangeType(values["HocKy"], typeof(System.String));
					sp1087_MaDonVi = (System.String) EntityUtil.ChangeType(values["MaDonVi"], typeof(System.String));
					sp1087_MaLoaiGiangVien = (System.Int32) EntityUtil.ChangeType(values["MaLoaiGiangVien"], typeof(System.Int32));
					results = ViewThanhToanThuLaoProvider.GetByNamHocHocKyDonViLoaiGiangVien(sp1087_NamHoc, sp1087_HocKy, sp1087_MaDonVi, sp1087_MaLoaiGiangVien, StartIndex, PageSize);
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

	#region ViewThanhToanThuLaoSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the ViewThanhToanThuLaoDataSource.SelectMethod property.
	/// </summary>
	public enum ViewThanhToanThuLaoSelectMethod
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
		/// Represents the GetByNamHocHocKyDonViLoaiGiangVien method.
		/// </summary>
		GetByNamHocHocKyDonViLoaiGiangVien
	}
	
	#endregion ViewThanhToanThuLaoSelectMethod
	
	#region ViewThanhToanThuLaoDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the ViewThanhToanThuLaoDataSource class.
	/// </summary>
	public class ViewThanhToanThuLaoDataSourceDesigner : ReadOnlyDataSourceDesigner<ViewThanhToanThuLao>
	{
		/// <summary>
		/// Initializes a new instance of the ViewThanhToanThuLaoDataSourceDesigner class.
		/// </summary>
		public ViewThanhToanThuLaoDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public new ViewThanhToanThuLaoSelectMethod SelectMethod
		{
			get { return ((ViewThanhToanThuLaoDataSource) DataSource).SelectMethod; }
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
				actions.Add(new ViewThanhToanThuLaoDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region ViewThanhToanThuLaoDataSourceActionList

	/// <summary>
	/// Supports the ViewThanhToanThuLaoDataSourceDesigner class.
	/// </summary>
	internal class ViewThanhToanThuLaoDataSourceActionList : DesignerActionList
	{
		private ViewThanhToanThuLaoDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the ViewThanhToanThuLaoDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public ViewThanhToanThuLaoDataSourceActionList(ViewThanhToanThuLaoDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public ViewThanhToanThuLaoSelectMethod SelectMethod
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

	#endregion ViewThanhToanThuLaoDataSourceActionList

	#endregion ViewThanhToanThuLaoDataSourceDesigner

	#region ViewThanhToanThuLaoFilter

	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewThanhToanThuLao"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewThanhToanThuLaoFilter : SqlFilter<ViewThanhToanThuLaoColumn>
	{
	}

	#endregion ViewThanhToanThuLaoFilter

	#region ViewThanhToanThuLaoExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewThanhToanThuLao"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewThanhToanThuLaoExpressionBuilder : SqlExpressionBuilder<ViewThanhToanThuLaoColumn>
	{
	}
	
	#endregion ViewThanhToanThuLaoExpressionBuilder		
}

