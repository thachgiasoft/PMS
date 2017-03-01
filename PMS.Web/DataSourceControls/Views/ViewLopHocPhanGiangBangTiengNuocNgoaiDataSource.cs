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
	/// Represents the DataRepository.ViewLopHocPhanGiangBangTiengNuocNgoaiProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[CLSCompliant(true)]
	[Designer(typeof(ViewLopHocPhanGiangBangTiengNuocNgoaiDataSourceDesigner))]
	public class ViewLopHocPhanGiangBangTiengNuocNgoaiDataSource : ReadOnlyDataSource<ViewLopHocPhanGiangBangTiengNuocNgoai>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewLopHocPhanGiangBangTiengNuocNgoaiDataSource class.
		/// </summary>
		public ViewLopHocPhanGiangBangTiengNuocNgoaiDataSource() : base(new ViewLopHocPhanGiangBangTiengNuocNgoaiService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the ViewLopHocPhanGiangBangTiengNuocNgoaiDataSourceView used by the ViewLopHocPhanGiangBangTiengNuocNgoaiDataSource.
		/// </summary>
		protected ViewLopHocPhanGiangBangTiengNuocNgoaiDataSourceView ViewLopHocPhanGiangBangTiengNuocNgoaiView
		{
			get { return ( View as ViewLopHocPhanGiangBangTiengNuocNgoaiDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the ViewLopHocPhanGiangBangTiengNuocNgoaiDataSource control invokes to retrieve data.
		/// </summary>
		public new ViewLopHocPhanGiangBangTiengNuocNgoaiSelectMethod SelectMethod
		{
			get
			{
				ViewLopHocPhanGiangBangTiengNuocNgoaiSelectMethod selectMethod = ViewLopHocPhanGiangBangTiengNuocNgoaiSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (ViewLopHocPhanGiangBangTiengNuocNgoaiSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}
		
		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the ViewLopHocPhanGiangBangTiengNuocNgoaiDataSourceView class that is to be
		/// used by the ViewLopHocPhanGiangBangTiengNuocNgoaiDataSource.
		/// </summary>
		/// <returns>An instance of the ViewLopHocPhanGiangBangTiengNuocNgoaiDataSourceView class.</returns>
		protected override BaseDataSourceView<ViewLopHocPhanGiangBangTiengNuocNgoai, Object> GetNewDataSourceView()
		{
			return new ViewLopHocPhanGiangBangTiengNuocNgoaiDataSourceView(this, DefaultViewName);
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
	/// Supports the ViewLopHocPhanGiangBangTiengNuocNgoaiDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class ViewLopHocPhanGiangBangTiengNuocNgoaiDataSourceView : ReadOnlyDataSourceView<ViewLopHocPhanGiangBangTiengNuocNgoai>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewLopHocPhanGiangBangTiengNuocNgoaiDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the ViewLopHocPhanGiangBangTiengNuocNgoaiDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public ViewLopHocPhanGiangBangTiengNuocNgoaiDataSourceView(ViewLopHocPhanGiangBangTiengNuocNgoaiDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal ViewLopHocPhanGiangBangTiengNuocNgoaiDataSource ViewLopHocPhanGiangBangTiengNuocNgoaiOwner
		{
			get { return Owner as ViewLopHocPhanGiangBangTiengNuocNgoaiDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal new ViewLopHocPhanGiangBangTiengNuocNgoaiSelectMethod SelectMethod
		{
			get { return ViewLopHocPhanGiangBangTiengNuocNgoaiOwner.SelectMethod; }
			set { ViewLopHocPhanGiangBangTiengNuocNgoaiOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal ViewLopHocPhanGiangBangTiengNuocNgoaiService ViewLopHocPhanGiangBangTiengNuocNgoaiProvider
		{
			get { return Provider as ViewLopHocPhanGiangBangTiengNuocNgoaiService; }
		}

		#endregion Properties
		
		#region Methods
		
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
	    /// <param name="values"></param>
		/// <param name="count">The total number of rows in the DataSource.</param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<ViewLopHocPhanGiangBangTiengNuocNgoai> GetSelectData(IDictionary values, out int count)
		{	
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			
			IList<ViewLopHocPhanGiangBangTiengNuocNgoai> results = null;
			// ViewLopHocPhanGiangBangTiengNuocNgoai item;
			count = 0;
			
			System.String sp1051_NamHoc;
			System.String sp1051_HocKy;
			System.String sp1051_MaDonVi;
			System.String sp1049_NamHoc;
			System.String sp1049_HocKy;

			switch ( SelectMethod )
			{
				case ViewLopHocPhanGiangBangTiengNuocNgoaiSelectMethod.Get:
					results = ViewLopHocPhanGiangBangTiengNuocNgoaiProvider.Get(WhereClause, OrderBy, PageIndex, PageSize, out count);
                    break;
				case ViewLopHocPhanGiangBangTiengNuocNgoaiSelectMethod.GetPaged:
					results = ViewLopHocPhanGiangBangTiengNuocNgoaiProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case ViewLopHocPhanGiangBangTiengNuocNgoaiSelectMethod.GetAll:
					results = ViewLopHocPhanGiangBangTiengNuocNgoaiProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case ViewLopHocPhanGiangBangTiengNuocNgoaiSelectMethod.Find:
					results = ViewLopHocPhanGiangBangTiengNuocNgoaiProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
                    break;
				// Custom
				case ViewLopHocPhanGiangBangTiengNuocNgoaiSelectMethod.GetByNamHocHocKyMaDonVi:
					sp1051_NamHoc = (System.String) EntityUtil.ChangeType(values["NamHoc"], typeof(System.String));
					sp1051_HocKy = (System.String) EntityUtil.ChangeType(values["HocKy"], typeof(System.String));
					sp1051_MaDonVi = (System.String) EntityUtil.ChangeType(values["MaDonVi"], typeof(System.String));
					results = ViewLopHocPhanGiangBangTiengNuocNgoaiProvider.GetByNamHocHocKyMaDonVi(sp1051_NamHoc, sp1051_HocKy, sp1051_MaDonVi, StartIndex, PageSize);
					break;
				case ViewLopHocPhanGiangBangTiengNuocNgoaiSelectMethod.GetByNamHocHocKy:
					sp1049_NamHoc = (System.String) EntityUtil.ChangeType(values["NamHoc"], typeof(System.String));
					sp1049_HocKy = (System.String) EntityUtil.ChangeType(values["HocKy"], typeof(System.String));
					results = ViewLopHocPhanGiangBangTiengNuocNgoaiProvider.GetByNamHocHocKy(sp1049_NamHoc, sp1049_HocKy, StartIndex, PageSize);
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

	#region ViewLopHocPhanGiangBangTiengNuocNgoaiSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the ViewLopHocPhanGiangBangTiengNuocNgoaiDataSource.SelectMethod property.
	/// </summary>
	public enum ViewLopHocPhanGiangBangTiengNuocNgoaiSelectMethod
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
	
	#endregion ViewLopHocPhanGiangBangTiengNuocNgoaiSelectMethod
	
	#region ViewLopHocPhanGiangBangTiengNuocNgoaiDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the ViewLopHocPhanGiangBangTiengNuocNgoaiDataSource class.
	/// </summary>
	public class ViewLopHocPhanGiangBangTiengNuocNgoaiDataSourceDesigner : ReadOnlyDataSourceDesigner<ViewLopHocPhanGiangBangTiengNuocNgoai>
	{
		/// <summary>
		/// Initializes a new instance of the ViewLopHocPhanGiangBangTiengNuocNgoaiDataSourceDesigner class.
		/// </summary>
		public ViewLopHocPhanGiangBangTiengNuocNgoaiDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public new ViewLopHocPhanGiangBangTiengNuocNgoaiSelectMethod SelectMethod
		{
			get { return ((ViewLopHocPhanGiangBangTiengNuocNgoaiDataSource) DataSource).SelectMethod; }
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
				actions.Add(new ViewLopHocPhanGiangBangTiengNuocNgoaiDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region ViewLopHocPhanGiangBangTiengNuocNgoaiDataSourceActionList

	/// <summary>
	/// Supports the ViewLopHocPhanGiangBangTiengNuocNgoaiDataSourceDesigner class.
	/// </summary>
	internal class ViewLopHocPhanGiangBangTiengNuocNgoaiDataSourceActionList : DesignerActionList
	{
		private ViewLopHocPhanGiangBangTiengNuocNgoaiDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the ViewLopHocPhanGiangBangTiengNuocNgoaiDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public ViewLopHocPhanGiangBangTiengNuocNgoaiDataSourceActionList(ViewLopHocPhanGiangBangTiengNuocNgoaiDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public ViewLopHocPhanGiangBangTiengNuocNgoaiSelectMethod SelectMethod
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

	#endregion ViewLopHocPhanGiangBangTiengNuocNgoaiDataSourceActionList

	#endregion ViewLopHocPhanGiangBangTiengNuocNgoaiDataSourceDesigner

	#region ViewLopHocPhanGiangBangTiengNuocNgoaiFilter

	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewLopHocPhanGiangBangTiengNuocNgoai"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewLopHocPhanGiangBangTiengNuocNgoaiFilter : SqlFilter<ViewLopHocPhanGiangBangTiengNuocNgoaiColumn>
	{
	}

	#endregion ViewLopHocPhanGiangBangTiengNuocNgoaiFilter

	#region ViewLopHocPhanGiangBangTiengNuocNgoaiExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewLopHocPhanGiangBangTiengNuocNgoai"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewLopHocPhanGiangBangTiengNuocNgoaiExpressionBuilder : SqlExpressionBuilder<ViewLopHocPhanGiangBangTiengNuocNgoaiColumn>
	{
	}
	
	#endregion ViewLopHocPhanGiangBangTiengNuocNgoaiExpressionBuilder		
}

