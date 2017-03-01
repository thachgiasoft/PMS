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
	/// Represents the DataRepository.ViewLietKeKhoiLuongGiangDayChiTietProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[CLSCompliant(true)]
	[Designer(typeof(ViewLietKeKhoiLuongGiangDayChiTietDataSourceDesigner))]
	public class ViewLietKeKhoiLuongGiangDayChiTietDataSource : ReadOnlyDataSource<ViewLietKeKhoiLuongGiangDayChiTiet>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewLietKeKhoiLuongGiangDayChiTietDataSource class.
		/// </summary>
		public ViewLietKeKhoiLuongGiangDayChiTietDataSource() : base(new ViewLietKeKhoiLuongGiangDayChiTietService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the ViewLietKeKhoiLuongGiangDayChiTietDataSourceView used by the ViewLietKeKhoiLuongGiangDayChiTietDataSource.
		/// </summary>
		protected ViewLietKeKhoiLuongGiangDayChiTietDataSourceView ViewLietKeKhoiLuongGiangDayChiTietView
		{
			get { return ( View as ViewLietKeKhoiLuongGiangDayChiTietDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the ViewLietKeKhoiLuongGiangDayChiTietDataSource control invokes to retrieve data.
		/// </summary>
		public new ViewLietKeKhoiLuongGiangDayChiTietSelectMethod SelectMethod
		{
			get
			{
				ViewLietKeKhoiLuongGiangDayChiTietSelectMethod selectMethod = ViewLietKeKhoiLuongGiangDayChiTietSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (ViewLietKeKhoiLuongGiangDayChiTietSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}
		
		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the ViewLietKeKhoiLuongGiangDayChiTietDataSourceView class that is to be
		/// used by the ViewLietKeKhoiLuongGiangDayChiTietDataSource.
		/// </summary>
		/// <returns>An instance of the ViewLietKeKhoiLuongGiangDayChiTietDataSourceView class.</returns>
		protected override BaseDataSourceView<ViewLietKeKhoiLuongGiangDayChiTiet, Object> GetNewDataSourceView()
		{
			return new ViewLietKeKhoiLuongGiangDayChiTietDataSourceView(this, DefaultViewName);
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
	/// Supports the ViewLietKeKhoiLuongGiangDayChiTietDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class ViewLietKeKhoiLuongGiangDayChiTietDataSourceView : ReadOnlyDataSourceView<ViewLietKeKhoiLuongGiangDayChiTiet>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewLietKeKhoiLuongGiangDayChiTietDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the ViewLietKeKhoiLuongGiangDayChiTietDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public ViewLietKeKhoiLuongGiangDayChiTietDataSourceView(ViewLietKeKhoiLuongGiangDayChiTietDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal ViewLietKeKhoiLuongGiangDayChiTietDataSource ViewLietKeKhoiLuongGiangDayChiTietOwner
		{
			get { return Owner as ViewLietKeKhoiLuongGiangDayChiTietDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal new ViewLietKeKhoiLuongGiangDayChiTietSelectMethod SelectMethod
		{
			get { return ViewLietKeKhoiLuongGiangDayChiTietOwner.SelectMethod; }
			set { ViewLietKeKhoiLuongGiangDayChiTietOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal ViewLietKeKhoiLuongGiangDayChiTietService ViewLietKeKhoiLuongGiangDayChiTietProvider
		{
			get { return Provider as ViewLietKeKhoiLuongGiangDayChiTietService; }
		}

		#endregion Properties
		
		#region Methods
		
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
	    /// <param name="values"></param>
		/// <param name="count">The total number of rows in the DataSource.</param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<ViewLietKeKhoiLuongGiangDayChiTiet> GetSelectData(IDictionary values, out int count)
		{	
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			
			IList<ViewLietKeKhoiLuongGiangDayChiTiet> results = null;
			// ViewLietKeKhoiLuongGiangDayChiTiet item;
			count = 0;
			
			System.String sp1030_NamHoc;
			System.String sp1030_HocKy;

			switch ( SelectMethod )
			{
				case ViewLietKeKhoiLuongGiangDayChiTietSelectMethod.Get:
					results = ViewLietKeKhoiLuongGiangDayChiTietProvider.Get(WhereClause, OrderBy, PageIndex, PageSize, out count);
                    break;
				case ViewLietKeKhoiLuongGiangDayChiTietSelectMethod.GetPaged:
					results = ViewLietKeKhoiLuongGiangDayChiTietProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case ViewLietKeKhoiLuongGiangDayChiTietSelectMethod.GetAll:
					results = ViewLietKeKhoiLuongGiangDayChiTietProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case ViewLietKeKhoiLuongGiangDayChiTietSelectMethod.Find:
					results = ViewLietKeKhoiLuongGiangDayChiTietProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
                    break;
				// Custom
				case ViewLietKeKhoiLuongGiangDayChiTietSelectMethod.GetByNamHocHocKy:
					sp1030_NamHoc = (System.String) EntityUtil.ChangeType(values["NamHoc"], typeof(System.String));
					sp1030_HocKy = (System.String) EntityUtil.ChangeType(values["HocKy"], typeof(System.String));
					results = ViewLietKeKhoiLuongGiangDayChiTietProvider.GetByNamHocHocKy(sp1030_NamHoc, sp1030_HocKy, StartIndex, PageSize);
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

	#region ViewLietKeKhoiLuongGiangDayChiTietSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the ViewLietKeKhoiLuongGiangDayChiTietDataSource.SelectMethod property.
	/// </summary>
	public enum ViewLietKeKhoiLuongGiangDayChiTietSelectMethod
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
		/// Represents the GetByNamHocHocKy method.
		/// </summary>
		GetByNamHocHocKy
	}
	
	#endregion ViewLietKeKhoiLuongGiangDayChiTietSelectMethod
	
	#region ViewLietKeKhoiLuongGiangDayChiTietDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the ViewLietKeKhoiLuongGiangDayChiTietDataSource class.
	/// </summary>
	public class ViewLietKeKhoiLuongGiangDayChiTietDataSourceDesigner : ReadOnlyDataSourceDesigner<ViewLietKeKhoiLuongGiangDayChiTiet>
	{
		/// <summary>
		/// Initializes a new instance of the ViewLietKeKhoiLuongGiangDayChiTietDataSourceDesigner class.
		/// </summary>
		public ViewLietKeKhoiLuongGiangDayChiTietDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public new ViewLietKeKhoiLuongGiangDayChiTietSelectMethod SelectMethod
		{
			get { return ((ViewLietKeKhoiLuongGiangDayChiTietDataSource) DataSource).SelectMethod; }
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
				actions.Add(new ViewLietKeKhoiLuongGiangDayChiTietDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region ViewLietKeKhoiLuongGiangDayChiTietDataSourceActionList

	/// <summary>
	/// Supports the ViewLietKeKhoiLuongGiangDayChiTietDataSourceDesigner class.
	/// </summary>
	internal class ViewLietKeKhoiLuongGiangDayChiTietDataSourceActionList : DesignerActionList
	{
		private ViewLietKeKhoiLuongGiangDayChiTietDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the ViewLietKeKhoiLuongGiangDayChiTietDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public ViewLietKeKhoiLuongGiangDayChiTietDataSourceActionList(ViewLietKeKhoiLuongGiangDayChiTietDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public ViewLietKeKhoiLuongGiangDayChiTietSelectMethod SelectMethod
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

	#endregion ViewLietKeKhoiLuongGiangDayChiTietDataSourceActionList

	#endregion ViewLietKeKhoiLuongGiangDayChiTietDataSourceDesigner

	#region ViewLietKeKhoiLuongGiangDayChiTietFilter

	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewLietKeKhoiLuongGiangDayChiTiet"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewLietKeKhoiLuongGiangDayChiTietFilter : SqlFilter<ViewLietKeKhoiLuongGiangDayChiTietColumn>
	{
	}

	#endregion ViewLietKeKhoiLuongGiangDayChiTietFilter

	#region ViewLietKeKhoiLuongGiangDayChiTietExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewLietKeKhoiLuongGiangDayChiTiet"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewLietKeKhoiLuongGiangDayChiTietExpressionBuilder : SqlExpressionBuilder<ViewLietKeKhoiLuongGiangDayChiTietColumn>
	{
	}
	
	#endregion ViewLietKeKhoiLuongGiangDayChiTietExpressionBuilder		
}

