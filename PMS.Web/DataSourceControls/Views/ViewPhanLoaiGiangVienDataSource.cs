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
	/// Represents the DataRepository.ViewPhanLoaiGiangVienProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[CLSCompliant(true)]
	[Designer(typeof(ViewPhanLoaiGiangVienDataSourceDesigner))]
	public class ViewPhanLoaiGiangVienDataSource : ReadOnlyDataSource<ViewPhanLoaiGiangVien>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewPhanLoaiGiangVienDataSource class.
		/// </summary>
		public ViewPhanLoaiGiangVienDataSource() : base(new ViewPhanLoaiGiangVienService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the ViewPhanLoaiGiangVienDataSourceView used by the ViewPhanLoaiGiangVienDataSource.
		/// </summary>
		protected ViewPhanLoaiGiangVienDataSourceView ViewPhanLoaiGiangVienView
		{
			get { return ( View as ViewPhanLoaiGiangVienDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the ViewPhanLoaiGiangVienDataSource control invokes to retrieve data.
		/// </summary>
		public new ViewPhanLoaiGiangVienSelectMethod SelectMethod
		{
			get
			{
				ViewPhanLoaiGiangVienSelectMethod selectMethod = ViewPhanLoaiGiangVienSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (ViewPhanLoaiGiangVienSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}
		
		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the ViewPhanLoaiGiangVienDataSourceView class that is to be
		/// used by the ViewPhanLoaiGiangVienDataSource.
		/// </summary>
		/// <returns>An instance of the ViewPhanLoaiGiangVienDataSourceView class.</returns>
		protected override BaseDataSourceView<ViewPhanLoaiGiangVien, Object> GetNewDataSourceView()
		{
			return new ViewPhanLoaiGiangVienDataSourceView(this, DefaultViewName);
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
	/// Supports the ViewPhanLoaiGiangVienDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class ViewPhanLoaiGiangVienDataSourceView : ReadOnlyDataSourceView<ViewPhanLoaiGiangVien>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewPhanLoaiGiangVienDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the ViewPhanLoaiGiangVienDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public ViewPhanLoaiGiangVienDataSourceView(ViewPhanLoaiGiangVienDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal ViewPhanLoaiGiangVienDataSource ViewPhanLoaiGiangVienOwner
		{
			get { return Owner as ViewPhanLoaiGiangVienDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal new ViewPhanLoaiGiangVienSelectMethod SelectMethod
		{
			get { return ViewPhanLoaiGiangVienOwner.SelectMethod; }
			set { ViewPhanLoaiGiangVienOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal ViewPhanLoaiGiangVienService ViewPhanLoaiGiangVienProvider
		{
			get { return Provider as ViewPhanLoaiGiangVienService; }
		}

		#endregion Properties
		
		#region Methods
		
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
	    /// <param name="values"></param>
		/// <param name="count">The total number of rows in the DataSource.</param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<ViewPhanLoaiGiangVien> GetSelectData(IDictionary values, out int count)
		{	
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			
			IList<ViewPhanLoaiGiangVien> results = null;
			// ViewPhanLoaiGiangVien item;
			count = 0;
			
			System.String sp1070_NamHoc;
			System.String sp1070_HocKy;
			System.String sp1070_MaDonVi;
			System.String sp1069_NamHoc;
			System.String sp1069_HocKy;

			switch ( SelectMethod )
			{
				case ViewPhanLoaiGiangVienSelectMethod.Get:
					results = ViewPhanLoaiGiangVienProvider.Get(WhereClause, OrderBy, PageIndex, PageSize, out count);
                    break;
				case ViewPhanLoaiGiangVienSelectMethod.GetPaged:
					results = ViewPhanLoaiGiangVienProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case ViewPhanLoaiGiangVienSelectMethod.GetAll:
					results = ViewPhanLoaiGiangVienProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case ViewPhanLoaiGiangVienSelectMethod.Find:
					results = ViewPhanLoaiGiangVienProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
                    break;
				// Custom
				case ViewPhanLoaiGiangVienSelectMethod.GetByNamHocHocKyMaDonVi:
					sp1070_NamHoc = (System.String) EntityUtil.ChangeType(values["NamHoc"], typeof(System.String));
					sp1070_HocKy = (System.String) EntityUtil.ChangeType(values["HocKy"], typeof(System.String));
					sp1070_MaDonVi = (System.String) EntityUtil.ChangeType(values["MaDonVi"], typeof(System.String));
					results = ViewPhanLoaiGiangVienProvider.GetByNamHocHocKyMaDonVi(sp1070_NamHoc, sp1070_HocKy, sp1070_MaDonVi, StartIndex, PageSize);
					break;
				case ViewPhanLoaiGiangVienSelectMethod.GetByNamHocHocKy:
					sp1069_NamHoc = (System.String) EntityUtil.ChangeType(values["NamHoc"], typeof(System.String));
					sp1069_HocKy = (System.String) EntityUtil.ChangeType(values["HocKy"], typeof(System.String));
					results = ViewPhanLoaiGiangVienProvider.GetByNamHocHocKy(sp1069_NamHoc, sp1069_HocKy, StartIndex, PageSize);
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

	#region ViewPhanLoaiGiangVienSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the ViewPhanLoaiGiangVienDataSource.SelectMethod property.
	/// </summary>
	public enum ViewPhanLoaiGiangVienSelectMethod
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
	
	#endregion ViewPhanLoaiGiangVienSelectMethod
	
	#region ViewPhanLoaiGiangVienDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the ViewPhanLoaiGiangVienDataSource class.
	/// </summary>
	public class ViewPhanLoaiGiangVienDataSourceDesigner : ReadOnlyDataSourceDesigner<ViewPhanLoaiGiangVien>
	{
		/// <summary>
		/// Initializes a new instance of the ViewPhanLoaiGiangVienDataSourceDesigner class.
		/// </summary>
		public ViewPhanLoaiGiangVienDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public new ViewPhanLoaiGiangVienSelectMethod SelectMethod
		{
			get { return ((ViewPhanLoaiGiangVienDataSource) DataSource).SelectMethod; }
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
				actions.Add(new ViewPhanLoaiGiangVienDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region ViewPhanLoaiGiangVienDataSourceActionList

	/// <summary>
	/// Supports the ViewPhanLoaiGiangVienDataSourceDesigner class.
	/// </summary>
	internal class ViewPhanLoaiGiangVienDataSourceActionList : DesignerActionList
	{
		private ViewPhanLoaiGiangVienDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the ViewPhanLoaiGiangVienDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public ViewPhanLoaiGiangVienDataSourceActionList(ViewPhanLoaiGiangVienDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public ViewPhanLoaiGiangVienSelectMethod SelectMethod
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

	#endregion ViewPhanLoaiGiangVienDataSourceActionList

	#endregion ViewPhanLoaiGiangVienDataSourceDesigner

	#region ViewPhanLoaiGiangVienFilter

	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewPhanLoaiGiangVien"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewPhanLoaiGiangVienFilter : SqlFilter<ViewPhanLoaiGiangVienColumn>
	{
	}

	#endregion ViewPhanLoaiGiangVienFilter

	#region ViewPhanLoaiGiangVienExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewPhanLoaiGiangVien"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewPhanLoaiGiangVienExpressionBuilder : SqlExpressionBuilder<ViewPhanLoaiGiangVienColumn>
	{
	}
	
	#endregion ViewPhanLoaiGiangVienExpressionBuilder		
}

