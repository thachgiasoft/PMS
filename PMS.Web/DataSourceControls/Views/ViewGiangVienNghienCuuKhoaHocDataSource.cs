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
	/// Represents the DataRepository.ViewGiangVienNghienCuuKhoaHocProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[CLSCompliant(true)]
	[Designer(typeof(ViewGiangVienNghienCuuKhoaHocDataSourceDesigner))]
	public class ViewGiangVienNghienCuuKhoaHocDataSource : ReadOnlyDataSource<ViewGiangVienNghienCuuKhoaHoc>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewGiangVienNghienCuuKhoaHocDataSource class.
		/// </summary>
		public ViewGiangVienNghienCuuKhoaHocDataSource() : base(new ViewGiangVienNghienCuuKhoaHocService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the ViewGiangVienNghienCuuKhoaHocDataSourceView used by the ViewGiangVienNghienCuuKhoaHocDataSource.
		/// </summary>
		protected ViewGiangVienNghienCuuKhoaHocDataSourceView ViewGiangVienNghienCuuKhoaHocView
		{
			get { return ( View as ViewGiangVienNghienCuuKhoaHocDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the ViewGiangVienNghienCuuKhoaHocDataSource control invokes to retrieve data.
		/// </summary>
		public new ViewGiangVienNghienCuuKhoaHocSelectMethod SelectMethod
		{
			get
			{
				ViewGiangVienNghienCuuKhoaHocSelectMethod selectMethod = ViewGiangVienNghienCuuKhoaHocSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (ViewGiangVienNghienCuuKhoaHocSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}
		
		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the ViewGiangVienNghienCuuKhoaHocDataSourceView class that is to be
		/// used by the ViewGiangVienNghienCuuKhoaHocDataSource.
		/// </summary>
		/// <returns>An instance of the ViewGiangVienNghienCuuKhoaHocDataSourceView class.</returns>
		protected override BaseDataSourceView<ViewGiangVienNghienCuuKhoaHoc, Object> GetNewDataSourceView()
		{
			return new ViewGiangVienNghienCuuKhoaHocDataSourceView(this, DefaultViewName);
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
	/// Supports the ViewGiangVienNghienCuuKhoaHocDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class ViewGiangVienNghienCuuKhoaHocDataSourceView : ReadOnlyDataSourceView<ViewGiangVienNghienCuuKhoaHoc>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewGiangVienNghienCuuKhoaHocDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the ViewGiangVienNghienCuuKhoaHocDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public ViewGiangVienNghienCuuKhoaHocDataSourceView(ViewGiangVienNghienCuuKhoaHocDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal ViewGiangVienNghienCuuKhoaHocDataSource ViewGiangVienNghienCuuKhoaHocOwner
		{
			get { return Owner as ViewGiangVienNghienCuuKhoaHocDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal new ViewGiangVienNghienCuuKhoaHocSelectMethod SelectMethod
		{
			get { return ViewGiangVienNghienCuuKhoaHocOwner.SelectMethod; }
			set { ViewGiangVienNghienCuuKhoaHocOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal ViewGiangVienNghienCuuKhoaHocService ViewGiangVienNghienCuuKhoaHocProvider
		{
			get { return Provider as ViewGiangVienNghienCuuKhoaHocService; }
		}

		#endregion Properties
		
		#region Methods
		
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
	    /// <param name="values"></param>
		/// <param name="count">The total number of rows in the DataSource.</param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<ViewGiangVienNghienCuuKhoaHoc> GetSelectData(IDictionary values, out int count)
		{	
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			
			IList<ViewGiangVienNghienCuuKhoaHoc> results = null;
			// ViewGiangVienNghienCuuKhoaHoc item;
			count = 0;
			
			System.String sp971_MaDonVi;
			System.String sp971_NamHoc;
			System.String sp972_MaDonVi;
			System.String sp972_NamHoc;
			System.String sp972_HocKy;

			switch ( SelectMethod )
			{
				case ViewGiangVienNghienCuuKhoaHocSelectMethod.Get:
					results = ViewGiangVienNghienCuuKhoaHocProvider.Get(WhereClause, OrderBy, PageIndex, PageSize, out count);
                    break;
				case ViewGiangVienNghienCuuKhoaHocSelectMethod.GetPaged:
					results = ViewGiangVienNghienCuuKhoaHocProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case ViewGiangVienNghienCuuKhoaHocSelectMethod.GetAll:
					results = ViewGiangVienNghienCuuKhoaHocProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case ViewGiangVienNghienCuuKhoaHocSelectMethod.Find:
					results = ViewGiangVienNghienCuuKhoaHocProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
                    break;
				// Custom
				case ViewGiangVienNghienCuuKhoaHocSelectMethod.GetByMaDonViNamHoc:
					sp971_MaDonVi = (System.String) EntityUtil.ChangeType(values["MaDonVi"], typeof(System.String));
					sp971_NamHoc = (System.String) EntityUtil.ChangeType(values["NamHoc"], typeof(System.String));
					results = ViewGiangVienNghienCuuKhoaHocProvider.GetByMaDonViNamHoc(sp971_MaDonVi, sp971_NamHoc, StartIndex, PageSize);
					break;
				case ViewGiangVienNghienCuuKhoaHocSelectMethod.GetByMaDonViNamHocHocKy:
					sp972_MaDonVi = (System.String) EntityUtil.ChangeType(values["MaDonVi"], typeof(System.String));
					sp972_NamHoc = (System.String) EntityUtil.ChangeType(values["NamHoc"], typeof(System.String));
					sp972_HocKy = (System.String) EntityUtil.ChangeType(values["HocKy"], typeof(System.String));
					results = ViewGiangVienNghienCuuKhoaHocProvider.GetByMaDonViNamHocHocKy(sp972_MaDonVi, sp972_NamHoc, sp972_HocKy, StartIndex, PageSize);
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

	#region ViewGiangVienNghienCuuKhoaHocSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the ViewGiangVienNghienCuuKhoaHocDataSource.SelectMethod property.
	/// </summary>
	public enum ViewGiangVienNghienCuuKhoaHocSelectMethod
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
		/// Represents the GetByMaDonViNamHoc method.
		/// </summary>
		GetByMaDonViNamHoc,
		/// <summary>
		/// Represents the GetByMaDonViNamHocHocKy method.
		/// </summary>
		GetByMaDonViNamHocHocKy
	}
	
	#endregion ViewGiangVienNghienCuuKhoaHocSelectMethod
	
	#region ViewGiangVienNghienCuuKhoaHocDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the ViewGiangVienNghienCuuKhoaHocDataSource class.
	/// </summary>
	public class ViewGiangVienNghienCuuKhoaHocDataSourceDesigner : ReadOnlyDataSourceDesigner<ViewGiangVienNghienCuuKhoaHoc>
	{
		/// <summary>
		/// Initializes a new instance of the ViewGiangVienNghienCuuKhoaHocDataSourceDesigner class.
		/// </summary>
		public ViewGiangVienNghienCuuKhoaHocDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public new ViewGiangVienNghienCuuKhoaHocSelectMethod SelectMethod
		{
			get { return ((ViewGiangVienNghienCuuKhoaHocDataSource) DataSource).SelectMethod; }
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
				actions.Add(new ViewGiangVienNghienCuuKhoaHocDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region ViewGiangVienNghienCuuKhoaHocDataSourceActionList

	/// <summary>
	/// Supports the ViewGiangVienNghienCuuKhoaHocDataSourceDesigner class.
	/// </summary>
	internal class ViewGiangVienNghienCuuKhoaHocDataSourceActionList : DesignerActionList
	{
		private ViewGiangVienNghienCuuKhoaHocDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the ViewGiangVienNghienCuuKhoaHocDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public ViewGiangVienNghienCuuKhoaHocDataSourceActionList(ViewGiangVienNghienCuuKhoaHocDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public ViewGiangVienNghienCuuKhoaHocSelectMethod SelectMethod
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

	#endregion ViewGiangVienNghienCuuKhoaHocDataSourceActionList

	#endregion ViewGiangVienNghienCuuKhoaHocDataSourceDesigner

	#region ViewGiangVienNghienCuuKhoaHocFilter

	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewGiangVienNghienCuuKhoaHoc"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewGiangVienNghienCuuKhoaHocFilter : SqlFilter<ViewGiangVienNghienCuuKhoaHocColumn>
	{
	}

	#endregion ViewGiangVienNghienCuuKhoaHocFilter

	#region ViewGiangVienNghienCuuKhoaHocExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewGiangVienNghienCuuKhoaHoc"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewGiangVienNghienCuuKhoaHocExpressionBuilder : SqlExpressionBuilder<ViewGiangVienNghienCuuKhoaHocColumn>
	{
	}
	
	#endregion ViewGiangVienNghienCuuKhoaHocExpressionBuilder		
}

